
namespace JsonComparer
{
    partial class Form2
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
            this.tbContent = new System.Windows.Forms.TextBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbContent
            // 
            this.tbContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbContent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbContent.Location = new System.Drawing.Point(0, 0);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbContent.Size = new System.Drawing.Size(420, 428);
            this.tbContent.TabIndex = 1;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSaveFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveFile.Location = new System.Drawing.Point(0, 424);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(420, 37);
            this.btnSaveFile.TabIndex = 2;
            this.btnSaveFile.Text = "Сохранить файл";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 461);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.tbContent);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно сравнения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Button btnSaveFile;
    }
}