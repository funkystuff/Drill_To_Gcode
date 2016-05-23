using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DrilltoGcode
{
    public enum m_unit {METRIC,IMPERIAL};
    public enum zero_supp {LEADING,TRAILING,NONE};
    public class DrillFileReader
    {
        List<DrillTool> tools;
        string aux_string_line;
        string last_tool_readed;
        point aux_point;
        StringBuilder stringmodifier;
        StringBuilder toolname;
        StringBuilder xybuilder;
        long header_line_pos;
        bool gfile;
        m_unit unita;
        //Proprietà
        public List<DrillTool> TOOLS
        {
            get { return tools;}
        }
        public bool GOODFILE
        {
            get { return gfile; }
        }
        //costruttore
        public DrillFileReader()
        {
            tools = new List<DrillTool>();
            aux_string_line = null;
            unita = m_unit.METRIC;
            gfile = false;
            stringmodifier = new StringBuilder();
            toolname = new StringBuilder();
            xybuilder = new StringBuilder();
            last_tool_readed = "last";
            aux_point = new point(0,0);
            header_line_pos = 0;
        }
        //metodi
        public void Clear()
        {
            tools.Clear();
            aux_string_line = null;
            gfile = false;
            stringmodifier.Clear();
            toolname.Clear();
            xybuilder.Clear();
            aux_point.X = 0;
            aux_point.Y = 0;
            header_line_pos = 0;
            last_tool_readed = "last";
        }
        public bool read_file(StreamReader drillfile)
        {
            this.Clear();
            drillfile.DiscardBufferedData();
            drillfile.BaseStream.Position = 0;
            //read header
            do
            {


             aux_string_line = drillfile.ReadLine();
                if (gfile != true && aux_string_line.Contains( "M48"))
                {
                    header_line_pos = drillfile.BaseStream.Length;
                    gfile = true;
                    do
                    {
                        aux_string_line = drillfile.ReadLine();
                    } while (!(aux_string_line.Contains ("M71") || aux_string_line.Contains("M72") || aux_string_line.Contains("METRIC") || aux_string_line.Contains("IMPERIAL") || aux_string_line.Contains("INCH")));
                    if (aux_string_line.Contains("M71") || aux_string_line.Contains("METRIC"))
                        unita = m_unit.METRIC;
                    if (aux_string_line.Contains("M72") || aux_string_line.Contains("IMPERIAL") || aux_string_line.Contains("INCH"))
                        unita = m_unit.IMPERIAL;
                    drillfile.DiscardBufferedData();
                    drillfile.BaseStream.Position = 0;
                    aux_string_line = drillfile.ReadLine();
                    aux_string_line = drillfile.ReadLine();
                }
                if (gfile != true)
                    continue;
                //Leggo i tools
                stringmodifier.Append(aux_string_line);
                if(stringmodifier.Length!= 0 && (stringmodifier[0]=='T'|| stringmodifier[0] == 't'))
                {
                    //avanzo dall'ultimo elemento fino a trovare la C
                    for (int i = 0; stringmodifier.Length != 0 && i<=500 && !(stringmodifier[0] == 'C' || stringmodifier[0] == 'c');i++)
                    {
                        toolname.Append(stringmodifier[0]);
                        stringmodifier.Remove(0, 1);
                    }
                    if (stringmodifier.Length != 0 && toolname.ToString() != last_tool_readed)
                    {
                        stringmodifier.Remove(0, 1);
                        stringmodifier.Insert(0, '0');
                        stringmodifier.Replace('.', ',');
                        tools.Add(new DrillTool(toolname.ToString(), Convert.ToDouble(stringmodifier.ToString()), 0, drilltype.PLATED,unita));
                        last_tool_readed = toolname.ToString();
                        //Determino quanti e quali sono i punti da forare per il tool appena trovato
                        //Mi posiziono alla fine dell'header
                        drillfile.DiscardBufferedData();
                        drillfile.BaseStream.Position = 0;
                        for (; !aux_string_line.Contains("%");)
                            aux_string_line = drillfile.ReadLine();
                        //Cerco il tool
                        do
                        {
                            aux_string_line = drillfile.ReadLine();
                            if (aux_string_line.Contains(toolname.ToString()))
                            {
                                aux_string_line = drillfile.ReadLine();
                                for (int i = 0; aux_string_line[0] == 'X' || aux_string_line[0] == 'Y'; i++)
                                {
                                    //Aumento la quantità dei fori del drill selezionato 
                                    tools[tools.Count - 1].DRILLQUANTITY++;
                                    aux_point.X = 0;
                                    aux_point.Y = 0;
                                    // inserisco il valore
                                    //X
                                    if (aux_string_line.Contains("X"))
                                    {
                                        xybuilder.Clear();
                                        xybuilder.Append(aux_string_line);
                                        if(aux_string_line.Contains("Y"))
                                            xybuilder.Remove(aux_string_line.IndexOf('Y'), aux_string_line.Length - aux_string_line.IndexOf('Y'));
                                        xybuilder.Remove(0, 1);
                                        aux_point.X = Convert.ToDouble(xybuilder.ToString());
                                    }
                                    else
                                        aux_point.X = 0;
                                    //Y
                                    if (aux_string_line.Contains("Y"))
                                    {
                                        xybuilder.Clear();
                                        xybuilder.Append(aux_string_line);
                                        if(aux_string_line.Contains("X"))
                                            xybuilder.Remove(aux_string_line.IndexOf('X'), aux_string_line.IndexOf('Y'));
                                        xybuilder.Remove(0, 1);
                                        aux_point.Y = Convert.ToDouble(xybuilder.ToString());
                                    }
                                    else
                                        aux_point.Y = 0;
                                    //Add point
                                    tools[tools.Count - 1].POINTS.Add(new point(aux_point.X,aux_point.Y));
                                    aux_string_line = drillfile.ReadLine();
                                }

                            }
                        } while (!(aux_string_line.Contains("%") || aux_string_line.Contains("M30") || aux_string_line == null));
                        drillfile.DiscardBufferedData();
                        drillfile.BaseStream.Position = 0;
                        for (; !aux_string_line.Contains(toolname.ToString());)
                            aux_string_line = drillfile.ReadLine();
                        toolname.Clear();
                    }
                }
                stringmodifier.Clear();
            } while (!(aux_string_line.Contains("%") || aux_string_line.Contains("M30") || aux_string_line == null ));
            return gfile;
        }
    }
}
