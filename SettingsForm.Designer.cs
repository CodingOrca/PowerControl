namespace PowerControl
{
    partial class mySettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mySettingsForm));
            this.myNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.myContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.preventSleepMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myPreventCheckBox = new System.Windows.Forms.CheckBox();
            this.myComboBox = new System.Windows.Forms.ComboBox();
            this.myRemainingTime = new System.Windows.Forms.Label();
            this.myStartAtLoginCheckBox = new System.Windows.Forms.CheckBox();
            this.myStartMinimizedCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.myContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // myNotifyIcon
            // 
            this.myNotifyIcon.BalloonTipText = "Power Control still running";
            this.myNotifyIcon.ContextMenuStrip = this.myContextMenu;
            this.myNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("myNotifyIcon.Icon")));
            this.myNotifyIcon.Text = "Do not prevent System to sleep";
            this.myNotifyIcon.Visible = true;
            this.myNotifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // myContextMenu
            // 
            this.myContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preventSleepMenuItem,
            this.toolStripSeparator2,
            this.settingsItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
            this.myContextMenu.Name = "contextMenuStrip1";
            this.myContextMenu.ShowCheckMargin = true;
            this.myContextMenu.ShowImageMargin = false;
            this.myContextMenu.Size = new System.Drawing.Size(185, 82);
            // 
            // preventSleepMenuItem
            // 
            this.preventSleepMenuItem.Name = "preventSleepMenuItem";
            this.preventSleepMenuItem.Size = new System.Drawing.Size(184, 22);
            this.preventSleepMenuItem.Text = "Prevent Sleep for ...";
            this.preventSleepMenuItem.CheckedChanged += new System.EventHandler(this.preventSleepMenuItem_CheckedChanged);
            this.preventSleepMenuItem.Click += new System.EventHandler(this.preventSleepMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // settingsItem
            // 
            this.settingsItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.settingsItem.Name = "settingsItem";
            this.settingsItem.Size = new System.Drawing.Size(184, 22);
            this.settingsItem.Text = "Settings";
            this.settingsItem.Click += new System.EventHandler(this.settingsMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // myPreventCheckBox
            // 
            this.myPreventCheckBox.AutoSize = true;
            this.myPreventCheckBox.Location = new System.Drawing.Point(12, 12);
            this.myPreventCheckBox.Name = "myPreventCheckBox";
            this.myPreventCheckBox.Size = new System.Drawing.Size(158, 17);
            this.myPreventCheckBox.TabIndex = 0;
            this.myPreventCheckBox.Text = "Prevent System to sleep for:";
            this.myPreventCheckBox.UseVisualStyleBackColor = true;
            this.myPreventCheckBox.CheckedChanged += new System.EventHandler(this.myPreventCheckBox_CheckedChanged);
            // 
            // myComboBox
            // 
            this.myComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.myComboBox.FormattingEnabled = true;
            this.myComboBox.Items.AddRange(new object[] {
            "1 minute",
            "1 hour",
            "2 hours",
            "3 hours",
            "5 hours",
            "8 hours",
            "12 hours",
            "1 day",
            "2 days",
            "3 days",
            "5 days"});
            this.myComboBox.Location = new System.Drawing.Point(171, 10);
            this.myComboBox.Name = "myComboBox";
            this.myComboBox.Size = new System.Drawing.Size(93, 21);
            this.myComboBox.TabIndex = 1;
            this.myComboBox.SelectedIndexChanged += new System.EventHandler(this.myComboBox_SelectedIndexChanged);
            // 
            // myRemainingTime
            // 
            this.myRemainingTime.Location = new System.Drawing.Point(168, 13);
            this.myRemainingTime.Name = "myRemainingTime";
            this.myRemainingTime.Size = new System.Drawing.Size(112, 23);
            this.myRemainingTime.TabIndex = 2;
            this.myRemainingTime.Text = "label1";
            // 
            // myStartAtLoginCheckBox
            // 
            this.myStartAtLoginCheckBox.AutoSize = true;
            this.myStartAtLoginCheckBox.Location = new System.Drawing.Point(12, 139);
            this.myStartAtLoginCheckBox.Name = "myStartAtLoginCheckBox";
            this.myStartAtLoginCheckBox.Size = new System.Drawing.Size(135, 17);
            this.myStartAtLoginCheckBox.TabIndex = 3;
            this.myStartAtLoginCheckBox.Text = "Run when user Logs in";
            this.myStartAtLoginCheckBox.UseVisualStyleBackColor = true;
            this.myStartAtLoginCheckBox.CheckedChanged += new System.EventHandler(this.startAtLogin_CheckedChanged);
            // 
            // myStartMinimizedCheckBox
            // 
            this.myStartMinimizedCheckBox.AutoSize = true;
            this.myStartMinimizedCheckBox.Location = new System.Drawing.Point(12, 116);
            this.myStartMinimizedCheckBox.Name = "myStartMinimizedCheckBox";
            this.myStartMinimizedCheckBox.Size = new System.Drawing.Size(157, 17);
            this.myStartMinimizedCheckBox.TabIndex = 4;
            this.myStartMinimizedCheckBox.Text = "Start minimized to system try";
            this.myStartMinimizedCheckBox.UseVisualStyleBackColor = true;
            this.myStartMinimizedCheckBox.CheckedChanged += new System.EventHandler(this.startMinimized_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(173, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "if CPU average usage exceeds";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(185, 18);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "%";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 71);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "%";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(184, 41);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(172, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "if Disk average usage exceeds";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // myTimer
            // 
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(0, 0);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(166, 17);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "Enable Application Monitoring";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // mySettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(292, 161);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.myComboBox);
            this.Controls.Add(this.myStartMinimizedCheckBox);
            this.Controls.Add(this.myStartAtLoginCheckBox);
            this.Controls.Add(this.myPreventCheckBox);
            this.Controls.Add(this.myRemainingTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mySettingsForm";
            this.Text = "Power Control";
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.Move += new System.EventHandler(this.SettingsForm_Move);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.myContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon myNotifyIcon;
        private System.Windows.Forms.CheckBox myPreventCheckBox;
        private System.Windows.Forms.ComboBox myComboBox;
        private System.Windows.Forms.Label myRemainingTime;
        private System.Windows.Forms.ContextMenuStrip myContextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem preventSleepMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.CheckBox myStartAtLoginCheckBox;
        private System.Windows.Forms.CheckBox myStartMinimizedCheckBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

