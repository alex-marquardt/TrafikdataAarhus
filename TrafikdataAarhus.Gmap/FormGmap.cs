namespace TrafikdataAarhus.Gmap
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using GMap.NET;
    using GMap.NET.MapProviders;
    using GMap.NET.WindowsForms;
    using GMap.NET.WindowsForms.Markers;
    using TrafikdataAarhus.ApiData.Data;
    using TrafikdataAarhus.ApiData.DataProviders;
    using TrafikdataAarhus.Gmap.Data;
    using TrafikdataAarhus.Gmap.DataProviders;

    public partial class FormGmap : Form
    {
        private TrafikdataModel _selectedRowModel;
        private RealtidsTrafikdataDataProvider _realtidsTrafikdataDataProvider;
        private TrafikdataDataProvider _trafikdataDataProvider;
        private int _ticks;

        // constructor
        public FormGmap()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
            _selectedRowModel = new TrafikdataModel();
            _trafikdataDataProvider = new TrafikdataDataProvider();
            _realtidsTrafikdataDataProvider = new RealtidsTrafikdataDataProvider();
        }

        // Load form
        private void FormGmap_Load(object sender, EventArgs e)
        {
            // Use Bing mapprovider and use server access to get map
            gmap.MapProvider = BingMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            // Remove red cross
            gmap.ShowCenter = false;

            // Start coordinates (Aarhus)
            gmap.Position = new PointLatLng(56.15674, 10.21076);

            // Add data from database to datagridview
            dataGridViewTrafikdata.DataSource = _trafikdataDataProvider.GetTrafikdataAarhus();
        }

        // Click on cell in datagridview
        private void dataGridViewTrafikdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MappingSelecteRowToTrafikdataModel(e.RowIndex);
            MappingSelectedRowToTextBox();
            DrawMarkers();
            DrawRoute();
        }

        // Get new update from database
        private void buttonGetNewTrafikdataUpdate_Click(object sender, EventArgs e)
        {
            dataGridViewTrafikdata.DataSource = _trafikdataDataProvider.GetTrafikdataAarhus();

            // disable update button
            buttonGetNewTrafikdataUpdate.Enabled = false;

            //// Update RuteMaalePunkterMetadata with new information
            //var ruteMaalePunkterMetadata = new RuteMaalepunkterMetadataDataProvider();
            //await ruteMaalePunkterMetadata.GetruteMaalepunkterMetadataAarhus();
        }

        // Timer for update realtidstrafikdata tabel every 5 min
        private async void timerUpdateDatabase_Tick(object sender, EventArgs e)
        {
            _ticks++;

            if (_ticks == 300)
            {
                await _realtidsTrafikdataDataProvider.GetRealtidsTrafikdataAarhus();
                _ticks = 0;
                buttonGetNewTrafikdataUpdate.Enabled = true;
            }
        }

        // Draw markers on map
        private void DrawMarkers()
        {
            // Clear and adding model points as markers
            gmap.Overlays.Clear();        
            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(_selectedRowModel.Point1Latitude, _selectedRowModel.Point1Longitude), GMarkerGoogleType.green_dot);
            GMapMarker marker2 = new GMarkerGoogle(new PointLatLng(_selectedRowModel.Point2Latitude, _selectedRowModel.Point2Longitude), GMarkerGoogleType.green_dot);

            // Start point tooltip
            marker.ToolTipText = "ReportId: " + _selectedRowModel.ReportId + ". Status: " + _selectedRowModel.Status + "\n Start: " + _selectedRowModel.Point1Latitude + ", " + _selectedRowModel.Point1Longitude;
            marker.ToolTip.Fill = Brushes.White;
            marker.ToolTip.Foreground = Brushes.Black;
            marker.ToolTip.Stroke = Pens.Black;
            marker.ToolTip.TextPadding = new Size(10, 10);
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;

            // End point tooltip
            marker2.ToolTipText = "ReportId: " + _selectedRowModel.ReportId + ". Status: " + _selectedRowModel.Status + "\n End: " + _selectedRowModel.Point2Latitude + ", " + _selectedRowModel.Point2Longitude;
            marker2.ToolTip.Fill = Brushes.White;
            marker2.ToolTip.Foreground = Brushes.Black;
            marker2.ToolTip.Stroke = Pens.Black;
            marker2.ToolTip.TextPadding = new Size(10, 10);
            marker2.ToolTipMode = MarkerTooltipMode.OnMouseOver;

            markers.Markers.Add(marker);
            markers.Markers.Add(marker2);
            gmap.Overlays.Add(markers);

            // Set position to point 1 coordinates
            gmap.Position = new PointLatLng(_selectedRowModel.Point1Latitude, _selectedRowModel.Point1Longitude);
        }

        // Draw route from 2 points on the map
        private void DrawRoute()
        {
            GMapOverlay routes = new GMapOverlay("routes");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(_selectedRowModel.Point1Latitude, _selectedRowModel.Point1Longitude));
            points.Add(new PointLatLng(_selectedRowModel.Point2Latitude, _selectedRowModel.Point2Longitude));

            GMapRoute route = new GMapRoute(points, "my route");
            route.Stroke = new Pen(Color.ForestGreen, 3);
            routes.Routes.Add(route);
            gmap.Overlays.Add(routes);

            // Set position to point 1 coordinates
            gmap.Position = new PointLatLng(_selectedRowModel.Point1Latitude, _selectedRowModel.Point1Longitude);
        }

        // Mapper selected row to trafikdata model
        private void MappingSelecteRowToTrafikdataModel(int indexOfRow)
        {
            _selectedRowModel.Id = (int)dataGridViewTrafikdata.Rows[indexOfRow].Cells[0].Value;
            _selectedRowModel.ReportId = (int)dataGridViewTrafikdata.Rows[indexOfRow].Cells[1].Value;
            _selectedRowModel.TimeStamp = Convert.ToDateTime(dataGridViewTrafikdata.Rows[indexOfRow].Cells[2].Value);
            _selectedRowModel.Status = (string)dataGridViewTrafikdata.Rows[indexOfRow].Cells[3].Value;
            _selectedRowModel.AvgMeasuredTime = (int)dataGridViewTrafikdata.Rows[indexOfRow].Cells[4].Value;
            _selectedRowModel.MedianMeasuredTime = (int)dataGridViewTrafikdata.Rows[indexOfRow].Cells[5].Value;
            _selectedRowModel.VehicleCount = (int)dataGridViewTrafikdata.Rows[indexOfRow].Cells[6].Value;
            _selectedRowModel.AvgSpeed = (int)dataGridViewTrafikdata.Rows[indexOfRow].Cells[7].Value;
            _selectedRowModel.ReportName = (string)dataGridViewTrafikdata.Rows[indexOfRow].Cells[8].Value;
            _selectedRowModel.Organisation = (string)dataGridViewTrafikdata.Rows[indexOfRow].Cells[9].Value;
            _selectedRowModel.RbaId = (int)dataGridViewTrafikdata.Rows[indexOfRow].Cells[10].Value;
            _selectedRowModel.Point1Name = (string)dataGridViewTrafikdata.Rows[indexOfRow].Cells[11].Value;
            _selectedRowModel.Point1Latitude = (float)dataGridViewTrafikdata.Rows[indexOfRow].Cells[12].Value;
            _selectedRowModel.Point1Longitude = (float)dataGridViewTrafikdata.Rows[indexOfRow].Cells[13].Value;
            _selectedRowModel.Point1Street = (string)dataGridViewTrafikdata.Rows[indexOfRow].Cells[14].Value;
            _selectedRowModel.Point1StreetNumber = (string)dataGridViewTrafikdata.Rows[indexOfRow].Cells[15].Value;
            _selectedRowModel.Point1PostalCode = (string)dataGridViewTrafikdata.Rows[indexOfRow].Cells[16].Value;
            _selectedRowModel.Point1City = (string)dataGridViewTrafikdata.Rows[indexOfRow].Cells[17].Value;
            _selectedRowModel.Point1Country = (string)dataGridViewTrafikdata.Rows[indexOfRow].Cells[18].Value;
            _selectedRowModel.Point2Name = (string)dataGridViewTrafikdata.Rows[indexOfRow].Cells[19].Value;
            _selectedRowModel.Point2Latitude = (float)dataGridViewTrafikdata.Rows[indexOfRow].Cells[20].Value;
            _selectedRowModel.Point2Longitude = (float)dataGridViewTrafikdata.Rows[indexOfRow].Cells[21].Value;
            _selectedRowModel.Point2Street = (string)dataGridViewTrafikdata.Rows[indexOfRow].Cells[22].Value;
            _selectedRowModel.Point2StreetNumber = (string)dataGridViewTrafikdata.Rows[indexOfRow].Cells[23].Value;
            _selectedRowModel.Point2PostalCode = (string)dataGridViewTrafikdata.Rows[indexOfRow].Cells[24].Value;
            _selectedRowModel.Point2City = (string)dataGridViewTrafikdata.Rows[indexOfRow].Cells[25].Value;
            _selectedRowModel.Point2Country = (string)dataGridViewTrafikdata.Rows[indexOfRow].Cells[26].Value;
            _selectedRowModel.DurationInSeconds = (int)dataGridViewTrafikdata.Rows[indexOfRow].Cells[27].Value;
            _selectedRowModel.DistanceInMeters = (int)dataGridViewTrafikdata.Rows[indexOfRow].Cells[28].Value;
            _selectedRowModel.NdtInKmh = (int)dataGridViewTrafikdata.Rows[indexOfRow].Cells[29].Value;
            _selectedRowModel.RoadType = (string)dataGridViewTrafikdata.Rows[indexOfRow].Cells[30].Value;
        }

        // Mapper trafikdata model to textbox
        private void MappingSelectedRowToTextBox()
        {
            textBoxReportId.Text = _selectedRowModel.ReportId.ToString();
            textBoxReportName.Text = _selectedRowModel.ReportName.ToString();
            textBoxTimeStamp.Text = _selectedRowModel.TimeStamp.ToString();
            textBoxStatus.Text = _selectedRowModel.Status;
            textBoxPoint1Latitude.Text = _selectedRowModel.Point1Latitude.ToString();
            textBoxPoint1Longitude.Text = _selectedRowModel.Point1Longitude.ToString();
            textBoxPoint2Latitude.Text = _selectedRowModel.Point2Latitude.ToString();
            textBoxPoint2Longitude.Text = _selectedRowModel.Point2Longitude.ToString();
        }
    }
}