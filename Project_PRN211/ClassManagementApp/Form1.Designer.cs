namespace ClassManagementApp
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.btnEditClass = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.cbLecturer = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.txtGName = new System.Windows.Forms.TextBox();
            this.txtGID = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbLecturer = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.lbGName = new System.Windows.Forms.Label();
            this.lbGID = new System.Windows.Forms.Label();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLDelete = new System.Windows.Forms.Button();
            this.btnLEdit = new System.Windows.Forms.Button();
            this.btnLAdd = new System.Windows.Forms.Button();
            this.dateLDOB = new System.Windows.Forms.DateTimePicker();
            this.rbLFemale = new System.Windows.Forms.RadioButton();
            this.rbLMale = new System.Windows.Forms.RadioButton();
            this.txtLEmail = new System.Windows.Forms.TextBox();
            this.txtLAddress = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtLID = new System.Windows.Forms.TextBox();
            this.lbLEmail = new System.Windows.Forms.Label();
            this.lbLDOB = new System.Windows.Forms.Label();
            this.lbLAddress = new System.Windows.Forms.Label();
            this.lbLGender = new System.Windows.Forms.Label();
            this.lbLName = new System.Windows.Forms.Label();
            this.lbLID = new System.Windows.Forms.Label();
            this.dgvLecturer = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.dateDob = new System.Windows.Forms.DateTimePicker();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbDOB = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbSGender = new System.Windows.Forms.Label();
            this.lbSName = new System.Windows.Forms.Label();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturer)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1056, 662);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDeleteClass);
            this.tabPage1.Controls.Add(this.btnEditClass);
            this.tabPage1.Controls.Add(this.btnAddClass);
            this.tabPage1.Controls.Add(this.cbLecturer);
            this.tabPage1.Controls.Add(this.cbStatus);
            this.tabPage1.Controls.Add(this.cbSubject);
            this.tabPage1.Controls.Add(this.txtGName);
            this.tabPage1.Controls.Add(this.txtGID);
            this.tabPage1.Controls.Add(this.lbStatus);
            this.tabPage1.Controls.Add(this.lbLecturer);
            this.tabPage1.Controls.Add(this.lbSubject);
            this.tabPage1.Controls.Add(this.lbGName);
            this.tabPage1.Controls.Add(this.lbGID);
            this.tabPage1.Controls.Add(this.dgvClass);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1048, 629);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Class Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Location = new System.Drawing.Point(747, 220);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(94, 29);
            this.btnDeleteClass.TabIndex = 13;
            this.btnDeleteClass.Text = "Delete";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // btnEditClass
            // 
            this.btnEditClass.Location = new System.Drawing.Point(498, 220);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(94, 29);
            this.btnEditClass.TabIndex = 12;
            this.btnEditClass.Text = "Edit";
            this.btnEditClass.UseVisualStyleBackColor = true;
            this.btnEditClass.Click += new System.EventHandler(this.btnEditClass_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(191, 221);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(94, 29);
            this.btnAddClass.TabIndex = 11;
            this.btnAddClass.Text = "Add";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // cbLecturer
            // 
            this.cbLecturer.FormattingEnabled = true;
            this.cbLecturer.Location = new System.Drawing.Point(669, 99);
            this.cbLecturer.Name = "cbLecturer";
            this.cbLecturer.Size = new System.Drawing.Size(250, 28);
            this.cbLecturer.TabIndex = 10;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(188, 158);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(250, 28);
            this.cbStatus.TabIndex = 9;
            // 
            // cbSubject
            // 
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(188, 91);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(250, 28);
            this.cbSubject.TabIndex = 8;
            // 
            // txtGName
            // 
            this.txtGName.Location = new System.Drawing.Point(669, 38);
            this.txtGName.Name = "txtGName";
            this.txtGName.Size = new System.Drawing.Size(250, 27);
            this.txtGName.TabIndex = 7;
            this.txtGName.Validating += new System.ComponentModel.CancelEventHandler(this.txtGName_Validating);
            // 
            // txtGID
            // 
            this.txtGID.Location = new System.Drawing.Point(188, 31);
            this.txtGID.Name = "txtGID";
            this.txtGID.Size = new System.Drawing.Size(250, 27);
            this.txtGID.TabIndex = 6;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(72, 158);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(49, 20);
            this.lbStatus.TabIndex = 5;
            this.lbStatus.Text = "Status";
            // 
            // lbLecturer
            // 
            this.lbLecturer.AutoSize = true;
            this.lbLecturer.Location = new System.Drawing.Point(530, 99);
            this.lbLecturer.Name = "lbLecturer";
            this.lbLecturer.Size = new System.Drawing.Size(62, 20);
            this.lbLecturer.TabIndex = 4;
            this.lbLecturer.Text = "Lecturer";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(72, 99);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(58, 20);
            this.lbSubject.TabIndex = 3;
            this.lbSubject.Text = "Subject";
            // 
            // lbGName
            // 
            this.lbGName.AutoSize = true;
            this.lbGName.Location = new System.Drawing.Point(530, 38);
            this.lbGName.Name = "lbGName";
            this.lbGName.Size = new System.Drawing.Size(90, 20);
            this.lbGName.TabIndex = 2;
            this.lbGName.Text = "GroupName";
            // 
            // lbGID
            // 
            this.lbGID.AutoSize = true;
            this.lbGID.Location = new System.Drawing.Point(72, 38);
            this.lbGID.Name = "lbGID";
            this.lbGID.Size = new System.Drawing.Size(65, 20);
            this.lbGID.TabIndex = 1;
            this.lbGID.Text = "GroupID";
            // 
            // dgvClass
            // 
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Location = new System.Drawing.Point(25, 255);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.RowHeadersWidth = 51;
            this.dgvClass.RowTemplate.Height = 29;
            this.dgvClass.Size = new System.Drawing.Size(998, 355);
            this.dgvClass.TabIndex = 0;
            this.dgvClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLDelete);
            this.tabPage2.Controls.Add(this.btnLEdit);
            this.tabPage2.Controls.Add(this.btnLAdd);
            this.tabPage2.Controls.Add(this.dateLDOB);
            this.tabPage2.Controls.Add(this.rbLFemale);
            this.tabPage2.Controls.Add(this.rbLMale);
            this.tabPage2.Controls.Add(this.txtLEmail);
            this.tabPage2.Controls.Add(this.txtLAddress);
            this.tabPage2.Controls.Add(this.txtLName);
            this.tabPage2.Controls.Add(this.txtLID);
            this.tabPage2.Controls.Add(this.lbLEmail);
            this.tabPage2.Controls.Add(this.lbLDOB);
            this.tabPage2.Controls.Add(this.lbLAddress);
            this.tabPage2.Controls.Add(this.lbLGender);
            this.tabPage2.Controls.Add(this.lbLName);
            this.tabPage2.Controls.Add(this.lbLID);
            this.tabPage2.Controls.Add(this.dgvLecturer);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1048, 629);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lecturer Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLDelete
            // 
            this.btnLDelete.Location = new System.Drawing.Point(752, 308);
            this.btnLDelete.Name = "btnLDelete";
            this.btnLDelete.Size = new System.Drawing.Size(94, 29);
            this.btnLDelete.TabIndex = 16;
            this.btnLDelete.Text = "Delete";
            this.btnLDelete.UseVisualStyleBackColor = true;
            this.btnLDelete.Click += new System.EventHandler(this.btnLDelete_Click);
            // 
            // btnLEdit
            // 
            this.btnLEdit.Location = new System.Drawing.Point(477, 308);
            this.btnLEdit.Name = "btnLEdit";
            this.btnLEdit.Size = new System.Drawing.Size(94, 29);
            this.btnLEdit.TabIndex = 15;
            this.btnLEdit.Text = "Edit";
            this.btnLEdit.UseVisualStyleBackColor = true;
            this.btnLEdit.Click += new System.EventHandler(this.btnLEdit_Click);
            // 
            // btnLAdd
            // 
            this.btnLAdd.Location = new System.Drawing.Point(257, 308);
            this.btnLAdd.Name = "btnLAdd";
            this.btnLAdd.Size = new System.Drawing.Size(94, 29);
            this.btnLAdd.TabIndex = 14;
            this.btnLAdd.Text = "Add";
            this.btnLAdd.UseVisualStyleBackColor = true;
            this.btnLAdd.Click += new System.EventHandler(this.btnLAdd_Click);
            // 
            // dateLDOB
            // 
            this.dateLDOB.Location = new System.Drawing.Point(194, 224);
            this.dateLDOB.Name = "dateLDOB";
            this.dateLDOB.Size = new System.Drawing.Size(274, 27);
            this.dateLDOB.TabIndex = 13;
            // 
            // rbLFemale
            // 
            this.rbLFemale.AutoSize = true;
            this.rbLFemale.Location = new System.Drawing.Point(351, 128);
            this.rbLFemale.Name = "rbLFemale";
            this.rbLFemale.Size = new System.Drawing.Size(78, 24);
            this.rbLFemale.TabIndex = 12;
            this.rbLFemale.TabStop = true;
            this.rbLFemale.Text = "Female";
            this.rbLFemale.UseVisualStyleBackColor = true;
            // 
            // rbLMale
            // 
            this.rbLMale.AutoSize = true;
            this.rbLMale.Location = new System.Drawing.Point(194, 128);
            this.rbLMale.Name = "rbLMale";
            this.rbLMale.Size = new System.Drawing.Size(63, 24);
            this.rbLMale.TabIndex = 11;
            this.rbLMale.TabStop = true;
            this.rbLMale.Text = "Male";
            this.rbLMale.UseVisualStyleBackColor = true;
            // 
            // txtLEmail
            // 
            this.txtLEmail.Location = new System.Drawing.Point(692, 221);
            this.txtLEmail.Name = "txtLEmail";
            this.txtLEmail.Size = new System.Drawing.Size(274, 27);
            this.txtLEmail.TabIndex = 10;
            this.txtLEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtLEmail_Validating);
            // 
            // txtLAddress
            // 
            this.txtLAddress.Location = new System.Drawing.Point(692, 123);
            this.txtLAddress.Name = "txtLAddress";
            this.txtLAddress.Size = new System.Drawing.Size(274, 27);
            this.txtLAddress.TabIndex = 9;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(692, 34);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(274, 27);
            this.txtLName.TabIndex = 8;
            // 
            // txtLID
            // 
            this.txtLID.Location = new System.Drawing.Point(194, 34);
            this.txtLID.Name = "txtLID";
            this.txtLID.Size = new System.Drawing.Size(274, 27);
            this.txtLID.TabIndex = 7;
            // 
            // lbLEmail
            // 
            this.lbLEmail.AutoSize = true;
            this.lbLEmail.Location = new System.Drawing.Point(550, 224);
            this.lbLEmail.Name = "lbLEmail";
            this.lbLEmail.Size = new System.Drawing.Size(46, 20);
            this.lbLEmail.TabIndex = 6;
            this.lbLEmail.Text = "Email";
            // 
            // lbLDOB
            // 
            this.lbLDOB.AutoSize = true;
            this.lbLDOB.Location = new System.Drawing.Point(53, 224);
            this.lbLDOB.Name = "lbLDOB";
            this.lbLDOB.Size = new System.Drawing.Size(40, 20);
            this.lbLDOB.TabIndex = 5;
            this.lbLDOB.Text = "DOB";
            // 
            // lbLAddress
            // 
            this.lbLAddress.AutoSize = true;
            this.lbLAddress.Location = new System.Drawing.Point(550, 123);
            this.lbLAddress.Name = "lbLAddress";
            this.lbLAddress.Size = new System.Drawing.Size(62, 20);
            this.lbLAddress.TabIndex = 4;
            this.lbLAddress.Text = "Address";
            // 
            // lbLGender
            // 
            this.lbLGender.AutoSize = true;
            this.lbLGender.Location = new System.Drawing.Point(53, 123);
            this.lbLGender.Name = "lbLGender";
            this.lbLGender.Size = new System.Drawing.Size(57, 20);
            this.lbLGender.TabIndex = 3;
            this.lbLGender.Text = "Gender";
            // 
            // lbLName
            // 
            this.lbLName.AutoSize = true;
            this.lbLName.Location = new System.Drawing.Point(550, 41);
            this.lbLName.Name = "lbLName";
            this.lbLName.Size = new System.Drawing.Size(102, 20);
            this.lbLName.TabIndex = 2;
            this.lbLName.Text = "LecturerName";
            // 
            // lbLID
            // 
            this.lbLID.AutoSize = true;
            this.lbLID.Location = new System.Drawing.Point(53, 41);
            this.lbLID.Name = "lbLID";
            this.lbLID.Size = new System.Drawing.Size(77, 20);
            this.lbLID.TabIndex = 1;
            this.lbLID.Text = "LecturerID";
            // 
            // dgvLecturer
            // 
            this.dgvLecturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLecturer.Location = new System.Drawing.Point(39, 348);
            this.dgvLecturer.Name = "dgvLecturer";
            this.dgvLecturer.RowHeadersWidth = 51;
            this.dgvLecturer.RowTemplate.Height = 29;
            this.dgvLecturer.Size = new System.Drawing.Size(972, 265);
            this.dgvLecturer.TabIndex = 0;
            this.dgvLecturer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLecturer_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Controls.Add(this.btnEdit);
            this.tabPage3.Controls.Add(this.btnAdd);
            this.tabPage3.Controls.Add(this.dgvStudent);
            this.tabPage3.Controls.Add(this.dateDob);
            this.tabPage3.Controls.Add(this.rbFemale);
            this.tabPage3.Controls.Add(this.rbMale);
            this.tabPage3.Controls.Add(this.txtEmail);
            this.tabPage3.Controls.Add(this.txtAddress);
            this.tabPage3.Controls.Add(this.txtName);
            this.tabPage3.Controls.Add(this.txtID);
            this.tabPage3.Controls.Add(this.lbEmail);
            this.tabPage3.Controls.Add(this.lbDOB);
            this.tabPage3.Controls.Add(this.lbAddress);
            this.tabPage3.Controls.Add(this.lbSGender);
            this.tabPage3.Controls.Add(this.lbSName);
            this.tabPage3.Controls.Add(this.lbStudentID);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1048, 629);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Student Management";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(736, 284);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(469, 284);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 29);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(201, 284);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(31, 328);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 29;
            this.dgvStudent.Size = new System.Drawing.Size(984, 279);
            this.dgvStudent.TabIndex = 27;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // dateDob
            // 
            this.dateDob.Location = new System.Drawing.Point(190, 231);
            this.dateDob.Name = "dateDob";
            this.dateDob.Size = new System.Drawing.Size(274, 27);
            this.dateDob.TabIndex = 26;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(347, 135);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(78, 24);
            this.rbFemale.TabIndex = 25;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(190, 135);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(63, 24);
            this.rbMale.TabIndex = 24;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(688, 228);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(274, 27);
            this.txtEmail.TabIndex = 23;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(688, 130);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(274, 27);
            this.txtAddress.TabIndex = 22;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(688, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(274, 27);
            this.txtName.TabIndex = 21;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(190, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(274, 27);
            this.txtID.TabIndex = 20;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(546, 231);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 19;
            this.lbEmail.Text = "Email";
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.Location = new System.Drawing.Point(49, 231);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(40, 20);
            this.lbDOB.TabIndex = 18;
            this.lbDOB.Text = "DOB";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(546, 130);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(62, 20);
            this.lbAddress.TabIndex = 17;
            this.lbAddress.Text = "Address";
            // 
            // lbSGender
            // 
            this.lbSGender.AutoSize = true;
            this.lbSGender.Location = new System.Drawing.Point(49, 130);
            this.lbSGender.Name = "lbSGender";
            this.lbSGender.Size = new System.Drawing.Size(57, 20);
            this.lbSGender.TabIndex = 16;
            this.lbSGender.Text = "Gender";
            // 
            // lbSName
            // 
            this.lbSName.AutoSize = true;
            this.lbSName.Location = new System.Drawing.Point(546, 48);
            this.lbSName.Name = "lbSName";
            this.lbSName.Size = new System.Drawing.Size(100, 20);
            this.lbSName.TabIndex = 15;
            this.lbSName.Text = "StudentName";
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Location = new System.Drawing.Point(49, 48);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(75, 20);
            this.lbStudentID.TabIndex = 14;
            this.lbStudentID.Text = "StudentID";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 703);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturer)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvClass;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ComboBox cbLecturer;
        private ComboBox cbStatus;
        private ComboBox cbSubject;
        private TextBox txtGName;
        private TextBox txtGID;
        private Label lbStatus;
        private Label lbLecturer;
        private Label lbSubject;
        private Label lbGName;
        private Label lbGID;
        private Button btnDeleteClass;
        private Button btnEditClass;
        private Button btnAddClass;
        private DataGridView dgvLecturer;
        private DateTimePicker dateLDOB;
        private RadioButton rbLFemale;
        private RadioButton rbLMale;
        private TextBox txtLEmail;
        private TextBox txtLAddress;
        private TextBox txtLName;
        private TextBox txtLID;
        private Label lbLEmail;
        private Label lbLDOB;
        private Label lbLAddress;
        private Label lbLGender;
        private Label lbLName;
        private Label lbLID;
        private Button btnLDelete;
        private Button btnLEdit;
        private Button btnLAdd;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dgvStudent;
        private DateTimePicker dateDob;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtName;
        private TextBox txtID;
        private Label lbEmail;
        private Label lbDOB;
        private Label lbAddress;
        private Label lbSGender;
        private Label lbSName;
        private Label lbStudentID;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider1;
    }
}