using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DrilltoGcode
{
    /// <summary>
    /// Reader drill file.
    /// </summary>
    public class DrillFileReader
    {
        #region Variabili

        private List<DrillTool> _Tools;
        private string _AuxStringLine;
        private string _LastToolRead;
        private Point _AuxPoint;
        private StringBuilder _StringModifier;
        private StringBuilder _ToolName;
        private StringBuilder _XYBuilder;
        private long _HeaderLinePos;
        private bool _GoodFile;
        private Units _Unita;

        #endregion

        #region Proprietà

        /// <summary>
        /// Lista dei tool.
        /// </summary>
        public List<DrillTool> Tools
        {
            get { return _Tools; }
        }

        /// <summary>
        /// File caricato correttamente.
        /// </summary>
        public bool GoodFile
        {
            get { return _GoodFile; }
        }

        #endregion

        #region Construttore

        /// <summary>
        /// Costruttore di base.
        /// </summary>
        public DrillFileReader()
        {
            _Tools = new List<DrillTool>();
            _AuxStringLine = null;
            _Unita = Units.Metric;
            _GoodFile = false;
            _StringModifier = new StringBuilder();
            _ToolName = new StringBuilder();
            _XYBuilder = new StringBuilder();
            _LastToolRead = "last";
            _AuxPoint = new Point(0,0);
            _HeaderLinePos = 0;
        }
        
        #endregion

        #region Metodi

        /// <summary>
        /// Iniziallizza il tool.
        /// </summary>
        public void Clear()
        {
            _Tools.Clear();
            _AuxStringLine = null;
            _GoodFile = false;
            _StringModifier.Clear();
            _ToolName.Clear();
            _XYBuilder.Clear();
            _AuxPoint.X = 0;
            _AuxPoint.Y = 0;
            _HeaderLinePos = 0;
            _LastToolRead = "last";
        }

        /// <summary>
        /// Legge un drill file.
        /// </summary>
        /// <param name="drillfile">Path del file da leggere</param>
        /// <returns>true se il file è stato letto correttamente false in caso contrario</returns>
        public bool ReadFile(StreamReader drillfile)
        {
            this.Clear();

            drillfile.DiscardBufferedData();
            drillfile.BaseStream.Position = 0;

            //read header
            do
            {
                _AuxStringLine = drillfile.ReadLine();

                if (!_GoodFile && _AuxStringLine.Contains("M48"))
                {
                    _HeaderLinePos = drillfile.BaseStream.Length;
                    _GoodFile = true;

                    do
                    {
                        _AuxStringLine = drillfile.ReadLine();
                    } while (!(_AuxStringLine.Contains("M71") || _AuxStringLine.Contains("M72") || _AuxStringLine.Contains("METRIC") || _AuxStringLine.Contains("IMPERIAL") || _AuxStringLine.Contains("INCH")));

                    if (_AuxStringLine.Contains("M71") || _AuxStringLine.Contains("METRIC"))
                        _Unita = Units.Metric;

                    if (_AuxStringLine.Contains("M72") || _AuxStringLine.Contains("IMPERIAL") || _AuxStringLine.Contains("INCH"))
                        _Unita = Units.Imperial;

                    drillfile.DiscardBufferedData();
                    drillfile.BaseStream.Position = 0;

                    _AuxStringLine = drillfile.ReadLine();
                    _AuxStringLine = drillfile.ReadLine();
                }

                if (!_GoodFile)
                    continue;

                //Leggo i tools
                _StringModifier.Append(_AuxStringLine);

                if ((_StringModifier.Length != 0) && ((_StringModifier[0] == 'T') || (_StringModifier[0] == 't')))
                {
                    //avanzo dall'ultimo elemento fino a trovare la C
                    for (int _i = 0; (_StringModifier.Length != 0) && (_i <= 500) && !((_StringModifier[0] == 'C') || (_StringModifier[0] == 'c')); _i++)
                    {
                        _ToolName.Append(_StringModifier[0]);
                        _StringModifier.Remove(0, 1);
                    }

                    if ((_StringModifier.Length != 0) && (_ToolName.ToString() != _LastToolRead))
                    {
                        _StringModifier.Remove(0, 1);
                        _StringModifier.Insert(0, '0');
                        _StringModifier.Replace('.', ',');
                        _Tools.Add(new DrillTool(_ToolName.ToString(), Convert.ToDouble(_StringModifier.ToString()), 0, DrillType.Plated, _Unita));
                        _LastToolRead = _ToolName.ToString();
                        //Determino quanti e quali sono i punti da forare per il tool appena trovato
                        //Mi posiziono alla fine dell'header
                        drillfile.DiscardBufferedData();
                        drillfile.BaseStream.Position = 0;

                        for (; !_AuxStringLine.Contains("%");)
                            _AuxStringLine = drillfile.ReadLine();
                        
                        //Cerco il tool
                        do
                        {
                            _AuxStringLine = drillfile.ReadLine();

                            if (_AuxStringLine.Contains(_ToolName.ToString()))
                            {
                                _AuxStringLine = drillfile.ReadLine();

                                for (int _i = 0; (_AuxStringLine[0] == 'X') || (_AuxStringLine[0] == 'Y'); _i++)
                                {
                                    //Aumento la quantità dei fori del drill selezionato 
                                    _Tools[_Tools.Count - 1].DrillQuantity++;
                                    _AuxPoint.X = 0;
                                    _AuxPoint.Y = 0;
                                    // inserisco il valore

                                    //X
                                    if (_AuxStringLine.Contains("X"))
                                    {
                                        _XYBuilder.Clear();
                                        _XYBuilder.Append(_AuxStringLine);

                                        if (_AuxStringLine.Contains("Y"))
                                            _XYBuilder.Remove(_AuxStringLine.IndexOf('Y'), _AuxStringLine.Length - _AuxStringLine.IndexOf('Y'));

                                        _XYBuilder.Remove(0, 1);
                                        _AuxPoint.X = Convert.ToDouble(_XYBuilder.ToString());
                                    }
                                    else
                                        _AuxPoint.X = 0;
                                    
                                    //Y
                                    if (_AuxStringLine.Contains("Y"))
                                    {
                                        _XYBuilder.Clear();
                                        _XYBuilder.Append(_AuxStringLine);

                                        if (_AuxStringLine.Contains("X"))
                                            _XYBuilder.Remove(_AuxStringLine.IndexOf('X'), _AuxStringLine.IndexOf('Y'));

                                        _XYBuilder.Remove(0, 1);
                                        _AuxPoint.Y = Convert.ToDouble(_XYBuilder.ToString());
                                    }
                                    else
                                        _AuxPoint.Y = 0;
                                    
                                    //Add point
                                    _Tools[_Tools.Count - 1].Points.Add(new Point(_AuxPoint.X, _AuxPoint.Y));
                                    _AuxStringLine = drillfile.ReadLine();
                                }

                            }
                        } while (!(_AuxStringLine.Contains("%") || _AuxStringLine.Contains("M30") || (_AuxStringLine == null)));

                        drillfile.DiscardBufferedData();
                        drillfile.BaseStream.Position = 0;

                        for (; !_AuxStringLine.Contains(_ToolName.ToString());)
                            _AuxStringLine = drillfile.ReadLine();

                        _ToolName.Clear();
                    }
                }

                _StringModifier.Clear();
            } while (!(_AuxStringLine.Contains("%") || _AuxStringLine.Contains("M30") || (_AuxStringLine == null)));

            return _GoodFile;
        }

        /// <summary>
        /// Create a DrillFileReader from a drill file.
        /// </summary>
        /// <param name="drillfile">Drill file</param>
        /// <returns></returns>
        public static DrillFileReader Create(StreamReader drillfile)
        {
            DrillFileReader _drillfilereader = new DrillFileReader();

            bool _result = _drillfilereader.ReadFile(drillfile);

            if (_result)
                return _drillfilereader;

            throw new Exception("Unable to create DrillFileReader");
        }

        #endregion
    }
}
