namespace Conveter
{
    partial class Conveter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conveter));
            this.bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mv = new System.Windows.Forms.TextBox();
            this.kmv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt
            // 
            this.bt.BackColor = System.Drawing.SystemColors.Window;
            this.bt.Location = new System.Drawing.Point(145, 190);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(112, 36);
            this.bt.TabIndex = 0;
            this.bt.Text = "Convert";
            this.bt.UseVisualStyleBackColor = false;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(275, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "m";
            // 
            // mv
            // 
            this.mv.Location = new System.Drawing.Point(145, 136);
            this.mv.Name = "mv";
            this.mv.Size = new System.Drawing.Size(112, 22);
            this.mv.TabIndex = 2;
            // 
            // kmv
            // 
            this.kmv.Location = new System.Drawing.Point(145, 266);
            this.kmv.Name = "kmv";
            this.kmv.ReadOnly = true;
            this.kmv.Size = new System.Drawing.Size(112, 22);
            this.kmv.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Km ";
            // 
            // Conveter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(419, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kmv);
            this.Controls.Add(this.mv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt);
            this.Name = "Conveter";
            this.Text = "Conveter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mv;
        private System.Windows.Forms.TextBox kmv;
        private System.Windows.Forms.Label label2;
    }
}

