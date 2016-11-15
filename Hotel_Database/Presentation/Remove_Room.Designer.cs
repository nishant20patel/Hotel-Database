﻿namespace Hotel_Database.Presentation
{
    partial class RemoveRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveRoom));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.dgv_ChooseRoom = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChooseRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(12, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(560, 51);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Select Room";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(12, 237);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(560, 46);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // dgv_ChooseRoom
            // 
            this.dgv_ChooseRoom.AllowUserToAddRows = false;
            this.dgv_ChooseRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChooseRoom.Location = new System.Drawing.Point(12, 63);
            this.dgv_ChooseRoom.Name = "dgv_ChooseRoom";
            this.dgv_ChooseRoom.ReadOnly = true;
            this.dgv_ChooseRoom.Size = new System.Drawing.Size(560, 168);
            this.dgv_ChooseRoom.TabIndex = 13;
            this.dgv_ChooseRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChooseGuest_CellClick);
            // 
            // RemoveRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Database.Properties.Resources.Sunset;
            this.ClientSize = new System.Drawing.Size(584, 288);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_ChooseRoom);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoveRoom";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Remove Room";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChooseRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DataGridView dgv_ChooseRoom;
    }
}