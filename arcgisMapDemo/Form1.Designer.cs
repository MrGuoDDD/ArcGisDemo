namespace arcgisMapDemo
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
            this.btnArcMapLisen = new System.Windows.Forms.Button();
            this.btnOpenAcDb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArcMapLisen
            // 
            this.btnArcMapLisen.Location = new System.Drawing.Point(12, 12);
            this.btnArcMapLisen.Name = "btnArcMapLisen";
            this.btnArcMapLisen.Size = new System.Drawing.Size(75, 23);
            this.btnArcMapLisen.TabIndex = 0;
            this.btnArcMapLisen.Text = "ArcMap授权";
            this.btnArcMapLisen.UseVisualStyleBackColor = true;
            this.btnArcMapLisen.Click += new System.EventHandler(this.btnArcMapLisen_Click);
            // 
            // btnOpenAcDb
            // 
            this.btnOpenAcDb.Location = new System.Drawing.Point(93, 12);
            this.btnOpenAcDb.Name = "btnOpenAcDb";
            this.btnOpenAcDb.Size = new System.Drawing.Size(190, 23);
            this.btnOpenAcDb.TabIndex = 0;
            this.btnOpenAcDb.Text = "Open Access Data Base";
            this.btnOpenAcDb.UseVisualStyleBackColor = true;
            this.btnOpenAcDb.Click += new System.EventHandler(this.btnOpenAcDb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 429);
            this.Controls.Add(this.btnOpenAcDb);
            this.Controls.Add(this.btnArcMapLisen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArcMapLisen;
        private System.Windows.Forms.Button btnOpenAcDb;
    }
}

