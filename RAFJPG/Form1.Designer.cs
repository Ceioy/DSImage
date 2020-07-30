namespace DSI
{
    partial class Form1
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
            this.Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentDirectory = new System.Windows.Forms.Label();
            this.fileListCheckBox = new System.Windows.Forms.CheckedListBox();
            this.CheckUncheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fileFormatDropBox = new System.Windows.Forms.ComboBox();
            this.Scan = new System.Windows.Forms.Button();
            this.upperBorder = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.subfileFormatDropBox = new System.Windows.Forms.ComboBox();
            this.Reset = new System.Windows.Forms.Button();
            this.upperBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Delete.Location = new System.Drawing.Point(496, 295);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(149, 32);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Location";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CurrentDirectory
            // 
            this.CurrentDirectory.AutoSize = true;
            this.CurrentDirectory.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CurrentDirectory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CurrentDirectory.Location = new System.Drawing.Point(17, 65);
            this.CurrentDirectory.Name = "CurrentDirectory";
            this.CurrentDirectory.Size = new System.Drawing.Size(46, 17);
            this.CurrentDirectory.TabIndex = 3;
            this.CurrentDirectory.Text = "label2";
            this.CurrentDirectory.Click += new System.EventHandler(this.label2_Click);
            // 
            // fileListCheckBox
            // 
            this.fileListCheckBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fileListCheckBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fileListCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.fileListCheckBox.FormattingEnabled = true;
            this.fileListCheckBox.HorizontalScrollbar = true;
            this.fileListCheckBox.Location = new System.Drawing.Point(20, 85);
            this.fileListCheckBox.Name = "fileListCheckBox";
            this.fileListCheckBox.Size = new System.Drawing.Size(470, 242);
            this.fileListCheckBox.TabIndex = 4;
            this.fileListCheckBox.SelectedIndexChanged += new System.EventHandler(this.fileListCheckBox_SelectedIndexChanged);
            // 
            // CheckUncheck
            // 
            this.CheckUncheck.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CheckUncheck.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CheckUncheck.Location = new System.Drawing.Point(496, 122);
            this.CheckUncheck.Name = "CheckUncheck";
            this.CheckUncheck.Size = new System.Drawing.Size(149, 32);
            this.CheckUncheck.TabIndex = 5;
            this.CheckUncheck.Text = "Check/Uncheck";
            this.CheckUncheck.UseVisualStyleBackColor = true;
            this.CheckUncheck.Click += new System.EventHandler(this.CheckUncheck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(513, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choice file format";
            // 
            // fileFormatDropBox
            // 
            this.fileFormatDropBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fileFormatDropBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fileFormatDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fileFormatDropBox.FormattingEnabled = true;
            this.fileFormatDropBox.Location = new System.Drawing.Point(496, 177);
            this.fileFormatDropBox.Name = "fileFormatDropBox";
            this.fileFormatDropBox.Size = new System.Drawing.Size(149, 24);
            this.fileFormatDropBox.TabIndex = 7;
            this.fileFormatDropBox.SelectedIndexChanged += new System.EventHandler(this.fileFormatDropBox_SelectedIndexChanged);
            // 
            // Scan
            // 
            this.Scan.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Scan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Scan.Location = new System.Drawing.Point(496, 257);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(149, 32);
            this.Scan.TabIndex = 11;
            this.Scan.Text = "Scan Files";
            this.Scan.UseVisualStyleBackColor = true;
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // upperBorder
            // 
            this.upperBorder.BackColor = System.Drawing.Color.LightGray;
            this.upperBorder.Controls.Add(this.label4);
            this.upperBorder.Controls.Add(this.Minimize);
            this.upperBorder.Controls.Add(this.Close);
            this.upperBorder.Location = new System.Drawing.Point(1, 1);
            this.upperBorder.Name = "upperBorder";
            this.upperBorder.Size = new System.Drawing.Size(656, 35);
            this.upperBorder.TabIndex = 12;
            this.upperBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.upperBorder_MouseDown);
            this.upperBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.upperBorder_MouseMove);
            this.upperBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.upperBorder_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "DSImage";
            // 
            // Minimize
            // 
            this.Minimize.Image = global::DSI.Properties.Resources.icons8_minimize_window_96__2_;
            this.Minimize.Location = new System.Drawing.Point(580, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(39, 36);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize.TabIndex = 14;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Close
            // 
            this.Close.Image = global::DSI.Properties.Resources.icons8_close_window_96__2_;
            this.Close.Location = new System.Drawing.Point(616, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(39, 36);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 13;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(493, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Choice delete file format";
            // 
            // subfileFormatDropBox
            // 
            this.subfileFormatDropBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subfileFormatDropBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.subfileFormatDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subfileFormatDropBox.FormattingEnabled = true;
            this.subfileFormatDropBox.Location = new System.Drawing.Point(496, 224);
            this.subfileFormatDropBox.Name = "subfileFormatDropBox";
            this.subfileFormatDropBox.Size = new System.Drawing.Size(149, 24);
            this.subfileFormatDropBox.TabIndex = 14;
            this.subfileFormatDropBox.SelectedIndexChanged += new System.EventHandler(this.subfileFormatDropBox_SelectedIndexChanged);
            // 
            // Reset
            // 
            this.Reset.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Reset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Reset.Location = new System.Drawing.Point(496, 85);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(149, 32);
            this.Reset.TabIndex = 15;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(658, 342);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.subfileFormatDropBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.upperBorder);
            this.Controls.Add(this.Scan);
            this.Controls.Add(this.fileFormatDropBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckUncheck);
            this.Controls.Add(this.fileListCheckBox);
            this.Controls.Add(this.CurrentDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.upperBorder.ResumeLayout(false);
            this.upperBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurrentDirectory;
        private System.Windows.Forms.CheckedListBox fileListCheckBox;
        private System.Windows.Forms.Button CheckUncheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fileFormatDropBox;
        private System.Windows.Forms.Button Scan;
        private System.Windows.Forms.Panel upperBorder;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox subfileFormatDropBox;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Reset;
    }
}

