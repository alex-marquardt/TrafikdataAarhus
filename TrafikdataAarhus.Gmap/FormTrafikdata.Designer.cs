namespace TrafikdataAarhus.Gmap
{
    partial class FormTrafikdata
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
            this.dataGridViewTrafikdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrafikdata)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTrafikdata
            // 
            this.dataGridViewTrafikdata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTrafikdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrafikdata.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTrafikdata.Name = "dataGridViewTrafikdata";
            this.dataGridViewTrafikdata.RowHeadersWidth = 51;
            this.dataGridViewTrafikdata.RowTemplate.Height = 24;
            this.dataGridViewTrafikdata.Size = new System.Drawing.Size(758, 429);
            this.dataGridViewTrafikdata.TabIndex = 0;
            // 
            // FormTrafikdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.dataGridViewTrafikdata);
            this.Name = "FormTrafikdata";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trafikdata Aarhus Data";
            this.Load += new System.EventHandler(this.FormTrafikdata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrafikdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTrafikdata;
    }
}