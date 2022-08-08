namespace TemperatureConversion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fahrenheight = new System.Windows.Forms.TextBox();
            this.txt_celcius = new System.Windows.Forms.TextBox();
            this.txt_kelvin = new System.Windows.Forms.TextBox();
            this.btn_fahrenheight = new System.Windows.Forms.Button();
            this.btn_celcius = new System.Windows.Forms.Button();
            this.btn_kelvin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fahrenheight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Celcius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelvin";
            // 
            // txt_fahrenheight
            // 
            this.txt_fahrenheight.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fahrenheight.Location = new System.Drawing.Point(175, 78);
            this.txt_fahrenheight.Name = "txt_fahrenheight";
            this.txt_fahrenheight.Size = new System.Drawing.Size(100, 28);
            this.txt_fahrenheight.TabIndex = 3;
            // 
            // txt_celcius
            // 
            this.txt_celcius.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_celcius.Location = new System.Drawing.Point(175, 125);
            this.txt_celcius.Name = "txt_celcius";
            this.txt_celcius.Size = new System.Drawing.Size(100, 28);
            this.txt_celcius.TabIndex = 4;
            // 
            // txt_kelvin
            // 
            this.txt_kelvin.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kelvin.Location = new System.Drawing.Point(175, 172);
            this.txt_kelvin.Name = "txt_kelvin";
            this.txt_kelvin.Size = new System.Drawing.Size(100, 28);
            this.txt_kelvin.TabIndex = 5;
            // 
            // btn_fahrenheight
            // 
            this.btn_fahrenheight.Location = new System.Drawing.Point(305, 78);
            this.btn_fahrenheight.Name = "btn_fahrenheight";
            this.btn_fahrenheight.Size = new System.Drawing.Size(75, 27);
            this.btn_fahrenheight.TabIndex = 6;
            this.btn_fahrenheight.Text = "Convert";
            this.btn_fahrenheight.UseVisualStyleBackColor = true;
            this.btn_fahrenheight.Click += new System.EventHandler(this.btn_fahrenheight_Click);
            // 
            // btn_celcius
            // 
            this.btn_celcius.Location = new System.Drawing.Point(305, 125);
            this.btn_celcius.Name = "btn_celcius";
            this.btn_celcius.Size = new System.Drawing.Size(75, 28);
            this.btn_celcius.TabIndex = 7;
            this.btn_celcius.Text = "Convert";
            this.btn_celcius.UseVisualStyleBackColor = true;
            this.btn_celcius.Click += new System.EventHandler(this.btn_celcius_Click);
            // 
            // btn_kelvin
            // 
            this.btn_kelvin.Location = new System.Drawing.Point(305, 172);
            this.btn_kelvin.Name = "btn_kelvin";
            this.btn_kelvin.Size = new System.Drawing.Size(75, 28);
            this.btn_kelvin.TabIndex = 8;
            this.btn_kelvin.Text = "Convert";
            this.btn_kelvin.UseVisualStyleBackColor = true;
            this.btn_kelvin.Click += new System.EventHandler(this.btn_kelvin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 301);
            this.Controls.Add(this.btn_kelvin);
            this.Controls.Add(this.btn_celcius);
            this.Controls.Add(this.btn_fahrenheight);
            this.Controls.Add(this.txt_kelvin);
            this.Controls.Add(this.txt_celcius);
            this.Controls.Add(this.txt_fahrenheight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fahrenheight;
        private System.Windows.Forms.TextBox txt_celcius;
        private System.Windows.Forms.TextBox txt_kelvin;
        private System.Windows.Forms.Button btn_fahrenheight;
        private System.Windows.Forms.Button btn_celcius;
        private System.Windows.Forms.Button btn_kelvin;
    }
}

