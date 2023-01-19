
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
            this.NewTaskTime = new System.Windows.Forms.NumericUpDown();
            this.NewTaskAdd = new System.Windows.Forms.Button();
            this.ProjectListPanel = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.EditionMenu = new System.Windows.Forms.TabControl();
            this.NewTask = new System.Windows.Forms.TabPage();
            this.EditTask = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.NewTaskTime)).BeginInit();
            this.ProjectListPanel.SuspendLayout();
            this.EditionMenu.SuspendLayout();
            this.NewTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewTaskName
            // 
            this.NewTaskName.Location = new System.Drawing.Point(6, 138);
            this.NewTaskName.Name = "NewTaskName";
            this.NewTaskName.Size = new System.Drawing.Size(174, 21);
            this.NewTaskName.TabIndex = 0;
            // 
            // NewTaskTime
            // 
            this.NewTaskTime.Location = new System.Drawing.Point(186, 138);
            this.NewTaskTime.Name = "NewTaskTime";
            this.NewTaskTime.Size = new System.Drawing.Size(79, 21);
            this.NewTaskTime.TabIndex = 2;
            this.NewTaskTime.ThousandsSeparator = true;
            // 
            // NewTaskAdd
            // 
            this.NewTaskAdd.Location = new System.Drawing.Point(271, 138);
            this.NewTaskAdd.Name = "NewTaskAdd";
            this.NewTaskAdd.Size = new System.Drawing.Size(75, 21);
            this.NewTaskAdd.TabIndex = 3;
            this.NewTaskAdd.Text = "Add";
            this.NewTaskAdd.UseVisualStyleBackColor = true;
            // 
            // ProjectListPanel
            // 
            this.ProjectListPanel.Controls.Add(this.listView1);
            this.ProjectListPanel.Location = new System.Drawing.Point(5, 12);
            this.ProjectListPanel.Name = "ProjectListPanel";
            this.ProjectListPanel.Size = new System.Drawing.Size(200, 564);
            this.ProjectListPanel.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(194, 497);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // EditionMenu
            // 
            this.EditionMenu.Controls.Add(this.NewTask);
            this.EditionMenu.Controls.Add(this.EditTask);
            this.EditionMenu.Location = new System.Drawing.Point(208, 52);
            this.EditionMenu.Name = "EditionMenu";
            this.EditionMenu.SelectedIndex = 0;
            this.EditionMenu.Size = new System.Drawing.Size(860, 191);
            this.EditionMenu.TabIndex = 3;
            // 
            // NewTask
            // 
            this.NewTask.Controls.Add(this.NewTaskAdd);
            this.NewTask.Controls.Add(this.NewTaskName);
            this.NewTask.Controls.Add(this.NewTaskTime);
            this.NewTask.Location = new System.Drawing.Point(4, 22);
            this.NewTask.Name = "NewTask";
            this.NewTask.Padding = new System.Windows.Forms.Padding(3);
            this.NewTask.Size = new System.Drawing.Size(852, 165);
            this.NewTask.TabIndex = 0;
            this.NewTask.Text = "New Task";
            this.NewTask.UseVisualStyleBackColor = true;
            // 
            // EditTask
            // 
            this.EditTask.Location = new System.Drawing.Point(4, 22);
            this.EditTask.Name = "EditTask";
            this.EditTask.Padding = new System.Windows.Forms.Padding(3);
            this.EditTask.Size = new System.Drawing.Size(852, 165);
            this.EditTask.TabIndex = 1;
            this.EditTask.Text = "Edit Task";
            this.EditTask.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 588);
            this.Controls.Add(this.EditionMenu);
            this.Controls.Add(this.ProjectListPanel);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "PERT Maker";
            ((System.ComponentModel.ISupportInitialize)(this.NewTaskTime)).EndInit();
            this.ProjectListPanel.ResumeLayout(false);
            this.EditionMenu.ResumeLayout(false);
            this.NewTask.ResumeLayout(false);
            this.NewTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox NewTaskName;
        private System.Windows.Forms.Button NewTaskAdd;
        private System.Windows.Forms.NumericUpDown NewTaskTime;
        private System.Windows.Forms.Panel ProjectListPanel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabControl EditionMenu;
        private System.Windows.Forms.TabPage NewTask;
        private System.Windows.Forms.TabPage EditTask;
    }
}

