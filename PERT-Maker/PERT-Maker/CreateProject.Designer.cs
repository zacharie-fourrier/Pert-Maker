﻿namespace PERT_Maker
{
    partial class CreateProject
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DescTextBox = new System.Windows.Forms.TextBox();
            this.CancelProjectBtn = new System.Windows.Forms.Button();
            this.ConfirmProjectBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConfirmProjectBtn);
            this.groupBox1.Controls.Add(this.CancelProjectBtn);
            this.groupBox1.Controls.Add(this.DescTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TitleTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Project";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Title";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextBox.Location = new System.Drawing.Point(9, 55);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(273, 22);
            this.TitleTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Project Description (optionnal)";
            // 
            // DescTextBox
            // 
            this.DescTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescTextBox.Location = new System.Drawing.Point(12, 105);
            this.DescTextBox.Multiline = true;
            this.DescTextBox.Name = "DescTextBox";
            this.DescTextBox.Size = new System.Drawing.Size(270, 89);
            this.DescTextBox.TabIndex = 3;
            // 
            // CancelProjectBtn
            // 
            this.CancelProjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelProjectBtn.Location = new System.Drawing.Point(224, 200);
            this.CancelProjectBtn.Name = "CancelProjectBtn";
            this.CancelProjectBtn.Size = new System.Drawing.Size(111, 23);
            this.CancelProjectBtn.TabIndex = 4;
            this.CancelProjectBtn.Text = "Cancel";
            this.CancelProjectBtn.UseVisualStyleBackColor = true;
            this.CancelProjectBtn.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ConfirmProjectBtn
            // 
            this.ConfirmProjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmProjectBtn.Location = new System.Drawing.Point(341, 200);
            this.ConfirmProjectBtn.Name = "ConfirmProjectBtn";
            this.ConfirmProjectBtn.Size = new System.Drawing.Size(111, 23);
            this.ConfirmProjectBtn.TabIndex = 5;
            this.ConfirmProjectBtn.Text = "Confirm";
            this.ConfirmProjectBtn.UseVisualStyleBackColor = true;
            this.ConfirmProjectBtn.Click += new System.EventHandler(this.ConfirmProjectBtn_Click);
            // 
            // CreateProject
            // 
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateProject";
            this.Text = "Create Project";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConfirmProjectBtn;
        private System.Windows.Forms.Button CancelProjectBtn;
        private System.Windows.Forms.TextBox DescTextBox;
    }
}
