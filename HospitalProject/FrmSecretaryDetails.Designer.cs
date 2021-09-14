
namespace HospitalProject
{
    partial class FrmSecretaryDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSecretaryDetails));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rchAnnouncement = new System.Windows.Forms.RichTextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAppointmentsList = new System.Windows.Forms.Button();
            this.btnBranchPanel = new System.Windows.Forms.Button();
            this.btnDoctorPanel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chcState = new System.Windows.Forms.CheckBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.mskTime = new System.Windows.Forms.MaskedTextBox();
            this.mskDate = new System.Windows.Forms.MaskedTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtgBranchs = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtgDoctors = new System.Windows.Forms.DataGridView();
            this.btnAnnouncements = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBranchs)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNameSurname);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 197);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Location = new System.Drawing.Point(197, 126);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(110, 32);
            this.lblNameSurname.TabIndex = 7;
            this.lblNameSurname.Text = "Null Null";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(197, 59);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(158, 32);
            this.lblTC.TabIndex = 6;
            this.lblTC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "İsim Soyisim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC Kimlik No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rchAnnouncement);
            this.groupBox2.Controls.Add(this.btnCreate);
            this.groupBox2.Location = new System.Drawing.Point(13, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 365);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // rchAnnouncement
            // 
            this.rchAnnouncement.Location = new System.Drawing.Point(34, 49);
            this.rchAnnouncement.Name = "rchAnnouncement";
            this.rchAnnouncement.Size = new System.Drawing.Size(392, 218);
            this.rchAnnouncement.TabIndex = 28;
            this.rchAnnouncement.Text = "";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(34, 281);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(392, 49);
            this.btnCreate.TabIndex = 27;
            this.btnCreate.Text = "Oluştur";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAnnouncements);
            this.groupBox3.Controls.Add(this.btnAppointmentsList);
            this.groupBox3.Controls.Add(this.btnBranchPanel);
            this.groupBox3.Controls.Add(this.btnDoctorPanel);
            this.groupBox3.Location = new System.Drawing.Point(13, 589);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(837, 144);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hızlı Erişim";
            // 
            // btnAppointmentsList
            // 
            this.btnAppointmentsList.Location = new System.Drawing.Point(416, 63);
            this.btnAppointmentsList.Name = "btnAppointmentsList";
            this.btnAppointmentsList.Size = new System.Drawing.Size(198, 49);
            this.btnAppointmentsList.TabIndex = 26;
            this.btnAppointmentsList.Text = "Randevular";
            this.btnAppointmentsList.UseVisualStyleBackColor = true;
            this.btnAppointmentsList.Click += new System.EventHandler(this.btnAppointmentsList_Click);
            // 
            // btnBranchPanel
            // 
            this.btnBranchPanel.Location = new System.Drawing.Point(214, 63);
            this.btnBranchPanel.Name = "btnBranchPanel";
            this.btnBranchPanel.Size = new System.Drawing.Size(196, 49);
            this.btnBranchPanel.TabIndex = 25;
            this.btnBranchPanel.Text = "Branş Paneli";
            this.btnBranchPanel.UseVisualStyleBackColor = true;
            this.btnBranchPanel.Click += new System.EventHandler(this.btnBranchPanel_Click);
            // 
            // btnDoctorPanel
            // 
            this.btnDoctorPanel.Location = new System.Drawing.Point(17, 63);
            this.btnDoctorPanel.Name = "btnDoctorPanel";
            this.btnDoctorPanel.Size = new System.Drawing.Size(191, 49);
            this.btnDoctorPanel.TabIndex = 24;
            this.btnDoctorPanel.Text = "Doktor Paneli";
            this.btnDoctorPanel.UseVisualStyleBackColor = true;
            this.btnDoctorPanel.Click += new System.EventHandler(this.btnDoctorPanel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.chcState);
            this.groupBox4.Controls.Add(this.mskTC);
            this.groupBox4.Controls.Add(this.cmbDoctor);
            this.groupBox4.Controls.Add(this.cmbBranch);
            this.groupBox4.Controls.Add(this.mskTime);
            this.groupBox4.Controls.Add(this.mskDate);
            this.groupBox4.Controls.Add(this.txtID);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(491, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(359, 569);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Randevu Paneli";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(120, 509);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(206, 49);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 454);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(206, 49);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chcState
            // 
            this.chcState.AutoSize = true;
            this.chcState.Location = new System.Drawing.Point(155, 411);
            this.chcState.Name = "chcState";
            this.chcState.Size = new System.Drawing.Size(111, 36);
            this.chcState.TabIndex = 21;
            this.chcState.Text = "Durum";
            this.chcState.UseVisualStyleBackColor = true;
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(120, 353);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(206, 39);
            this.mskTC.TabIndex = 20;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(120, 290);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(206, 39);
            this.cmbDoctor.TabIndex = 19;
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(120, 225);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(206, 39);
            this.cmbBranch.TabIndex = 18;
            this.cmbBranch.SelectedIndexChanged += new System.EventHandler(this.cmbBranch_SelectedIndexChanged);
            // 
            // mskTime
            // 
            this.mskTime.Location = new System.Drawing.Point(120, 165);
            this.mskTime.Mask = "00:00";
            this.mskTime.Name = "mskTime";
            this.mskTime.Size = new System.Drawing.Size(206, 39);
            this.mskTime.TabIndex = 17;
            this.mskTime.ValidatingType = typeof(System.DateTime);
            // 
            // mskDate
            // 
            this.mskDate.Location = new System.Drawing.Point(120, 108);
            this.mskDate.Mask = "00/00/0000";
            this.mskDate.Name = "mskDate";
            this.mskDate.Size = new System.Drawing.Size(206, 39);
            this.mskDate.TabIndex = 16;
            this.mskDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(120, 59);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(206, 39);
            this.txtID.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "TC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Doktor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Branş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Saat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tarih:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtgBranchs);
            this.groupBox5.Location = new System.Drawing.Point(862, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(457, 353);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Branşlar";
            // 
            // dtgBranchs
            // 
            this.dtgBranchs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBranchs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBranchs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgBranchs.Location = new System.Drawing.Point(3, 35);
            this.dtgBranchs.Name = "dtgBranchs";
            this.dtgBranchs.RowHeadersWidth = 51;
            this.dtgBranchs.RowTemplate.Height = 24;
            this.dtgBranchs.Size = new System.Drawing.Size(451, 315);
            this.dtgBranchs.TabIndex = 7;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtgDoctors);
            this.groupBox6.Location = new System.Drawing.Point(862, 373);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(457, 360);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Doktorlar";
            // 
            // dtgDoctors
            // 
            this.dtgDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDoctors.Location = new System.Drawing.Point(3, 35);
            this.dtgDoctors.Name = "dtgDoctors";
            this.dtgDoctors.RowHeadersWidth = 51;
            this.dtgDoctors.RowTemplate.Height = 24;
            this.dtgDoctors.Size = new System.Drawing.Size(451, 322);
            this.dtgDoctors.TabIndex = 8;
            // 
            // btnAnnouncements
            // 
            this.btnAnnouncements.Location = new System.Drawing.Point(620, 63);
            this.btnAnnouncements.Name = "btnAnnouncements";
            this.btnAnnouncements.Size = new System.Drawing.Size(198, 49);
            this.btnAnnouncements.TabIndex = 27;
            this.btnAnnouncements.Text = "Duyurular";
            this.btnAnnouncements.UseVisualStyleBackColor = true;
            this.btnAnnouncements.Click += new System.EventHandler(this.btnAnnouncements_Click);
            // 
            // FrmSecretaryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1331, 746);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "FrmSecretaryDetails";
            this.Text = "Sekreter Detay";
            this.Load += new System.EventHandler(this.FrmSecretaryDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBranchs)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoctors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dtgBranchs;
        private System.Windows.Forms.DataGridView dtgDoctors;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.MaskedTextBox mskTime;
        private System.Windows.Forms.MaskedTextBox mskDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chcState;
        private System.Windows.Forms.RichTextBox rchAnnouncement;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnAppointmentsList;
        private System.Windows.Forms.Button btnBranchPanel;
        private System.Windows.Forms.Button btnDoctorPanel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAnnouncements;
    }
}