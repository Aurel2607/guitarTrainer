using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;
using System.Collections.Specialized;

namespace guitarTrainer
{
	public partial class MainMenu : Form
	{
		private bool timerIsRunning = false;
		private DateTime startingPeriod;
		private TimeSpan timerTot = new TimeSpan(0);

		public MainMenu()
		{
			InitializeComponent();
		}

		private void btn_warmUp_Click(object sender, EventArgs e)
		{
			chekStartingTime();

			List<string[]> wuLst = AppConfigParser.parse("WU");

			foreach(string[] strTab in wuLst)
			{
				Console.WriteLine("Name:'" + strTab[0] + "', Pic:'" + strTab[1] + "', Audio:'" + strTab[2] + "', Video:'" + strTab[3]);
			}

			sectionDisplay ex = new sectionDisplay("WarmUp", wuLst);
			ex.Show();


		}

		private void btn_riff_Click(object sender, EventArgs e)
		{
			chekStartingTime();
			sectionDisplay ex = new sectionDisplay("Riff");
			ex.Show();
		}

		private void btn_solo_Click(object sender, EventArgs e)
		{
			chekStartingTime();
			sectionDisplay ex = new sectionDisplay("Solo");
			ex.Show();
		}

		private void btn_fun_Click(object sender, EventArgs e)
		{
			chekStartingTime();
			sectionDisplay ex = new sectionDisplay("Fun");
			ex.Show();
		}

		private void btn_config_Click(object sender, EventArgs e)
		{

		}

		private void displayTimer()
		{
			TimeSpan dt = (DateTime.Now - startingPeriod) + timerTot;
			lbl_elapse_tot.Text = dt.ToString(@"hh\:mm\:ss");
		}

		private void timerClock_Tick(object sender, EventArgs e)
		{
			lbl_clock.Text = DateTime.Now.ToString("HH:mm:ss");
			if (timerIsRunning == true)
				displayTimer();
		}

		private void chekStartingTime()
		{
			if(timerIsRunning == false)
			{
				startingPeriod = DateTime.Now;
				timerIsRunning = true;
			}
		}

		private void btn_timer_start_Click(object sender, EventArgs e)
		{
			if (timerIsRunning == false)
			{
				startingPeriod = DateTime.Now;
				timerIsRunning = true;
			}
		}

		private void btn_timer_pause_Click(object sender, EventArgs e)
		{
			if (timerIsRunning == true)
			{
				timerTot = timerTot +(DateTime.Now - startingPeriod);
				timerIsRunning = false;
			}
			else
			{
				startingPeriod = DateTime.Now;
				timerIsRunning = true;
			}
		}

		private void btn_timer_raz__Click(object sender, EventArgs e)
		{
			timerTot = TimeSpan.Zero;
			startingPeriod = DateTime.Now;
			displayTimer();
		}

		private void btn_raz_all_Click(object sender, EventArgs e)
		{

		}

		private void btn_test_Click(object sender, EventArgs e)
		{
			frm_TestVlc testVlc = new frm_TestVlc();
			testVlc.Show();
		}
	}
}
