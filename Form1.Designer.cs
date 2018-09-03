namespace EasyBluetoothFileTransfer {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.devicesAvailable_listview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scanForDevices_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.isAuthenticated_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.isConnected_txtbox = new System.Windows.Forms.TextBox();
            this.lastSeen_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastUsed_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.remembered_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label0 = new System.Windows.Forms.Label();
            this.selectedDeviceName_txtbox = new System.Windows.Forms.TextBox();
            this.selectFile_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sendCancelFile_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.selectedFileLength_txtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.selectedFilePath_txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.selectedFileName_txtbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // devicesAvailable_listview
            // 
            this.devicesAvailable_listview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.devicesAvailable_listview.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.devicesAvailable_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.devicesAvailable_listview.FullRowSelect = true;
            this.devicesAvailable_listview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.devicesAvailable_listview.Location = new System.Drawing.Point(2, 2);
            this.devicesAvailable_listview.MultiSelect = false;
            this.devicesAvailable_listview.Name = "devicesAvailable_listview";
            this.devicesAvailable_listview.Size = new System.Drawing.Size(216, 438);
            this.devicesAvailable_listview.TabIndex = 0;
            this.devicesAvailable_listview.UseCompatibleStateImageBehavior = false;
            this.devicesAvailable_listview.View = System.Windows.Forms.View.Details;
            this.devicesAvailable_listview.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.devicesAvailable_listview_ItemSelectionChanged);
            this.devicesAvailable_listview.Leave += new System.EventHandler(this.devicesAvailable_listview_Leave);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Devices Available";
            this.columnHeader1.Width = 210;
            // 
            // scanForDevices_btn
            // 
            this.scanForDevices_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.scanForDevices_btn.Location = new System.Drawing.Point(223, 418);
            this.scanForDevices_btn.Name = "scanForDevices_btn";
            this.scanForDevices_btn.Size = new System.Drawing.Size(209, 22);
            this.scanForDevices_btn.TabIndex = 1;
            this.scanForDevices_btn.Text = "Search for devices";
            this.scanForDevices_btn.UseVisualStyleBackColor = true;
            this.scanForDevices_btn.Click += new System.EventHandler(this.scanForDevices_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Is Authenticated:";
            // 
            // isAuthenticated_txtbox
            // 
            this.isAuthenticated_txtbox.Location = new System.Drawing.Point(99, 63);
            this.isAuthenticated_txtbox.Name = "isAuthenticated_txtbox";
            this.isAuthenticated_txtbox.ReadOnly = true;
            this.isAuthenticated_txtbox.Size = new System.Drawing.Size(104, 20);
            this.isAuthenticated_txtbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Is Connected:";
            // 
            // isConnected_txtbox
            // 
            this.isConnected_txtbox.Location = new System.Drawing.Point(99, 89);
            this.isConnected_txtbox.Name = "isConnected_txtbox";
            this.isConnected_txtbox.ReadOnly = true;
            this.isConnected_txtbox.Size = new System.Drawing.Size(104, 20);
            this.isConnected_txtbox.TabIndex = 5;
            // 
            // lastSeen_txtbox
            // 
            this.lastSeen_txtbox.Location = new System.Drawing.Point(99, 141);
            this.lastSeen_txtbox.Name = "lastSeen_txtbox";
            this.lastSeen_txtbox.ReadOnly = true;
            this.lastSeen_txtbox.Size = new System.Drawing.Size(104, 20);
            this.lastSeen_txtbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Seen:";
            // 
            // lastUsed_txtbox
            // 
            this.lastUsed_txtbox.Location = new System.Drawing.Point(99, 167);
            this.lastUsed_txtbox.Name = "lastUsed_txtbox";
            this.lastUsed_txtbox.ReadOnly = true;
            this.lastUsed_txtbox.Size = new System.Drawing.Size(104, 20);
            this.lastUsed_txtbox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Last Used:";
            // 
            // remembered_txtbox
            // 
            this.remembered_txtbox.Location = new System.Drawing.Point(99, 115);
            this.remembered_txtbox.Name = "remembered_txtbox";
            this.remembered_txtbox.ReadOnly = true;
            this.remembered_txtbox.Size = new System.Drawing.Size(104, 20);
            this.remembered_txtbox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Remembered:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label0);
            this.groupBox1.Controls.Add(this.selectedDeviceName_txtbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.remembered_txtbox);
            this.groupBox1.Controls.Add(this.isAuthenticated_txtbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lastUsed_txtbox);
            this.groupBox1.Controls.Add(this.isConnected_txtbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lastSeen_txtbox);
            this.groupBox1.Location = new System.Drawing.Point(223, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 192);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device Info";
            // 
            // label0
            // 
            this.label0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label0.Location = new System.Drawing.Point(8, 16);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(196, 20);
            this.label0.TabIndex = 12;
            this.label0.Text = "Selected Device Name";
            this.label0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedDeviceName_txtbox
            // 
            this.selectedDeviceName_txtbox.Location = new System.Drawing.Point(9, 35);
            this.selectedDeviceName_txtbox.Name = "selectedDeviceName_txtbox";
            this.selectedDeviceName_txtbox.ReadOnly = true;
            this.selectedDeviceName_txtbox.Size = new System.Drawing.Size(194, 20);
            this.selectedDeviceName_txtbox.TabIndex = 13;
            // 
            // selectFile_btn
            // 
            this.selectFile_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectFile_btn.Location = new System.Drawing.Point(9, 145);
            this.selectFile_btn.Name = "selectFile_btn";
            this.selectFile_btn.Size = new System.Drawing.Size(194, 23);
            this.selectFile_btn.TabIndex = 13;
            this.selectFile_btn.Text = "Select file";
            this.selectFile_btn.UseVisualStyleBackColor = true;
            this.selectFile_btn.Click += new System.EventHandler(this.selectFile_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.sendCancelFile_btn);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.selectedFileLength_txtbox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.selectedFilePath_txtbox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.selectedFileName_txtbox);
            this.groupBox2.Controls.Add(this.selectFile_btn);
            this.groupBox2.Location = new System.Drawing.Point(223, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 212);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Info";
            // 
            // sendCancelFile_btn
            // 
            this.sendCancelFile_btn.Enabled = false;
            this.sendCancelFile_btn.Location = new System.Drawing.Point(9, 183);
            this.sendCancelFile_btn.Name = "sendCancelFile_btn";
            this.sendCancelFile_btn.Size = new System.Drawing.Size(194, 23);
            this.sendCancelFile_btn.TabIndex = 15;
            this.sendCancelFile_btn.Text = "Send File";
            this.sendCancelFile_btn.UseVisualStyleBackColor = true;
            this.sendCancelFile_btn.Click += new System.EventHandler(this.sendFile_btn_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(8, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "File Length (kB)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedFileLength_txtbox
            // 
            this.selectedFileLength_txtbox.Location = new System.Drawing.Point(9, 119);
            this.selectedFileLength_txtbox.Name = "selectedFileLength_txtbox";
            this.selectedFileLength_txtbox.ReadOnly = true;
            this.selectedFileLength_txtbox.Size = new System.Drawing.Size(194, 20);
            this.selectedFileLength_txtbox.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(8, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "File Path";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedFilePath_txtbox
            // 
            this.selectedFilePath_txtbox.Location = new System.Drawing.Point(9, 77);
            this.selectedFilePath_txtbox.Name = "selectedFilePath_txtbox";
            this.selectedFilePath_txtbox.ReadOnly = true;
            this.selectedFilePath_txtbox.Size = new System.Drawing.Size(194, 20);
            this.selectedFilePath_txtbox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(8, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "File Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedFileName_txtbox
            // 
            this.selectedFileName_txtbox.Location = new System.Drawing.Point(9, 35);
            this.selectedFileName_txtbox.Name = "selectedFileName_txtbox";
            this.selectedFileName_txtbox.ReadOnly = true;
            this.selectedFileName_txtbox.Size = new System.Drawing.Size(194, 20);
            this.selectedFileName_txtbox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(436, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.scanForDevices_btn);
            this.Controls.Add(this.devicesAvailable_listview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Bluetooth File Transfer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView devicesAvailable_listview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button scanForDevices_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox isAuthenticated_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox isConnected_txtbox;
        private System.Windows.Forms.TextBox lastSeen_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastUsed_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox remembered_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox selectedDeviceName_txtbox;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Button selectFile_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox selectedFileLength_txtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox selectedFilePath_txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox selectedFileName_txtbox;
        private System.Windows.Forms.Button sendCancelFile_btn;
    }
}

