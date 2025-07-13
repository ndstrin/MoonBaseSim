namespace MoonBaseSim
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.btn_Mine = new System.Windows.Forms.Button();
            this.grbox_Resources = new System.Windows.Forms.GroupBox();
            this.LB_Resource_Ore_Value = new System.Windows.Forms.Label();
            this.LB_Resouce_Water_Value = new System.Windows.Forms.Label();
            this.LB_Resource_Food_Value = new System.Windows.Forms.Label();
            this.LB_Resource_Oxygen_Value = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_ProcessOre = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LB_Base_ActiveWorkers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_Base_Workers_Value = new System.Windows.Forms.Label();
            this.LB_Base_Level_Value = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker_MineOre = new System.ComponentModel.BackgroundWorker();
            this.timer_GamePlay = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker_ProcessOre = new System.ComponentModel.BackgroundWorker();
            this.ActiveMiners = new System.Windows.Forms.NumericUpDown();
            this.ProcessingWorkers = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.LB_EXP_Value = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar_EXP = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grbox_Resources.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveMiners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessingWorkers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Mine
            // 
            this.btn_Mine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Mine.Enabled = false;
            this.btn_Mine.Location = new System.Drawing.Point(7, 288);
            this.btn_Mine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Mine.Name = "btn_Mine";
            this.btn_Mine.Size = new System.Drawing.Size(168, 35);
            this.btn_Mine.TabIndex = 0;
            this.btn_Mine.Text = "Mine Ore";
            this.btn_Mine.UseVisualStyleBackColor = false;
            this.btn_Mine.Click += new System.EventHandler(this.btn_Mine_Click);
            // 
            // grbox_Resources
            // 
            this.grbox_Resources.BackColor = System.Drawing.Color.Transparent;
            this.grbox_Resources.Controls.Add(this.LB_Resource_Ore_Value);
            this.grbox_Resources.Controls.Add(this.LB_Resouce_Water_Value);
            this.grbox_Resources.Controls.Add(this.LB_Resource_Food_Value);
            this.grbox_Resources.Controls.Add(this.LB_Resource_Oxygen_Value);
            this.grbox_Resources.Controls.Add(this.label4);
            this.grbox_Resources.Controls.Add(this.label3);
            this.grbox_Resources.Controls.Add(this.label2);
            this.grbox_Resources.Controls.Add(this.label1);
            this.grbox_Resources.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbox_Resources.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbox_Resources.Location = new System.Drawing.Point(4, 35);
            this.grbox_Resources.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbox_Resources.Name = "grbox_Resources";
            this.grbox_Resources.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbox_Resources.Size = new System.Drawing.Size(168, 194);
            this.grbox_Resources.TabIndex = 1;
            this.grbox_Resources.TabStop = false;
            this.grbox_Resources.Text = "Resources";
            // 
            // LB_Resource_Ore_Value
            // 
            this.LB_Resource_Ore_Value.AutoSize = true;
            this.LB_Resource_Ore_Value.Location = new System.Drawing.Point(114, 151);
            this.LB_Resource_Ore_Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Resource_Ore_Value.Name = "LB_Resource_Ore_Value";
            this.LB_Resource_Ore_Value.Size = new System.Drawing.Size(18, 20);
            this.LB_Resource_Ore_Value.TabIndex = 7;
            this.LB_Resource_Ore_Value.Text = "0";
            // 
            // LB_Resouce_Water_Value
            // 
            this.LB_Resouce_Water_Value.AutoSize = true;
            this.LB_Resouce_Water_Value.Location = new System.Drawing.Point(114, 112);
            this.LB_Resouce_Water_Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Resouce_Water_Value.Name = "LB_Resouce_Water_Value";
            this.LB_Resouce_Water_Value.Size = new System.Drawing.Size(18, 20);
            this.LB_Resouce_Water_Value.TabIndex = 6;
            this.LB_Resouce_Water_Value.Text = "0";
            // 
            // LB_Resource_Food_Value
            // 
            this.LB_Resource_Food_Value.AutoSize = true;
            this.LB_Resource_Food_Value.Location = new System.Drawing.Point(114, 77);
            this.LB_Resource_Food_Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Resource_Food_Value.Name = "LB_Resource_Food_Value";
            this.LB_Resource_Food_Value.Size = new System.Drawing.Size(18, 20);
            this.LB_Resource_Food_Value.TabIndex = 5;
            this.LB_Resource_Food_Value.Text = "0";
            // 
            // LB_Resource_Oxygen_Value
            // 
            this.LB_Resource_Oxygen_Value.AutoSize = true;
            this.LB_Resource_Oxygen_Value.Location = new System.Drawing.Point(114, 43);
            this.LB_Resource_Oxygen_Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Resource_Oxygen_Value.Name = "LB_Resource_Oxygen_Value";
            this.LB_Resource_Oxygen_Value.Size = new System.Drawing.Size(18, 20);
            this.LB_Resource_Oxygen_Value.TabIndex = 4;
            this.LB_Resource_Oxygen_Value.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(22, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ore:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(22, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Water: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Food: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oxygen: ";
            // 
            // BTN_ProcessOre
            // 
            this.BTN_ProcessOre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_ProcessOre.Enabled = false;
            this.BTN_ProcessOre.Location = new System.Drawing.Point(7, 348);
            this.BTN_ProcessOre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_ProcessOre.Name = "BTN_ProcessOre";
            this.BTN_ProcessOre.Size = new System.Drawing.Size(168, 35);
            this.BTN_ProcessOre.TabIndex = 2;
            this.BTN_ProcessOre.Text = "Process Ore";
            this.BTN_ProcessOre.UseVisualStyleBackColor = false;
            this.BTN_ProcessOre.Click += new System.EventHandler(this.BTN_ProcessOre_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.LB_Base_ActiveWorkers);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LB_Base_Workers_Value);
            this.groupBox1.Controls.Add(this.LB_Base_Level_Value);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(630, 305);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(186, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base";
            // 
            // LB_Base_ActiveWorkers
            // 
            this.LB_Base_ActiveWorkers.AutoSize = true;
            this.LB_Base_ActiveWorkers.Location = new System.Drawing.Point(148, 112);
            this.LB_Base_ActiveWorkers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Base_ActiveWorkers.Name = "LB_Base_ActiveWorkers";
            this.LB_Base_ActiveWorkers.Size = new System.Drawing.Size(18, 20);
            this.LB_Base_ActiveWorkers.TabIndex = 5;
            this.LB_Base_ActiveWorkers.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(22, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Active Workers: ";
            // 
            // LB_Base_Workers_Value
            // 
            this.LB_Base_Workers_Value.AutoSize = true;
            this.LB_Base_Workers_Value.Location = new System.Drawing.Point(148, 77);
            this.LB_Base_Workers_Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Base_Workers_Value.Name = "LB_Base_Workers_Value";
            this.LB_Base_Workers_Value.Size = new System.Drawing.Size(18, 20);
            this.LB_Base_Workers_Value.TabIndex = 3;
            this.LB_Base_Workers_Value.Text = "0";
            // 
            // LB_Base_Level_Value
            // 
            this.LB_Base_Level_Value.AutoSize = true;
            this.LB_Base_Level_Value.Location = new System.Drawing.Point(148, 43);
            this.LB_Base_Level_Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Base_Level_Value.Name = "LB_Base_Level_Value";
            this.LB_Base_Level_Value.Size = new System.Drawing.Size(18, 20);
            this.LB_Base_Level_Value.TabIndex = 2;
            this.LB_Base_Level_Value.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(22, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total Workers: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(22, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Level: ";
            // 
            // backgroundWorker_MineOre
            // 
            this.backgroundWorker_MineOre.WorkerReportsProgress = true;
            this.backgroundWorker_MineOre.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_MineOre_DoWork);
            this.backgroundWorker_MineOre.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_MineOre_ProgressChanged);
            this.backgroundWorker_MineOre.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_MineOre_RunWorkerCompleted);
            // 
            // timer_GamePlay
            // 
            this.timer_GamePlay.Enabled = true;
            this.timer_GamePlay.Interval = 30000;
            this.timer_GamePlay.Tick += new System.EventHandler(this.timer_GamePlay_Tick);
            // 
            // backgroundWorker_ProcessOre
            // 
            this.backgroundWorker_ProcessOre.WorkerReportsProgress = true;
            this.backgroundWorker_ProcessOre.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_ProcessOre_DoWork);
            this.backgroundWorker_ProcessOre.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProcessOre_ProgressChanged);
            // 
            // ActiveMiners
            // 
            this.ActiveMiners.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ActiveMiners.Location = new System.Drawing.Point(8, 29);
            this.ActiveMiners.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ActiveMiners.Name = "ActiveMiners";
            this.ActiveMiners.ReadOnly = true;
            this.ActiveMiners.Size = new System.Drawing.Size(78, 26);
            this.ActiveMiners.TabIndex = 5;
            this.ActiveMiners.ValueChanged += new System.EventHandler(this.ActiveMiners_ValueChanged);
            this.ActiveMiners.Validating += new System.ComponentModel.CancelEventHandler(this.ActiveMiners_Validating);
            // 
            // ProcessingWorkers
            // 
            this.ProcessingWorkers.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ProcessingWorkers.Location = new System.Drawing.Point(8, 93);
            this.ProcessingWorkers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProcessingWorkers.Name = "ProcessingWorkers";
            this.ProcessingWorkers.ReadOnly = true;
            this.ProcessingWorkers.Size = new System.Drawing.Size(78, 26);
            this.ProcessingWorkers.TabIndex = 6;
            this.ProcessingWorkers.ValueChanged += new System.EventHandler(this.ProcessingWorkers_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GrayText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(442, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "EXP: ";
            // 
            // LB_EXP_Value
            // 
            this.LB_EXP_Value.AutoSize = true;
            this.LB_EXP_Value.BackColor = System.Drawing.SystemColors.GrayText;
            this.LB_EXP_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EXP_Value.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LB_EXP_Value.Location = new System.Drawing.Point(535, 2);
            this.LB_EXP_Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_EXP_Value.Name = "LB_EXP_Value";
            this.LB_EXP_Value.Size = new System.Drawing.Size(26, 29);
            this.LB_EXP_Value.TabIndex = 9;
            this.LB_EXP_Value.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GrayText;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 33);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_File
            // 
            this.Menu_File.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadGameToolStripMenuItem});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(54, 29);
            this.Menu_File.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            // 
            // progressBar_EXP
            // 
            this.progressBar_EXP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar_EXP.Location = new System.Drawing.Point(604, 4);
            this.progressBar_EXP.Name = "progressBar_EXP";
            this.progressBar_EXP.Size = new System.Drawing.Size(199, 23);
            this.progressBar_EXP.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.ActiveMiners);
            this.groupBox2.Controls.Add(this.ProcessingWorkers);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(202, 261);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(103, 142);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Workers";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 457);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar_EXP);
            this.Controls.Add(this.LB_EXP_Value);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTN_ProcessOre);
            this.Controls.Add(this.grbox_Resources);
            this.Controls.Add(this.btn_Mine);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Main";
            this.Text = "Moon Base SIM";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.grbox_Resources.ResumeLayout(false);
            this.grbox_Resources.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveMiners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessingWorkers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Mine;
        private System.Windows.Forms.GroupBox grbox_Resources;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_ProcessOre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LB_Base_Workers_Value;
        private System.Windows.Forms.Label LB_Base_Level_Value;
        private System.ComponentModel.BackgroundWorker backgroundWorker_MineOre;
        private System.Windows.Forms.Label LB_Resource_Ore_Value;
        private System.Windows.Forms.Label LB_Resouce_Water_Value;
        private System.Windows.Forms.Label LB_Resource_Food_Value;
        private System.Windows.Forms.Label LB_Resource_Oxygen_Value;
        private System.Windows.Forms.Timer timer_GamePlay;
        private System.ComponentModel.BackgroundWorker backgroundWorker_ProcessOre;
        private System.Windows.Forms.NumericUpDown ActiveMiners;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_Base_ActiveWorkers;
        private System.Windows.Forms.NumericUpDown ProcessingWorkers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LB_EXP_Value;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_File;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar_EXP;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

