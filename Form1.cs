﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.Location;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Weather
{
    public partial class Form1 : Form
    {
        const string APIID = "846f12aa31d2907a0bbb26f484c1c60f";
        string units = "metric";
        private GeoCoordinateWatcher Watcher = null;
        public Form1()
        {
            InitializeComponent();
        }



        void getWeather(double lat, double lon)
        {
            string url = string.Format("https://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&units={2}&appid={3}", lat, lon, units, APIID);
            createQuery(url);
        }
        void getWeather(string cityName)
        {

            string url = "https://api.openweathermap.org/data/2.5/weather?q=" + cityName + "&units=" + units + "&appid=" + APIID;
            createQuery(url);
        }
        void createQuery(string url) 
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    var json = web.DownloadString(url);
                    var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                    WeatherInfo.root output = result;
                    fillLables(output);
                }
                catch (WebException e) {
                    lbl_cityname.Text = e.Message;
                }
            }
        }

        void fillLables(WeatherInfo.root output)
        {
            lbl_cityname.Text = string.Format("{0} {1}", output.name, output.sys.country);
            lbl_units.Text = "\u00B0C";
            lbl_temp.Text = string.Format("{0}", output.main.temp);
            lbl_humidity.Text = string.Format("{0}%", output.main.humidity);
            lbl_wind.Text = string.Format("{0} м/с", output.wind.speed);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Watcher = new GeoCoordinateWatcher();
            
            Watcher.StatusChanged += Watcher_StatusChanged;


            Watcher.Start();
        }

        private void Watcher_StatusChanged(object sender,
    GeoPositionStatusChangedEventArgs e)
        {
            if (e.Status == GeoPositionStatus.Ready)
            {
                if (Watcher.Position.Location.IsUnknown)
                {
                    lbl_cityname.Text = "Cannot find location data";
                }
                else
                {
                    GeoCoordinate location =
                    Watcher.Position.Location;
                    double lat, lon;
                    lat = location.Latitude;
                    lon = location.Longitude;
                    lbl_lat.Text = location.Latitude.ToString();
                    lbl_lon.Text = location.Longitude.ToString();
                    getWeather(lat, lon);
                }
            }
        }


        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (lbl_temp.Text == "*") return;
            double arg = Convert.ToDouble(lbl_temp.Text);
            double result;
            if (units == "metric")
            {
                lbl_units.Text = "\u00B0F";
                units = "imperial";
                result = (arg * 9) / 5 + 32;
            }
            else
            {
                lbl_units.Text = "\u00B0C";
                units = "metric";
                result = (arg - 32) * 5 / 9;
            }
            lbl_temp.Text = result.ToString();
        }

    }
    }