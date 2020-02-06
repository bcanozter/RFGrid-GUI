namespace Tag_Scanner
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tagLabel = new System.Windows.Forms.Label();
            this.imageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tagBox = new System.Windows.Forms.TextBox();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.imageButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.soundTextBox = new System.Windows.Forms.TextBox();
            this.soundButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseCOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tagGetIdButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dispCalibrateButton = new System.Windows.Forms.Button();
            this.displayInfoButton = new System.Windows.Forms.Button();
            this.dispCalibXBox = new System.Windows.Forms.TextBox();
            this.gridSizeLabel = new System.Windows.Forms.Label();
            this.connectedPortLabel = new System.Windows.Forms.Label();
            this.portTextLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundCalibButton = new System.Windows.Forms.Button();
            this.backgroundImgButton = new System.Windows.Forms.Button();
            this.backgroundImgTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.debugTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dispCalibYBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tagLabel
            // 
            this.tagLabel.AutoSize = true;
            this.tagLabel.BackColor = System.Drawing.Color.Transparent;
            this.tagLabel.Font = new System.Drawing.Font("Verdana", 11F);
            this.tagLabel.ForeColor = System.Drawing.Color.Black;
            this.tagLabel.Location = new System.Drawing.Point(6, 37);
            this.tagLabel.Name = "tagLabel";
            this.tagLabel.Size = new System.Drawing.Size(66, 18);
            this.tagLabel.TabIndex = 0;
            this.tagLabel.Text = "Tag ID :";
            // 
            // imageLabel
            // 
            this.imageLabel.BackColor = System.Drawing.Color.Transparent;
            this.imageLabel.Font = new System.Drawing.Font("Verdana", 11F);
            this.imageLabel.ForeColor = System.Drawing.Color.Black;
            this.imageLabel.Location = new System.Drawing.Point(6, 76);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(79, 18);
            this.imageLabel.TabIndex = 1;
            this.imageLabel.Text = "Image :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sound :";
            // 
            // tagBox
            // 
            this.tagBox.BackColor = System.Drawing.Color.White;
            this.tagBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagBox.ForeColor = System.Drawing.Color.Black;
            this.tagBox.Location = new System.Drawing.Point(90, 36);
            this.tagBox.Name = "tagBox";
            this.tagBox.Size = new System.Drawing.Size(167, 22);
            this.tagBox.TabIndex = 3;
            // 
            // imageTextBox
            // 
            this.imageTextBox.BackColor = System.Drawing.Color.White;
            this.imageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageTextBox.ForeColor = System.Drawing.Color.Black;
            this.imageTextBox.Location = new System.Drawing.Point(90, 75);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(167, 22);
            this.imageTextBox.TabIndex = 4;
            // 
            // imageButton
            // 
            this.imageButton.Location = new System.Drawing.Point(273, 71);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(75, 23);
            this.imageButton.TabIndex = 5;
            this.imageButton.Text = "Browse";
            this.imageButton.UseVisualStyleBackColor = true;
            this.imageButton.Click += new System.EventHandler(this.ImageButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(48, 151);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(273, 35);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // soundTextBox
            // 
            this.soundTextBox.BackColor = System.Drawing.Color.White;
            this.soundTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundTextBox.ForeColor = System.Drawing.Color.Black;
            this.soundTextBox.Location = new System.Drawing.Point(90, 111);
            this.soundTextBox.Name = "soundTextBox";
            this.soundTextBox.Size = new System.Drawing.Size(167, 22);
            this.soundTextBox.TabIndex = 8;
            // 
            // soundButton
            // 
            this.soundButton.Location = new System.Drawing.Point(273, 109);
            this.soundButton.Name = "soundButton";
            this.soundButton.Size = new System.Drawing.Size(75, 23);
            this.soundButton.TabIndex = 9;
            this.soundButton.Text = "Browse";
            this.soundButton.UseVisualStyleBackColor = true;
            this.soundButton.Click += new System.EventHandler(this.SoundButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseCOMToolStripMenuItem,
            this.installModulesToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // chooseCOMToolStripMenuItem
            // 
            this.chooseCOMToolStripMenuItem.Name = "chooseCOMToolStripMenuItem";
            this.chooseCOMToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.chooseCOMToolStripMenuItem.Text = "Select Connection Port";
            this.chooseCOMToolStripMenuItem.Click += new System.EventHandler(this.ChooseCOMToolStripMenuItem_Click);
            // 
            // installModulesToolStripMenuItem
            // 
            this.installModulesToolStripMenuItem.Name = "installModulesToolStripMenuItem";
            this.installModulesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.installModulesToolStripMenuItem.Text = "Install Modules";
            this.installModulesToolStripMenuItem.Click += new System.EventHandler(this.InstallModulesToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tagGetIdButton);
            this.groupBox1.Controls.Add(this.tagBox);
            this.groupBox1.Controls.Add(this.soundButton);
            this.groupBox1.Controls.Add(this.tagLabel);
            this.groupBox1.Controls.Add(this.soundTextBox);
            this.groupBox1.Controls.Add(this.imageLabel);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.imageTextBox);
            this.groupBox1.Controls.Add(this.imageButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 193);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tag Creator";
            // 
            // tagGetIdButton
            // 
            this.tagGetIdButton.Location = new System.Drawing.Point(193, 151);
            this.tagGetIdButton.Name = "tagGetIdButton";
            this.tagGetIdButton.Size = new System.Drawing.Size(100, 23);
            this.tagGetIdButton.TabIndex = 10;
            this.tagGetIdButton.Text = "Scan Tag";
            this.tagGetIdButton.UseVisualStyleBackColor = true;
            this.tagGetIdButton.Click += new System.EventHandler(this.TagGetIdButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dispCalibYBox);
            this.groupBox2.Controls.Add(this.dispCalibrateButton);
            this.groupBox2.Controls.Add(this.displayInfoButton);
            this.groupBox2.Controls.Add(this.dispCalibXBox);
            this.groupBox2.Controls.Add(this.gridSizeLabel);
            this.groupBox2.Location = new System.Drawing.Point(390, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 193);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Calibration";
            // 
            // dispCalibrateButton
            // 
            this.dispCalibrateButton.Location = new System.Drawing.Point(108, 151);
            this.dispCalibrateButton.Name = "dispCalibrateButton";
            this.dispCalibrateButton.Size = new System.Drawing.Size(75, 23);
            this.dispCalibrateButton.TabIndex = 3;
            this.dispCalibrateButton.Text = "Calibrate";
            this.dispCalibrateButton.UseVisualStyleBackColor = true;
            this.dispCalibrateButton.Click += new System.EventHandler(this.DispCalibrateButton_Click);
            // 
            // displayInfoButton
            // 
            this.displayInfoButton.Location = new System.Drawing.Point(185, 37);
            this.displayInfoButton.Name = "displayInfoButton";
            this.displayInfoButton.Size = new System.Drawing.Size(22, 23);
            this.displayInfoButton.TabIndex = 2;
            this.displayInfoButton.Text = "?";
            this.displayInfoButton.UseVisualStyleBackColor = true;
            this.displayInfoButton.Click += new System.EventHandler(this.DisplayInfoButton_Click);
            // 
            // dispCalibXBox
            // 
            this.dispCalibXBox.Location = new System.Drawing.Point(98, 40);
            this.dispCalibXBox.MaxLength = 2;
            this.dispCalibXBox.Name = "dispCalibXBox";
            this.dispCalibXBox.Size = new System.Drawing.Size(21, 20);
            this.dispCalibXBox.TabIndex = 1;
            // 
            // gridSizeLabel
            // 
            this.gridSizeLabel.AutoSize = true;
            this.gridSizeLabel.Font = new System.Drawing.Font("Verdana", 11F);
            this.gridSizeLabel.Location = new System.Drawing.Point(6, 40);
            this.gridSizeLabel.Name = "gridSizeLabel";
            this.gridSizeLabel.Size = new System.Drawing.Size(81, 18);
            this.gridSizeLabel.TabIndex = 0;
            this.gridSizeLabel.Text = "Grid Size:";
            // 
            // connectedPortLabel
            // 
            this.connectedPortLabel.AutoSize = true;
            this.connectedPortLabel.Location = new System.Drawing.Point(859, 24);
            this.connectedPortLabel.Name = "connectedPortLabel";
            this.connectedPortLabel.Size = new System.Drawing.Size(84, 13);
            this.connectedPortLabel.TabIndex = 13;
            this.connectedPortLabel.Text = "Connected Port:";
            // 
            // portTextLabel
            // 
            this.portTextLabel.AutoSize = true;
            this.portTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portTextLabel.Location = new System.Drawing.Point(940, 24);
            this.portTextLabel.Name = "portTextLabel";
            this.portTextLabel.Size = new System.Drawing.Size(22, 13);
            this.portTextLabel.TabIndex = 14;
            this.portTextLabel.Text = "NA";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.backgroundCalibButton);
            this.groupBox3.Controls.Add(this.backgroundImgButton);
            this.groupBox3.Controls.Add(this.backgroundImgTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(684, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 193);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Background Calibration";
            // 
            // backgroundCalibButton
            // 
            this.backgroundCalibButton.Location = new System.Drawing.Point(115, 151);
            this.backgroundCalibButton.Name = "backgroundCalibButton";
            this.backgroundCalibButton.Size = new System.Drawing.Size(75, 23);
            this.backgroundCalibButton.TabIndex = 3;
            this.backgroundCalibButton.Text = "Calibrate";
            this.backgroundCalibButton.UseVisualStyleBackColor = true;
            this.backgroundCalibButton.Click += new System.EventHandler(this.BackgroundCalibButton_Click);
            // 
            // backgroundImgButton
            // 
            this.backgroundImgButton.Location = new System.Drawing.Point(205, 69);
            this.backgroundImgButton.Name = "backgroundImgButton";
            this.backgroundImgButton.Size = new System.Drawing.Size(94, 23);
            this.backgroundImgButton.TabIndex = 2;
            this.backgroundImgButton.Text = "Browse";
            this.backgroundImgButton.UseVisualStyleBackColor = true;
            this.backgroundImgButton.Click += new System.EventHandler(this.BackgroundImgButton_Click);
            // 
            // backgroundImgTextBox
            // 
            this.backgroundImgTextBox.Location = new System.Drawing.Point(9, 69);
            this.backgroundImgTextBox.Name = "backgroundImgTextBox";
            this.backgroundImgTextBox.Size = new System.Drawing.Size(181, 20);
            this.backgroundImgTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F);
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Background Image";
            // 
            // debugTextBox
            // 
            this.debugTextBox.BackColor = System.Drawing.Color.White;
            this.debugTextBox.Location = new System.Drawing.Point(12, 439);
            this.debugTextBox.Multiline = true;
            this.debugTextBox.Name = "debugTextBox";
            this.debugTextBox.ReadOnly = true;
            this.debugTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.debugTextBox.Size = new System.Drawing.Size(585, 121);
            this.debugTextBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Output";
            // 
            // dispCalibYBox
            // 
            this.dispCalibYBox.Location = new System.Drawing.Point(143, 40);
            this.dispCalibYBox.MaxLength = 2;
            this.dispCalibYBox.Name = "dispCalibYBox";
            this.dispCalibYBox.Size = new System.Drawing.Size(21, 20);
            this.dispCalibYBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "x";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1019, 632);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.debugTextBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.portTextLabel);
            this.Controls.Add(this.connectedPortLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RFGrid Tools";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tagLabel;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tagBox;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.Button imageButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox soundTextBox;
        private System.Windows.Forms.Button soundButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseCOMToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label connectedPortLabel;
        private System.Windows.Forms.Label portTextLabel;
        private System.Windows.Forms.Button displayInfoButton;
        private System.Windows.Forms.TextBox dispCalibXBox;
        private System.Windows.Forms.Label gridSizeLabel;
        private System.Windows.Forms.Button dispCalibrateButton;
        private System.Windows.Forms.ToolStripMenuItem installModulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button backgroundImgButton;
        private System.Windows.Forms.TextBox backgroundImgTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox debugTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backgroundCalibButton;
        private System.Windows.Forms.Button tagGetIdButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dispCalibYBox;
    }
}

