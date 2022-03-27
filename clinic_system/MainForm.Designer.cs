
namespace clinic_system
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.insertVisitBtn = new System.Windows.Forms.Button();
            this.updateVisitBtn = new System.Windows.Forms.Button();
            this.deleteVisitBtn = new System.Windows.Forms.Button();
            this.visitDrugTextBox = new System.Windows.Forms.TextBox();
            this.visitGeneralTextBox = new System.Windows.Forms.TextBox();
            this.visitDate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.visitTempTextBox = new System.Windows.Forms.TextBox();
            this.visitBpTextBox = new System.Windows.Forms.TextBox();
            this.visitPulseTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.visitFeesTextBox = new System.Windows.Forms.TextBox();
            this.visitComplaintTextBox = new System.Windows.Forms.TextBox();
            this.visitsGridView = new System.Windows.Forms.DataGridView();
            this.vdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complaint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitIDTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.female = new System.Windows.Forms.RadioButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.patientsGridView = new System.Windows.Forms.DataGridView();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitsGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1142, 701);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1134, 675);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "مرضى";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.insertVisitBtn);
            this.groupBox2.Controls.Add(this.updateVisitBtn);
            this.groupBox2.Controls.Add(this.deleteVisitBtn);
            this.groupBox2.Controls.Add(this.visitDrugTextBox);
            this.groupBox2.Controls.Add(this.visitGeneralTextBox);
            this.groupBox2.Controls.Add(this.visitDate);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.visitTempTextBox);
            this.groupBox2.Controls.Add(this.visitBpTextBox);
            this.groupBox2.Controls.Add(this.visitPulseTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.visitFeesTextBox);
            this.groupBox2.Controls.Add(this.visitComplaintTextBox);
            this.groupBox2.Controls.Add(this.visitsGridView);
            this.groupBox2.Controls.Add(this.visitIDTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox2.Location = new System.Drawing.Point(29, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1081, 334);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "زيارة";
            // 
            // insertVisitBtn
            // 
            this.insertVisitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insertVisitBtn.Location = new System.Drawing.Point(912, 295);
            this.insertVisitBtn.Name = "insertVisitBtn";
            this.insertVisitBtn.Size = new System.Drawing.Size(75, 32);
            this.insertVisitBtn.TabIndex = 35;
            this.insertVisitBtn.Text = "إضافه";
            this.insertVisitBtn.UseMnemonic = false;
            this.insertVisitBtn.UseVisualStyleBackColor = true;
            this.insertVisitBtn.Click += new System.EventHandler(this.insertVisitBtn_Click);
            // 
            // updateVisitBtn
            // 
            this.updateVisitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateVisitBtn.Location = new System.Drawing.Point(807, 295);
            this.updateVisitBtn.Name = "updateVisitBtn";
            this.updateVisitBtn.Size = new System.Drawing.Size(75, 32);
            this.updateVisitBtn.TabIndex = 34;
            this.updateVisitBtn.Text = "تعديل";
            this.updateVisitBtn.UseVisualStyleBackColor = true;
            this.updateVisitBtn.Click += new System.EventHandler(this.updateVisitBtn_Click);
            // 
            // deleteVisitBtn
            // 
            this.deleteVisitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteVisitBtn.Location = new System.Drawing.Point(701, 295);
            this.deleteVisitBtn.Name = "deleteVisitBtn";
            this.deleteVisitBtn.Size = new System.Drawing.Size(75, 32);
            this.deleteVisitBtn.TabIndex = 33;
            this.deleteVisitBtn.Text = "حذف";
            this.deleteVisitBtn.UseVisualStyleBackColor = true;
            this.deleteVisitBtn.Click += new System.EventHandler(this.deleteVisitBtn_Click);
            // 
            // visitDrugTextBox
            // 
            this.visitDrugTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.visitDrugTextBox.Location = new System.Drawing.Point(598, 216);
            this.visitDrugTextBox.Multiline = true;
            this.visitDrugTextBox.Name = "visitDrugTextBox";
            this.visitDrugTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.visitDrugTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.visitDrugTextBox.Size = new System.Drawing.Size(389, 28);
            this.visitDrugTextBox.TabIndex = 32;
            // 
            // visitGeneralTextBox
            // 
            this.visitGeneralTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.visitGeneralTextBox.Location = new System.Drawing.Point(598, 165);
            this.visitGeneralTextBox.Multiline = true;
            this.visitGeneralTextBox.Name = "visitGeneralTextBox";
            this.visitGeneralTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.visitGeneralTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.visitGeneralTextBox.Size = new System.Drawing.Size(389, 48);
            this.visitGeneralTextBox.TabIndex = 31;
            // 
            // visitDate
            // 
            this.visitDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.visitDate.Font = new System.Drawing.Font("Tahoma", 8F);
            this.visitDate.Location = new System.Drawing.Point(598, 22);
            this.visitDate.Name = "visitDate";
            this.visitDate.Size = new System.Drawing.Size(200, 20);
            this.visitDate.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label15.Location = new System.Drawing.Point(993, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 19);
            this.label15.TabIndex = 29;
            this.label15.Text = "دواء";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label10.Location = new System.Drawing.Point(993, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 19);
            this.label10.TabIndex = 26;
            this.label10.Text = "شكوي عامه";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label11.Location = new System.Drawing.Point(719, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "ضغط";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label12.Location = new System.Drawing.Point(844, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 19);
            this.label12.TabIndex = 24;
            this.label12.Text = "حرارة";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label13.Location = new System.Drawing.Point(993, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 19);
            this.label13.TabIndex = 23;
            this.label13.Text = "نبض";
            // 
            // visitTempTextBox
            // 
            this.visitTempTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.visitTempTextBox.Location = new System.Drawing.Point(765, 132);
            this.visitTempTextBox.Name = "visitTempTextBox";
            this.visitTempTextBox.Size = new System.Drawing.Size(73, 27);
            this.visitTempTextBox.TabIndex = 22;
            // 
            // visitBpTextBox
            // 
            this.visitBpTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.visitBpTextBox.Location = new System.Drawing.Point(613, 132);
            this.visitBpTextBox.Name = "visitBpTextBox";
            this.visitBpTextBox.Size = new System.Drawing.Size(100, 27);
            this.visitBpTextBox.TabIndex = 20;
            // 
            // visitPulseTextBox
            // 
            this.visitPulseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.visitPulseTextBox.Location = new System.Drawing.Point(905, 130);
            this.visitPulseTextBox.Name = "visitPulseTextBox";
            this.visitPulseTextBox.Size = new System.Drawing.Size(82, 27);
            this.visitPulseTextBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(993, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "شكوي";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(808, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "تاريخ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(993, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "مبلغ";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.Location = new System.Drawing.Point(993, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "رقم";
            // 
            // visitFeesTextBox
            // 
            this.visitFeesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.visitFeesTextBox.Location = new System.Drawing.Point(887, 250);
            this.visitFeesTextBox.Name = "visitFeesTextBox";
            this.visitFeesTextBox.Size = new System.Drawing.Size(100, 27);
            this.visitFeesTextBox.TabIndex = 8;
            // 
            // visitComplaintTextBox
            // 
            this.visitComplaintTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.visitComplaintTextBox.Location = new System.Drawing.Point(598, 63);
            this.visitComplaintTextBox.Multiline = true;
            this.visitComplaintTextBox.Name = "visitComplaintTextBox";
            this.visitComplaintTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.visitComplaintTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.visitComplaintTextBox.Size = new System.Drawing.Size(389, 61);
            this.visitComplaintTextBox.TabIndex = 7;
            // 
            // visitsGridView
            // 
            this.visitsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.visitsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vdate,
            this.complaint,
            this.visitID});
            this.visitsGridView.Location = new System.Drawing.Point(25, 26);
            this.visitsGridView.Name = "visitsGridView";
            this.visitsGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.visitsGridView.Size = new System.Drawing.Size(489, 218);
            this.visitsGridView.TabIndex = 0;
            this.visitsGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.visitsGridView_RowHeaderMouseClick);
            // 
            // vdate
            // 
            this.vdate.HeaderText = "تاريخ";
            this.vdate.Name = "vdate";
            this.vdate.Width = 200;
            // 
            // complaint
            // 
            this.complaint.HeaderText = "شكوى";
            this.complaint.Name = "complaint";
            this.complaint.Width = 240;
            // 
            // visitID
            // 
            this.visitID.HeaderText = "visitID";
            this.visitID.Name = "visitID";
            this.visitID.Visible = false;
            // 
            // visitIDTextBox
            // 
            this.visitIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.visitIDTextBox.Enabled = false;
            this.visitIDTextBox.Location = new System.Drawing.Point(887, 19);
            this.visitIDTextBox.Name = "visitIDTextBox";
            this.visitIDTextBox.Size = new System.Drawing.Size(100, 27);
            this.visitIDTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.insertBtn);
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.female);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.mobileTextBox);
            this.groupBox1.Controls.Add(this.ageTextBox);
            this.groupBox1.Controls.Add(this.patientsGridView);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.searchTextBox);
            this.groupBox1.Controls.Add(this.male);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(29, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1081, 301);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مريض";
            // 
            // insertBtn
            // 
            this.insertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insertBtn.Location = new System.Drawing.Point(912, 215);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 32);
            this.insertBtn.TabIndex = 15;
            this.insertBtn.Text = "إضافه";
            this.insertBtn.UseMnemonic = false;
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBtn.Location = new System.Drawing.Point(807, 215);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 32);
            this.updateBtn.TabIndex = 14;
            this.updateBtn.Text = "تعديل";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(834, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "محمول";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(993, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "سن";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(993, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "إسم";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(993, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "رقم";
            // 
            // female
            // 
            this.female.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(863, 154);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(57, 23);
            this.female.TabIndex = 9;
            this.female.Text = "أنثي";
            this.female.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(699, 85);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(288, 27);
            this.nameTextBox.TabIndex = 8;
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mobileTextBox.Location = new System.Drawing.Point(699, 119);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(129, 27);
            this.mobileTextBox.TabIndex = 7;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ageTextBox.Location = new System.Drawing.Point(916, 118);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(71, 27);
            this.ageTextBox.TabIndex = 6;
            // 
            // patientsGridView
            // 
            this.patientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pname,
            this.pAge,
            this.mobile});
            this.patientsGridView.Location = new System.Drawing.Point(25, 54);
            this.patientsGridView.Name = "patientsGridView";
            this.patientsGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.patientsGridView.Size = new System.Drawing.Size(489, 231);
            this.patientsGridView.TabIndex = 0;
            this.patientsGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.patientsGridView_RowHeaderMouseClick);
            // 
            // pname
            // 
            this.pname.HeaderText = "الإسم";
            this.pname.Name = "pname";
            this.pname.Width = 200;
            // 
            // pAge
            // 
            this.pAge.HeaderText = "السن";
            this.pAge.Name = "pAge";
            // 
            // mobile
            // 
            this.mobile.HeaderText = "محمول";
            this.mobile.Name = "mobile";
            this.mobile.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(460, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "بحث";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(25, 20);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(419, 27);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // male
            // 
            this.male.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.male.AutoSize = true;
            this.male.Checked = true;
            this.male.Location = new System.Drawing.Point(938, 154);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(49, 23);
            this.male.TabIndex = 4;
            this.male.TabStop = true;
            this.male.Text = "ذكر";
            this.male.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(887, 50);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 27);
            this.idTextBox.TabIndex = 2;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Location = new System.Drawing.Point(701, 215);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 32);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "حذف";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1134, 675);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "خاص";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 701);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العيادة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitsGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView patientsGridView;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox visitFeesTextBox;
        private System.Windows.Forms.TextBox visitComplaintTextBox;
        private System.Windows.Forms.DataGridView visitsGridView;
        private System.Windows.Forms.TextBox visitIDTextBox;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox visitTempTextBox;
        private System.Windows.Forms.TextBox visitBpTextBox;
        private System.Windows.Forms.TextBox visitPulseTextBox;
        private System.Windows.Forms.DateTimePicker visitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.TextBox visitDrugTextBox;
        private System.Windows.Forms.TextBox visitGeneralTextBox;
        private System.Windows.Forms.Button insertVisitBtn;
        private System.Windows.Forms.Button updateVisitBtn;
        private System.Windows.Forms.Button deleteVisitBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn complaint;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitID;
    }
}