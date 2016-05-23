using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace DrilltoGcode
{
    public enum increment {ABSOLUTE,RELATIVE}
    public partial class mainWindow : Form
    {

        StreamReader drillfile;
        DrillFileReader drlfilereader = new DrillFileReader();
        List<DrillTool> list_tools = new List<DrillTool>();
        const int zheightmm = 5;
        string drill;
        string drillup;

        public mainWindow()
        {
            InitializeComponent();
            toolListBox.VirtualListSize = list_tools.Count();
            foreach (string e in Enum.GetNames(typeof(increment)))
                incrementsett.Items.Add(e);
            foreach (string e in Enum.GetNames(typeof(zero_supp)))
                suppressionsett.Items.Add(e);
            drill = "G01" + " Z0" + " F" + (Convert.ToInt32(DrilltoGcode.Properties.Settings.Default.drill_speed) * 60).ToString() + "\r\n";
            drillup = "G01 Z" + zheightmm.ToString() + " F" + (Convert.ToInt32(DrilltoGcode.Properties.Settings.Default.drill_speed) * 60).ToString() + "\r\n";
        }

        //METODI
        string creategcode(DrillTool tool)
        {
            StringBuilder gcode = new StringBuilder();
            gcode.Append("G21\r\n");
            //Setto la modalità assoluta o relativa
            if (DrilltoGcode.Properties.Settings.Default.absolute_or_relative_cmd == increment.ABSOLUTE.ToString())
                gcode.Append("G90\r\n");
            else
                gcode.Append("G91\r\n");
            //Vado a Home
            gcode.Append(DrilltoGcode.Properties.Settings.Default.home_cmd + " X Y Z\r\n");
            //Salgo lungo l'asse Z di zheight mm
            gcode.Append(drillup);
            //scrivo ogni punto
            foreach(point p in tool.POINTS)
            {
                double convfact = 1;
                if(tool.UNIT == m_unit.IMPERIAL)
                    convfact = 25.4;
                gcode.Append("G01 " + "X" + (p.X * convfact).ToString().Replace(',','.') + " Y" + (p.Y * convfact).ToString().Replace(',', '.') + " F" + (Convert.ToInt32(DrilltoGcode.Properties.Settings.Default.move_speed) * 60).ToString() + "\r\n");
                gcode.Append(drill);
                gcode.Append(drillup);
            }
            gcode.Append(DrilltoGcode.Properties.Settings.Default.tp_element_off_cmd + "\r\n");
            gcode.Append(DrilltoGcode.Properties.Settings.Default.home_cmd +" X Y");
            return gcode.ToString();
        }

        //EVENTI
        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            if (DrillFileOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    list_tools.Clear();
                    drillFilePath.Text = DrillFileOpen.FileName;
                    drillfile = new StreamReader(DrillFileOpen.FileName);
                    if (!drlfilereader.read_file(drillfile))
                        throw new Exception("Nessun Header trovato");
                    else
                    {
                        foreach (DrillTool d in drlfilereader.TOOLS)
                            list_tools.Add(d);
                        toolListBox.VirtualListSize = list_tools.Count();
                        toolpg.SelectedObject = list_tools[0];
                        gcodebutton.Enabled = true;
                        normalizebtn.Enabled = true;

                    }
  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nessun file Caricato: " +'\n'+ ex.Message);
                }
            }
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {

        }
        private void toolpg_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {

        }

        private void toolListBox_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            ListViewItem item = new ListViewItem(list_tools[e.ItemIndex].ToString());
            e.Item = item;
        }

        private void toolListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolListBox.SelectedIndices.Count != 0)
                toolpg.SelectedObject = list_tools[toolListBox.SelectedIndices[0]];
        }

        private void savesettbtn_Click(object sender, EventArgs e)
        {
            DrilltoGcode.Properties.Settings.Default.Save();
        }

        private void normalizebtn_Click(object sender, EventArgs e)
        {
            point minp = new point(0, 0);
            double div = Math.Pow(10, Convert.ToDouble(DrilltoGcode.Properties.Settings.Default.n_precision));
            if (div != 0)
                foreach (DrillTool tool in list_tools)
                {
                    foreach (point p in tool.POINTS)
                    {
                        p.X = p.X * Math.Pow(10, tool.LASTNORMVAL) / div;
                        p.Y = p.Y * Math.Pow(10, tool.LASTNORMVAL) / div;
                        p.X = Math.Round(p.X,Convert.ToInt16(DrilltoGcode.Properties.Settings.Default.n_precision));
                        p.Y = Math.Round(p.Y, Convert.ToInt16(DrilltoGcode.Properties.Settings.Default.n_precision));
                        if (tool.NORMALIZED != true)
                        {
                            if (minp.X == 0 || p.X < minp.X)
                                minp.X = p.X;
                            if (minp.Y == 0 || p.Y < minp.Y)
                                minp.Y = p.Y;
                        }
                    }
                        foreach (point p in tool.POINTS)
                        {
                            if (minp.X < 0)
                                p.X += Math.Abs(minp.X) + Convert.ToInt32(DrilltoGcode.Properties.Settings.Default.offsetx);
                            else
                                p.X -= minp.X - Convert.ToInt32(DrilltoGcode.Properties.Settings.Default.offsetx);
                            if (minp.Y < 0)
                                p.Y += Math.Abs(minp.Y) + +Convert.ToInt32(DrilltoGcode.Properties.Settings.Default.offsety);
                            else
                                p.Y -= minp.Y - Convert.ToInt32(DrilltoGcode.Properties.Settings.Default.offsety);
                            p.X = Math.Round(p.X, Convert.ToInt16(DrilltoGcode.Properties.Settings.Default.n_precision));
                            p.Y = Math.Round(p.Y, Convert.ToInt16(DrilltoGcode.Properties.Settings.Default.n_precision));
                    }
                    tool.NORMALIZED = true;
                    tool.LASTNORMVAL = Convert.ToInt32(DrilltoGcode.Properties.Settings.Default.n_precision);
                }
            MessageBox.Show(this, "Normalizzation completed!");
        }

        private void gcodebutton_Click(object sender, EventArgs e)
        {
            string dir = null;
            if (folderdialog.ShowDialog() == DialogResult.OK)
            {
                if(drlfilereader.GOODFILE == true) // Da capire l'errore.....io farei aprire un dialog per settare il nome della cartella in cui salvare i vari file gcode!
                {
                    dir = folderdialog.SelectedPath + "\\" + DrillFileOpen.SafeFileName.Remove(DrillFileOpen.SafeFileName.IndexOf(".")) + "_drilltogecode";
                    Directory.CreateDirectory(dir);
                }
                else
                {
                    dir = folderdialog.SelectedPath + "\\" + "Drilltogcode_" + DateTime.Now.ToString().Replace('/','_').Replace(':','_') ;
                    Directory.CreateDirectory(dir);
                }
                    for (int i = 0; i < list_tools.Count; i++)
                    {
                        try
                        {
                            File.WriteAllText(dir + "\\" + list_tools[i].TOOLNAME + "_" + list_tools[i].DRILLDIAMETER.ToString() + ".gcode", creategcode(list_tools[i]));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error during creation: " + ex.Message);
                        }
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list_tools.Add(new DrillTool("PT" + list_tools.Count().ToString(), 0, 0, drilltype.NONPLATED, m_unit.METRIC));
            toolListBox.VirtualListSize = list_tools.Count();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (list_tools.Count != 0)
            {
                if (toolListBox.SelectedIndices.Count != 0)
                {
                    list_tools.RemoveAt(toolListBox.SelectedIndices[0]);
                    toolListBox.VirtualListSize = list_tools.Count();
                }
            }
        }
    }
}
