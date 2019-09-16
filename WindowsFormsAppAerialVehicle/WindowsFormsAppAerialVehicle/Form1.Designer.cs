namespace WindowsFormsAppAerialVehicle
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
            this.comboBoxAerialVehicle = new System.Windows.Forms.ComboBox();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.textBoxAbout = new System.Windows.Forms.TextBox();
            this.ButtonUp = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonWind = new System.Windows.Forms.Button();
            this.buttonTakeOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxAerialVehicle
            // 
            this.comboBoxAerialVehicle.FormattingEnabled = true;
            this.comboBoxAerialVehicle.Items.AddRange(new object[] {
            "Airplane",
            "Helicopter"});
            this.comboBoxAerialVehicle.Location = new System.Drawing.Point(12, 27);
            this.comboBoxAerialVehicle.Name = "comboBoxAerialVehicle";
            this.comboBoxAerialVehicle.Size = new System.Drawing.Size(156, 28);
            this.comboBoxAerialVehicle.TabIndex = 0;
            this.comboBoxAerialVehicle.SelectedIndexChanged += new System.EventHandler(this.comboBoxAerialVehicle_SelectedIndexChanged);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(174, 27);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 49);
            this.buttonAbout.TabIndex = 1;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // textBoxAbout
            // 
            this.textBoxAbout.Location = new System.Drawing.Point(12, 209);
            this.textBoxAbout.Multiline = true;
            this.textBoxAbout.Name = "textBoxAbout";
            this.textBoxAbout.Size = new System.Drawing.Size(310, 209);
            this.textBoxAbout.TabIndex = 2;
            // 
            // ButtonUp
            // 
            this.ButtonUp.Location = new System.Drawing.Point(12, 98);
            this.ButtonUp.Name = "ButtonUp";
            this.ButtonUp.Size = new System.Drawing.Size(75, 33);
            this.ButtonUp.TabIndex = 3;
            this.ButtonUp.Text = "Up";
            this.ButtonUp.UseVisualStyleBackColor = true;
            this.ButtonUp.Click += new System.EventHandler(this.ButtonUp_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(93, 98);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 33);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 148);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 5;
            this.button4.Text = "Down";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(339, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 387);
            this.panel1.TabIndex = 6;
            // 
            // buttonWind
            // 
            this.buttonWind.Location = new System.Drawing.Point(93, 148);
            this.buttonWind.Name = "buttonWind";
            this.buttonWind.Size = new System.Drawing.Size(75, 33);
            this.buttonWind.TabIndex = 7;
            this.buttonWind.Text = "Wind";
            this.buttonWind.UseVisualStyleBackColor = true;
            // 
            // buttonTakeOff
            // 
            this.buttonTakeOff.Location = new System.Drawing.Point(174, 98);
            this.buttonTakeOff.Name = "buttonTakeOff";
            this.buttonTakeOff.Size = new System.Drawing.Size(75, 32);
            this.buttonTakeOff.TabIndex = 8;
            this.buttonTakeOff.Text = "TakeOff";
            this.buttonTakeOff.UseVisualStyleBackColor = true;
            this.buttonTakeOff.Click += new System.EventHandler(this.buttonTakeOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTakeOff);
            this.Controls.Add(this.buttonWind);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.ButtonUp);
            this.Controls.Add(this.textBoxAbout);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.comboBoxAerialVehicle);
            this.Name = "Form1";
            this.Text = "Aerial Vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAerialVehicle;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.TextBox textBoxAbout;
        private System.Windows.Forms.Button ButtonUp;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonWind;
        private System.Windows.Forms.Button buttonTakeOff;
    }
}

