namespace TrueFalseEditor
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripGame = new System.Windows.Forms.ToolStripButton();
            this.toolStripQw = new System.Windows.Forms.ToolStripButton();
            this.toolStripEnd = new System.Windows.Forms.ToolStripButton();
            this.True = new System.Windows.Forms.Button();
            this.False = new System.Windows.Forms.Button();
            this.labelQw = new System.Windows.Forms.Label();
            this.labelQ1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGame,
            this.toolStripQw,
            this.toolStripEnd});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(829, 30);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripGame
            // 
            this.toolStripGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripGame.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripGame.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripGame.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGame.Image")));
            this.toolStripGame.ImageTransparentColor = System.Drawing.Color.LimeGreen;
            this.toolStripGame.Name = "toolStripGame";
            this.toolStripGame.Size = new System.Drawing.Size(114, 27);
            this.toolStripGame.Text = "Новая игра";
            this.toolStripGame.Click += new System.EventHandler(this.toolStripGame_Click);
            // 
            // toolStripQw
            // 
            this.toolStripQw.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripQw.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripQw.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStripQw.Image = ((System.Drawing.Image)(resources.GetObject("toolStripQw.Image")));
            this.toolStripQw.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripQw.Name = "toolStripQw";
            this.toolStripQw.Size = new System.Drawing.Size(93, 27);
            this.toolStripQw.Text = "Вопросы";
            this.toolStripQw.Click += new System.EventHandler(this.toolStripQw_Click);
            // 
            // toolStripEnd
            // 
            this.toolStripEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripEnd.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripEnd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolStripEnd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEnd.Image")));
            this.toolStripEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEnd.Name = "toolStripEnd";
            this.toolStripEnd.Size = new System.Drawing.Size(74, 27);
            this.toolStripEnd.Text = "Выход";
            this.toolStripEnd.Click += new System.EventHandler(this.toolStripEnd_Click);
            // 
            // True
            // 
            this.True.BackColor = System.Drawing.SystemColors.Info;
            this.True.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.True.Location = new System.Drawing.Point(190, 216);
            this.True.Name = "True";
            this.True.Size = new System.Drawing.Size(162, 81);
            this.True.TabIndex = 1;
            this.True.Text = "ВЕРЮ";
            this.True.UseVisualStyleBackColor = false;
            this.True.Click += new System.EventHandler(this.True_Click);
            // 
            // False
            // 
            this.False.BackColor = System.Drawing.SystemColors.Info;
            this.False.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.False.Location = new System.Drawing.Point(494, 216);
            this.False.Name = "False";
            this.False.Size = new System.Drawing.Size(162, 81);
            this.False.TabIndex = 2;
            this.False.Text = "НЕ ВЕРЮ";
            this.False.UseVisualStyleBackColor = false;
            this.False.Click += new System.EventHandler(this.False_Click);
            // 
            // labelQw
            // 
            this.labelQw.AutoSize = true;
            this.labelQw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQw.Location = new System.Drawing.Point(49, 75);
            this.labelQw.Name = "labelQw";
            this.labelQw.Size = new System.Drawing.Size(0, 29);
            this.labelQw.TabIndex = 3;
            // 
            // labelQ1
            // 
            this.labelQ1.AutoSize = true;
            this.labelQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQ1.Location = new System.Drawing.Point(136, 75);
            this.labelQ1.Name = "labelQ1";
            this.labelQ1.Size = new System.Drawing.Size(102, 29);
            this.labelQ1.TabIndex = 4;
            this.labelQ1.Text = "Вопрос";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 483);
            this.Controls.Add(this.labelQ1);
            this.Controls.Add(this.labelQw);
            this.Controls.Add(this.False);
            this.Controls.Add(this.True);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Game";
            this.Text = "Игра   \"Верю - Не верю\"";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripGame;
        private System.Windows.Forms.ToolStripButton toolStripQw;
        private System.Windows.Forms.ToolStripButton toolStripEnd;
        private System.Windows.Forms.Button True;
        private System.Windows.Forms.Button False;
        private System.Windows.Forms.Label labelQw;
        private System.Windows.Forms.Label labelQ1;
    }
}