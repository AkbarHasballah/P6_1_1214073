namespace P6_1_1214073
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.vbButton = new System.Windows.Forms.Button();
            this.CsButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Closebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vbButton
            // 
            this.vbButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton.ForeColor = System.Drawing.Color.Red;
            this.vbButton.Location = new System.Drawing.Point(125, 84);
            this.vbButton.Name = "vbButton";
            this.vbButton.Size = new System.Drawing.Size(158, 42);
            this.vbButton.TabIndex = 0;
            this.vbButton.Text = "Visual Button";
            this.vbButton.UseVisualStyleBackColor = true;
            this.vbButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vbButton_MouseMove);
            // 
            // CsButton
            // 
            this.CsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CsButton.ForeColor = System.Drawing.Color.Lime;
            this.CsButton.Location = new System.Drawing.Point(531, 84);
            this.CsButton.Name = "CsButton";
            this.CsButton.Size = new System.Drawing.Size(146, 42);
            this.CsButton.TabIndex = 1;
            this.CsButton.Text = "C#";
            this.CsButton.UseVisualStyleBackColor = true;
            this.CsButton.Click += new System.EventHandler(this.CsButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(94, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(8, 16);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Closebutton
            // 
            this.Closebutton.Location = new System.Drawing.Point(27, 339);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(88, 29);
            this.Closebutton.TabIndex = 3;
            this.Closebutton.Text = "Close ";
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Which do you think is better, Visual Basic or C#";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CsButton);
            this.Controls.Add(this.vbButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button vbButton;
        private System.Windows.Forms.Button CsButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.Label label1;
    }
}

