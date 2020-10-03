namespace DrilltoGcode
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.DrillFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.DrillFilePath = new System.Windows.Forms.TextBox();
            this.OptionsTC = new System.Windows.Forms.TabControl();
            this.ToolsPage = new System.Windows.Forms.TabPage();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.NormalizeBtn = new System.Windows.Forms.Button();
            this.GCodeBtn = new System.Windows.Forms.Button();
            this.ToolListBox = new System.Windows.Forms.ListView();
            this.ToolHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToolPG = new System.Windows.Forms.PropertyGrid();
            this.OptionsPage = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveSettBtn = new System.Windows.Forms.Button();
            this.DirectoryLabel = new System.Windows.Forms.Label();
            this.FolderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.YOffsetBox = new System.Windows.Forms.TextBox();
            this.XOffsetBox = new System.Windows.Forms.TextBox();
            this.SuppressionSett = new System.Windows.Forms.ComboBox();
            this.PrecisionDgt = new System.Windows.Forms.TextBox();
            this.NDigit = new System.Windows.Forms.TextBox();
            this.IncrementSett = new System.Windows.Forms.ComboBox();
            this.HomeCmdTxt = new System.Windows.Forms.TextBox();
            this.MoveSpeedTxt = new System.Windows.Forms.TextBox();
            this.DrillSpeedTxt = new System.Windows.Forms.TextBox();
            this.FanOFFCmdTxt = new System.Windows.Forms.TextBox();
            this.FanONCmdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Depth = new System.Windows.Forms.TextBox();
            this.OptionsTC.SuspendLayout();
            this.ToolsPage.SuspendLayout();
            this.OptionsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrillFileDlg
            // 
            this.DrillFileDlg.Filter = "Excellon Drill|*.drl;*.drill;*.dril|Text file|*.txt";
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Location = new System.Drawing.Point(651, 37);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(44, 37);
            this.OpenFileBtn.TabIndex = 0;
            this.OpenFileBtn.Text = "...";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // DrillFilePath
            // 
            this.DrillFilePath.Location = new System.Drawing.Point(128, 40);
            this.DrillFilePath.Name = "DrillFilePath";
            this.DrillFilePath.ReadOnly = true;
            this.DrillFilePath.Size = new System.Drawing.Size(516, 26);
            this.DrillFilePath.TabIndex = 1;
            // 
            // OptionsTC
            // 
            this.OptionsTC.Controls.Add(this.ToolsPage);
            this.OptionsTC.Controls.Add(this.OptionsPage);
            this.OptionsTC.Location = new System.Drawing.Point(40, 80);
            this.OptionsTC.Name = "OptionsTC";
            this.OptionsTC.SelectedIndex = 0;
            this.OptionsTC.Size = new System.Drawing.Size(654, 608);
            this.OptionsTC.TabIndex = 2;
            // 
            // ToolsPage
            // 
            this.ToolsPage.Controls.Add(this.RemoveBtn);
            this.ToolsPage.Controls.Add(this.AddBtn);
            this.ToolsPage.Controls.Add(this.NormalizeBtn);
            this.ToolsPage.Controls.Add(this.GCodeBtn);
            this.ToolsPage.Controls.Add(this.ToolListBox);
            this.ToolsPage.Controls.Add(this.ToolPG);
            this.ToolsPage.Location = new System.Drawing.Point(4, 29);
            this.ToolsPage.Name = "ToolsPage";
            this.ToolsPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.ToolsPage.Size = new System.Drawing.Size(646, 475);
            this.ToolsPage.TabIndex = 0;
            this.ToolsPage.Text = "Tools";
            this.ToolsPage.UseVisualStyleBackColor = true;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(146, 422);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(140, 40);
            this.RemoveBtn.TabIndex = 18;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(6, 422);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(135, 40);
            this.AddBtn.TabIndex = 17;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // NormalizeBtn
            // 
            this.NormalizeBtn.Location = new System.Drawing.Point(290, 395);
            this.NormalizeBtn.Name = "NormalizeBtn";
            this.NormalizeBtn.Size = new System.Drawing.Size(171, 66);
            this.NormalizeBtn.TabIndex = 16;
            this.NormalizeBtn.Text = "Normalize";
            this.NormalizeBtn.UseVisualStyleBackColor = true;
            this.NormalizeBtn.Click += new System.EventHandler(this.NormalizeBtn_Click);
            // 
            // GCodeBtn
            // 
            this.GCodeBtn.Location = new System.Drawing.Point(465, 395);
            this.GCodeBtn.Name = "GCodeBtn";
            this.GCodeBtn.Size = new System.Drawing.Size(171, 66);
            this.GCodeBtn.TabIndex = 15;
            this.GCodeBtn.Text = "Generate Gcode";
            this.GCodeBtn.UseVisualStyleBackColor = true;
            this.GCodeBtn.Click += new System.EventHandler(this.GCodeBtn_Click);
            // 
            // ToolListBox
            // 
            this.ToolListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ToolHeader});
            this.ToolListBox.HideSelection = false;
            this.ToolListBox.Location = new System.Drawing.Point(6, 6);
            this.ToolListBox.Name = "ToolListBox";
            this.ToolListBox.Size = new System.Drawing.Size(276, 407);
            this.ToolListBox.TabIndex = 14;
            this.ToolListBox.UseCompatibleStateImageBehavior = false;
            this.ToolListBox.View = System.Windows.Forms.View.Details;
            this.ToolListBox.VirtualMode = true;
            this.ToolListBox.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.ToolListBox_RetrieveVirtualItem);
            this.ToolListBox.SelectedIndexChanged += new System.EventHandler(this.ToolListBox_SelectedIndexChanged);
            // 
            // ToolHeader
            // 
            this.ToolHeader.Text = "Tool Name";
            this.ToolHeader.Width = 263;
            // 
            // ToolPG
            // 
            this.ToolPG.Location = new System.Drawing.Point(290, 6);
            this.ToolPG.Name = "ToolPG";
            this.ToolPG.Size = new System.Drawing.Size(346, 383);
            this.ToolPG.TabIndex = 13;
            // 
            // OptionsPage
            // 
            this.OptionsPage.Controls.Add(this.label1);
            this.OptionsPage.Controls.Add(this.Depth);
            this.OptionsPage.Controls.Add(this.label15);
            this.OptionsPage.Controls.Add(this.label14);
            this.OptionsPage.Controls.Add(this.label13);
            this.OptionsPage.Controls.Add(this.label12);
            this.OptionsPage.Controls.Add(this.label11);
            this.OptionsPage.Controls.Add(this.label2);
            this.OptionsPage.Controls.Add(this.label10);
            this.OptionsPage.Controls.Add(this.label9);
            this.OptionsPage.Controls.Add(this.label8);
            this.OptionsPage.Controls.Add(this.label6);
            this.OptionsPage.Controls.Add(this.label7);
            this.OptionsPage.Controls.Add(this.label5);
            this.OptionsPage.Controls.Add(this.label4);
            this.OptionsPage.Controls.Add(this.label3);
            this.OptionsPage.Controls.Add(this.SaveSettBtn);
            this.OptionsPage.Controls.Add(this.YOffsetBox);
            this.OptionsPage.Controls.Add(this.XOffsetBox);
            this.OptionsPage.Controls.Add(this.SuppressionSett);
            this.OptionsPage.Controls.Add(this.PrecisionDgt);
            this.OptionsPage.Controls.Add(this.NDigit);
            this.OptionsPage.Controls.Add(this.IncrementSett);
            this.OptionsPage.Controls.Add(this.HomeCmdTxt);
            this.OptionsPage.Controls.Add(this.MoveSpeedTxt);
            this.OptionsPage.Controls.Add(this.DrillSpeedTxt);
            this.OptionsPage.Controls.Add(this.FanOFFCmdTxt);
            this.OptionsPage.Controls.Add(this.FanONCmdTxt);
            this.OptionsPage.Location = new System.Drawing.Point(4, 29);
            this.OptionsPage.Name = "OptionsPage";
            this.OptionsPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.OptionsPage.Size = new System.Drawing.Size(646, 575);
            this.OptionsPage.TabIndex = 1;
            this.OptionsPage.Text = "Options";
            this.OptionsPage.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(390, 342);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Y: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(260, 342);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "X: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(156, 342);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Offset: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(74, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Zero Suppression: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(340, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Precision Digit: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Integer Digit: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(502, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "mm/s: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(502, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "mm/s: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Home cmd: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Move Speed: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Drill Speed: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Increment: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fan OFF cmd: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fan ON cmd: ";
            // 
            // SaveSettBtn
            // 
            this.SaveSettBtn.Location = new System.Drawing.Point(273, 520);
            this.SaveSettBtn.Name = "SaveSettBtn";
            this.SaveSettBtn.Size = new System.Drawing.Size(94, 49);
            this.SaveSettBtn.TabIndex = 1;
            this.SaveSettBtn.Text = "Save";
            this.SaveSettBtn.UseVisualStyleBackColor = true;
            this.SaveSettBtn.Click += new System.EventHandler(this.SaveSettBtn_Click);
            // 
            // DirectoryLabel
            // 
            this.DirectoryLabel.AutoSize = true;
            this.DirectoryLabel.Location = new System.Drawing.Point(36, 45);
            this.DirectoryLabel.Name = "DirectoryLabel";
            this.DirectoryLabel.Size = new System.Drawing.Size(76, 20);
            this.DirectoryLabel.TabIndex = 3;
            this.DirectoryLabel.Text = "Directory:";
            // 
            // YOffsetBox
            // 
            this.YOffsetBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "offsety", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.YOffsetBox.Enabled = false;
            this.YOffsetBox.Location = new System.Drawing.Point(424, 338);
            this.YOffsetBox.Name = "YOffsetBox";
            this.YOffsetBox.Size = new System.Drawing.Size(73, 26);
            this.YOffsetBox.TabIndex = 27;
            this.YOffsetBox.Text = global::DrilltoGcode.Properties.Settings.Default.offsety;
            // 
            // XOffsetBox
            // 
            this.XOffsetBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "offsetx", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.XOffsetBox.Enabled = false;
            this.XOffsetBox.Location = new System.Drawing.Point(294, 338);
            this.XOffsetBox.Name = "XOffsetBox";
            this.XOffsetBox.Size = new System.Drawing.Size(73, 26);
            this.XOffsetBox.TabIndex = 26;
            this.XOffsetBox.Text = global::DrilltoGcode.Properties.Settings.Default.offsetx;
            // 
            // SuppressionSett
            // 
            this.SuppressionSett.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "zero_supp", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SuppressionSett.Enabled = false;
            this.SuppressionSett.FormattingEnabled = true;
            this.SuppressionSett.Location = new System.Drawing.Point(254, 305);
            this.SuppressionSett.Name = "SuppressionSett";
            this.SuppressionSett.Size = new System.Drawing.Size(242, 28);
            this.SuppressionSett.TabIndex = 24;
            this.SuppressionSett.Text = global::DrilltoGcode.Properties.Settings.Default.zero_supp;
            // 
            // PrecisionDgt
            // 
            this.PrecisionDgt.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "n_precision", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PrecisionDgt.Location = new System.Drawing.Point(464, 272);
            this.PrecisionDgt.Name = "PrecisionDgt";
            this.PrecisionDgt.Size = new System.Drawing.Size(32, 26);
            this.PrecisionDgt.TabIndex = 22;
            this.PrecisionDgt.Text = global::DrilltoGcode.Properties.Settings.Default.n_precision;
            // 
            // NDigit
            // 
            this.NDigit.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "n_cfr_int", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NDigit.Location = new System.Drawing.Point(254, 272);
            this.NDigit.Name = "NDigit";
            this.NDigit.Size = new System.Drawing.Size(32, 26);
            this.NDigit.TabIndex = 20;
            this.NDigit.Text = global::DrilltoGcode.Properties.Settings.Default.n_cfr_int;
            // 
            // IncrementSett
            // 
            this.IncrementSett.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "absolute_or_relative_cmd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IncrementSett.FormattingEnabled = true;
            this.IncrementSett.Location = new System.Drawing.Point(254, 78);
            this.IncrementSett.Name = "IncrementSett";
            this.IncrementSett.Size = new System.Drawing.Size(242, 28);
            this.IncrementSett.TabIndex = 18;
            this.IncrementSett.Text = global::DrilltoGcode.Properties.Settings.Default.absolute_or_relative_cmd;
            // 
            // HomeCmdTxt
            // 
            this.HomeCmdTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "home_cmd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.HomeCmdTxt.Location = new System.Drawing.Point(254, 242);
            this.HomeCmdTxt.Name = "HomeCmdTxt";
            this.HomeCmdTxt.Size = new System.Drawing.Size(242, 26);
            this.HomeCmdTxt.TabIndex = 15;
            this.HomeCmdTxt.Text = global::DrilltoGcode.Properties.Settings.Default.home_cmd;
            // 
            // MoveSpeedTxt
            // 
            this.MoveSpeedTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "move_speed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MoveSpeedTxt.Location = new System.Drawing.Point(254, 145);
            this.MoveSpeedTxt.Name = "MoveSpeedTxt";
            this.MoveSpeedTxt.Size = new System.Drawing.Size(242, 26);
            this.MoveSpeedTxt.TabIndex = 13;
            this.MoveSpeedTxt.Text = global::DrilltoGcode.Properties.Settings.Default.move_speed;
            // 
            // DrillSpeedTxt
            // 
            this.DrillSpeedTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "drill_speed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DrillSpeedTxt.Location = new System.Drawing.Point(254, 112);
            this.DrillSpeedTxt.Name = "DrillSpeedTxt";
            this.DrillSpeedTxt.Size = new System.Drawing.Size(242, 26);
            this.DrillSpeedTxt.TabIndex = 12;
            this.DrillSpeedTxt.Text = global::DrilltoGcode.Properties.Settings.Default.drill_speed;
            // 
            // FanOFFCmdTxt
            // 
            this.FanOFFCmdTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "tp_element_off_cmd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FanOFFCmdTxt.Location = new System.Drawing.Point(254, 209);
            this.FanOFFCmdTxt.Name = "FanOFFCmdTxt";
            this.FanOFFCmdTxt.Size = new System.Drawing.Size(242, 26);
            this.FanOFFCmdTxt.TabIndex = 8;
            this.FanOFFCmdTxt.Text = global::DrilltoGcode.Properties.Settings.Default.tp_element_off_cmd;
            // 
            // FanONCmdTxt
            // 
            this.FanONCmdTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "tp_element_cmd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FanONCmdTxt.Location = new System.Drawing.Point(254, 177);
            this.FanONCmdTxt.Name = "FanONCmdTxt";
            this.FanONCmdTxt.Size = new System.Drawing.Size(242, 26);
            this.FanONCmdTxt.TabIndex = 7;
            this.FanONCmdTxt.Text = global::DrilltoGcode.Properties.Settings.Default.tp_element_cmd;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Depth: ";
            // 
            // Depth
            // 
            this.Depth.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "drill_depth", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Depth.Location = new System.Drawing.Point(254, 370);
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(242, 26);
            this.Depth.TabIndex = 31;
            this.Depth.Text = global::DrilltoGcode.Properties.Settings.Default.drill_depth;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 700);
            this.Controls.Add(this.DirectoryLabel);
            this.Controls.Add(this.OptionsTC);
            this.Controls.Add(this.DrillFilePath);
            this.Controls.Add(this.OpenFileBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drill to Gcode";
            this.OptionsTC.ResumeLayout(false);
            this.ToolsPage.ResumeLayout(false);
            this.OptionsPage.ResumeLayout(false);
            this.OptionsPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog DrillFileDlg;
        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.TextBox DrillFilePath;
        private System.Windows.Forms.TabControl OptionsTC;
        private System.Windows.Forms.TabPage ToolsPage;
        private System.Windows.Forms.Button GCodeBtn;
        private System.Windows.Forms.ListView ToolListBox;
        private System.Windows.Forms.ColumnHeader ToolHeader;
        private System.Windows.Forms.PropertyGrid ToolPG;
        private System.Windows.Forms.TabPage OptionsPage;
        private System.Windows.Forms.Label DirectoryLabel;
        private System.Windows.Forms.Button SaveSettBtn;
        private System.Windows.Forms.TextBox FanOFFCmdTxt;
        private System.Windows.Forms.TextBox FanONCmdTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MoveSpeedTxt;
        private System.Windows.Forms.TextBox DrillSpeedTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox HomeCmdTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox IncrementSett;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrecisionDgt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NDigit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox SuppressionSett;
        private System.Windows.Forms.Button NormalizeBtn;
        private System.Windows.Forms.FolderBrowserDialog FolderDlg;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox XOffsetBox;
        private System.Windows.Forms.TextBox YOffsetBox;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Depth;
    }
}

