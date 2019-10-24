namespace TrafikdataAarhus.Gmap
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using GMap.NET;
    using GMap.NET.MapProviders;
    using GMap.NET.WindowsForms;
    using GMap.NET.WindowsForms.Markers;

    public partial class FormGmap : Form
    {
        public FormGmap()
        {
            InitializeComponent();
        }

        private void FormGmap_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = BingMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gmap.ShowCenter = false;

            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(56.1712485170938, 10.15683662714), GMarkerGoogleType.green_dot);
            GMapMarker marker2 = new GMarkerGoogle(new PointLatLng(56.1763699180381, 10.1785437446976), GMarkerGoogleType.green_dot);

            // Start point tooltip
            marker.ToolTipText = "ReportId: " + 1164 + ". Status: OK" + "\n Start: " + 56.1712485170938 + ", " + 10.15683662714;
            marker.ToolTip.Fill = Brushes.White;
            marker.ToolTip.Foreground = Brushes.Black;
            marker.ToolTip.Stroke = Pens.Black;
            marker.ToolTip.TextPadding = new Size(10, 10);
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;

            // End point tooltip
            marker2.ToolTipText = "ReportId: " + 1164 + ". Status: OK" + "\n End: " + 56.1763699180381 + ", " + 10.1785437446976;
            marker2.ToolTip.Fill = Brushes.White;
            marker2.ToolTip.Foreground = Brushes.Black;
            marker2.ToolTip.Stroke = Pens.Black;
            marker2.ToolTip.TextPadding = new Size(10, 10);
            marker2.ToolTipMode = MarkerTooltipMode.OnMouseOver;

            markers.Markers.Add(marker);
            markers.Markers.Add(marker2);
            gmap.Overlays.Add(markers);

            gmap.Position = new PointLatLng(56.1763699180381, 10.1785437446976);
        }
    }
}
