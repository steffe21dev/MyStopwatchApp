using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;

namespace MyStopwatchApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        Stopwatch stopwatch;

        public MainPage()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();

        }

        private void BtnStart_Clicked(object sender, EventArgs e)
        {
            stopwatch.Start();

            Device.StartTimer(TimeSpan.FromMilliseconds(100), () => {

                tidsLabel.Text = stopwatch.Elapsed.ToString();


                return true;
            });
        }

        private void BtnStop_Clicked(object sender, EventArgs e)
        {
            stopwatch.Stop();
            btnStart.Text = "Fortsätt";
        }

        private void BtnReset_Clicked(object sender, EventArgs e)
        {
            stopwatch.Reset();
            tidsLabel.Text = "00:00:00.00000";
            btnStart.Text = "Starta";

        }
    }
}
