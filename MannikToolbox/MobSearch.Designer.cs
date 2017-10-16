﻿namespace MannikToolbox
{
    partial class MobSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgd_MobSearch = new System.Windows.Forms.DataGridView();
            this.MobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NPCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NPCRegionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.picNPC = new System.Windows.Forms.PictureBox();
            this.txtFilterMob = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSelectNPC = new System.Windows.Forms.Button();
            this.lblMob_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgd_MobSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNPC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgd_MobSearch
            // 
            this.dgd_MobSearch.AllowUserToOrderColumns = true;
            this.dgd_MobSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgd_MobSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgd_MobSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MobID,
            this.NPCName,
            this.Guild,
            this.Model,
            this.NPCRegionID});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgd_MobSearch.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgd_MobSearch.Location = new System.Drawing.Point(8, 8);
            this.dgd_MobSearch.MultiSelect = false;
            this.dgd_MobSearch.Name = "dgd_MobSearch";
            this.dgd_MobSearch.ReadOnly = true;
            this.dgd_MobSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgd_MobSearch.Size = new System.Drawing.Size(619, 559);
            this.dgd_MobSearch.TabIndex = 1;
            this.dgd_MobSearch.SelectionChanged += new System.EventHandler(this.Dgd_MobSearch_SelectionChanged);
            // 
            // MobID
            // 
            this.MobID.FillWeight = 5.076142F;
            this.MobID.HeaderText = "Mob_ID";
            this.MobID.MinimumWidth = 2;
            this.MobID.Name = "MobID";
            this.MobID.ReadOnly = true;
            this.MobID.Visible = false;
            // 
            // NPCName
            // 
            this.NPCName.FillWeight = 123.731F;
            this.NPCName.HeaderText = "Name";
            this.NPCName.Name = "NPCName";
            this.NPCName.ReadOnly = true;
            // 
            // Guild
            // 
            this.Guild.FillWeight = 123.731F;
            this.Guild.HeaderText = "Guild";
            this.Guild.Name = "Guild";
            this.Guild.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.FillWeight = 123.731F;
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // NPCRegionID
            // 
            this.NPCRegionID.FillWeight = 123.731F;
            this.NPCRegionID.HeaderText = "Region ID";
            this.NPCRegionID.Name = "NPCRegionID";
            this.NPCRegionID.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(790, 466);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // picNPC
            // 
            this.picNPC.Location = new System.Drawing.Point(633, 8);
            this.picNPC.Name = "picNPC";
            this.picNPC.Size = new System.Drawing.Size(253, 452);
            this.picNPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNPC.TabIndex = 4;
            this.picNPC.TabStop = false;
            // 
            // txtFilterMob
            // 
            this.txtFilterMob.Location = new System.Drawing.Point(633, 468);
            this.txtFilterMob.Name = "txtFilterMob";
            this.txtFilterMob.Size = new System.Drawing.Size(151, 20);
            this.txtFilterMob.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(790, 495);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnSelectNPC
            // 
            this.btnSelectNPC.Location = new System.Drawing.Point(633, 544);
            this.btnSelectNPC.Name = "btnSelectNPC";
            this.btnSelectNPC.Size = new System.Drawing.Size(248, 23);
            this.btnSelectNPC.TabIndex = 7;
            this.btnSelectNPC.Text = "&Edit this NPC";
            this.btnSelectNPC.UseVisualStyleBackColor = true;
            this.btnSelectNPC.Click += new System.EventHandler(this.BtnSelectNPC_Click);
            // 
            // lblMob_ID
            // 
            this.lblMob_ID.AutoSize = true;
            this.lblMob_ID.Location = new System.Drawing.Point(657, 528);
            this.lblMob_ID.Name = "lblMob_ID";
            this.lblMob_ID.Size = new System.Drawing.Size(202, 13);
            this.lblMob_ID.TabIndex = 8;
            this.lblMob_ID.Text = "fd83f37b-e43a-412d-9d60-550a9bbf0449";
            // 
            // MobSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 579);
            this.Controls.Add(this.lblMob_ID);
            this.Controls.Add(this.btnSelectNPC);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtFilterMob);
            this.Controls.Add(this.picNPC);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgd_MobSearch);
            this.MaximumSize = new System.Drawing.Size(909, 618);
            this.MinimumSize = new System.Drawing.Size(909, 618);
            this.Name = "MobSearch";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.MobSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgd_MobSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgd_MobSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox picNPC;
        private System.Windows.Forms.TextBox txtFilterMob;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSelectNPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NPCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guild;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn NPCRegionID;
        private System.Windows.Forms.Label lblMob_ID;
    }
}