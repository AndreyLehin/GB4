namespace Doubler
{
    partial class Form2
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
            this.labelComputerNumber2 = new System.Windows.Forms.Label();
            this.labelinf = new System.Windows.Forms.Label();
            this.labelCount2 = new System.Windows.Forms.Label();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.Ok1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.usNumb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelComputerNumber2
            // 
            this.labelComputerNumber2.AutoSize = true;
            this.labelComputerNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelComputerNumber2.Location = new System.Drawing.Point(166, 44);
            this.labelComputerNumber2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComputerNumber2.Name = "labelComputerNumber2";
            this.labelComputerNumber2.Size = new System.Drawing.Size(381, 31);
            this.labelComputerNumber2.TabIndex = 4;
            this.labelComputerNumber2.Text = "Угадайте число от 0 до 100";
            // 
            // labelinf
            // 
            this.labelinf.AutoSize = true;
            this.labelinf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelinf.Location = new System.Drawing.Point(166, 372);
            this.labelinf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelinf.Name = "labelinf";
            this.labelinf.Size = new System.Drawing.Size(289, 31);
            this.labelinf.TabIndex = 5;
            this.labelinf.Text = "Больше или меньше";
            // 
            // labelCount2
            // 
            this.labelCount2.AutoSize = true;
            this.labelCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount2.Location = new System.Drawing.Point(166, 510);
            this.labelCount2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCount2.Name = "labelCount2";
            this.labelCount2.Size = new System.Drawing.Size(291, 31);
            this.labelCount2.TabIndex = 6;
            this.labelCount2.Text = "Количество попыток";
            // 
            // buttonEnd
            // 
            this.buttonEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnd.Location = new System.Drawing.Point(701, 44);
            this.buttonEnd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(169, 79);
            this.buttonEnd.TabIndex = 7;
            this.buttonEnd.Text = "Сдаться";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // Ok1
            // 
            this.Ok1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok1.Location = new System.Drawing.Point(412, 207);
            this.Ok1.Margin = new System.Windows.Forms.Padding(4);
            this.Ok1.Name = "Ok1";
            this.Ok1.Size = new System.Drawing.Size(135, 41);
            this.Ok1.TabIndex = 9;
            this.Ok1.Text = "Ok";
            this.Ok1.UseVisualStyleBackColor = true;
            this.Ok1.Click += new System.EventHandler(this.Ok1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(172, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 49);
            this.textBox1.TabIndex = 10;
            this.textBox1.Leave += new System.EventHandler(this.Ok1_Click);
            // 
            // usNumb
            // 
            this.usNumb.AutoSize = true;
            this.usNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usNumb.Location = new System.Drawing.Point(664, 362);
            this.usNumb.MinimumSize = new System.Drawing.Size(80, 26);
            this.usNumb.Name = "usNumb";
            this.usNumb.Size = new System.Drawing.Size(80, 42);
            this.usNumb.TabIndex = 11;
            this.usNumb.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 640);
            this.Controls.Add(this.usNumb);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Ok1);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.labelCount2);
            this.Controls.Add(this.labelinf);
            this.Controls.Add(this.labelComputerNumber2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelComputerNumber2;
        private System.Windows.Forms.Label labelinf;
        private System.Windows.Forms.Label labelCount2;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Button Ok1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label usNumb;
    }
}