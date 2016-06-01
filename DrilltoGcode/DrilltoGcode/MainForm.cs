using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrilltoGcode
{
    public partial class MainForm : Form
    {
        #region Variabili

        private StreamReader _DrillFile;
        private DrillFileReader _DrillFileReader = new DrillFileReader();
        private List<DrillTool> _ToolsList = new List<DrillTool>();
        private const int _ZHeightMM = 5; //TODO: export in settings
        private string _Drill;
        private string _DrillUp;

        #endregion

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        #region Metodi

        private void Init()
        {
            ToolListBox.VirtualListSize = _ToolsList.Count();

            foreach (string e in Enum.GetNames(typeof(Increment)))
                IncrementSett.Items.Add(e);

            foreach (string e in Enum.GetNames(typeof(ZeroSuppression)))
                SuppressionSett.Items.Add(e);

            _Drill = "G01" + " Z0" + " F" + (Convert.ToInt32(DrilltoGcode.Properties.Settings.Default.drill_speed) * 60).ToString() + "\r\n";
            _DrillUp = "G01 Z" + _ZHeightMM.ToString() + " F" + (Convert.ToInt32(DrilltoGcode.Properties.Settings.Default.drill_speed) * 60).ToString() + "\r\n";
        }

        private string CeateGCode(DrillTool tool)
        {
            StringBuilder _GCode = new StringBuilder();

            _GCode.Append("G21\r\n");

            //Setto la modalità assoluta o relativa

            if (DrilltoGcode.Properties.Settings.Default.absolute_or_relative_cmd == Increment.Absolute.ToString())
                _GCode.Append("G90\r\n");
            else
                _GCode.Append("G91\r\n");
            
            //Vado a Home
            _GCode.Append(DrilltoGcode.Properties.Settings.Default.home_cmd + " X Y Z\r\n");
            
            //Salgo lungo l'asse Z di zheight mm
            _GCode.Append(_DrillUp);
            
            //scrivo ogni punto
            foreach (Point _point in tool.Points)
            {
                double _ConvFact = 1;

                if (tool.Unit == Units.Imperial)
                    _ConvFact = 25.4;

                _GCode.Append("G01 " + "X" + (_point.X * _ConvFact).ToString().Replace(',', '.') + " Y" + (_point.Y * _ConvFact).ToString().Replace(',', '.') + " F" + (Convert.ToInt32(DrilltoGcode.Properties.Settings.Default.move_speed) * 60).ToString() + "\r\n");
                _GCode.Append(_Drill);
                _GCode.Append(_DrillUp);
            }

            _GCode.Append(DrilltoGcode.Properties.Settings.Default.tp_element_off_cmd + "\r\n");
            _GCode.Append(DrilltoGcode.Properties.Settings.Default.home_cmd + " X Y");

            return _GCode.ToString();
        }

        #endregion

        #region Eventi

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            if (DrillFileDlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _ToolsList.Clear();
                    DrillFilePath.Text = DrillFileDlg.FileName;
                    _DrillFile = new StreamReader(DrillFileDlg.FileName);

                    if (!_DrillFileReader.ReadFile(_DrillFile))
                        throw new Exception("No Header Found");
                    else
                    {
                        foreach (DrillTool d in _DrillFileReader.Tools)
                            _ToolsList.Add(d);

                        ToolListBox.VirtualListSize = _ToolsList.Count();
                        ToolPG.SelectedObject = _ToolsList[0];
                        GCodeBtn.Enabled = true;
                        NormalizeBtn.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nessun file Caricato: " + '\n' + ex.Message);
                }
            }
        }

        private void ToolListBox_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            ListViewItem _Item = new ListViewItem(_ToolsList[e.ItemIndex].ToString());

            e.Item = _Item;
        }

        private void ToolListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ToolListBox.SelectedIndices.Count != 0)
                ToolPG.SelectedObject = _ToolsList[ToolListBox.SelectedIndices[0]];
        }

        private void SaveSettBtn_Click(object sender, EventArgs e)
        {
            DrilltoGcode.Properties.Settings.Default.Save();
        }

        private void NormalizeBtn_Click(object sender, EventArgs e)
        {
            Point _MinPoint = new Point(0, 0);

            double _div = Math.Pow(10, Convert.ToDouble(DrilltoGcode.Properties.Settings.Default.n_precision));

            if (_div == 0)
                return;

            foreach (DrillTool _tool in _ToolsList)
            {
                foreach (Point _point in _tool.Points)
                {
                    _point.X = _point.X * Math.Pow(10, _tool.LastNormal) / _div;
                    _point.Y = _point.Y * Math.Pow(10, _tool.LastNormal) / _div;
                    _point.X = Math.Round(_point.X, Convert.ToInt16(DrilltoGcode.Properties.Settings.Default.n_precision));
                    _point.Y = Math.Round(_point.Y, Convert.ToInt16(DrilltoGcode.Properties.Settings.Default.n_precision));

                    if (_tool.Normalized != true)
                    {
                        if (_MinPoint.X == 0 || _point.X < _MinPoint.X)
                            _MinPoint.X = _point.X;

                        if (_MinPoint.Y == 0 || _point.Y < _MinPoint.Y)
                            _MinPoint.Y = _point.Y;
                    }
                }

                foreach (Point _point in _tool.Points)
                {
                    if (_MinPoint.X < 0)
                        _point.X += Math.Abs(_MinPoint.X) + Convert.ToInt32(DrilltoGcode.Properties.Settings.Default.offsetx);
                    else
                        _point.X -= _MinPoint.X - Convert.ToInt32(DrilltoGcode.Properties.Settings.Default.offsetx);

                    if (_MinPoint.Y < 0)
                        _point.Y += Math.Abs(_MinPoint.Y) + +Convert.ToInt32(DrilltoGcode.Properties.Settings.Default.offsety);
                    else
                        _point.Y -= _MinPoint.Y - Convert.ToInt32(DrilltoGcode.Properties.Settings.Default.offsety);

                    _point.X = Math.Round(_point.X, Convert.ToInt16(DrilltoGcode.Properties.Settings.Default.n_precision));
                    _point.Y = Math.Round(_point.Y, Convert.ToInt16(DrilltoGcode.Properties.Settings.Default.n_precision));
                }

                _tool.Normalized = true;
                _tool.LastNormal = Convert.ToInt32(DrilltoGcode.Properties.Settings.Default.n_precision);
            }

            MessageBox.Show(this, "Normalizzation completed!");
        }

        private void GCodeBtn_Click(object sender, EventArgs e)
        {
            string dir = null;

            if (FolderDlg.ShowDialog() != DialogResult.OK)
                return;

            if (_DrillFileReader.GoodFile) // Da capire l'errore.....io farei aprire un dialog per settare il nome della cartella in cui salvare i vari file gcode!
            {
                dir = FolderDlg.SelectedPath + "\\" + DrillFileDlg.SafeFileName.Remove(DrillFileDlg.SafeFileName.IndexOf(".")) + "_drilltogecode";
                Directory.CreateDirectory(dir);
            }
            else
            {
                dir = FolderDlg.SelectedPath + "\\" + "Drilltogcode_" + DateTime.Now.ToString().Replace('/', '_').Replace(':', '_');
                Directory.CreateDirectory(dir);
            }

            for (int _i = 0; _i < _ToolsList.Count; _i++)
            {
                try
                {
                    File.WriteAllText(dir + "\\" + _ToolsList[_i].ToolName + "_" + _ToolsList[_i].DrillDiameter.ToString() + ".gcode", CeateGCode(_ToolsList[_i]));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during creation: " + ex.Message);
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            _ToolsList.Add(new DrillTool("PT" + _ToolsList.Count().ToString(), 0, 0, DrillType.NonPLated, Units.Metric));
            ToolListBox.VirtualListSize = _ToolsList.Count();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (_ToolsList.Count == 0)
                return;

            if (ToolListBox.SelectedIndices.Count != 0)
            {
                _ToolsList.RemoveAt(ToolListBox.SelectedIndices[0]);
                ToolListBox.VirtualListSize = _ToolsList.Count();
            }
        }

        #endregion

    }
}
