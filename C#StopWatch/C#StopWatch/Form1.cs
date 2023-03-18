using System;
using System.Windows.Forms;

namespace C_StopWatch
{
    public partial class Stop_Watch : Form
    {
        private DateTime startTime;
        private DateTime stopTime;
        private TimeSpan elapsedTime;
        private bool isRunning = false;

        public Stop_Watch()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                // stop the stopwatch
                stopTime = DateTime.Now;
                elapsedTime = stopTime - startTime;
                isRunning = false;
                startStopButton.Text = "Start";
                lapButton.Enabled = false;
                timer1.Stop();
            }
            else
            {
                // start the stopwatch
                startTime = DateTime.Now;
                isRunning = true;
                startStopButton.Text = "Stop";
                lapButton.Enabled = true;
                timer1.Start();
            }

            updateTimer();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // reset the stopwatch
            startTime = DateTime.MinValue;
            stopTime = DateTime.MinValue;
            elapsedTime = TimeSpan.Zero;
            isRunning = false;
            lapButton.Enabled = false;
            lapTimesListBox.Items.Clear();

            updateTimer();
        }

        private void lapButton_Click(object sender, EventArgs e)
        {
            // add lap time to listbox
            lapTimesListBox.Items.Insert(0, elapsedTime.ToString(@"hh\:mm\:ss\.fff"));
        }

        private void updateTimer()
        {
            // update the stopwatch time label
            if (isRunning)
            {
                elapsedTime = DateTime.Now - startTime;
            }

            timerLabel.Text = elapsedTime.ToString(@"hh\:mm\:ss\.fff");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // update the stopwatch time label
            updateTimer();
        }
    }
}
