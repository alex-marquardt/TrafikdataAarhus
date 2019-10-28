namespace TrafikdataAarhus.Gmap
{
    partial class FormGmap
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
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.buttonGetAarhusTrafikdata = new System.Windows.Forms.Button();
            this.dataGridViewTrafikdata = new System.Windows.Forms.DataGridView();
            this.textBoxReportId = new System.Windows.Forms.TextBox();
            this.textBoxTimeStamp = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxPoint1Latitude = new System.Windows.Forms.TextBox();
            this.textBoxPoint1Longitude = new System.Windows.Forms.TextBox();
            this.textBoxPoint2Latitude = new System.Windows.Forms.TextBox();
            this.textBoxPoint2Longitude = new System.Windows.Forms.TextBox();
            this.textBoxReportName = new System.Windows.Forms.TextBox();
            this.labelReportId = new System.Windows.Forms.Label();
            this.labelReportName = new System.Windows.Forms.Label();
            this.labelTimestamp = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelPoint1Longitude = new System.Windows.Forms.Label();
            this.labelPoint2Longitude = new System.Windows.Forms.Label();
            this.labelPoint1Latitude = new System.Windows.Forms.Label();
            this.labelPoint2Latitude = new System.Windows.Forms.Label();
            this.timerUpdateDatabase = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrafikdata)).BeginInit();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(12, 12);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(678, 329);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 13D;
            // 
            // buttonGetAarhusTrafikdata
            // 
            this.buttonGetAarhusTrafikdata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetAarhusTrafikdata.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetAarhusTrafikdata.Location = new System.Drawing.Point(696, 294);
            this.buttonGetAarhusTrafikdata.Name = "buttonGetAarhusTrafikdata";
            this.buttonGetAarhusTrafikdata.Size = new System.Drawing.Size(554, 47);
            this.buttonGetAarhusTrafikdata.TabIndex = 1;
            this.buttonGetAarhusTrafikdata.Text = "Get Aarhus Trafikdata";
            this.buttonGetAarhusTrafikdata.UseVisualStyleBackColor = true;
            this.buttonGetAarhusTrafikdata.Click += new System.EventHandler(this.buttonGetAarhusTrafikdata_Click);
            // 
            // dataGridViewTrafikdata
            // 
            this.dataGridViewTrafikdata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTrafikdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrafikdata.Location = new System.Drawing.Point(12, 347);
            this.dataGridViewTrafikdata.MultiSelect = false;
            this.dataGridViewTrafikdata.Name = "dataGridViewTrafikdata";
            this.dataGridViewTrafikdata.ReadOnly = true;
            this.dataGridViewTrafikdata.RowHeadersWidth = 51;
            this.dataGridViewTrafikdata.RowTemplate.Height = 24;
            this.dataGridViewTrafikdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTrafikdata.Size = new System.Drawing.Size(1238, 317);
            this.dataGridViewTrafikdata.TabIndex = 2;
            this.dataGridViewTrafikdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTrafikdata_CellClick);
            // 
            // textBoxReportId
            // 
            this.textBoxReportId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReportId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReportId.Location = new System.Drawing.Point(696, 28);
            this.textBoxReportId.Name = "textBoxReportId";
            this.textBoxReportId.Size = new System.Drawing.Size(274, 25);
            this.textBoxReportId.TabIndex = 3;
            // 
            // textBoxTimeStamp
            // 
            this.textBoxTimeStamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTimeStamp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimeStamp.Location = new System.Drawing.Point(976, 90);
            this.textBoxTimeStamp.Name = "textBoxTimeStamp";
            this.textBoxTimeStamp.Size = new System.Drawing.Size(274, 25);
            this.textBoxTimeStamp.TabIndex = 4;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(696, 90);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(274, 25);
            this.textBoxStatus.TabIndex = 5;
            // 
            // textBoxPoint1Latitude
            // 
            this.textBoxPoint1Latitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPoint1Latitude.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPoint1Latitude.Location = new System.Drawing.Point(696, 157);
            this.textBoxPoint1Latitude.Name = "textBoxPoint1Latitude";
            this.textBoxPoint1Latitude.Size = new System.Drawing.Size(274, 25);
            this.textBoxPoint1Latitude.TabIndex = 6;
            // 
            // textBoxPoint1Longitude
            // 
            this.textBoxPoint1Longitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPoint1Longitude.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPoint1Longitude.Location = new System.Drawing.Point(976, 157);
            this.textBoxPoint1Longitude.Name = "textBoxPoint1Longitude";
            this.textBoxPoint1Longitude.Size = new System.Drawing.Size(274, 25);
            this.textBoxPoint1Longitude.TabIndex = 7;
            // 
            // textBoxPoint2Latitude
            // 
            this.textBoxPoint2Latitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPoint2Latitude.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPoint2Latitude.Location = new System.Drawing.Point(696, 213);
            this.textBoxPoint2Latitude.Name = "textBoxPoint2Latitude";
            this.textBoxPoint2Latitude.Size = new System.Drawing.Size(274, 25);
            this.textBoxPoint2Latitude.TabIndex = 8;
            // 
            // textBoxPoint2Longitude
            // 
            this.textBoxPoint2Longitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPoint2Longitude.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPoint2Longitude.Location = new System.Drawing.Point(976, 213);
            this.textBoxPoint2Longitude.Name = "textBoxPoint2Longitude";
            this.textBoxPoint2Longitude.Size = new System.Drawing.Size(274, 25);
            this.textBoxPoint2Longitude.TabIndex = 9;
            // 
            // textBoxReportName
            // 
            this.textBoxReportName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReportName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReportName.Location = new System.Drawing.Point(976, 28);
            this.textBoxReportName.Name = "textBoxReportName";
            this.textBoxReportName.Size = new System.Drawing.Size(274, 25);
            this.textBoxReportName.TabIndex = 10;
            // 
            // labelReportId
            // 
            this.labelReportId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelReportId.AutoSize = true;
            this.labelReportId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportId.Location = new System.Drawing.Point(696, 9);
            this.labelReportId.Name = "labelReportId";
            this.labelReportId.Size = new System.Drawing.Size(75, 16);
            this.labelReportId.TabIndex = 11;
            this.labelReportId.Text = "Report Id:";
            // 
            // labelReportName
            // 
            this.labelReportName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelReportName.AutoSize = true;
            this.labelReportName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportName.Location = new System.Drawing.Point(973, 9);
            this.labelReportName.Name = "labelReportName";
            this.labelReportName.Size = new System.Drawing.Size(101, 16);
            this.labelReportName.TabIndex = 12;
            this.labelReportName.Text = "Report Name:";
            // 
            // labelTimestamp
            // 
            this.labelTimestamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimestamp.AutoSize = true;
            this.labelTimestamp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimestamp.Location = new System.Drawing.Point(973, 71);
            this.labelTimestamp.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.labelTimestamp.Name = "labelTimestamp";
            this.labelTimestamp.Size = new System.Drawing.Size(95, 16);
            this.labelTimestamp.TabIndex = 14;
            this.labelTimestamp.Text = "Last Update:";
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(693, 71);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(55, 16);
            this.labelStatus.TabIndex = 13;
            this.labelStatus.Text = "Status:";
            // 
            // labelPoint1Longitude
            // 
            this.labelPoint1Longitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPoint1Longitude.AutoSize = true;
            this.labelPoint1Longitude.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoint1Longitude.Location = new System.Drawing.Point(979, 133);
            this.labelPoint1Longitude.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.labelPoint1Longitude.Name = "labelPoint1Longitude";
            this.labelPoint1Longitude.Size = new System.Drawing.Size(129, 16);
            this.labelPoint1Longitude.TabIndex = 16;
            this.labelPoint1Longitude.Text = "Point 1 Longitude:";
            // 
            // labelPoint2Longitude
            // 
            this.labelPoint2Longitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPoint2Longitude.AutoSize = true;
            this.labelPoint2Longitude.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoint2Longitude.Location = new System.Drawing.Point(979, 194);
            this.labelPoint2Longitude.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.labelPoint2Longitude.Name = "labelPoint2Longitude";
            this.labelPoint2Longitude.Size = new System.Drawing.Size(129, 16);
            this.labelPoint2Longitude.TabIndex = 15;
            this.labelPoint2Longitude.Text = "Point 2 Longitude:";
            // 
            // labelPoint1Latitude
            // 
            this.labelPoint1Latitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPoint1Latitude.AutoSize = true;
            this.labelPoint1Latitude.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoint1Latitude.Location = new System.Drawing.Point(696, 133);
            this.labelPoint1Latitude.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.labelPoint1Latitude.Name = "labelPoint1Latitude";
            this.labelPoint1Latitude.Size = new System.Drawing.Size(117, 16);
            this.labelPoint1Latitude.TabIndex = 18;
            this.labelPoint1Latitude.Text = "Point 1 Latitude:";
            // 
            // labelPoint2Latitude
            // 
            this.labelPoint2Latitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPoint2Latitude.AutoSize = true;
            this.labelPoint2Latitude.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoint2Latitude.Location = new System.Drawing.Point(696, 194);
            this.labelPoint2Latitude.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.labelPoint2Latitude.Name = "labelPoint2Latitude";
            this.labelPoint2Latitude.Size = new System.Drawing.Size(117, 16);
            this.labelPoint2Latitude.TabIndex = 17;
            this.labelPoint2Latitude.Text = "Point 2 Latitude:";
            // 
            // timerUpdateDatabase
            // 
            this.timerUpdateDatabase.Enabled = true;
            this.timerUpdateDatabase.Interval = 1000;
            this.timerUpdateDatabase.Tick += new System.EventHandler(this.timerUpdateDatabase_Tick);
            // 
            // FormGmap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 676);
            this.Controls.Add(this.labelPoint1Latitude);
            this.Controls.Add(this.labelPoint2Latitude);
            this.Controls.Add(this.labelPoint1Longitude);
            this.Controls.Add(this.labelPoint2Longitude);
            this.Controls.Add(this.labelTimestamp);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelReportName);
            this.Controls.Add(this.labelReportId);
            this.Controls.Add(this.textBoxReportName);
            this.Controls.Add(this.textBoxPoint2Longitude);
            this.Controls.Add(this.textBoxPoint2Latitude);
            this.Controls.Add(this.textBoxPoint1Longitude);
            this.Controls.Add(this.textBoxPoint1Latitude);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxTimeStamp);
            this.Controls.Add(this.textBoxReportId);
            this.Controls.Add(this.dataGridViewTrafikdata);
            this.Controls.Add(this.buttonGetAarhusTrafikdata);
            this.Controls.Add(this.gmap);
            this.Name = "FormGmap";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trafikdata Aarhus Map";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGmap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrafikdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Button buttonGetAarhusTrafikdata;
        private System.Windows.Forms.DataGridView dataGridViewTrafikdata;
        private System.Windows.Forms.TextBox textBoxReportId;
        private System.Windows.Forms.TextBox textBoxTimeStamp;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxPoint1Latitude;
        private System.Windows.Forms.TextBox textBoxPoint1Longitude;
        private System.Windows.Forms.TextBox textBoxPoint2Latitude;
        private System.Windows.Forms.TextBox textBoxPoint2Longitude;
        private System.Windows.Forms.TextBox textBoxReportName;
        private System.Windows.Forms.Label labelReportId;
        private System.Windows.Forms.Label labelReportName;
        private System.Windows.Forms.Label labelTimestamp;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelPoint1Longitude;
        private System.Windows.Forms.Label labelPoint2Longitude;
        private System.Windows.Forms.Label labelPoint1Latitude;
        private System.Windows.Forms.Label labelPoint2Latitude;
        private System.Windows.Forms.Timer timerUpdateDatabase;
    }
}

