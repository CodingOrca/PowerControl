using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;

namespace PowerControl
{
    public partial class mySettingsForm : Form
    {
        const string myApplicationKey = "PowerControl";
        uint myPreviousExecutionState = 0;
        bool myExecutionStateChanged = false;
        DateTime myCountDownTarget;
        uint[] myCountDowns = new uint[] { 60, 3600, 7200, 10800, 18000, 28800, 43200, 86400, 172800, 259200, 432000 };
        bool myReallyClose = false;
        Properties.Settings mySettings = new PowerControl.Properties.Settings();

        public mySettingsForm()
        {
            InitializeComponent();
            myRemainingTime.Text = "";
            myComboBox.SelectedIndex = mySettings.LastTimerValueIndex;
            myStartMinimizedCheckBox.Checked = mySettings.StartMinimized;
            if (mySettings.LastX != -1)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(mySettings.LastX, mySettings.LastY);
            }
            myStartAtLoginCheckBox.Checked = (AutostartUility.IsAutoStartEnabled(myApplicationKey) != null);
        }

        void myTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan remaining = TimeSpan.FromSeconds(
                Convert.ToInt32((myCountDownTarget - DateTime.Now).TotalSeconds));
            if (remaining.TotalSeconds <= 0)
            {
                myPreventCheckBox.Checked = false;
            }
            else
            {
                myRemainingTime.Text = remaining.ToString();
                myNotifyIcon.Text = "Prevent System to sleep for " + remaining.ToString();
                preventSleepMenuItem.Text = "Prevent Sleep for " + remaining.ToString(); 
            }

        }

        private void myPreventCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!myPreventCheckBox.Checked)
            {
                myTimer.Stop();
                this.myNotifyIcon.Icon = Properties.Resources.BlueSuspend16;
                myRemainingTime.Text = "";
                NativeMethods.SetThreadExecutionState(myPreviousExecutionState);
                myExecutionStateChanged = false;
                myComboBox.Show();
                myNotifyIcon.Text = "Do not prevent System to sleep";
            }
            else
            {
                myPreviousExecutionState = NativeMethods.SetThreadExecutionState(NativeMethods.ES_CONTINUOUS | NativeMethods.ES_SYSTEM_REQUIRED);
                myExecutionStateChanged = true;
                myCountDownTarget = DateTime.Now + TimeSpan.FromSeconds(myCountDowns[myComboBox.SelectedIndex]);
                myTimer.Start();
                myComboBox.Hide();
                this.myNotifyIcon.Icon = Properties.Resources.OrangeSuspend16;
            }
            preventSleepMenuItem.Checked = myPreventCheckBox.Checked;
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.BringToFront();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            myReallyClose = true;
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (myReallyClose)
            {
                if (myExecutionStateChanged)
                {
                    myTimer.Stop();
                    myTimer.Dispose();
                    NativeMethods.SetThreadExecutionState(myPreviousExecutionState);
                }
                Point p = this.Location;
                mySettings.LastX = p.X;
                mySettings.LastY = p.Y;
                mySettings.Save();
                myNotifyIcon.Dispose();
            }
            else
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void settingsMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.BringToFront();
        }

        private void myComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mySettings.LastTimerValueIndex = myComboBox.SelectedIndex;
            mySettings.Save();
            preventSleepMenuItem.Text = "Prevent Sleep for " + myComboBox.SelectedItem as String;
        }

        private void preventSleepMenuItem_Click(object sender, EventArgs e)
        {
            preventSleepMenuItem.Checked = !preventSleepMenuItem.Checked;
            myPreventCheckBox.Checked = preventSleepMenuItem.Checked;
        }

        private void preventSleepMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (!preventSleepMenuItem.Checked)
            {
                preventSleepMenuItem.Text = "Prevent Sleep for " + myComboBox.SelectedItem as String;
            }
        }

        private void startMinimized_CheckedChanged(object sender, EventArgs e)
        {
            mySettings.StartMinimized = myStartMinimizedCheckBox.Checked;
            mySettings.Save();
        }

        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            if (mySettings.StartMinimized)
            {
                this.Hide();
            }
        }

        private void startAtLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (myStartAtLoginCheckBox.Checked)
            {
                AutostartUility.SetAutoStart(myApplicationKey, Assembly.GetExecutingAssembly().Location);
            }
            else
            {
                AutostartUility.UnSetAutoStart(myApplicationKey);
            }
        }

        private void SettingsForm_Move(object sender, EventArgs e)
        {
        }

    }

    internal static class NativeMethods
    {
        // Import SetThreadExecutionState Win32 API and necessary flags
        [DllImport("kernel32.dll")]
        public static extern uint SetThreadExecutionState(uint esFlags);
        public const uint ES_CONTINUOUS = 0x80000000;
        public const uint ES_SYSTEM_REQUIRED = 0x00000001;
    }
}
