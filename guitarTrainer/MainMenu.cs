﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
			itemDisplay ex = new itemDisplay("Warm Up");
			ex.Show();
		}

		private void btn_riff_Click(object sender, EventArgs e)
		{
			chekStartingTime();
			itemDisplay ex = new itemDisplay("Riff");
			ex.Show();
		}

		private void btn_solo_Click(object sender, EventArgs e)
		{
			chekStartingTime();
			itemDisplay ex = new itemDisplay("Solo");
			ex.Show();
		}

		private void btn_fun_Click(object sender, EventArgs e)
		{
			chekStartingTime();
			itemDisplay ex = new itemDisplay("Fun");
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

		private void btn_timer_raz_Click(object sender, EventArgs e)
		{
			timerTot = TimeSpan.Zero;
			startingPeriod = DateTime.Now;
			displayTimer();
		}

		private void btn_raz_all_Click(object sender, EventArgs e)
		{

		}
	}
}
