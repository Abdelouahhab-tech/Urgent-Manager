namespace Urgent_Manager.View.OptimaisationWindows
{
    partial class ArchiveManager
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gdateTimeUrgent = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.icExport = new FontAwesome.Sharp.IconButton();
            this.Famille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeadCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emplacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateUrgent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Zone,
            this.Machine,
            this.Emplacement,
            this.DateUrgent,
            this.shift,
            this.Status,
            this.finishedDate});
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
            this.guna2DataGridView1.Location = new System.Drawing.Point(19, 81);
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
            this.guna2DataGridView1.TabIndex = 10;
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
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.guna2DataGridView1;
            // 
            // gdateTimeUrgent
            // 
            this.gdateTimeUrgent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gdateTimeUrgent.BackColor = System.Drawing.Color.Transparent;
            this.gdateTimeUrgent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(79)))), ((int)(((byte)(12)))));
            this.gdateTimeUrgent.BorderRadius = 18;
            this.gdateTimeUrgent.BorderThickness = 2;
            this.gdateTimeUrgent.Checked = true;
            this.gdateTimeUrgent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gdateTimeUrgent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gdateTimeUrgent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gdateTimeUrgent.ForeColor = System.Drawing.Color.White;
            this.gdateTimeUrgent.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.gdateTimeUrgent.Location = new System.Drawing.Point(650, 21);
            this.gdateTimeUrgent.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gdateTimeUrgent.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gdateTimeUrgent.Name = "gdateTimeUrgent";
            this.gdateTimeUrgent.Size = new System.Drawing.Size(278, 40);
            this.gdateTimeUrgent.TabIndex = 14;
            this.gdateTimeUrgent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gdateTimeUrgent.Value = new System.DateTime(2022, 7, 7, 8, 22, 58, 917);
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
            this.icExport.Location = new System.Drawing.Point(596, 21);
            this.icExport.Name = "icExport";
            this.icExport.Size = new System.Drawing.Size(45, 38);
            this.icExport.TabIndex = 12;
            this.icExport.UseVisualStyleBackColor = true;
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
            this.LeadCode.HeaderText = "LeadCode";
            this.LeadCode.Name = "LeadCode";
            this.LeadCode.ReadOnly = true;
            // 
            // Zone
            // 
            this.Zone.HeaderText = "Area";
            this.Zone.Name = "Zone";
            this.Zone.ReadOnly = true;
            // 
            // Machine
            // 
            this.Machine.HeaderText = "Machine";
            this.Machine.Name = "Machine";
            this.Machine.ReadOnly = true;
            // 
            // Emplacement
            // 
            this.Emplacement.HeaderText = "Location";
            this.Emplacement.Name = "Emplacement";
            this.Emplacement.ReadOnly = true;
            // 
            // DateUrgent
            // 
            this.DateUrgent.HeaderText = "Urgent Date";
            this.DateUrgent.Name = "DateUrgent";
            this.DateUrgent.ReadOnly = true;
            // 
            // shift
            // 
            this.shift.HeaderText = "Shift";
            this.shift.Name = "shift";
            this.shift.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // finishedDate
            // 
            this.finishedDate.HeaderText = "Finished Date";
            this.finishedDate.Name = "finishedDate";
            this.finishedDate.ReadOnly = true;
            // 
            // ArchiveManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(940, 641);
            this.Controls.Add(this.gdateTimeUrgent);
            this.Controls.Add(this.icExport);
            this.Controls.Add(this.guna2DataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArchiveManager";
            this.Text = "ArchiveManager";
            this.Load += new System.EventHandler(this.ArchiveManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton icExport;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DateTimePicker gdateTimeUrgent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Famille;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unico;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeadCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateUrgent;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishedDate;
    }
}