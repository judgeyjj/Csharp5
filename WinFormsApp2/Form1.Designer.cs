
namespace WinFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.txt1 = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.Button();
            this.txt3 = new System.Windows.Forms.Button();
            this.txt4 = new System.Windows.Forms.Button();
            this.txt5 = new System.Windows.Forms.Button();
            this.txt6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.doMake = new System.Windows.Forms.Button();
            this.fName = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.tiip = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.Label();
            this.tip2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(128, 55);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(160, 83);
            this.txt1.TabIndex = 0;
            this.txt1.Text = "1.txt";
            this.txt1.UseVisualStyleBackColor = true;
            this.txt1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(442, 55);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(203, 83);
            this.txt2.TabIndex = 1;
            this.txt2.Text = "2.txt";
            this.txt2.UseVisualStyleBackColor = true;
            this.txt2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(128, 155);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(160, 83);
            this.txt3.TabIndex = 2;
            this.txt3.Text = "3.txt";
            this.txt3.UseVisualStyleBackColor = true;
            this.txt3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(442, 155);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(203, 83);
            this.txt4.TabIndex = 3;
            this.txt4.Text = "4.txt";
            this.txt4.UseVisualStyleBackColor = true;
            this.txt4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(126, 244);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(162, 83);
            this.txt5.TabIndex = 4;
            this.txt5.Text = "5.txt";
            this.txt5.UseVisualStyleBackColor = true;
            this.txt5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(442, 244);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(203, 83);
            this.txt6.TabIndex = 5;
            this.txt6.Text = "6.txt";
            this.txt6.UseVisualStyleBackColor = true;
            this.txt6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.label1.Location = new System.Drawing.Point(126, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "合成文件名";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // doMake
            // 
            this.doMake.Location = new System.Drawing.Point(355, 400);
            this.doMake.Name = "doMake";
            this.doMake.Size = new System.Drawing.Size(94, 29);
            this.doMake.TabIndex = 8;
            this.doMake.Text = "合成";
            this.doMake.UseVisualStyleBackColor = true;
            this.doMake.Click += new System.EventHandler(this.button7_Click);
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(296, 353);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(229, 27);
            this.fName.TabIndex = 9;
            this.fName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tiip
            // 
            this.tiip.AutoSize = true;
            this.tiip.Location = new System.Drawing.Point(115, 9);
            this.tiip.Name = "tiip";
            this.tiip.Size = new System.Drawing.Size(0, 20);
            this.tiip.TabIndex = 10;
            this.tiip.Click += new System.EventHandler(this.label2_Click);
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.Location = new System.Drawing.Point(652, 354);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(0, 20);
            this.tip.TabIndex = 11;
            this.tip.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // tip2
            // 
            this.tip2.AutoSize = true;
            this.tip2.ForeColor = System.Drawing.Color.Red;
            this.tip2.Location = new System.Drawing.Point(659, 354);
            this.tip2.Name = "tip2";
            this.tip2.Size = new System.Drawing.Size(0, 20);
            this.tip2.TabIndex = 12;
            this.tip2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tip2);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.tiip);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.doMake);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txt1;
        private System.Windows.Forms.Button txt2;
        private System.Windows.Forms.Button txt3;
        private System.Windows.Forms.Button txt4;
        private System.Windows.Forms.Button txt5;
        private System.Windows.Forms.Button txt6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button doMake;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Label tiip;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Label tip2;
    }
}

