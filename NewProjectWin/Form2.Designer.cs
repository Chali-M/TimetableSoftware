
namespace NewProjectWin
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeleteSub = new System.Windows.Forms.Button();
            this.btnUpdateSub = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.VtimeDu = new System.Windows.Forms.TextBox();
            this.addLocBTN = new System.Windows.Forms.Button();
            this.dataGV4 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.selSID = new System.Windows.Forms.ComboBox();
            this.selSGrp = new System.Windows.Forms.ComboBox();
            this.selGrp = new System.Windows.Forms.ComboBox();
            this.selLec = new System.Windows.Forms.ComboBox();
            this.timeDu = new System.Windows.Forms.TextBox();
            this.btnClearSub = new System.Windows.Forms.Button();
            this.btnSaveSub = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LdataGV = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV4)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.LdataGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDeleteSub);
            this.tabPage2.Controls.Add(this.btnUpdateSub);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.VtimeDu);
            this.tabPage2.Controls.Add(this.addLocBTN);
            this.tabPage2.Controls.Add(this.dataGV4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(817, 549);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Not-Available Time";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSub
            // 
            this.btnDeleteSub.Location = new System.Drawing.Point(626, 461);
            this.btnDeleteSub.Name = "btnDeleteSub";
            this.btnDeleteSub.Size = new System.Drawing.Size(174, 48);
            this.btnDeleteSub.TabIndex = 24;
            this.btnDeleteSub.Text = "Delete";
            this.btnDeleteSub.UseVisualStyleBackColor = true;
            this.btnDeleteSub.Click += new System.EventHandler(this.btnDeleteSub_Click_1);
            // 
            // btnUpdateSub
            // 
            this.btnUpdateSub.Location = new System.Drawing.Point(327, 461);
            this.btnUpdateSub.Name = "btnUpdateSub";
            this.btnUpdateSub.Size = new System.Drawing.Size(174, 48);
            this.btnUpdateSub.TabIndex = 23;
            this.btnUpdateSub.Text = "Update";
            this.btnUpdateSub.UseVisualStyleBackColor = true;
            this.btnUpdateSub.Click += new System.EventHandler(this.btnUpdateSub_Click_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(145, 336);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(226, 45);
            this.label17.TabIndex = 19;
            this.label17.Text = "Time Duration";
            // 
            // VtimeDu
            // 
            this.VtimeDu.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VtimeDu.Location = new System.Drawing.Point(408, 336);
            this.VtimeDu.Name = "VtimeDu";
            this.VtimeDu.Size = new System.Drawing.Size(289, 51);
            this.VtimeDu.TabIndex = 18;
            // 
            // addLocBTN
            // 
            this.addLocBTN.Location = new System.Drawing.Point(18, 461);
            this.addLocBTN.Name = "addLocBTN";
            this.addLocBTN.Size = new System.Drawing.Size(171, 48);
            this.addLocBTN.TabIndex = 1;
            this.addLocBTN.Text = "Add Location";
            this.addLocBTN.UseVisualStyleBackColor = true;
            this.addLocBTN.Click += new System.EventHandler(this.addLocBTN_Click);
            // 
            // dataGV4
            // 
            this.dataGV4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV4.Location = new System.Drawing.Point(18, 29);
            this.dataGV4.Name = "dataGV4";
            this.dataGV4.RowHeadersWidth = 51;
            this.dataGV4.RowTemplate.Height = 29;
            this.dataGV4.Size = new System.Drawing.Size(782, 251);
            this.dataGV4.TabIndex = 0;
            this.dataGV4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.selSID);
            this.tabPage1.Controls.Add(this.selSGrp);
            this.tabPage1.Controls.Add(this.selGrp);
            this.tabPage1.Controls.Add(this.selLec);
            this.tabPage1.Controls.Add(this.timeDu);
            this.tabPage1.Controls.Add(this.btnClearSub);
            this.tabPage1.Controls.Add(this.btnSaveSub);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(817, 549);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Not-Available Time";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // selSID
            // 
            this.selSID.FormattingEnabled = true;
            this.selSID.Items.AddRange(new object[] {
            "Ses1",
            "Ses2",
            "Ses3",
            "ses4",
            "ses5"});
            this.selSID.Location = new System.Drawing.Point(409, 224);
            this.selSID.Name = "selSID";
            this.selSID.Size = new System.Drawing.Size(271, 28);
            this.selSID.TabIndex = 25;
            // 
            // selSGrp
            // 
            this.selSGrp.FormattingEnabled = true;
            this.selSGrp.Location = new System.Drawing.Point(409, 174);
            this.selSGrp.Name = "selSGrp";
            this.selSGrp.Size = new System.Drawing.Size(271, 28);
            this.selSGrp.TabIndex = 24;
            this.selSGrp.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // selGrp
            // 
            this.selGrp.FormattingEnabled = true;
            this.selGrp.Location = new System.Drawing.Point(409, 128);
            this.selGrp.Name = "selGrp";
            this.selGrp.Size = new System.Drawing.Size(271, 28);
            this.selGrp.TabIndex = 23;
            this.selGrp.SelectedIndexChanged += new System.EventHandler(this.selGrp_SelectedIndexChanged);
            // 
            // selLec
            // 
            this.selLec.FormattingEnabled = true;
            this.selLec.Location = new System.Drawing.Point(409, 81);
            this.selLec.Name = "selLec";
            this.selLec.Size = new System.Drawing.Size(271, 28);
            this.selLec.TabIndex = 22;
            // 
            // timeDu
            // 
            this.timeDu.Location = new System.Drawing.Point(409, 272);
            this.timeDu.Name = "timeDu";
            this.timeDu.Size = new System.Drawing.Size(271, 27);
            this.timeDu.TabIndex = 17;
            // 
            // btnClearSub
            // 
            this.btnClearSub.Location = new System.Drawing.Point(521, 383);
            this.btnClearSub.Name = "btnClearSub";
            this.btnClearSub.Size = new System.Drawing.Size(159, 50);
            this.btnClearSub.TabIndex = 12;
            this.btnClearSub.Text = "Clear";
            this.btnClearSub.UseVisualStyleBackColor = true;
            this.btnClearSub.Click += new System.EventHandler(this.btnClearSub_Click);
            // 
            // btnSaveSub
            // 
            this.btnSaveSub.Location = new System.Drawing.Point(177, 383);
            this.btnSaveSub.Name = "btnSaveSub";
            this.btnSaveSub.Size = new System.Drawing.Size(158, 50);
            this.btnSaveSub.TabIndex = 11;
            this.btnSaveSub.Text = "Save";
            this.btnSaveSub.UseVisualStyleBackColor = true;
            this.btnSaveSub.Click += new System.EventHandler(this.btnSaveSub_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(177, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Time Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(177, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Select Session ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(177, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select Sub Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(177, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(177, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Lecturer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(247, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Not Available Time Details";
            // 
            // LdataGV
            // 
            this.LdataGV.Controls.Add(this.tabPage1);
            this.LdataGV.Controls.Add(this.tabPage2);
            this.LdataGV.Location = new System.Drawing.Point(197, 37);
            this.LdataGV.Name = "LdataGV";
            this.LdataGV.SelectedIndex = 0;
            this.LdataGV.Size = new System.Drawing.Size(825, 582);
            this.LdataGV.TabIndex = 1;
            this.LdataGV.SelectedIndexChanged += new System.EventHandler(this.LdataGV_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 631);
            this.Controls.Add(this.LdataGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV4)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.LdataGV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDeleteSub;
        private System.Windows.Forms.Button btnUpdateSub;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox VtimeDu;
        private System.Windows.Forms.Button addLocBTN;
        private System.Windows.Forms.DataGridView dataGV4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox selSID;
        private System.Windows.Forms.ComboBox selSGrp;
        private System.Windows.Forms.ComboBox selGrp;
        private System.Windows.Forms.ComboBox selLec;
        private System.Windows.Forms.TextBox timeDu;
        private System.Windows.Forms.Button btnClearSub;
        private System.Windows.Forms.Button btnSaveSub;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl LdataGV;
    }
}