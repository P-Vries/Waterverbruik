namespace WaterVerbruik
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
            this.rdb00 = new System.Windows.Forms.RadioButton();
            this.rdb01 = new System.Windows.Forms.RadioButton();
            this.rdb02 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdb00
            // 
            this.rdb00.AutoSize = true;
            this.rdb00.Checked = true;
            this.rdb00.Location = new System.Drawing.Point(12, 12);
            this.rdb00.Name = "rdb00";
            this.rdb00.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdb00.Size = new System.Drawing.Size(61, 17);
            this.rdb00.TabIndex = 0;
            this.rdb00.TabStop = true;
            this.rdb00.Text = "Tarief 0";
            this.rdb00.UseVisualStyleBackColor = true;
            // 
            // rdb01
            // 
            this.rdb01.AutoSize = true;
            this.rdb01.Location = new System.Drawing.Point(12, 35);
            this.rdb01.Name = "rdb01";
            this.rdb01.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdb01.Size = new System.Drawing.Size(61, 17);
            this.rdb01.TabIndex = 1;
            this.rdb01.Text = "Tarief 1";
            this.rdb01.UseVisualStyleBackColor = true;
            // 
            // rdb02
            // 
            this.rdb02.AutoSize = true;
            this.rdb02.Location = new System.Drawing.Point(12, 58);
            this.rdb02.Name = "rdb02";
            this.rdb02.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdb02.Size = new System.Drawing.Size(61, 17);
            this.rdb02.TabIndex = 2;
            this.rdb02.Text = "Tarief 2";
            this.rdb02.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aantal kubieke meters water: ";
            // 
            // txbIn
            // 
            this.txbIn.Location = new System.Drawing.Point(162, 75);
            this.txbIn.Name = "txbIn";
            this.txbIn.Size = new System.Drawing.Size(80, 20);
            this.txbIn.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Bereken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOut
            // 
            this.lblOut.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOut.Location = new System.Drawing.Point(12, 136);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(230, 53);
            this.lblOut.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 198);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdb02);
            this.Controls.Add(this.rdb01);
            this.Controls.Add(this.rdb00);
            this.Name = "Form1";
            this.Text = "Water Verbruik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb00;
        private System.Windows.Forms.RadioButton rdb01;
        private System.Windows.Forms.RadioButton rdb02;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOut;
    }
}

