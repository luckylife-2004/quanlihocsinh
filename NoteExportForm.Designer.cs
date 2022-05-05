﻿
namespace StudyManagementApp
{
    partial class NoteExportForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NoteExportButton = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 391);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NoteExportButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 391);
            this.panel2.TabIndex = 18;
            // 
            // NoteExportButton
            // 
            this.NoteExportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoteExportButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.NoteExportButton.BorderColor = System.Drawing.Color.White;
            this.NoteExportButton.BorderRadius = 18;
            this.NoteExportButton.BorderSize = 0;
            this.NoteExportButton.FlatAppearance.BorderSize = 0;
            this.NoteExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoteExportButton.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteExportButton.ForeColor = System.Drawing.Color.White;
            this.NoteExportButton.Location = new System.Drawing.Point(138, 141);
            this.NoteExportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NoteExportButton.Name = "NoteExportButton";
            this.NoteExportButton.Size = new System.Drawing.Size(185, 47);
            this.NoteExportButton.TabIndex = 14;
            this.NoteExportButton.Text = "EXPORT NOTE";
            this.NoteExportButton.UseVisualStyleBackColor = false;
            this.NoteExportButton.Click += new System.EventHandler(this.NoteExportButton_Click);
            // 
            // NoteExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(480, 391);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NoteExportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verification Code Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.RoundedCornerButton NoteExportButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
    }
}