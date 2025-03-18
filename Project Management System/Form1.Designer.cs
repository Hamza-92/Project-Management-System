namespace Project_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            projectsTable = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)projectsTable).BeginInit();
            SuspendLayout();
            // 
            // projectsTable
            // 
            projectsTable.BackgroundColor = SystemColors.Window;
            projectsTable.BorderStyle = BorderStyle.None;
            projectsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectsTable.Location = new Point(12, 94);
            projectsTable.Name = "projectsTable";
            projectsTable.Size = new Size(548, 344);
            projectsTable.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 31);
            label1.Name = "label1";
            label1.Size = new Size(243, 32);
            label1.TabIndex = 1;
            label1.Text = "Project Management";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(572, 450);
            Controls.Add(label1);
            Controls.Add(projectsTable);
            Name = "Form1";
            Text = "Project Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)projectsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView projectsTable;
        private Label label1;
    }
}
