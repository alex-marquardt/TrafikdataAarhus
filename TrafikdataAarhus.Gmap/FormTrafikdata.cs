namespace TrafikdataAarhus.Gmap
{
    using System.Windows.Forms;
    using TrafikdataAarhus.Gmap.DataProviders;

    public partial class FormTrafikdata : Form
    {
        private TrafikdataDataProvider _trafikdataDataProvider;

        public FormTrafikdata()
        {
            InitializeComponent();
            _trafikdataDataProvider = new TrafikdataDataProvider();
        }

        private void FormTrafikdata_Load(object sender, System.EventArgs e)
        {
            var trafikdata = _trafikdataDataProvider.GetTrafikdataAarhus();
            dataGridViewTrafikdata.DataSource = trafikdata;
        }
    }
}
