using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformModbus.Forms
{
    public partial class FormStatistic : Form
    {
        List<StatisticDB> statisticList = new List<StatisticDB>();
        private static FormStatistic instance;
        public static FormStatistic getInstance()
        {
            if (instance == null)
                instance = new FormStatistic();
            return instance;
        }
        public FormStatistic()
        {
            InitializeComponent();

            cartesianChart1.LegendLocation = LegendLocation.Right;

        }


        private void FormStatistic_Load(object sender, EventArgs e)
        {
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new DataAccess();
                statisticList = db.GetModbusDB(comTextBox.Text, baudTextBox.Text, databitsTextBox.Text, stopbitsTextBox.Text, parityTextBox.Text, addressTextBox.Text,functionTextBox.Text, pollTextBox.Text, responseTextBox.Text);

                List<string> baudList = new List<string>();
                List<double> respList = new List<double>();
                foreach (var _sta in statisticList)
                {
                    respList.Add(_sta.ResponseCount);
                    baudList.Add(_sta.Baud.ToString());
                }
                UpdateBinding();

                cartesianChart1.Series = new SeriesCollection
                {
                    new LineSeries
                    {
                        Values = new ChartValues<double> {}
                    },
                };
                foreach (var resp in respList) cartesianChart1.Series[0].Values.Add(resp);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.searchListbox.DataSource = null;
                this.searchListbox.Items.Clear();
                this.cartesianChart1.Series.Clear();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public SeriesCollection SeriesCollection { get; set; }
        public List<string> Labels { get; set; }
        public Func<double, string> Formatter { get; set; }




        private void UpdateBinding()
        {
            searchListbox.DataSource = statisticList;
            searchListbox.DisplayMember = "Info";
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertModbusDB(Int32.Parse(comTextBox.Text), Int32.Parse(baudTextBox.Text), Int32.Parse(databitsTextBox.Text), Int32.Parse(stopbitsTextBox.Text), Int32.Parse(parityTextBox.Text), Int32.Parse(addressTextBox.Text), Int32.Parse(functionTextBox.Text), Int32.Parse(pollTextBox.Text), Int32.Parse(responseTextBox.Text));
            comTextBox.Text = "";
            baudTextBox.Text = "";
            databitsTextBox.Text = "";
            stopbitsTextBox.Text = "";
            parityTextBox.Text = "";
            addressTextBox.Text = "";
            functionTextBox.Text = "";
            pollTextBox.Text = "";
            responseTextBox.Text = "";
        }
    }
}
