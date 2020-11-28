namespace JsonComparer
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
            this.tbPath1 = new System.Windows.Forms.TextBox();
            this.btnJson1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnJson2 = new System.Windows.Forms.Button();
            this.tbPath2 = new System.Windows.Forms.TextBox();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // tbPath1
            // 
            this.tbPath1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPath1.Location = new System.Drawing.Point(117, 12);
            this.tbPath1.Name = "tbPath1";
            this.tbPath1.Size = new System.Drawing.Size(421, 29);
            this.tbPath1.TabIndex = 0;
            // 
            // btnJson1
            // 
            this.btnJson1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJson1.Location = new System.Drawing.Point(544, 12);
            this.btnJson1.Name = "btnJson1";
            this.btnJson1.Size = new System.Drawing.Size(91, 29);
            this.btnJson1.TabIndex = 1;
            this.btnJson1.Text = "Выбрать";
            this.btnJson1.UseVisualStyleBackColor = true;
            this.btnJson1.Click += new System.EventHandler(this.btnJson1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Первый json";
            // 
            // btnCompare
            // 
            this.btnCompare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompare.Location = new System.Drawing.Point(544, 96);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(91, 32);
            this.btnCompare.TabIndex = 6;
            this.btnCompare.Text = "Сравнить";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Второй json";
            // 
            // btnJson2
            // 
            this.btnJson2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJson2.Location = new System.Drawing.Point(544, 54);
            this.btnJson2.Name = "btnJson2";
            this.btnJson2.Size = new System.Drawing.Size(91, 29);
            this.btnJson2.TabIndex = 8;
            this.btnJson2.Text = "Выбрать";
            this.btnJson2.UseVisualStyleBackColor = true;
            this.btnJson2.Click += new System.EventHandler(this.btnJson2_Click);
            // 
            // tbPath2
            // 
            this.tbPath2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPath2.Location = new System.Drawing.Point(117, 54);
            this.tbPath2.Name = "tbPath2";
            this.tbPath2.Size = new System.Drawing.Size(421, 29);
            this.tbPath2.TabIndex = 7;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(13, 96);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(525, 32);
            this.pb.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pb.TabIndex = 10;
            this.pb.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 140);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnJson2);
            this.Controls.Add(this.tbPath2);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJson1);
            this.Controls.Add(this.tbPath1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сравнение json";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPath1;
        private System.Windows.Forms.Button btnJson1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnJson2;
        private System.Windows.Forms.TextBox tbPath2;
        private System.Windows.Forms.ProgressBar pb;
    }
}

