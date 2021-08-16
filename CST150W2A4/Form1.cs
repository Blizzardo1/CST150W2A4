#define IMPL2
using System;
using System.Windows.Forms;

namespace CST150W2A4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates a new control by proxy of Generic Type T
        /// </summary>
        /// <typeparam name="T">A Generic Type constrained by Controls only</typeparam>
        /// <param name="name">The name of the proposed control</param>
        /// <param name="label">The text value of the proposed control</param>
        /// <returns>A Control constrained T Type</returns>
        private static T CreateControl<T>(string name, string label) where T : Control, new() => new() { Name = name, Text = label, AutoSize = true, Padding = new(8) };

        /// <summary>
        /// Formats an ordinal into a time unit
        /// </summary>
        /// <typeparam name="T">A Generic Type constrained by a number</typeparam>
        /// <param name="t">The generic numerical value to format into a string</param>
        /// <param name="unit">The given time unit</param>
        /// <param name="strip">Strips any preceding text that should not belong in certain parts of a string</param>
        /// <returns></returns>
        private static string FormatOrdinal<T>(T t, string unit, bool strip = false)
            where T : IComparable,
            IComparable<T>, IConvertible, IEquatable<T>, IFormattable, new() {
            
            bool isOne = t.ToDouble(null) == 1;
            return $"{(!strip ? (isOne ? "is " : "are ") : "")}{t} {(isOne ? unit : $"{unit}s")}";
        }

        /// <summary>
        /// Disposes each control then proceeds to remove them.
        /// </summary>
        private void KillControls()
        {
            foreach(Control c in flp.Controls)
            {
                c.Dispose();
            }
            flp.Controls.Clear();
        }

        /// <summary>
        /// Converts the user input into human readable time units
        /// </summary>
        // It's Show Time!
        private void ShowTime()
        {
            KillControls();
            if(!double.TryParse(secondsTxt.Text, out double seconds))
            {
                NativeMethods.Error(this, "Not a number!", "Error");
                return;
            }
            string secstr = FormatOrdinal(seconds, "second", true);
            double minutes = Math.Round(seconds / 60, 2);
            double hours = Math.Round(seconds / 3600, 2);
            double days = Math.Round(seconds / 86400, 2);
#if IMPL2
            switch (seconds)
            {
                case double _ when seconds < 60:
                    flp.Controls.Add(CreateControl<Label>("Seconds", $"There are {secstr}."));
                    break;
                case double _ when seconds < 3600:
                    flp.Controls.Add(CreateControl<Label>("Minutes", $"There {FormatOrdinal(minutes, "minute")} in {secstr}."));
                    break;
                case double _ when seconds < 86400:
                    flp.Controls.Add(CreateControl<Label>("Hours", $"There {FormatOrdinal(hours, "hour")} in {secstr}."));
                    break;
                case double _ when seconds < double.MaxValue:
                    flp.Controls.Add(CreateControl<Label>("Days", $"There {FormatOrdinal(days, "day")} in {secstr}."));
                    break;
                default:
                    flp.Controls.Add(CreateControl<Label>("World", "Out of this world!"));
                    break;

            }
#else
            flp.Controls.Add(CreateControl<Label>("Minutes", $"There {FormatOrdinal(minutes, "minute")} in {secstr}."));
            flp.Controls.Add(CreateControl<Label>("Hours", $"There {FormatOrdinal(hours, "hour")} in {secstr}."));
            flp.Controls.Add(CreateControl<Label>("Days", $"There {FormatOrdinal(days, "day")} in {secstr}."));
            //flp.Controls.Add(CreateControl<Label>("TimeFrame", $"{FormatOrdinal(Math.Floor(days), "day", true)}, {FormatOrdinal(Math.Floor(hours % 24), "hour", true)}, {FormatOrdinal(Math.Floor(minutes % 60), "minute", true)}, and {FormatOrdinal(Math.Floor(seconds % 60), "second", true)}"));
#endif
        }

        /// <summary>
        /// Basic implementation of the Time Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeBtn_Click(object sender, EventArgs e)
        {
            ShowTime();
            secondsTxt.Clear();
        }
    }
}
