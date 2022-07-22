namespace Urgent_Manager.View.OptimaisationWindows
{
    partial class UrgentManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cmbMac = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnUrgentDelete = new Guna.UI2.WinForms.Guna2Button();
            this.icExport = new FontAwesome.Sharp.IconButton();
            this.gtxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.icPrint = new FontAwesome.Sharp.IconButton();
            this.Famille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeadCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emplacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateUrgent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alimentation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
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
            this.guna2DataGridView1.ColumnHeadersHeight = 45;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Famille,
            this.Unico,
            this.LeadCode,
            this.Emplacement,
            this.Machine,
            this.Zone,
            this.DateUrgent,
            this.Status,
            this.Alimentation});
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
            this.guna2DataGridView1.Location = new System.Drawing.Point(23, 81);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.guna2DataGridView1.RowTemplate.Height = 45;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(909, 427);
            this.guna2DataGridView1.TabIndex = 3;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 45;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 45;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(660, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 2);
            this.panel1.TabIndex = 6;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.guna2DataGridView1;
            // 
            // cmbMac
            // 
            this.cmbMac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMac.BackColor = System.Drawing.Color.Transparent;
            this.cmbMac.BorderColor = System.Drawing.Color.White;
            this.cmbMac.BorderRadius = 15;
            this.cmbMac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMac.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMac.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmbMac.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMac.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMac.ForeColor = System.Drawing.Color.White;
            this.cmbMac.ItemHeight = 30;
            this.cmbMac.Items.AddRange(new object[] {
            "M01",
            "M02",
            "M03"});
            this.cmbMac.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.cmbMac.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.cmbMac.Location = new System.Drawing.Point(522, 23);
            this.cmbMac.Name = "cmbMac";
            this.cmbMac.Size = new System.Drawing.Size(109, 36);
            this.cmbMac.TabIndex = 1;
            this.cmbMac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUrgentDelete
            // 
            this.btnUrgentDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrgentDelete.BorderRadius = 20;
            this.btnUrgentDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrgentDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUrgentDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUrgentDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUrgentDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUrgentDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.btnUrgentDelete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnUrgentDelete.ForeColor = System.Drawing.Color.White;
            this.btnUrgentDelete.Image = global::Urgent_Manager.Properties.Resources.check;
            this.btnUrgentDelete.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUrgentDelete.IndicateFocus = true;
            this.btnUrgentDelete.Location = new System.Drawing.Point(375, 21);
            this.btnUrgentDelete.Name = "btnUrgentDelete";
            this.btnUrgentDelete.Size = new System.Drawing.Size(126, 40);
            this.btnUrgentDelete.TabIndex = 2;
            this.btnUrgentDelete.Text = "Finish";
            this.btnUrgentDelete.Click += new System.EventHandler(this.btnUrgentDelete_Click);
            // 
            // icExport
            // 
            this.icExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icExport.FlatAppearance.BorderSize = 0;
            this.icExport.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.icExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.icExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.icExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icExport.ForeColor = System.Drawing.Color.White;
            this.icExport.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.icExport.IconColor = System.Drawing.Color.White;
            this.icExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icExport.IconSize = 40;
            this.icExport.Location = new System.Drawing.Point(312, 25);
            this.icExport.Name = "icExport";
            this.icExport.Size = new System.Drawing.Size(45, 38);
            this.icExport.TabIndex = 3;
            this.icExport.UseVisualStyleBackColor = true;
            // 
            // gtxtSearch
            // 
            this.gtxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gtxtSearch.BorderRadius = 15;
            this.gtxtSearch.BorderThickness = 0;
            this.gtxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxtSearch.DefaultText = "";
            this.gtxtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gtxtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gtxtSearch.ForeColor = System.Drawing.Color.White;
            this.gtxtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxtSearch.IconLeft = global::Urgent_Manager.Properties.Resources.search;
            this.gtxtSearch.Location = new System.Drawing.Point(655, 21);
            this.gtxtSearch.Name = "gtxtSearch";
            this.gtxtSearch.PasswordChar = '\0';
            this.gtxtSearch.PlaceholderForeColor = System.Drawing.Color.White;
            this.gtxtSearch.PlaceholderText = "Search";
            this.gtxtSearch.SelectedText = "";
            this.gtxtSearch.Size = new System.Drawing.Size(272, 36);
            this.gtxtSearch.TabIndex = 0;
            this.gtxtSearch.TextOffset = new System.Drawing.Point(10, 0);
            this.gtxtSearch.TextChanged += new System.EventHandler(this.gtxtSearch_TextChanged);
            // 
            // icPrint
            // 
            this.icPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icPrint.FlatAppearance.BorderSize = 0;
            this.icPrint.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.icPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.icPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.icPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icPrint.ForeColor = System.Drawing.Color.White;
            this.icPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.icPrint.IconColor = System.Drawing.Color.White;
            this.icPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icPrint.IconSize = 40;
            this.icPrint.Location = new System.Drawing.Point(261, 25);
            this.icPrint.Name = "icPrint";
            this.icPrint.Size = new System.Drawing.Size(45, 38);
            this.icPrint.TabIndex = 7;
            this.icPrint.UseVisualStyleBackColor = true;
            // 
            // Famille
            // 
            this.Famille.HeaderText = "Family";
            this.Famille.Name = "Famille";
            this.Famille.ReadOnly = true;
            // 
            // Unico
            // 
            this.Unico.HeaderText = "Unico";
            this.Unico.Name = "Unico";
            this.Unico.ReadOnly = true;
            // 
            // LeadCode
            // 
            this.LeadCode.HeaderText = "Lead Code";
            this.LeadCode.Name = "LeadCode";
            this.LeadCode.ReadOnly = true;
            // 
            // Emplacement
            // 
            this.Emplacement.HeaderText = "Location";
            this.Emplacement.Name = "Emplacement";
            this.Emplacement.ReadOnly = true;
            // 
            // Machine
            // 
            this.Machine.HeaderText = "Machine";
            this.Machine.Name = "Machine";
            this.Machine.ReadOnly = true;
            // 
            // Zone
            // 
            this.Zone.HeaderText = "Area";
            this.Zone.Name = "Zone";
            this.Zone.ReadOnly = true;
            // 
            // DateUrgent
            // 
            this.DateUrgent.HeaderText = "Urgent Date";
            this.DateUrgent.Name = "DateUrgent";
            this.DateUrgent.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Alimentation
            // 
            this.Alimentation.HeaderText = "Alimentation";
            this.Alimentation.Name = "Alimentation";
            this.Alimentation.ReadOnly = true;
            // 
            // UrgentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(956, 680);
            this.Controls.Add(this.icPrint);
            this.Controls.Add(this.cmbMac);
            this.Controls.Add(this.btnUrgentDelete);
            this.Controls.Add(this.icExport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gtxtSearch);
            this.Controls.Add(this.guna2DataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UrgentManager";
            this.Text = "UrgentManager";
            this.Load += new System.EventHandler(this.UrgentManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox gtxtSearch;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton icExport;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnUrgentDelete;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMac;
        private FontAwesome.Sharp.IconButton icPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Famille;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeadCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateUrgent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alimentation;
    }
}