namespace hwlesson_8
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnTask1 = new System.Windows.Forms.Button();
            this.btnTask2 = new System.Windows.Forms.Button();
            this.btnTask3 = new System.Windows.Forms.Button();
            this.btnTask4 = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTask1
            // 
            this.btnTask1.Location = new System.Drawing.Point(12, 12);
            this.btnTask1.Name = "btnTask1";
            this.btnTask1.Size = new System.Drawing.Size(270, 30);
            this.btnTask1.TabIndex = 0;
            this.btnTask1.Text = "Task 1";
            this.btnTask1.UseVisualStyleBackColor = true;
            this.btnTask1.Click += new System.EventHandler(this.btnTask1_Click);
            // 
            // btnTask2
            // 
            this.btnTask2.Location = new System.Drawing.Point(302, 12);
            this.btnTask2.Name = "btnTask2";
            this.btnTask2.Size = new System.Drawing.Size(270, 30);
            this.btnTask2.TabIndex = 1;
            this.btnTask2.Text = "Task 2";
            this.btnTask2.UseVisualStyleBackColor = true;
            this.btnTask2.Click += new System.EventHandler(this.btnTask2_Click);
            // 
            // btnTask3
            // 
            this.btnTask3.Location = new System.Drawing.Point(12, 48);
            this.btnTask3.Name = "btnTask3";
            this.btnTask3.Size = new System.Drawing.Size(270, 30);
            this.btnTask3.TabIndex = 2;
            this.btnTask3.Text = "Task 3";
            this.btnTask3.UseVisualStyleBackColor = true;
            this.btnTask3.Click += new System.EventHandler(this.btnTask3_Click);
            // 
            // btnTask4
            // 
            this.btnTask4.Location = new System.Drawing.Point(302, 48);
            this.btnTask4.Name = "btnTask4";
            this.btnTask4.Size = new System.Drawing.Size(270, 30);
            this.btnTask4.TabIndex = 3;
            this.btnTask4.Text = "Task 4";
            this.btnTask4.UseVisualStyleBackColor = true;
            this.btnTask4.Click += new System.EventHandler(this.btnTask4_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 90);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(560, 310);
            this.txtOutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnTask4);
            this.Controls.Add(this.btnTask3);
            this.Controls.Add(this.btnTask2);
            this.Controls.Add(this.btnTask1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parallel Programming (Tasks 1–4)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTask1;
        private System.Windows.Forms.Button btnTask2;
        private System.Windows.Forms.Button btnTask3;
        private System.Windows.Forms.Button btnTask4;
        private System.Windows.Forms.TextBox txtOutput;
    }
}