
namespace NewProjectWin
{
    partial class Form3
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.VtimeDu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearBTN6 = new System.Windows.Forms.Button();
            this.addSesBTN = new System.Windows.Forms.Button();
            this.eTime = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.sTime = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.selDay = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.selRoom = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.VselSID = new System.Windows.Forms.TextBox();
            this.VselSGrp = new System.Windows.Forms.TextBox();
            this.VselGrp = new System.Windows.Forms.TextBox();
            this.VselLec = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LocDGV2 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGV9 = new System.Windows.Forms.DataGridView();
            this.homeBTN = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocDGV2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV9)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(190, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 535);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.VtimeDu);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ClearBTN6);
            this.tabPage1.Controls.Add(this.addSesBTN);
            this.tabPage1.Controls.Add(this.eTime);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.sTime);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.selDay);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.selRoom);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.VselSID);
            this.tabPage1.Controls.Add(this.VselSGrp);
            this.tabPage1.Controls.Add(this.VselGrp);
            this.tabPage1.Controls.Add(this.VselLec);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.LocDGV2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(313, 332);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(176, 38);
            this.label18.TabIndex = 45;
            this.label18.Text = "Add Session";
            // 
            // VtimeDu
            // 
            this.VtimeDu.Location = new System.Drawing.Point(390, 302);
            this.VtimeDu.Name = "VtimeDu";
            this.VtimeDu.ReadOnly = true;
            this.VtimeDu.Size = new System.Drawing.Size(281, 27);
            this.VtimeDu.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(170, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 43;
            this.label1.Text = "Time Duration";
            // 
            // ClearBTN6
            // 
            this.ClearBTN6.Location = new System.Drawing.Point(525, 457);
            this.ClearBTN6.Name = "ClearBTN6";
            this.ClearBTN6.Size = new System.Drawing.Size(94, 29);
            this.ClearBTN6.TabIndex = 42;
            this.ClearBTN6.Text = "Clear";
            this.ClearBTN6.UseVisualStyleBackColor = true;
            // 
            // addSesBTN
            // 
            this.addSesBTN.Location = new System.Drawing.Point(201, 457);
            this.addSesBTN.Name = "addSesBTN";
            this.addSesBTN.Size = new System.Drawing.Size(152, 29);
            this.addSesBTN.TabIndex = 41;
            this.addSesBTN.Text = "Add Session";
            this.addSesBTN.UseVisualStyleBackColor = true;
            this.addSesBTN.Click += new System.EventHandler(this.addSesBTN_Click);
            // 
            // eTime
            // 
            this.eTime.Location = new System.Drawing.Point(525, 416);
            this.eTime.Name = "eTime";
            this.eTime.Size = new System.Drawing.Size(221, 27);
            this.eTime.TabIndex = 40;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(416, 415);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 28);
            this.label22.TabIndex = 39;
            this.label22.Text = "End Time";
            // 
            // sTime
            // 
            this.sTime.Location = new System.Drawing.Point(182, 415);
            this.sTime.Name = "sTime";
            this.sTime.Size = new System.Drawing.Size(201, 27);
            this.sTime.TabIndex = 38;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(55, 415);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 28);
            this.label21.TabIndex = 37;
            this.label21.Text = "Start Time";
            // 
            // selDay
            // 
            this.selDay.FormattingEnabled = true;
            this.selDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednsday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.selDay.Location = new System.Drawing.Point(525, 371);
            this.selDay.Name = "selDay";
            this.selDay.Size = new System.Drawing.Size(221, 28);
            this.selDay.TabIndex = 36;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(416, 371);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 28);
            this.label20.TabIndex = 35;
            this.label20.Text = "Select Day";
            // 
            // selRoom
            // 
            this.selRoom.FormattingEnabled = true;
            this.selRoom.Items.AddRange(new object[] {
            "Room 1",
            "Room 2",
            "Room 3",
            "Room 4"});
            this.selRoom.Location = new System.Drawing.Point(182, 375);
            this.selRoom.Name = "selRoom";
            this.selRoom.Size = new System.Drawing.Size(201, 28);
            this.selRoom.TabIndex = 34;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(55, 371);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(121, 28);
            this.label19.TabIndex = 33;
            this.label19.Text = "Select Room";
            // 
            // VselSID
            // 
            this.VselSID.Location = new System.Drawing.Point(390, 258);
            this.VselSID.Name = "VselSID";
            this.VselSID.ReadOnly = true;
            this.VselSID.Size = new System.Drawing.Size(281, 27);
            this.VselSID.TabIndex = 32;
            // 
            // VselSGrp
            // 
            this.VselSGrp.Location = new System.Drawing.Point(390, 221);
            this.VselSGrp.Name = "VselSGrp";
            this.VselSGrp.ReadOnly = true;
            this.VselSGrp.Size = new System.Drawing.Size(281, 27);
            this.VselSGrp.TabIndex = 31;
            // 
            // VselGrp
            // 
            this.VselGrp.Location = new System.Drawing.Point(390, 181);
            this.VselGrp.Name = "VselGrp";
            this.VselGrp.ReadOnly = true;
            this.VselGrp.Size = new System.Drawing.Size(281, 27);
            this.VselGrp.TabIndex = 30;
            // 
            // VselLec
            // 
            this.VselLec.Location = new System.Drawing.Point(390, 144);
            this.VselLec.Name = "VselLec";
            this.VselLec.ReadOnly = true;
            this.VselLec.Size = new System.Drawing.Size(281, 27);
            this.VselLec.TabIndex = 29;
            this.VselLec.TextChanged += new System.EventHandler(this.VselLec_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(170, 254);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(158, 28);
            this.label16.TabIndex = 28;
            this.label16.Text = "Select Session ID";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(170, 217);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 28);
            this.label15.TabIndex = 27;
            this.label15.Text = "Select Sub Group";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(170, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 28);
            this.label14.TabIndex = 26;
            this.label14.Text = "Select Group";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(170, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 28);
            this.label13.TabIndex = 25;
            this.label13.Text = "Select Lecturer";
            // 
            // LocDGV2
            // 
            this.LocDGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocDGV2.Location = new System.Drawing.Point(46, 15);
            this.LocDGV2.Name = "LocDGV2";
            this.LocDGV2.RowHeadersWidth = 51;
            this.LocDGV2.RowTemplate.Height = 29;
            this.LocDGV2.Size = new System.Drawing.Size(700, 110);
            this.LocDGV2.TabIndex = 0;
            this.LocDGV2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LocDGV2_MouseDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.homeBTN);
            this.tabPage2.Controls.Add(this.dataGV9);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGV9
            // 
            this.dataGV9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV9.Location = new System.Drawing.Point(17, 23);
            this.dataGV9.Name = "dataGV9";
            this.dataGV9.RowHeadersWidth = 51;
            this.dataGV9.RowTemplate.Height = 29;
            this.dataGV9.Size = new System.Drawing.Size(745, 214);
            this.dataGV9.TabIndex = 0;
            // 
            // homeBTN
            // 
            this.homeBTN.Location = new System.Drawing.Point(277, 289);
            this.homeBTN.Name = "homeBTN";
            this.homeBTN.Size = new System.Drawing.Size(223, 62);
            this.homeBTN.TabIndex = 1;
            this.homeBTN.Text = "Home";
            this.homeBTN.UseVisualStyleBackColor = true;
            this.homeBTN.Click += new System.EventHandler(this.homeBTN_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 626);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocDGV2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView LocDGV2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox VselLec;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox VselSID;
        private System.Windows.Forms.TextBox VselSGrp;
        private System.Windows.Forms.TextBox VselGrp;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox selRoom;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox selDay;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox sTime;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button ClearBTN6;
        private System.Windows.Forms.Button addSesBTN;
        private System.Windows.Forms.TextBox VeTime;
        private System.Windows.Forms.TextBox VtimeDu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGV9;
        private System.Windows.Forms.TextBox eTime;
        private System.Windows.Forms.Button homeBTN;
    }
}