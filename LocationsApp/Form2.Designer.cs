
namespace LocationsApp
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ClearBTN = new System.Windows.Forms.Button();
            this.AddroomBTN = new System.Windows.Forms.Button();
            this.lec2Area = new System.Windows.Forms.TextBox();
            this.lec1Area = new System.Windows.Forms.TextBox();
            this.label4R = new System.Windows.Forms.Label();
            this.tagcombo1 = new System.Windows.Forms.ComboBox();
            this.label3R = new System.Windows.Forms.Label();
            this.SubText = new System.Windows.Forms.ComboBox();
            this.label2R = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RoomArea = new System.Windows.Forms.TextBox();
            this.label6R = new System.Windows.Forms.Label();
            this.TimetableDGV2 = new System.Windows.Forms.DataGridView();
            this.RefreshBTN = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddroomBTN2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimetableDGV2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(384, -56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Locations";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ClearBTN);
            this.tabPage2.Controls.Add(this.AddroomBTN);
            this.tabPage2.Controls.Add(this.lec2Area);
            this.tabPage2.Controls.Add(this.lec1Area);
            this.tabPage2.Controls.Add(this.label4R);
            this.tabPage2.Controls.Add(this.tagcombo1);
            this.tabPage2.Controls.Add(this.label3R);
            this.tabPage2.Controls.Add(this.SubText);
            this.tabPage2.Controls.Add(this.label2R);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(943, 529);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consecutive";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ClearBTN
            // 
            this.ClearBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClearBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearBTN.Location = new System.Drawing.Point(536, 446);
            this.ClearBTN.Name = "ClearBTN";
            this.ClearBTN.Size = new System.Drawing.Size(278, 46);
            this.ClearBTN.TabIndex = 15;
            this.ClearBTN.Text = "Clear details";
            this.ClearBTN.UseVisualStyleBackColor = false;
            // 
            // AddroomBTN
            // 
            this.AddroomBTN.BackColor = System.Drawing.Color.Red;
            this.AddroomBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddroomBTN.Location = new System.Drawing.Point(67, 446);
            this.AddroomBTN.Name = "AddroomBTN";
            this.AddroomBTN.Size = new System.Drawing.Size(268, 46);
            this.AddroomBTN.TabIndex = 14;
            this.AddroomBTN.Text = "Add suitable room";
            this.AddroomBTN.UseVisualStyleBackColor = false;
            // 
            // lec2Area
            // 
            this.lec2Area.Location = new System.Drawing.Point(370, 320);
            this.lec2Area.Multiline = true;
            this.lec2Area.Name = "lec2Area";
            this.lec2Area.Size = new System.Drawing.Size(363, 48);
            this.lec2Area.TabIndex = 13;
            this.lec2Area.Text = "2.";
            // 
            // lec1Area
            // 
            this.lec1Area.Location = new System.Drawing.Point(370, 255);
            this.lec1Area.Multiline = true;
            this.lec1Area.Name = "lec1Area";
            this.lec1Area.Size = new System.Drawing.Size(363, 48);
            this.lec1Area.TabIndex = 12;
            this.lec1Area.Text = "1.";
            // 
            // label4R
            // 
            this.label4R.AutoSize = true;
            this.label4R.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4R.Location = new System.Drawing.Point(112, 255);
            this.label4R.Name = "label4R";
            this.label4R.Size = new System.Drawing.Size(207, 32);
            this.label4R.TabIndex = 11;
            this.label4R.Text = "Lecturer name     :";
            // 
            // tagcombo1
            // 
            this.tagcombo1.FormattingEnabled = true;
            this.tagcombo1.Items.AddRange(new object[] {
            "Lecture Hall",
            "Laboratary"});
            this.tagcombo1.Location = new System.Drawing.Point(370, 161);
            this.tagcombo1.Name = "tagcombo1";
            this.tagcombo1.Size = new System.Drawing.Size(363, 33);
            this.tagcombo1.TabIndex = 10;
            // 
            // label3R
            // 
            this.label3R.AutoSize = true;
            this.label3R.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3R.Location = new System.Drawing.Point(112, 161);
            this.label3R.Name = "label3R";
            this.label3R.Size = new System.Drawing.Size(208, 32);
            this.label3R.TabIndex = 9;
            this.label3R.Text = "Select tag            :";
            // 
            // SubText
            // 
            this.SubText.FormattingEnabled = true;
            this.SubText.Items.AddRange(new object[] {
            "Lecture Hall",
            "Laboratary"});
            this.SubText.Location = new System.Drawing.Point(370, 72);
            this.SubText.Name = "SubText";
            this.SubText.Size = new System.Drawing.Size(363, 33);
            this.SubText.TabIndex = 8;
            // 
            // label2R
            // 
            this.label2R.AutoSize = true;
            this.label2R.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2R.Location = new System.Drawing.Point(112, 76);
            this.label2R.Name = "label2R";
            this.label2R.Size = new System.Drawing.Size(208, 32);
            this.label2R.TabIndex = 2;
            this.label2R.Text = "Select subject      :";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(943, 529);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Not Available times";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // RoomArea
            // 
            this.RoomArea.Location = new System.Drawing.Point(417, 327);
            this.RoomArea.Multiline = true;
            this.RoomArea.Name = "RoomArea";
            this.RoomArea.Size = new System.Drawing.Size(279, 59);
            this.RoomArea.TabIndex = 7;
            // 
            // label6R
            // 
            this.label6R.AutoSize = true;
            this.label6R.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6R.Location = new System.Drawing.Point(231, 330);
            this.label6R.Name = "label6R";
            this.label6R.Size = new System.Drawing.Size(162, 32);
            this.label6R.TabIndex = 3;
            this.label6R.Text = "Room name  :";
            // 
            // TimetableDGV2
            // 
            this.TimetableDGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimetableDGV2.Location = new System.Drawing.Point(102, 24);
            this.TimetableDGV2.Name = "TimetableDGV2";
            this.TimetableDGV2.RowHeadersWidth = 62;
            this.TimetableDGV2.RowTemplate.Height = 33;
            this.TimetableDGV2.Size = new System.Drawing.Size(753, 244);
            this.TimetableDGV2.TabIndex = 1;
            this.TimetableDGV2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TimetableDGV2_MouseDoubleClick);
            // 
            // RefreshBTN
            // 
            this.RefreshBTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.RefreshBTN.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RefreshBTN.Location = new System.Drawing.Point(679, 444);
            this.RefreshBTN.Name = "RefreshBTN";
            this.RefreshBTN.Size = new System.Drawing.Size(176, 57);
            this.RefreshBTN.TabIndex = 14;
            this.RefreshBTN.Text = "Refresh";
            this.RefreshBTN.UseVisualStyleBackColor = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RefreshBTN);
            this.tabPage1.Controls.Add(this.AddroomBTN2);
            this.tabPage1.Controls.Add(this.RoomArea);
            this.tabPage1.Controls.Add(this.label6R);
            this.tabPage1.Controls.Add(this.TimetableDGV2);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(943, 529);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sessions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AddroomBTN2
            // 
            this.AddroomBTN2.BackColor = System.Drawing.Color.Red;
            this.AddroomBTN2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddroomBTN2.Location = new System.Drawing.Point(102, 444);
            this.AddroomBTN2.Name = "AddroomBTN2";
            this.AddroomBTN2.Size = new System.Drawing.Size(176, 57);
            this.AddroomBTN2.TabIndex = 13;
            this.AddroomBTN2.Text = "Add Room";
            this.AddroomBTN2.UseVisualStyleBackColor = false;
            this.AddroomBTN2.Click += new System.EventHandler(this.AddroomBTN2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(51, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(951, 567);
            this.tabControl1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(384, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 48);
            this.label5.TabIndex = 3;
            this.label5.Text = "Add Locations";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 681);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimetableDGV2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ClearBTN;
        private System.Windows.Forms.Button AddroomBTN;
        private System.Windows.Forms.TextBox lec2Area;
        private System.Windows.Forms.TextBox lec1Area;
        private System.Windows.Forms.Label label4R;
        private System.Windows.Forms.ComboBox tagcombo1;
        private System.Windows.Forms.Label label3R;
        private System.Windows.Forms.ComboBox SubText;
        private System.Windows.Forms.Label label2R;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox RoomArea;
        private System.Windows.Forms.Label label6R;
        private System.Windows.Forms.DataGridView TimetableDGV2;
        private System.Windows.Forms.Button RefreshBTN;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button AddroomBTN2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label5;
    }
}