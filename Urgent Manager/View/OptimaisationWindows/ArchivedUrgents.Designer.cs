namespace Urgent_Manager.View.OptimaisationWindows
{
    partial class ArchivedUrgents
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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeleteProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.chFinished = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.CustomIconSize = 20F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(350, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 35);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(10, 62);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 18);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Paste Or Type Unicos To Delete";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 10;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 105);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(371, 336);
            this.textBox1.TabIndex = 0;
            // 
            // DeleteProgressBar
            // 
            this.DeleteProgressBar.BorderRadius = 5;
            this.DeleteProgressBar.Location = new System.Drawing.Point(13, 518);
            this.DeleteProgressBar.Name = "DeleteProgressBar";
            this.DeleteProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.DeleteProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(120)))));
            this.DeleteProgressBar.Size = new System.Drawing.Size(370, 15);
            this.DeleteProgressBar.TabIndex = 9;
            this.DeleteProgressBar.Text = "guna2ProgressBar1";
            this.DeleteProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.DeleteProgressBar.Visible = false;
            // 
            // chFinished
            // 
            this.chFinished.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chFinished.CheckedState.BorderRadius = 3;
            this.chFinished.CheckedState.BorderThickness = 0;
            this.chFinished.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chFinished.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chFinished.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chFinished.ForeColor = System.Drawing.Color.White;
            this.chFinished.Location = new System.Drawing.Point(13, 472);
            this.chFinished.Name = "chFinished";
            this.chFinished.Size = new System.Drawing.Size(116, 24);
            this.chFinished.TabIndex = 10;
            this.chFinished.Text = "Finished";
            this.chFinished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chFinished.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chFinished.UncheckedState.BorderRadius = 0;
            this.chFinished.UncheckedState.BorderThickness = 0;
            this.chFinished.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // ArchivedUrgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(395, 557);
            this.Controls.Add(this.chFinished);
            this.Controls.Add(this.DeleteProgressBar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArchivedUrgents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchivedUrgents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2ProgressBar DeleteProgressBar;
        private Guna.UI2.WinForms.Guna2CheckBox chFinished;
    }
}