namespace Urgent_Manager.View.DashBoard
{
    partial class User
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gtxtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.gradientPanel1 = new Urgent_Manager.CustomViews.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.icEyes = new FontAwesome.Sharp.IconPictureBox();
            this.gtxtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.gtxtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.cmbRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbArea = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.chUpdate = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.MCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icEyes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gtxtUsername
            // 
            this.gtxtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gtxtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtUsername.BorderRadius = 20;
            this.gtxtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtUsername.DefaultText = "";
            this.gtxtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gtxtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxtUsername.ForeColor = System.Drawing.Color.White;
            this.gtxtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtUsername.Location = new System.Drawing.Point(174, 88);
            this.gtxtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtUsername.Name = "gtxtUsername";
            this.gtxtUsername.PasswordChar = '\0';
            this.gtxtUsername.PlaceholderText = "User Name";
            this.gtxtUsername.SelectedText = "";
            this.gtxtUsername.Size = new System.Drawing.Size(240, 41);
            this.gtxtUsername.TabIndex = 0;
            this.gtxtUsername.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(78, 100);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(94, 18);
            this.lblUsername.TabIndex = 24;
            this.lblUsername.Text = "UserName : ";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(120)))));
            this.gradientPanel1.Location = new System.Drawing.Point(0, 40);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(881, 2);
            this.gradientPanel1.TabIndex = 26;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 40);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(865, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = " User\'s Credentials";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPass
            // 
            this.lblPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(423, 100);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(89, 18);
            this.lblPass.TabIndex = 28;
            this.lblPass.Text = "Password : ";
            // 
            // icEyes
            // 
            this.icEyes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.icEyes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.icEyes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icEyes.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.icEyes.IconColor = System.Drawing.Color.White;
            this.icEyes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icEyes.IconSize = 35;
            this.icEyes.Location = new System.Drawing.Point(765, 91);
            this.icEyes.Name = "icEyes";
            this.icEyes.Size = new System.Drawing.Size(32, 32);
            this.icEyes.TabIndex = 30;
            this.icEyes.TabStop = false;
            this.icEyes.Click += new System.EventHandler(this.icEyes_Click);
            // 
            // gtxtPass
            // 
            this.gtxtPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gtxtPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtPass.BorderRadius = 20;
            this.gtxtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtPass.DefaultText = "";
            this.gtxtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gtxtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxtPass.ForeColor = System.Drawing.Color.White;
            this.gtxtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtPass.Location = new System.Drawing.Point(522, 88);
            this.gtxtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtPass.Name = "gtxtPass";
            this.gtxtPass.PasswordChar = '●';
            this.gtxtPass.PlaceholderText = "Password";
            this.gtxtPass.SelectedText = "";
            this.gtxtPass.Size = new System.Drawing.Size(240, 41);
            this.gtxtPass.TabIndex = 1;
            this.gtxtPass.TextOffset = new System.Drawing.Point(20, 0);
            this.gtxtPass.UseSystemPasswordChar = true;
            // 
            // lblRole
            // 
            this.lblRole.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(423, 160);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(103, 18);
            this.lblRole.TabIndex = 34;
            this.lblRole.Text = "User\'s Role : ";
            // 
            // gtxtFullName
            // 
            this.gtxtFullName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gtxtFullName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gtxtFullName.BorderRadius = 20;
            this.gtxtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtFullName.DefaultText = "";
            this.gtxtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtFullName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gtxtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxtFullName.ForeColor = System.Drawing.Color.White;
            this.gtxtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtFullName.Location = new System.Drawing.Point(174, 148);
            this.gtxtFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxtFullName.Name = "gtxtFullName";
            this.gtxtFullName.PasswordChar = '\0';
            this.gtxtFullName.PlaceholderText = "Full Name";
            this.gtxtFullName.SelectedText = "";
            this.gtxtFullName.Size = new System.Drawing.Size(240, 41);
            this.gtxtFullName.TabIndex = 2;
            this.gtxtFullName.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.White;
            this.lblFullName.Location = new System.Drawing.Point(78, 160);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(90, 18);
            this.lblFullName.TabIndex = 33;
            this.lblFullName.Text = "Full Name : ";
            // 
            // cmbRole
            // 
            this.cmbRole.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbRole.BackColor = System.Drawing.Color.Transparent;
            this.cmbRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.cmbRole.BorderRadius = 20;
            this.cmbRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRole.ForeColor = System.Drawing.Color.White;
            this.cmbRole.ItemHeight = 35;
            this.cmbRole.Items.AddRange(new object[] {
            "Administrateur",
            "Operateur",
            "Alimentation",
            "Optimisateur",
            "Agent de Saisie",
            "Shift Leader"});
            this.cmbRole.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.cmbRole.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.cmbRole.Location = new System.Drawing.Point(522, 148);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(240, 41);
            this.cmbRole.TabIndex = 3;
            this.cmbRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbArea
            // 
            this.cmbArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbArea.BackColor = System.Drawing.Color.Transparent;
            this.cmbArea.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.cmbArea.BorderRadius = 20;
            this.cmbArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbArea.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbArea.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbArea.ForeColor = System.Drawing.Color.White;
            this.cmbArea.ItemHeight = 35;
            this.cmbArea.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.cmbArea.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.cmbArea.Location = new System.Drawing.Point(174, 212);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(240, 41);
            this.cmbArea.TabIndex = 4;
            this.cmbArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblArea
            // 
            this.lblArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.White;
            this.lblArea.Location = new System.Drawing.Point(78, 224);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(52, 18);
            this.lblArea.TabIndex = 36;
            this.lblArea.Text = "Area : ";
            // 
            // chUpdate
            // 
            this.chUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chUpdate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chUpdate.CheckedState.BorderRadius = 2;
            this.chUpdate.CheckedState.BorderThickness = 0;
            this.chUpdate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.chUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chUpdate.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chUpdate.ForeColor = System.Drawing.Color.White;
            this.chUpdate.Location = new System.Drawing.Point(440, 224);
            this.chUpdate.Name = "chUpdate";
            this.chUpdate.Size = new System.Drawing.Size(130, 22);
            this.chUpdate.TabIndex = 5;
            this.chUpdate.Text = "Is Updated";
            this.chUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chUpdate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chUpdate.UncheckedState.BorderRadius = 2;
            this.chUpdate.UncheckedState.BorderThickness = 0;
            this.chUpdate.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 25;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MCName,
            this.MCType,
            this.MCZone,
            this.Section,
            this.GReference,
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(81, 282);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(716, 221);
            this.guna2DataGridView1.TabIndex = 6;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.guna2DataGridView1;
            // 
            // MCName
            // 
            this.MCName.HeaderText = "User Name";
            this.MCName.Name = "MCName";
            // 
            // MCType
            // 
            this.MCType.HeaderText = "Password";
            this.MCType.Name = "MCType";
            // 
            // MCZone
            // 
            this.MCZone.HeaderText = "Full Name";
            this.MCZone.Name = "MCZone";
            // 
            // Section
            // 
            this.Section.HeaderText = "User\'s Role";
            this.Section.Name = "Section";
            // 
            // GReference
            // 
            this.GReference.HeaderText = "Is Updated";
            this.GReference.Name = "GReference";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Entry Agent";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(865, 564);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.chUpdate);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.gtxtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.gtxtPass);
            this.Controls.Add(this.icEyes);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gtxtUsername);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.Text = "User";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icEyes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox gtxtUsername;
        private System.Windows.Forms.Label lblUsername;
        private CustomViews.GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPass;
        private FontAwesome.Sharp.IconPictureBox icEyes;
        private Guna.UI2.WinForms.Guna2TextBox gtxtPass;
        private System.Windows.Forms.Label lblRole;
        private Guna.UI2.WinForms.Guna2TextBox gtxtFullName;
        private System.Windows.Forms.Label lblFullName;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRole;
        private Guna.UI2.WinForms.Guna2ComboBox cmbArea;
        private System.Windows.Forms.Label lblArea;
        private Guna.UI2.WinForms.Guna2CheckBox chUpdate;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCZone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn GReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}