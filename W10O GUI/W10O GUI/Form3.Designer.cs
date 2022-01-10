
namespace W10O_GUI
{
    partial class CUSTOM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CUSTOM));
            this.label1 = new System.Windows.Forms.Label();
            this.DEF = new System.Windows.Forms.Button();
            this.WUD = new System.Windows.Forms.Button();
            this.PWRMGMT = new System.Windows.Forms.Button();
            this.RBW = new System.Windows.Forms.Button();
            this.RRF = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(64, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOM";
            // 
            // DEF
            // 
            this.DEF.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DEF.Location = new System.Drawing.Point(12, 89);
            this.DEF.Name = "DEF";
            this.DEF.Size = new System.Drawing.Size(251, 23);
            this.DEF.TabIndex = 1;
            this.DEF.Text = "DISABLE Microsoft Windows Defender";
            this.DEF.UseVisualStyleBackColor = true;
            this.DEF.Click += new System.EventHandler(this.DEF_Click);
            // 
            // WUD
            // 
            this.WUD.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WUD.Location = new System.Drawing.Point(12, 144);
            this.WUD.Name = "WUD";
            this.WUD.Size = new System.Drawing.Size(251, 23);
            this.WUD.TabIndex = 2;
            this.WUD.Text = "DISABLE Microsoft Windows Update";
            this.WUD.UseVisualStyleBackColor = true;
            this.WUD.Click += new System.EventHandler(this.WUD_Click);
            // 
            // PWRMGMT
            // 
            this.PWRMGMT.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PWRMGMT.Location = new System.Drawing.Point(12, 202);
            this.PWRMGMT.Name = "PWRMGMT";
            this.PWRMGMT.Size = new System.Drawing.Size(251, 23);
            this.PWRMGMT.TabIndex = 3;
            this.PWRMGMT.Text = "CONFIGURE Energy System";
            this.PWRMGMT.UseVisualStyleBackColor = true;
            this.PWRMGMT.Click += new System.EventHandler(this.PWRMGMT_Click);
            // 
            // RBW
            // 
            this.RBW.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RBW.Location = new System.Drawing.Point(12, 253);
            this.RBW.Name = "RBW";
            this.RBW.Size = new System.Drawing.Size(251, 23);
            this.RBW.TabIndex = 4;
            this.RBW.Text = "UNINSTALL Microsoft Windows 10 Bloatware";
            this.RBW.UseVisualStyleBackColor = true;
            this.RBW.Click += new System.EventHandler(this.RBW_Click);
            // 
            // RRF
            // 
            this.RRF.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RRF.Location = new System.Drawing.Point(12, 303);
            this.RRF.Name = "RRF";
            this.RRF.Size = new System.Drawing.Size(251, 23);
            this.RRF.TabIndex = 5;
            this.RRF.Text = "REMOVE Ramaining files";
            this.RRF.UseVisualStyleBackColor = true;
            this.RRF.Click += new System.EventHandler(this.RRF_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.back.Location = new System.Drawing.Point(121, 341);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(35, 23);
            this.back.TabIndex = 6;
            this.back.Text = "<---";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // CUSTOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 382);
            this.Controls.Add(this.back);
            this.Controls.Add(this.RRF);
            this.Controls.Add(this.RBW);
            this.Controls.Add(this.PWRMGMT);
            this.Controls.Add(this.WUD);
            this.Controls.Add(this.DEF);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CUSTOM";
            this.Text = "W10O";
            this.Load += new System.EventHandler(this.CUSTOM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DEF;
        private System.Windows.Forms.Button WUD;
        private System.Windows.Forms.Button PWRMGMT;
        private System.Windows.Forms.Button RBW;
        private System.Windows.Forms.Button RRF;
        private System.Windows.Forms.Button back;
    }
}