namespace MyМushroomController
{
    partial class Sections
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sections4RB = new System.Windows.Forms.RadioButton();
            this.Sections3RB = new System.Windows.Forms.RadioButton();
            this.Sections2RB = new System.Windows.Forms.RadioButton();
            this.Sections1RB = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.Sections4RB);
            this.groupBox1.Controls.Add(this.Sections3RB);
            this.groupBox1.Controls.Add(this.Sections2RB);
            this.groupBox1.Controls.Add(this.Sections1RB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 194);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Sections4RB
            // 
            this.Sections4RB.AutoSize = true;
            this.Sections4RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sections4RB.Location = new System.Drawing.Point(30, 152);
            this.Sections4RB.Name = "Sections4RB";
            this.Sections4RB.Size = new System.Drawing.Size(115, 29);
            this.Sections4RB.TabIndex = 3;
            this.Sections4RB.TabStop = true;
            this.Sections4RB.Text = "4 Section";
            this.Sections4RB.UseVisualStyleBackColor = true;
            // 
            // Sections3RB
            // 
            this.Sections3RB.AutoSize = true;
            this.Sections3RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sections3RB.Location = new System.Drawing.Point(30, 108);
            this.Sections3RB.Name = "Sections3RB";
            this.Sections3RB.Size = new System.Drawing.Size(115, 29);
            this.Sections3RB.TabIndex = 2;
            this.Sections3RB.TabStop = true;
            this.Sections3RB.Text = "3 Section";
            this.Sections3RB.UseVisualStyleBackColor = true;
            // 
            // Sections2RB
            // 
            this.Sections2RB.AutoSize = true;
            this.Sections2RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sections2RB.Location = new System.Drawing.Point(30, 64);
            this.Sections2RB.Name = "Sections2RB";
            this.Sections2RB.Size = new System.Drawing.Size(115, 29);
            this.Sections2RB.TabIndex = 1;
            this.Sections2RB.TabStop = true;
            this.Sections2RB.Text = "2 Section";
            this.Sections2RB.UseVisualStyleBackColor = true;
            // 
            // Sections1RB
            // 
            this.Sections1RB.AutoSize = true;
            this.Sections1RB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sections1RB.Location = new System.Drawing.Point(30, 20);
            this.Sections1RB.Name = "Sections1RB";
            this.Sections1RB.Size = new System.Drawing.Size(115, 29);
            this.Sections1RB.TabIndex = 0;
            this.Sections1RB.TabStop = true;
            this.Sections1RB.Text = "1 Section";
            this.Sections1RB.UseVisualStyleBackColor = true;
            // 
            // Sections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(196, 218);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Sections";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Sections";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sections_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Sections3RB;
        private System.Windows.Forms.RadioButton Sections2RB;
        private System.Windows.Forms.RadioButton Sections1RB;
        private System.Windows.Forms.RadioButton Sections4RB;
    }
}