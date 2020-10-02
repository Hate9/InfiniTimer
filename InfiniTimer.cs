using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace InfiniTimer
{
    public partial class InfiniTimer : Form
    {
        private readonly SoundPlayer alarmSound = new SoundPlayer(Properties.Resources.alarm);
        private readonly Random rng = new Random();
        private long _clockTicks = 0;
        public long ClockTicks
        {
            get => _clockTicks;
            set
            {
                _clockTicks = value;

                long temp = value;
                int minutes = (int)(temp / 6000.0);
                temp -= minutes * 6000;
                int seconds = (int)(temp / 100.0);
                temp -= seconds * 100;
                int centiseconds = (int)temp;

                timerLabel.Text = minutes.ToString() + ":" + seconds.ToString("D2") + "." + centiseconds.ToString("D2");
            }
        }

        public InfiniTimer()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Option[] options = JsonConvert.DeserializeObject<Option[]>(Properties.Settings.Default.Options);
            if (options != null && options.Length != 0)
            {
                optionsList.Items.AddRange(options);
            }
            timerMin.Value = Properties.Settings.Default.Min;
            timerMax.Value = Properties.Settings.Default.Max;
            timerUnit.Text = Properties.Settings.Default.UnitName;
            alarmSound.Load();
        }

        private void AddAttribute_Click(object sender, EventArgs e)
        {
            if (attributeMax.Value >= attributeMin.Value && attributeName.Text != "")
            {
                Attribute temp = new Attribute(attributeName.Text, (int)attributeMin.Value, (int)attributeMax.Value);
                attributesList.Items.Add(temp);
                attributeName.Clear();
                attributeMin.Value = 0;
                attributeMax.Value = 0;
            }
        }

        private void RemoveAttribute_Click(object sender, EventArgs e)
        {
            if (attributesList.SelectedItem != null)
            {
                attributesList.Items.Remove(attributesList.SelectedItem);
            }
        }

        private void AddOption_Click(object sender, EventArgs e)
        {
            if (optionName.Text != "")
            {
                List<Attribute> attributes = attributesList.Items.Cast<Attribute>().ToList();
                Option temp = new Option(optionName.Text, attributes);
                optionsList.Items.Add(temp);
                optionName.Clear();
                attributesList.Items.Clear();

                Properties.Settings.Default.Options = JsonConvert.SerializeObject(optionsList.Items.Cast<Option>().ToArray());
                Properties.Settings.Default.Save();
            }
        }

        private void RemoveOption_Click(object sender, EventArgs e)
        {
            if (optionsList.SelectedItem != null)
            {
                optionsList.Items.Remove(optionsList.SelectedItem);

                Properties.Settings.Default.Options = JsonConvert.SerializeObject(optionsList.Items.Cast<Option>().ToArray());
                Properties.Settings.Default.Save();
            }
        }

        private void TimerMin_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Min = timerMin.Value;
            Properties.Settings.Default.Save();
        }

        private void TimerMax_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Max = timerMax.Value;
            Properties.Settings.Default.Save();
        }

        private void TimerUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UnitName = timerUnit.Text;
            Properties.Settings.Default.Save();
        }

        private void StartTimer(object sender = null, EventArgs e = null)
        {
            if (!randomTimer.Enabled && !clockTimer.Enabled && timerMax.Value >= timerMin.Value && !(timerMax.Value == 0 && timerMin.Value == 0))
            {
                int unitMult;
                switch (timerUnit.Text.ToLower())
                {
                    case "hours":
                        unitMult = 1000 * 60 * 60;
                        break;
                    case "minutes":
                        unitMult = 1000 * 60;
                        break;
                    default:
                    case "seconds":
                        unitMult = 1000;
                        break;
                    case "milliseconds":
                        unitMult = 1;
                        break;
                }

                int interval = rng.Next((int)(timerMin.Value * unitMult), (int)(timerMax.Value * unitMult));
                if (interval <= 0)
                {
                    interval = 1;
                }
                randomTimer.Interval = interval;

                randomTimer.Start();
                clockTimer.Start();
            }
        }

        private void StopTimer(object sender = null, EventArgs e = null)
        {
            randomTimer.Stop();
            clockTimer.Stop();
            ClockTicks = 0;
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            ClockTicks += ((Timer)sender).Interval / 10;//might as well make the function as generic as possible, right?
        }

        private void RandomTimer_Tick(object sender, EventArgs e)
        {
            StopTimer();

            if (optionsList.Items.Count != 0)
            {
                int optionNum = rng.Next(optionsList.Items.Count);
                Option temp = (Option)optionsList.Items[optionNum];

                string attributes = temp.label;
                foreach (Attribute attribute in temp.attributes)
                {
                    if (attribute.min == 0 && attribute.max == 0)
                    {
                        attributes += "\r\n" + attribute.label;
                    }
                    else
                    {
                        attributes += "\r\n" + $"{attribute.label}: {rng.Next(attribute.min, attribute.max)}";
                    }
                }

                alarmSound.Play();
                MessageBox.Show(attributes, "Timer Finished!");
                alarmSound.Stop();
            }
            else
            {
                alarmSound.Play();
                MessageBox.Show("Timer Finished!", "Timer Finished!");
                alarmSound.Stop();
            }

            StartTimer();
        }
    }

    /// <summary>
    /// Represents an evenly weighted random option, with an arbitrary number of random numeric properties (attributes).
    /// </summary>
    public class Option
    {
        public string label;
        public List<Attribute> attributes;

        public Option(string label, List<Attribute> attributes)
        {
            this.label = label;
            this.attributes = attributes;
        }

        public override string ToString()
        {
            return label;
        }
    }

    /// <summary>
    /// Represents a random numeric property.
    /// </summary>
    public class Attribute
    {
        public string label;
        public int min;
        public int max;

        public Attribute(string label, int min, int max)
        {
            this.label = label;
            this.min = min;
            this.max = max;
        }

        public override string ToString()
        {
            return label;
        }
    }
}
