namespace TimeZoneCalculator
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
            this.CurrentTimeZone = new System.Windows.Forms.Label();
            this.TimeZone_TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Latitude = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_Logitude = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CurrentTimeZone
            // 
            this.CurrentTimeZone.AutoSize = true;
            this.CurrentTimeZone.Location = new System.Drawing.Point(187, 145);
            this.CurrentTimeZone.Name = "CurrentTimeZone";
            this.CurrentTimeZone.Size = new System.Drawing.Size(92, 13);
            this.CurrentTimeZone.TabIndex = 0;
            this.CurrentTimeZone.Text = "Current TimeZone";
            this.CurrentTimeZone.Click += new System.EventHandler(this.CurrentTimeZone_Click);
            // 
            // TimeZone_TextBox
            // 
            this.TimeZone_TextBox.Location = new System.Drawing.Point(285, 142);
            this.TimeZone_TextBox.Name = "TimeZone_TextBox";
            this.TimeZone_TextBox.Size = new System.Drawing.Size(250, 20);
            this.TimeZone_TextBox.TabIndex = 1;
            this.TimeZone_TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Latitude";
            // 
            // TextBox_Latitude
            // 
            this.TextBox_Latitude.Location = new System.Drawing.Point(285, 80);
            this.TextBox_Latitude.Name = "TextBox_Latitude";
            this.TextBox_Latitude.Size = new System.Drawing.Size(250, 20);
            this.TextBox_Latitude.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Longitude";
            // 
            // TextBox_Logitude
            // 
            this.TextBox_Logitude.Location = new System.Drawing.Point(285, 111);
            this.TextBox_Logitude.Name = "TextBox_Logitude";
            this.TextBox_Logitude.Size = new System.Drawing.Size(250, 20);
            this.TextBox_Logitude.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBox_Logitude);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_Latitude);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TimeZone_TextBox);
            this.Controls.Add(this.CurrentTimeZone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentTimeZone;
        private System.Windows.Forms.TextBox TimeZone_TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_Latitude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_Logitude;
    }
}

