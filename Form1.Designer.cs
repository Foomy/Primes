namespace Primes
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
            if (disposing && (components != null)) {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIsPrime = new System.Windows.Forms.TextBox();
            this.textBoxNextPrime = new System.Windows.Forms.TextBox();
            this.textBoxPrevPrime = new System.Windows.Forms.TextBox();
            this.checkBoxIsPrime = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(533, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.BeendenToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Prüfen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(158, 54);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(193, 22);
            this.textBoxInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ist Prim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nächsthöhere Primzahl:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vorhergehnde Primzahl:";
            // 
            // textBoxIsPrime
            // 
            this.textBoxIsPrime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIsPrime.Location = new System.Drawing.Point(309, 114);
            this.textBoxIsPrime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIsPrime.Name = "textBoxIsPrime";
            this.textBoxIsPrime.Size = new System.Drawing.Size(93, 34);
            this.textBoxIsPrime.TabIndex = 6;
            // 
            // textBoxNextPrime
            // 
            this.textBoxNextPrime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNextPrime.Location = new System.Drawing.Point(309, 155);
            this.textBoxNextPrime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNextPrime.Name = "textBoxNextPrime";
            this.textBoxNextPrime.Size = new System.Drawing.Size(93, 34);
            this.textBoxNextPrime.TabIndex = 7;
            // 
            // textBoxPrevPrime
            // 
            this.textBoxPrevPrime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrevPrime.Location = new System.Drawing.Point(309, 196);
            this.textBoxPrevPrime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrevPrime.Name = "textBoxPrevPrime";
            this.textBoxPrevPrime.Size = new System.Drawing.Size(93, 34);
            this.textBoxPrevPrime.TabIndex = 8;
            // 
            // checkBoxIsPrime
            // 
            this.checkBoxIsPrime.AutoSize = true;
            this.checkBoxIsPrime.Location = new System.Drawing.Point(427, 126);
            this.checkBoxIsPrime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxIsPrime.Name = "checkBoxIsPrime";
            this.checkBoxIsPrime.Size = new System.Drawing.Size(18, 17);
            this.checkBoxIsPrime.TabIndex = 9;
            this.checkBoxIsPrime.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 291);
            this.Controls.Add(this.checkBoxIsPrime);
            this.Controls.Add(this.textBoxPrevPrime);
            this.Controls.Add(this.textBoxNextPrime);
            this.Controls.Add(this.textBoxIsPrime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIsPrime;
        private System.Windows.Forms.TextBox textBoxNextPrime;
        private System.Windows.Forms.TextBox textBoxPrevPrime;
        private System.Windows.Forms.CheckBox checkBoxIsPrime;
    }
}

