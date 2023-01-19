
namespace PERT_Maker
{
    partial class Form1
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
            this.NewTaskName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewTaskTitle = new System.Windows.Forms.Label();
            this.NewTaskTime = new System.Windows.Forms.NumericUpDown();
            this.NewTaskAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewTaskTime)).BeginInit();
            this.SuspendLayout();
            // 
            // NewTaskName
            // 
            this.NewTaskName.Location = new System.Drawing.Point(7, 57);
            this.NewTaskName.Name = "NewTaskName";
            this.NewTaskName.Size = new System.Drawing.Size(174, 21);
            this.NewTaskName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NewTaskAdd);
            this.panel1.Controls.Add(this.NewTaskTime);
            this.panel1.Controls.Add(this.NewTaskTitle);
            this.panel1.Controls.Add(this.NewTaskName);
            this.panel1.Location = new System.Drawing.Point(138, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 80);
            this.panel1.TabIndex = 1;
            // 
            // NewTaskTitle
            // 
            this.NewTaskTitle.AutoSize = true;
            this.NewTaskTitle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTaskTitle.Location = new System.Drawing.Point(4, 4);
            this.NewTaskTitle.Name = "NewTaskTitle";
            this.NewTaskTitle.Size = new System.Drawing.Size(63, 17);
            this.NewTaskTitle.TabIndex = 1;
            this.NewTaskTitle.Text = "New Task";
            this.NewTaskTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewTaskTime
            // 
            this.NewTaskTime.Location = new System.Drawing.Point(187, 57);
            this.NewTaskTime.Name = "NewTaskTime";
            this.NewTaskTime.Size = new System.Drawing.Size(79, 21);
            this.NewTaskTime.TabIndex = 2;
            this.NewTaskTime.ThousandsSeparator = true;
            // 
            // NewTaskAdd
            // 
            this.NewTaskAdd.Location = new System.Drawing.Point(273, 57);
            this.NewTaskAdd.Name = "NewTaskAdd";
            this.NewTaskAdd.Size = new System.Drawing.Size(75, 21);
            this.NewTaskAdd.TabIndex = 3;
            this.NewTaskAdd.Text = "Add";
            this.NewTaskAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 588);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "PERT Maker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewTaskTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox NewTaskName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NewTaskTitle;
        private System.Windows.Forms.Button NewTaskAdd;
        private System.Windows.Forms.NumericUpDown NewTaskTime;
    }
}

