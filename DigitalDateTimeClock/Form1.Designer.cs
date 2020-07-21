namespace DigitalDateTimeClock
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
            this.components = new System.ComponentModel.Container();
            this.HourMinute = new System.Windows.Forms.Label();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DayLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // HourMinute
            // 
            this.HourMinute.Font = new System.Drawing.Font("Lucida Sans Unicode", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourMinute.Location = new System.Drawing.Point(37, 301);
            this.HourMinute.Name = "HourMinute";
            this.HourMinute.Size = new System.Drawing.Size(557, 146);
            this.HourMinute.TabIndex = 0;
            this.HourMinute.Text = "19 : 25";
            this.HourMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondsLabel.Location = new System.Drawing.Point(544, 301);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(256, 146);
            this.SecondsLabel.TabIndex = 1;
            this.SecondsLabel.Text = ".47";
            this.SecondsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateLabel
            // 
            this.DateLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 67.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(12, 155);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(820, 146);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Jan. 03, 2017";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DayLabel
            // 
            this.DayLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayLabel.Location = new System.Drawing.Point(12, 9);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(820, 146);
            this.DayLabel.TabIndex = 3;
            this.DayLabel.Text = "Wednesday";
            this.DayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(844, 462);
            this.Controls.Add(this.DayLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.HourMinute);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HourMinute;
        private System.Windows.Forms.Label SecondsLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

