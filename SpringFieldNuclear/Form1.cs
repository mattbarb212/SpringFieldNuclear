using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace SpringFieldNuclear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alert);
            alertPlayer.Play();
            OutputLabel.BackColor = Color.Red;
            OutputLabel.Text = "Meltdown Imminent";
            reactor2StateLabel.BackColor = Color.Red;
            reactor1StateLabel.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(500);

            reactor2StateLabel.BackColor = Color.Green;
            reactor1StateLabel.BackColor = Color.Green;
            OutputLabel.BackColor = Color.Green;

            Refresh();
            Thread.Sleep(500);

            reactor2StateLabel.BackColor = Color.Red;
            reactor1StateLabel.BackColor = Color.Red;
            OutputLabel.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(500);

            reactor2StateLabel.BackColor = Color.Green;
            reactor1StateLabel.BackColor = Color.Green;
            OutputLabel.BackColor = Color.Green;

            Refresh();
            Thread.Sleep(500);

            reactor2StateLabel.BackColor = Color.Red;
            reactor1StateLabel.BackColor = Color.Red;
            OutputLabel.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(500);

            reactor2StateLabel.BackColor = Color.Green;
            reactor1StateLabel.BackColor = Color.Green;
            OutputLabel.BackColor = Color.Green;

            Refresh();
            Thread.Sleep(500);

            reactor2StateLabel.BackColor = Color.Red;
            reactor1StateLabel.BackColor = Color.Red;
            OutputLabel.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(500);

            reactor2StateLabel.BackColor = Color.Green;
            reactor1StateLabel.BackColor = Color.Green;
            OutputLabel.BackColor = Color.Green;
        }
    }
}