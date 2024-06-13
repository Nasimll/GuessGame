namespace GuessGame
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
            this.min = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Label();
            this.mintext = new System.Windows.Forms.TextBox();
            this.maxtext = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.level = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.min.Location = new System.Drawing.Point(38, 54);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(54, 20);
            this.min.TabIndex = 0;
            this.min.Text = "MIN :";
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.max.Location = new System.Drawing.Point(38, 124);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(60, 20);
            this.max.TabIndex = 1;
            this.max.Text = "MAX :";
            // 
            // mintext
            // 
            this.mintext.Location = new System.Drawing.Point(131, 54);
            this.mintext.Name = "mintext";
            this.mintext.Size = new System.Drawing.Size(100, 22);
            this.mintext.TabIndex = 2;
            // 
            // maxtext
            // 
            this.maxtext.Location = new System.Drawing.Point(131, 122);
            this.maxtext.Name = "maxtext";
            this.maxtext.Size = new System.Drawing.Size(100, 22);
            this.maxtext.TabIndex = 3;
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn.Location = new System.Drawing.Point(29, 255);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(234, 42);
            this.btn.TabIndex = 4;
            this.btn.Text = "START";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.Location = new System.Drawing.Point(29, 317);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(234, 45);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "EXIT";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.level.Location = new System.Drawing.Point(38, 183);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(73, 20);
            this.level.TabIndex = 6;
            this.level.Text = "LEVEL:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Expert"});
            this.comboBox1.Location = new System.Drawing.Point(131, 178);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.level);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.maxtext);
            this.Controls.Add(this.mintext);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.TextBox mintext;
        private System.Windows.Forms.TextBox maxtext;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

