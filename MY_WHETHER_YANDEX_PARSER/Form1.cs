using MY_WHETHER_YANDEX_PARSER.API;
using MY_WHETHER_YANDEX_PARSER.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_WHETHER_YANDEX_PARSER
{
    public partial class Form1 : Form
    {
        private CoordData coordData;
        private WeatherData weatherData;

        public Form1()
        {
            InitializeComponent();
            comboBoxCities.SelectedIndex = 0;
            buttonGetWeather.Select();
        }

        private void buttonGetWeather_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy == false)
            {
                backgroundWorker.RunWorkerAsync(comboBoxCities.SelectedItem);
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string cityName = e.Argument.ToString();

            coordData = ApiWorker.GetCoordData(cityName);
            weatherData = ApiWorker.GetWeatherData(coordData);
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            labelCityName.Text = coordData.CityName;
            labelLat.Text = coordData.Lat;
            labelLon.Text = coordData.Lon;

            labelTemp.Text = weatherData.Temp;
            labelCondition.Text = ApiHelper.GetWeatherCondition(weatherData.Condition);
            labelWindSpeed.Text = weatherData.WindSpeed;
            labelWindDir.Text = ApiHelper.GetWinDir(weatherData.WindDir);
            labelPressureMM.Text = weatherData.PressureMM;
            labelHumidity.Text = weatherData.Humidity;
        }

        
    }
}
