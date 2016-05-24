namespace DrilltoGcode
{
    partial class mainWindow
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
            this.DrillFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.drillFilePath = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.normalizebtn = new System.Windows.Forms.Button();
            this.gcodebutton = new System.Windows.Forms.Button();
            this.toolListBox = new System.Windows.Forms.ListView();
            this.ToolHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolpg = new System.Windows.Forms.PropertyGrid();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.yoffsetbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.xoffsetbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.suppressionsett = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.savesettbtn = new System.Windows.Forms.Button();
            this.ndigit = new System.Windows.Forms.TextBox();
            this.incrementsett = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderdialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrillFileOpen
            // 
            this.DrillFileOpen.Filter = "Excellon Drill|*.drl;*.drill;*.dril|Text file|*.txt";
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Location = new System.Drawing.Point(651, 32);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(51, 42);
            this.OpenFileBtn.TabIndex = 0;
            this.OpenFileBtn.Text = "...";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // drillFilePath
            // 
            this.drillFilePath.Location = new System.Drawing.Point(126, 40);
            this.drillFilePath.Name = "drillFilePath";
            this.drillFilePath.ReadOnly = true;
            this.drillFilePath.Size = new System.Drawing.Size(518, 26);
            this.drillFilePath.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(48, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 508);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.normalizebtn);
            this.tabPage1.Controls.Add(this.gcodebutton);
            this.tabPage1.Controls.Add(this.toolListBox);
            this.tabPage1.Controls.Add(this.toolpg);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(646, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tools";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 40);
            this.button2.TabIndex = 18;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // normalizebtn
            // 
            this.normalizebtn.Location = new System.Drawing.Point(291, 389);
            this.normalizebtn.Name = "normalizebtn";
            this.normalizebtn.Size = new System.Drawing.Size(171, 66);
            this.normalizebtn.TabIndex = 16;
            this.normalizebtn.Text = "Normalize";
            this.normalizebtn.UseVisualStyleBackColor = true;
            this.normalizebtn.Click += new System.EventHandler(this.normalizebtn_Click);
            // 
            // gcodebutton
            // 
            this.gcodebutton.Location = new System.Drawing.Point(484, 389);
            this.gcodebutton.Name = "gcodebutton";
            this.gcodebutton.Size = new System.Drawing.Size(154, 66);
            this.gcodebutton.TabIndex = 15;
            this.gcodebutton.Text = "Generate Gcode";
            this.gcodebutton.UseVisualStyleBackColor = true;
            this.gcodebutton.Click += new System.EventHandler(this.gcodebutton_Click);
            // 
            // toolListBox
            // 
            this.toolListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ToolHeader});
            this.toolListBox.Location = new System.Drawing.Point(6, 20);
            this.toolListBox.Name = "toolListBox";
            this.toolListBox.Size = new System.Drawing.Size(278, 387);
            this.toolListBox.TabIndex = 14;
            this.toolListBox.UseCompatibleStateImageBehavior = false;
            this.toolListBox.View = System.Windows.Forms.View.Details;
            this.toolListBox.VirtualMode = true;
            this.toolListBox.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.toolListBox_RetrieveVirtualItem);
            this.toolListBox.SelectedIndexChanged += new System.EventHandler(this.toolListBox_SelectedIndexChanged);
            // 
            // ToolHeader
            // 
            this.ToolHeader.Text = "Tool Name";
            this.ToolHeader.Width = 263;
            // 
            // toolpg
            // 
            this.toolpg.Location = new System.Drawing.Point(291, 20);
            this.toolpg.Name = "toolpg";
            this.toolpg.Size = new System.Drawing.Size(350, 365);
            this.toolpg.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.yoffsetbox);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.xoffsetbox);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.suppressionsett);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.savesettbtn);
            this.tabPage2.Controls.Add(this.ndigit);
            this.tabPage2.Controls.Add(this.incrementsett);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(646, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // yoffsetbox
            // 
            this.yoffsetbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "offsety", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.yoffsetbox.Enabled = false;
            this.yoffsetbox.Location = new System.Drawing.Point(424, 338);
            this.yoffsetbox.Name = "yoffsetbox";
            this.yoffsetbox.Size = new System.Drawing.Size(73, 26);
            this.yoffsetbox.TabIndex = 27;
            this.yoffsetbox.Text = global::DrilltoGcode.Properties.Settings.Default.offsety;
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
            // xoffsetbox
            // 
            this.xoffsetbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "offsetx", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.xoffsetbox.Enabled = false;
            this.xoffsetbox.Location = new System.Drawing.Point(294, 338);
            this.xoffsetbox.Name = "xoffsetbox";
            this.xoffsetbox.Size = new System.Drawing.Size(73, 26);
            this.xoffsetbox.TabIndex = 26;
            this.xoffsetbox.Text = global::DrilltoGcode.Properties.Settings.Default.offsetx;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(76, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Zero Suppression: ";
            // 
            // suppressionsett
            // 
            this.suppressionsett.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "zero_supp", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.suppressionsett.Enabled = false;
            this.suppressionsett.FormattingEnabled = true;
            this.suppressionsett.Location = new System.Drawing.Point(254, 305);
            this.suppressionsett.Name = "suppressionsett";
            this.suppressionsett.Size = new System.Drawing.Size(242, 28);
            this.suppressionsett.TabIndex = 24;
            this.suppressionsett.Text = global::DrilltoGcode.Properties.Settings.Default.zero_supp;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "n_precision", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(464, 272);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 26);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = global::DrilltoGcode.Properties.Settings.Default.n_precision;
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
            this.label2.Location = new System.Drawing.Point(116, 275);
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
            this.label8.Location = new System.Drawing.Point(124, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Home cmd: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Move Speed: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 115);
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
            this.label4.Location = new System.Drawing.Point(104, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fan OFF cmd: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fan ON cmd: ";
            // 
            // savesettbtn
            // 
            this.savesettbtn.Location = new System.Drawing.Point(546, 418);
            this.savesettbtn.Name = "savesettbtn";
            this.savesettbtn.Size = new System.Drawing.Size(94, 49);
            this.savesettbtn.TabIndex = 1;
            this.savesettbtn.Text = "save";
            this.savesettbtn.UseVisualStyleBackColor = true;
            this.savesettbtn.Click += new System.EventHandler(this.savesettbtn_Click);
            // 
            // ndigit
            // 
            this.ndigit.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "n_cfr_int", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ndigit.Location = new System.Drawing.Point(254, 272);
            this.ndigit.Name = "ndigit";
            this.ndigit.Size = new System.Drawing.Size(32, 26);
            this.ndigit.TabIndex = 20;
            this.ndigit.Text = global::DrilltoGcode.Properties.Settings.Default.n_cfr_int;
            // 
            // incrementsett
            // 
            this.incrementsett.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "absolute_or_relative_cmd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.incrementsett.FormattingEnabled = true;
            this.incrementsett.Location = new System.Drawing.Point(254, 78);
            this.incrementsett.Name = "incrementsett";
            this.incrementsett.Size = new System.Drawing.Size(242, 28);
            this.incrementsett.TabIndex = 18;
            this.incrementsett.Text = global::DrilltoGcode.Properties.Settings.Default.absolute_or_relative_cmd;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "home_cmd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox7.Location = new System.Drawing.Point(254, 242);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(242, 26);
            this.textBox7.TabIndex = 15;
            this.textBox7.Text = global::DrilltoGcode.Properties.Settings.Default.home_cmd;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "move_speed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox5.Location = new System.Drawing.Point(254, 145);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(242, 26);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = global::DrilltoGcode.Properties.Settings.Default.move_speed;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "drill_speed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox6.Location = new System.Drawing.Point(254, 112);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(242, 26);
            this.textBox6.TabIndex = 12;
            this.textBox6.Text = global::DrilltoGcode.Properties.Settings.Default.drill_speed;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "tp_element_off_cmd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox3.Location = new System.Drawing.Point(254, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(242, 26);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = global::DrilltoGcode.Properties.Settings.Default.tp_element_off_cmd;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DrilltoGcode.Properties.Settings.Default, "tp_element_cmd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.Location = new System.Drawing.Point(254, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 26);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = global::DrilltoGcode.Properties.Settings.Default.tp_element_cmd;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Directory:";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 625);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.drillFilePath);
            this.Controls.Add(this.OpenFileBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drill to Gcode";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog DrillFileOpen;
        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.TextBox drillFilePath;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button gcodebutton;
        private System.Windows.Forms.ListView toolListBox;
        private System.Windows.Forms.ColumnHeader ToolHeader;
        private System.Windows.Forms.PropertyGrid toolpg;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button savesettbtn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox incrementsett;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ndigit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox suppressionsett;
        private System.Windows.Forms.Button normalizebtn;
        private System.Windows.Forms.FolderBrowserDialog folderdialog;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox xoffsetbox;
        private System.Windows.Forms.TextBox yoffsetbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

