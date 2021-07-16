
namespace WinFormsAppCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.Mod = new System.Windows.Forms.RadioButton();
            this.Deg = new System.Windows.Forms.RadioButton();
            this.Con = new System.Windows.Forms.RadioButton();
            this.Div = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(168, 175);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(100, 23);
            this.TB1.TabIndex = 0;
            this.TB1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(527, 175);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(100, 23);
            this.TB2.TabIndex = 1;
            // 
            // TB3
            // 
            this.TB3.Location = new System.Drawing.Point(335, 45);
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(100, 23);
            this.TB3.TabIndex = 2;
            // 
            // Mod
            // 
            this.Mod.AutoSize = true;
            this.Mod.Location = new System.Drawing.Point(80, 122);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(94, 19);
            this.Mod.TabIndex = 3;
            this.Mod.TabStop = true;
            this.Mod.Text = "radioButton1";
            this.Mod.UseVisualStyleBackColor = true;
            // 
            // Deg
            // 
            this.Deg.AutoSize = true;
            this.Deg.Location = new System.Drawing.Point(263, 122);
            this.Deg.Name = "Deg";
            this.Deg.Size = new System.Drawing.Size(94, 19);
            this.Deg.TabIndex = 4;
            this.Deg.TabStop = true;
            this.Deg.Text = "radioButton2";
            this.Deg.UseVisualStyleBackColor = true;
            // 
            // Con
            // 
            this.Con.AutoSize = true;
            this.Con.Location = new System.Drawing.Point(435, 122);
            this.Con.Name = "Con";
            this.Con.Size = new System.Drawing.Size(94, 19);
            this.Con.TabIndex = 5;
            this.Con.TabStop = true;
            this.Con.Text = "radioButton3";
            this.Con.UseVisualStyleBackColor = true;
            // 
            // Div
            // 
            this.Div.AutoSize = true;
            this.Div.Location = new System.Drawing.Point(623, 122);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(94, 19);
            this.Div.TabIndex = 6;
            this.Div.TabStop = true;
            this.Div.Text = "radioButton4";
            this.Div.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Con);
            this.Controls.Add(this.Deg);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.TextBox TB3;
        private System.Windows.Forms.RadioButton Mod;
        private System.Windows.Forms.RadioButton Deg;
        private System.Windows.Forms.RadioButton Con;
        private System.Windows.Forms.RadioButton Div;
        private System.Windows.Forms.Button button1;
    }
}

