namespace FractionDemo
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLoop1 = new FractionDemo.ButtonLoop();
            this.numBox1 = new FractionDemo.NumBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(249, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLoop1
            // 
            this.buttonLoop1.BackColor = System.Drawing.Color.LightBlue;
            this.buttonLoop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoop1.Location = new System.Drawing.Point(98, 238);
            this.buttonLoop1.loupe = false;
            this.buttonLoop1.Name = "buttonLoop1";
            this.buttonLoop1.Size = new System.Drawing.Size(140, 70);
            this.buttonLoop1.TabIndex = 2;
            this.buttonLoop1.Text = "TEST LOUPE";
            this.buttonLoop1.UseVisualStyleBackColor = false;
            // 
            // numBox1
            // 
            this.numBox1.Location = new System.Drawing.Point(513, 238);
            this.numBox1.maxi = 100D;
            this.numBox1.mini = 0D;
            this.numBox1.Name = "numBox1";
            this.numBox1.Size = new System.Drawing.Size(210, 20);
            this.numBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.buttonLoop1);
            this.Controls.Add(this.numBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private NumBox numBox1;
        private ButtonLoop buttonLoop1;
    }
}

