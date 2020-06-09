using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class WeaterComponent : UserControl
    {

        private bool enableBlackTheme;


        public WeaterComponent()
        {
            InitializeComponent();
        }

        public void clear()
        {
            setWeatherValues("Temperature", "Sunrise and Sunset", "City", "Pressure", "Date", "Coordinates", "Humidity");
        }

        public void setWeatherValues(string temperature, string sunriseAndSunset, string city, string pressure, string date, string coordinates, string humidity)
        {
            temperatureButton.Text = temperature;
            sunTimesButton.Text = sunriseAndSunset;
            cityButton.Text = city;
            humidityButton.Text = humidity;
            pressureButton.Text = pressure;
            coordinatesButton.Text = coordinates;
            dateButton.Text = date;
        }

        public TextBox getSearchField()
        {
            return searchBox;
        }


        public Button getSearchButton()
        {
            return searchButton;
        }

        public Button getClearButton()
        {
            return clearButton;
        }

        public Button getSaveButton()
        {
            return saveButton;
        }

        public ListView getHistory()
        {
            return historyList;
        }

        public bool EnableBlackTheme
        {
            get
            {
                return enableBlackTheme;
            }

            set
            {
                enableBlackTheme = value;

                if (enableBlackTheme) 
                {
                    historyList.BackColor = Color.Black;
                    weatherTable.BackColor = Color.Black;
                    searchBox.BackColor = Color.Black;
                    historyList.ForeColor = Color.White;
                    weatherTable.ForeColor = Color.White;
                    searchBox.ForeColor = Color.White;
                    this.BackColor = Color.Black;
                    this.ForeColor = Color.White;
                    foreach (Control btn in weatherTable.Controls)
                    {

                        btn.BackColor = Color.Black;
                        btn.ForeColor = Color.White;
                    }
                    clearButton.BackColor = Color.Black;
                    clearButton.ForeColor = Color.White;
                    saveButton.BackColor = Color.Black;
                    saveButton.ForeColor = Color.White;
                }
                else
                {
                    historyList.BackColor = Color.White;
                    weatherTable.BackColor = Color.White;
                    searchBox.BackColor = Color.White;
                    this.BackColor = Color.White;
                    this.ForeColor = Color.Black;
                    historyList.ForeColor = Color.Black;
                    weatherTable.ForeColor = Color.Black;
                    searchBox.ForeColor = Color.Black;
                    foreach (Control btn in weatherTable.Controls)
                    {
                        btn.BackColor = Color.White;
                        btn.ForeColor = Color.Black;
                    }

                    clearButton.BackColor = Color.White;
                    clearButton.ForeColor = Color.Black;
                    saveButton.BackColor = Color.White;
                    saveButton.ForeColor = Color.Black;
                }
                
            }

        }

    }
}
