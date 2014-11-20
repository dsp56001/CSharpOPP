namespace WindowsFormDog
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAboutDog = new System.Windows.Forms.TextBox();
            this.buttonBark = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "About Dog";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAboutDog
            // 
            this.textBoxAboutDog.Location = new System.Drawing.Point(25, 117);
            this.textBoxAboutDog.Multiline = true;
            this.textBoxAboutDog.Name = "textBoxAboutDog";
            this.textBoxAboutDog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAboutDog.Size = new System.Drawing.Size(222, 133);
            this.textBoxAboutDog.TabIndex = 1;
            // 
            // buttonBark
            // 
            this.buttonBark.Location = new System.Drawing.Point(132, 33);
            this.buttonBark.Name = "buttonBark";
            this.buttonBark.Size = new System.Drawing.Size(75, 23);
            this.buttonBark.TabIndex = 2;
            this.buttonBark.Text = "Bark";
            this.buttonBark.UseVisualStyleBackColor = true;
            this.buttonBark.Click += new System.EventHandler(this.buttonBark_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Change Owner";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonBark);
            this.Controls.Add(this.textBoxAboutDog);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxAboutDog;
        private System.Windows.Forms.Button buttonBark;
        private System.Windows.Forms.Button button2;
    }
}

