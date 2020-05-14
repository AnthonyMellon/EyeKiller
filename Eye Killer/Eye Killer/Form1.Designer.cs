namespace Eye_Killer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxFaceX = new System.Windows.Forms.TextBox();
            this.textBoxFaceY = new System.Windows.Forms.TextBox();
            this.serialPortArduino = new System.IO.Ports.SerialPort(this.components);
            this.textBoxPortName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 769);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(778, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(196, 39);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Face Position";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFaceX
            // 
            this.textBoxFaceX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFaceX.Location = new System.Drawing.Point(778, 78);
            this.textBoxFaceX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFaceX.Name = "textBoxFaceX";
            this.textBoxFaceX.Size = new System.Drawing.Size(196, 19);
            this.textBoxFaceX.TabIndex = 0;
            // 
            // textBoxFaceY
            // 
            this.textBoxFaceY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFaceY.Location = new System.Drawing.Point(778, 118);
            this.textBoxFaceY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFaceY.Name = "textBoxFaceY";
            this.textBoxFaceY.Size = new System.Drawing.Size(196, 19);
            this.textBoxFaceY.TabIndex = 0;
            // 
            // textBoxPortName
            // 
            this.textBoxPortName.Location = new System.Drawing.Point(777, 238);
            this.textBoxPortName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPortName.Name = "textBoxPortName";
            this.textBoxPortName.Size = new System.Drawing.Size(148, 26);
            this.textBoxPortName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(777, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Port";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonStart.Location = new System.Drawing.Point(777, 300);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(122, 57);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonEnd.Location = new System.Drawing.Point(777, 366);
            this.buttonEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(122, 57);
            this.buttonEnd.TabIndex = 5;
            this.buttonEnd.Text = "End";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(780, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1018, 815);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPortName);
            this.Controls.Add(this.textBoxFaceY);
            this.Controls.Add(this.textBoxFaceX);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxFaceX;
        private System.Windows.Forms.TextBox textBoxFaceY;
        private System.IO.Ports.SerialPort serialPortArduino;
        private System.Windows.Forms.TextBox textBoxPortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Label label2;
    }
}

