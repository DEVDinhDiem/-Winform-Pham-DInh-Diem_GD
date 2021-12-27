
namespace Testgd
{
    partial class Bai09
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
            this.components = new System.ComponentModel.Container();
            this.tmEgg = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tmCount = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmEgg
            // 
            this.tmEgg.Tick += new System.EventHandler(this.tmEgg_tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(859, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            // 
            // tmCount
            // 
            this.tmCount.Tick += new System.EventHandler(this.tmCount_Tick);
            // 
            // Bai09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 464);
            this.Controls.Add(this.label1);
            this.Name = "Bai09";
            this.Text = "Bai 09";
            this.Load += new System.EventHandler(this.Bai09_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bai09_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmCount;
    }
}