
namespace LocationsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RoomTypeVTB2 = new System.Windows.Forms.TextBox();
            this.BuildingNameVTB2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ClearBTN2 = new System.Windows.Forms.Button();
            this.SaveBTN2 = new System.Windows.Forms.Button();
            this.CapacityTB2 = new System.Windows.Forms.TextBox();
            this.RoomTypeCB2 = new System.Windows.Forms.ComboBox();
            this.RoomNameTB2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BuildingNameTB2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RoomNameVTB2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGV2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ClBTN2 = new System.Windows.Forms.Button();
            this.DeleteBTN2 = new System.Windows.Forms.Button();
            this.UpdateBTN2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CapacityVTB2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoomTypeVTB2
            // 
            this.RoomTypeVTB2.Location = new System.Drawing.Point(309, 459);
            this.RoomTypeVTB2.Name = "RoomTypeVTB2";
            this.RoomTypeVTB2.Size = new System.Drawing.Size(315, 31);
            this.RoomTypeVTB2.TabIndex = 7;
            this.RoomTypeVTB2.TextChanged += new System.EventHandler(this.RoomTypeVTB2_TextChanged);
            // 
            // BuildingNameVTB2
            // 
            this.BuildingNameVTB2.Location = new System.Drawing.Point(309, 317);
            this.BuildingNameVTB2.Name = "BuildingNameVTB2";
            this.BuildingNameVTB2.Size = new System.Drawing.Size(315, 31);
            this.BuildingNameVTB2.TabIndex = 5;
            this.BuildingNameVTB2.TextChanged += new System.EventHandler(this.BuildingNameVTB2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(55, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(457, 32);
            this.label9.TabIndex = 10;
            this.label9.Text = "Add rooms according to the buildings:";
            // 
            // ClearBTN2
            // 
            this.ClearBTN2.BackColor = System.Drawing.Color.SteelBlue;
            this.ClearBTN2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearBTN2.Location = new System.Drawing.Point(554, 489);
            this.ClearBTN2.Name = "ClearBTN2";
            this.ClearBTN2.Size = new System.Drawing.Size(171, 57);
            this.ClearBTN2.TabIndex = 9;
            this.ClearBTN2.Text = "Clear";
            this.ClearBTN2.UseVisualStyleBackColor = false;
            this.ClearBTN2.Click += new System.EventHandler(this.ClearBTN2_Click);
            // 
            // SaveBTN2
            // 
            this.SaveBTN2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SaveBTN2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveBTN2.Location = new System.Drawing.Point(74, 489);
            this.SaveBTN2.Name = "SaveBTN2";
            this.SaveBTN2.Size = new System.Drawing.Size(176, 57);
            this.SaveBTN2.TabIndex = 8;
            this.SaveBTN2.Text = "Save";
            this.SaveBTN2.UseVisualStyleBackColor = false;
            this.SaveBTN2.Click += new System.EventHandler(this.SaveBTN2_Click);
            // 
            // CapacityTB2
            // 
            this.CapacityTB2.Location = new System.Drawing.Point(281, 378);
            this.CapacityTB2.Name = "CapacityTB2";
            this.CapacityTB2.Size = new System.Drawing.Size(327, 31);
            this.CapacityTB2.TabIndex = 7;
            this.CapacityTB2.TextChanged += new System.EventHandler(this.CapacityTB2_TextChanged);
            // 
            // RoomTypeCB2
            // 
            this.RoomTypeCB2.FormattingEnabled = true;
            this.RoomTypeCB2.Items.AddRange(new object[] {
            "Lecture Hall",
            "Laboratary"});
            this.RoomTypeCB2.Location = new System.Drawing.Point(281, 288);
            this.RoomTypeCB2.Name = "RoomTypeCB2";
            this.RoomTypeCB2.Size = new System.Drawing.Size(327, 33);
            this.RoomTypeCB2.TabIndex = 6;
            this.RoomTypeCB2.SelectedIndexChanged += new System.EventHandler(this.RoomTypeCB2_SelectedIndexChanged);
            // 
            // RoomNameTB2
            // 
            this.RoomNameTB2.Location = new System.Drawing.Point(281, 203);
            this.RoomNameTB2.Name = "RoomNameTB2";
            this.RoomNameTB2.Size = new System.Drawing.Size(327, 31);
            this.RoomNameTB2.TabIndex = 5;
            this.RoomNameTB2.TextChanged += new System.EventHandler(this.RoomNameTB2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(107, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 32);
            this.label8.TabIndex = 4;
            this.label8.Text = "Capacity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(107, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 32);
            this.label7.TabIndex = 3;
            this.label7.Text = "Room Type";
            // 
            // BuildingNameTB2
            // 
            this.BuildingNameTB2.Location = new System.Drawing.Point(281, 113);
            this.BuildingNameTB2.Name = "BuildingNameTB2";
            this.BuildingNameTB2.Size = new System.Drawing.Size(327, 31);
            this.BuildingNameTB2.TabIndex = 4;
            this.BuildingNameTB2.TextChanged += new System.EventHandler(this.BuildingNameTB2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(55, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(55, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Name";
            // 
            // RoomNameVTB2
            // 
            this.RoomNameVTB2.Location = new System.Drawing.Point(309, 386);
            this.RoomNameVTB2.Name = "RoomNameVTB2";
            this.RoomNameVTB2.Size = new System.Drawing.Size(315, 31);
            this.RoomNameVTB2.TabIndex = 6;
            this.RoomNameVTB2.TextChanged += new System.EventHandler(this.RoomNameVTB2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(107, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Room name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(55, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room type";
            // 
            // DataGV2
            // 
            this.DataGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV2.Location = new System.Drawing.Point(45, 19);
            this.DataGV2.Name = "DataGV2";
            this.DataGV2.RowHeadersWidth = 62;
            this.DataGV2.RowTemplate.Height = 33;
            this.DataGV2.Size = new System.Drawing.Size(753, 206);
            this.DataGV2.TabIndex = 0;
            this.DataGV2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGV2_CellContentClick);
            this.DataGV2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGV2_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Building Name";
            // 
            // ClBTN2
            // 
            this.ClBTN2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClBTN2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClBTN2.Location = new System.Drawing.Point(624, 255);
            this.ClBTN2.Name = "ClBTN2";
            this.ClBTN2.Size = new System.Drawing.Size(127, 41);
            this.ClBTN2.TabIndex = 11;
            this.ClBTN2.Text = "Clear";
            this.ClBTN2.UseVisualStyleBackColor = false;
            this.ClBTN2.Click += new System.EventHandler(this.ClBTN2_Click);
            // 
            // DeleteBTN2
            // 
            this.DeleteBTN2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DeleteBTN2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBTN2.Location = new System.Drawing.Point(361, 255);
            this.DeleteBTN2.Name = "DeleteBTN2";
            this.DeleteBTN2.Size = new System.Drawing.Size(124, 41);
            this.DeleteBTN2.TabIndex = 10;
            this.DeleteBTN2.Text = "Delete";
            this.DeleteBTN2.UseVisualStyleBackColor = false;
            this.DeleteBTN2.Click += new System.EventHandler(this.DeleteBTN2_Click);
            // 
            // UpdateBTN2
            // 
            this.UpdateBTN2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.UpdateBTN2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateBTN2.Location = new System.Drawing.Point(104, 255);
            this.UpdateBTN2.Name = "UpdateBTN2";
            this.UpdateBTN2.Size = new System.Drawing.Size(122, 41);
            this.UpdateBTN2.TabIndex = 9;
            this.UpdateBTN2.Text = "Update";
            this.UpdateBTN2.UseVisualStyleBackColor = false;
            this.UpdateBTN2.Click += new System.EventHandler(this.UpdateBTN2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ClBTN2);
            this.tabPage2.Controls.Add(this.DeleteBTN2);
            this.tabPage2.Controls.Add(this.UpdateBTN2);
            this.tabPage2.Controls.Add(this.CapacityVTB2);
            this.tabPage2.Controls.Add(this.RoomTypeVTB2);
            this.tabPage2.Controls.Add(this.RoomNameVTB2);
            this.tabPage2.Controls.Add(this.BuildingNameVTB2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.DataGV2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(836, 580);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Locations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CapacityVTB2
            // 
            this.CapacityVTB2.Location = new System.Drawing.Point(309, 521);
            this.CapacityVTB2.Name = "CapacityVTB2";
            this.CapacityVTB2.Size = new System.Drawing.Size(315, 31);
            this.CapacityVTB2.TabIndex = 8;
            this.CapacityVTB2.TextChanged += new System.EventHandler(this.CapacityVTB2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(107, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Building Name";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.ClearBTN2);
            this.tabPage1.Controls.Add(this.SaveBTN2);
            this.tabPage1.Controls.Add(this.CapacityTB2);
            this.tabPage1.Controls.Add(this.RoomTypeCB2);
            this.tabPage1.Controls.Add(this.RoomNameTB2);
            this.tabPage1.Controls.Add(this.BuildingNameTB2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(836, 580);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Location";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(241, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 618);
            this.tabControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 715);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGV2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox RoomTypeVTB2;
        private System.Windows.Forms.TextBox BuildingNameVTB2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ClearBTN2;
        private System.Windows.Forms.Button SaveBTN2;
        private System.Windows.Forms.TextBox CapacityTB2;
        private System.Windows.Forms.ComboBox RoomTypeCB2;
        private System.Windows.Forms.TextBox RoomNameTB2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BuildingNameTB2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RoomNameVTB2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGV2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClBTN2;
        private System.Windows.Forms.Button DeleteBTN2;
        private System.Windows.Forms.Button UpdateBTN2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox CapacityVTB2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

