﻿
namespace Ongoren
{
    partial class Trash
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
            this.label1 = new System.Windows.Forms.Label();
            this.TrashPeopleGridView = new System.Windows.Forms.DataGridView();
            this.TakeItBackBtn = new System.Windows.Forms.Button();
            this.TrashUserIdTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TrashPeopleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(550, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRASH USERS";
            // 
            // TrashPeopleGridView
            // 
            this.TrashPeopleGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.TrashPeopleGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TrashPeopleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrashPeopleGridView.Location = new System.Drawing.Point(1, 37);
            this.TrashPeopleGridView.Name = "TrashPeopleGridView";
            this.TrashPeopleGridView.RowHeadersVisible = false;
            this.TrashPeopleGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TrashPeopleGridView.Size = new System.Drawing.Size(1200, 348);
            this.TrashPeopleGridView.TabIndex = 3;
            this.TrashPeopleGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TrashPeopleGridView_CellClick);
            // 
            // TakeItBackBtn
            // 
            this.TakeItBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.TakeItBackBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(116)))), ((int)(((byte)(190)))));
            this.TakeItBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TakeItBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TakeItBackBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TakeItBackBtn.Location = new System.Drawing.Point(1081, 391);
            this.TakeItBackBtn.Name = "TakeItBackBtn";
            this.TakeItBackBtn.Size = new System.Drawing.Size(109, 33);
            this.TakeItBackBtn.TabIndex = 36;
            this.TakeItBackBtn.Text = "Take It Back";
            this.TakeItBackBtn.UseVisualStyleBackColor = false;
            this.TakeItBackBtn.Click += new System.EventHandler(this.TakeItBackBtn_Click);
            // 
            // TrashUserIdTxt
            // 
            this.TrashUserIdTxt.Location = new System.Drawing.Point(101, 413);
            this.TrashUserIdTxt.Name = "TrashUserIdTxt";
            this.TrashUserIdTxt.Size = new System.Drawing.Size(100, 20);
            this.TrashUserIdTxt.TabIndex = 37;
            this.TrashUserIdTxt.Visible = false;
            // 
            // Trash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1202, 461);
            this.Controls.Add(this.TrashUserIdTxt);
            this.Controls.Add(this.TakeItBackBtn);
            this.Controls.Add(this.TrashPeopleGridView);
            this.Controls.Add(this.label1);
            this.Name = "Trash";
            this.Text = "Trash";
            this.Load += new System.EventHandler(this.Trash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrashPeopleGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TrashPeopleGridView;
        private System.Windows.Forms.Button TakeItBackBtn;
        private System.Windows.Forms.TextBox TrashUserIdTxt;
    }
}