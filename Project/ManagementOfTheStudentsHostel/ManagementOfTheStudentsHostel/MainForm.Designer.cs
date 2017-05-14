namespace ManagementOfTheStudentsHostel
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Students = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentsDetail = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.ShowPassord = new System.Windows.Forms.CheckBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreateAccountDateLbl = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.AccessLevelCB = new System.Windows.Forms.ComboBox();
            this.RoomNB = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FullNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NotesRTB = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CurrentAccountBtn = new System.Windows.Forms.LinkLabel();
            this.AccesLvlLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.RegistrationBtn = new System.Windows.Forms.LinkLabel();
            this.SaveChangesBtn = new System.Windows.Forms.LinkLabel();
            this.UsersListBS = new System.Windows.Forms.BindingSource(this.components);
            this.FullName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.AccessLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.StudentsDetail.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.PasswordPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomNB)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersListBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Students);
            this.tabControl1.Controls.Add(this.StudentsDetail);
            this.tabControl1.Location = new System.Drawing.Point(0, 7);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(733, 413);
            this.tabControl1.TabIndex = 0;
            // 
            // Students
            // 
            this.Students.Controls.Add(this.dataGridView1);
            this.Students.Location = new System.Drawing.Point(4, 22);
            this.Students.Name = "Students";
            this.Students.Padding = new System.Windows.Forms.Padding(3);
            this.Students.Size = new System.Drawing.Size(725, 387);
            this.Students.TabIndex = 0;
            this.Students.Text = "Студенты";
            this.Students.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.AccessLevel,
            this.Room,
            this.CreateDate,
            this.Login,
            this.Notes});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(719, 381);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StudentsDetail
            // 
            this.StudentsDetail.AutoScroll = true;
            this.StudentsDetail.Controls.Add(this.tableLayoutPanel2);
            this.StudentsDetail.Location = new System.Drawing.Point(4, 22);
            this.StudentsDetail.Name = "StudentsDetail";
            this.StudentsDetail.Padding = new System.Windows.Forms.Padding(3);
            this.StudentsDetail.Size = new System.Drawing.Size(725, 387);
            this.StudentsDetail.TabIndex = 1;
            this.StudentsDetail.Text = "Аккаунт";
            this.StudentsDetail.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.LoginPanel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.PasswordPanel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 7);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(679, 438);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPanel.AutoSize = true;
            this.LoginPanel.Controls.Add(this.LoginTB);
            this.LoginPanel.Controls.Add(this.label7);
            this.LoginPanel.Location = new System.Drawing.Point(3, 3);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(673, 63);
            this.LoginPanel.TabIndex = 18;
            this.LoginPanel.Visible = false;
            // 
            // LoginTB
            // 
            this.LoginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTB.Location = new System.Drawing.Point(80, 16);
            this.LoginTB.Margin = new System.Windows.Forms.Padding(3, 20, 20, 3);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(255, 29);
            this.LoginTB.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(-1, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Логин:";
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordPanel.AutoSize = true;
            this.PasswordPanel.Controls.Add(this.ShowPassord);
            this.PasswordPanel.Controls.Add(this.PasswordTB);
            this.PasswordPanel.Controls.Add(this.label8);
            this.PasswordPanel.Location = new System.Drawing.Point(3, 72);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(673, 66);
            this.PasswordPanel.TabIndex = 17;
            this.PasswordPanel.Visible = false;
            // 
            // ShowPassord
            // 
            this.ShowPassord.AutoSize = true;
            this.ShowPassord.Checked = true;
            this.ShowPassord.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowPassord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowPassord.Location = new System.Drawing.Point(358, 19);
            this.ShowPassord.Name = "ShowPassord";
            this.ShowPassord.Size = new System.Drawing.Size(117, 28);
            this.ShowPassord.TabIndex = 41;
            this.ShowPassord.Text = "Скрывать";
            this.ShowPassord.UseVisualStyleBackColor = true;
            this.ShowPassord.CheckedChanged += new System.EventHandler(this.ShowPassord_CheckedChanged);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTB.Location = new System.Drawing.Point(80, 18);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(3, 20, 20, 3);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(255, 29);
            this.PasswordTB.TabIndex = 20;
            this.PasswordTB.UseSystemPasswordChar = true;
            this.PasswordTB.TextChanged += new System.EventHandler(this.Account_EditChanget);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(-4, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Пароль:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CreateAccountDateLbl);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.AccessLevelCB);
            this.panel1.Controls.Add(this.RoomNB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.FullNameTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NotesRTB);
            this.panel1.Location = new System.Drawing.Point(3, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 291);
            this.panel1.TabIndex = 15;
            // 
            // CreateAccountDateLbl
            // 
            this.CreateAccountDateLbl.AutoSize = true;
            this.CreateAccountDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateAccountDateLbl.Location = new System.Drawing.Point(287, 119);
            this.CreateAccountDateLbl.Margin = new System.Windows.Forms.Padding(20, 20, 3, 20);
            this.CreateAccountDateLbl.Name = "CreateAccountDateLbl";
            this.CreateAccountDateLbl.Size = new System.Drawing.Size(180, 24);
            this.CreateAccountDateLbl.TabIndex = 22;
            this.CreateAccountDateLbl.Text = "Дата регистрации:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Location = new System.Drawing.Point(473, 115);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker2.TabIndex = 21;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.Account_EditChanget);
            // 
            // AccessLevelCB
            // 
            this.AccessLevelCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccessLevelCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccessLevelCB.Items.AddRange(new object[] {
            "Студент",
            "Модератор",
            "Администратор"});
            this.AccessLevelCB.Location = new System.Drawing.Point(341, 67);
            this.AccessLevelCB.Name = "AccessLevelCB";
            this.AccessLevelCB.Size = new System.Drawing.Size(332, 32);
            this.AccessLevelCB.TabIndex = 20;
            this.AccessLevelCB.SelectedValueChanged += new System.EventHandler(this.Account_EditChanget);
            // 
            // RoomNB
            // 
            this.RoomNB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomNB.Location = new System.Drawing.Point(158, 68);
            this.RoomNB.Maximum = new decimal(new int[] {
            1299,
            0,
            0,
            0});
            this.RoomNB.Name = "RoomNB";
            this.RoomNB.Size = new System.Drawing.Size(77, 29);
            this.RoomNB.TabIndex = 19;
            this.RoomNB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RoomNB.ValueChanged += new System.EventHandler(this.Account_EditChanget);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(-4, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(20, 20, 3, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Номер комнаты:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(258, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(20, 20, 3, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Статус:";
            // 
            // FullNameTB
            // 
            this.FullNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameTB.Location = new System.Drawing.Point(80, 17);
            this.FullNameTB.Margin = new System.Windows.Forms.Padding(3, 20, 20, 3);
            this.FullNameTB.Name = "FullNameTB";
            this.FullNameTB.Size = new System.Drawing.Size(593, 29);
            this.FullNameTB.TabIndex = 16;
            this.FullNameTB.Text = "Игорь михайловский\r\n";
            this.FullNameTB.TextChanged += new System.EventHandler(this.Account_EditChanget);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-2, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "ФИО:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Заметки:";
            // 
            // NotesRTB
            // 
            this.NotesRTB.Location = new System.Drawing.Point(0, 194);
            this.NotesRTB.Margin = new System.Windows.Forms.Padding(20);
            this.NotesRTB.Name = "NotesRTB";
            this.NotesRTB.Size = new System.Drawing.Size(669, 97);
            this.NotesRTB.TabIndex = 11;
            this.NotesRTB.Text = "";
            this.NotesRTB.TextChanged += new System.EventHandler(this.Account_EditChanget);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.CurrentAccountBtn, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.AccesLvlLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.FullNameLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.RegistrationBtn, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.SaveChangesBtn, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(733, 28);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // CurrentAccountBtn
            // 
            this.CurrentAccountBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CurrentAccountBtn.AutoSize = true;
            this.CurrentAccountBtn.Location = new System.Drawing.Point(677, 7);
            this.CurrentAccountBtn.Name = "CurrentAccountBtn";
            this.CurrentAccountBtn.Size = new System.Drawing.Size(53, 13);
            this.CurrentAccountBtn.TabIndex = 2;
            this.CurrentAccountBtn.TabStop = true;
            this.CurrentAccountBtn.Text = "Профиль";
            this.CurrentAccountBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // AccesLvlLabel
            // 
            this.AccesLvlLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AccesLvlLabel.AutoSize = true;
            this.AccesLvlLabel.Location = new System.Drawing.Point(136, 7);
            this.AccesLvlLabel.Name = "AccesLvlLabel";
            this.AccesLvlLabel.Size = new System.Drawing.Size(41, 13);
            this.AccesLvlLabel.TabIndex = 4;
            this.AccesLvlLabel.Text = "Статус";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Статус:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(46, 7);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(34, 13);
            this.FullNameLabel.TabIndex = 3;
            this.FullNameLabel.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(591, 7);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Пользователи";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // RegistrationBtn
            // 
            this.RegistrationBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RegistrationBtn.AutoSize = true;
            this.RegistrationBtn.Location = new System.Drawing.Point(465, 7);
            this.RegistrationBtn.Name = "RegistrationBtn";
            this.RegistrationBtn.Size = new System.Drawing.Size(120, 13);
            this.RegistrationBtn.TabIndex = 12;
            this.RegistrationBtn.TabStop = true;
            this.RegistrationBtn.Text = "Регистрация студента";
            this.RegistrationBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegistrationBtn_LinkClicked);
            // 
            // SaveChangesBtn
            // 
            this.SaveChangesBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SaveChangesBtn.AutoSize = true;
            this.SaveChangesBtn.Location = new System.Drawing.Point(399, 7);
            this.SaveChangesBtn.Name = "SaveChangesBtn";
            this.SaveChangesBtn.Size = new System.Drawing.Size(60, 13);
            this.SaveChangesBtn.TabIndex = 11;
            this.SaveChangesBtn.TabStop = true;
            this.SaveChangesBtn.Text = "Сохранить";
            this.SaveChangesBtn.Visible = false;
            this.SaveChangesBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SaveChangesBtn_LinkClicked);
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "ФИО";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AccessLevel
            // 
            this.AccessLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AccessLevel.DataPropertyName = "AccessLevelString";
            this.AccessLevel.HeaderText = "Статус";
            this.AccessLevel.Name = "AccessLevel";
            this.AccessLevel.ReadOnly = true;
            this.AccessLevel.Width = 66;
            // 
            // Room
            // 
            this.Room.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Room.DataPropertyName = "Room";
            this.Room.HeaderText = "Комната";
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            this.Room.Width = 76;
            // 
            // CreateDate
            // 
            this.CreateDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "Дата регистрации";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            this.CreateDate.Width = 114;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            this.Login.Visible = false;
            // 
            // Notes
            // 
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.Visible = false;
            // 
            // userClassBindingSource
            // 
            this.userClassBindingSource.DataSource = typeof(ManagementOfTheStudentsHostel.UserClass);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 419);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Учет и регистрация студентов в общежитии";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.Students.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.StudentsDetail.ResumeLayout(false);
            this.StudentsDetail.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomNB)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersListBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userClassBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Students;
        private System.Windows.Forms.TabPage StudentsDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label AccesLvlLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel CurrentAccountBtn;
        private System.Windows.Forms.LinkLabel SaveChangesBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox NotesRTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource userClassBindingSource;
        private System.Windows.Forms.BindingSource UsersListBS;
        private System.Windows.Forms.LinkLabel RegistrationBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel PasswordPanel;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CreateAccountDateLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox AccessLevelCB;
        private System.Windows.Forms.NumericUpDown RoomNB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FullNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ShowPassord;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewLinkColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
    }
}