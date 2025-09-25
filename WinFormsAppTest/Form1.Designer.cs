namespace WinFormsAppTest
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
            dataGridViewMagazzino = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMagazzino).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMagazzino
            // 
            dataGridViewMagazzino.AllowUserToAddRows = false;
            dataGridViewMagazzino.AllowUserToDeleteRows = false;
            dataGridViewMagazzino.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMagazzino.Location = new Point(102, 99);
            dataGridViewMagazzino.Name = "dataGridViewMagazzino";
            dataGridViewMagazzino.ReadOnly = true;
            dataGridViewMagazzino.RowHeadersWidth = 51;
            dataGridViewMagazzino.Size = new Size(568, 380);
            dataGridViewMagazzino.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 686);
            Controls.Add(dataGridViewMagazzino);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMagazzino).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewMagazzino;
    }
}
