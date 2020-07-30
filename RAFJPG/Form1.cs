using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DSI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Scan.MouseEnter += OnMouseEnterButton1;
            Scan.MouseLeave += OnMouseLeaveButton1;
            Delete.MouseEnter += OnMouseEnterButton1;
            Delete.MouseLeave += OnMouseLeaveButton1;
            CheckUncheck.MouseEnter += OnMouseEnterButton1;
            CheckUncheck.MouseLeave += OnMouseLeaveButton1;
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
            CurrentDirectory.Text = Directory.GetCurrentDirectory();
            for (int i = 0; i < LaunchScan.extension().Length; i++)
            {
                fileFormatDropBox.Items.Add(LaunchScan.extension()[i]);
                subfileFormatDropBox.Items.Add(LaunchScan.extension()[i]);
            }
        }
        //
        // Scan, Delete, CheckUncheck
        //
        private void Reset_Click(object sender, EventArgs e)
        {
            fileListCheckBox.Items.Clear();
            fileFormatDropBox.Items.Clear();
            subfileFormatDropBox.Items.Clear();
            for (int i = 0; i < LaunchScan.extension().Length; i++)
            {
                fileFormatDropBox.Items.Add(LaunchScan.extension()[i]);
                subfileFormatDropBox.Items.Add(LaunchScan.extension()[i]);
            }
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            fileListCheckBox.Items.Clear();
            for (int i = 0; i < Sort.byName(fileFormatDropBox.GetItemText(fileFormatDropBox.SelectedItem), subfileFormatDropBox.GetItemText(subfileFormatDropBox.SelectedItem)).Length; i++)
            {
                fileListCheckBox.Items.Add(
                    Sort.byName(fileFormatDropBox.GetItemText(fileFormatDropBox.SelectedItem), 
                    subfileFormatDropBox.GetItemText(subfileFormatDropBox.SelectedItem))[i]);
            }
            for (int i = 0; i < fileListCheckBox.Items.Count; i++)
            {
                fileListCheckBox.SetItemChecked(i, true);
            }
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            string[] files = new string[fileListCheckBox.Items.Count + 1];
            fileListCheckBox.CheckedItems.CopyTo(files, 0);
            Sort.deleteFile(files, subfileFormatDropBox.GetItemText(subfileFormatDropBox.SelectedItem));
            fileListCheckBox.Items.Clear();
                fileFormatDropBox.Items.Clear();
                subfileFormatDropBox.Items.Clear();
            Reset.PerformClick();
        }

        private void CheckUncheck_Click(object sender, EventArgs e)
        {
            bool[] check = new bool[fileListCheckBox.Items.Count];

            for (int i = 0; i < fileListCheckBox.Items.Count; i++)
            {
                if (fileListCheckBox.GetItemCheckState(i) == CheckState.Checked)
                {
                    check[i] = true;
                }
                else
                {
                    check[i] = false;
                }
            }
            int trueArray = check.Where(c => c).Count();
            int falseArray = check.Where(c => !c).Count();
            if (trueArray > falseArray)
            {
                for (int i = 0; i < fileListCheckBox.Items.Count; i++)
                {
                    fileListCheckBox.SetItemChecked(i, false);
                }
            }
            else
            {
                for (int i = 0; i < fileListCheckBox.Items.Count; i++)
                {
                    fileListCheckBox.SetItemChecked(i, true);
                }
            }
        }
        //
        //
        //
        private void fileListCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //
        // Drop box list
        //
        private void fileFormatDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void subfileFormatDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //
        // Panel mouse dragging
        //
        int mov;
        int movX;
        int movY;

        private void upperBorder_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void upperBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }    
        }

        private void upperBorder_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        //
        // Close, minimize icons
        //
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //
        // Labels
        //
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //
        // Button color
        //
        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
            Scan.BackColor = Color.FromArgb(238, 238, 238);
            Delete.BackColor = Color.FromArgb(238, 238, 238);
            CheckUncheck.BackColor = Color.FromArgb(238, 238, 238);
        }
        private void OnMouseLeaveButton1(object sender, EventArgs e)
        {
            Scan.BackColor = SystemColors.ButtonFace;
            Delete.BackColor = SystemColors.ButtonFace;
            CheckUncheck.BackColor = SystemColors.ButtonFace;
        }
        //
        //
        //
    }
}
