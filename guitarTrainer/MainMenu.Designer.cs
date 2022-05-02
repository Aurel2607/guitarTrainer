namespace guitarTrainer
{
	partial class MainMenu
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btn_warmUp = new System.Windows.Forms.Button();
			this.btn_riff = new System.Windows.Forms.Button();
			this.btn_solo = new System.Windows.Forms.Button();
			this.btn_fun = new System.Windows.Forms.Button();
			this.btn_config = new System.Windows.Forms.Button();
			this.lbl_clock = new System.Windows.Forms.Label();
			this.lbl_elapsed_warmUp = new System.Windows.Forms.Label();
			this.lbl_elapsed_riff = new System.Windows.Forms.Label();
			this.lbl_elapsed_solo = new System.Windows.Forms.Label();
			this.lbl_elapsed_fun = new System.Windows.Forms.Label();
			this.lbl_elapse_tot = new System.Windows.Forms.Label();
			this.timerClock = new System.Windows.Forms.Timer(this.components);
			this.gb_timer = new System.Windows.Forms.GroupBox();
			this.btn_timer_raz = new System.Windows.Forms.Button();
			this.btn_timer_pause = new System.Windows.Forms.Button();
			this.btn_timer_start = new System.Windows.Forms.Button();
			this.btn_raz_all = new System.Windows.Forms.Button();
			this.gb_timer.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_warmUp
			// 
			this.btn_warmUp.Location = new System.Drawing.Point(12, 12);
			this.btn_warmUp.Name = "btn_warmUp";
			this.btn_warmUp.Size = new System.Drawing.Size(89, 31);
			this.btn_warmUp.TabIndex = 0;
			this.btn_warmUp.Text = "WarmUp";
			this.btn_warmUp.UseVisualStyleBackColor = true;
			this.btn_warmUp.Click += new System.EventHandler(this.btn_warmUp_Click);
			// 
			// btn_riff
			// 
			this.btn_riff.Location = new System.Drawing.Point(12, 49);
			this.btn_riff.Name = "btn_riff";
			this.btn_riff.Size = new System.Drawing.Size(89, 31);
			this.btn_riff.TabIndex = 1;
			this.btn_riff.Text = "Riff";
			this.btn_riff.UseVisualStyleBackColor = true;
			this.btn_riff.Click += new System.EventHandler(this.btn_riff_Click);
			// 
			// btn_solo
			// 
			this.btn_solo.Location = new System.Drawing.Point(12, 86);
			this.btn_solo.Name = "btn_solo";
			this.btn_solo.Size = new System.Drawing.Size(89, 31);
			this.btn_solo.TabIndex = 2;
			this.btn_solo.Text = "Solo";
			this.btn_solo.UseVisualStyleBackColor = true;
			this.btn_solo.Click += new System.EventHandler(this.btn_solo_Click);
			// 
			// btn_fun
			// 
			this.btn_fun.Location = new System.Drawing.Point(12, 123);
			this.btn_fun.Name = "btn_fun";
			this.btn_fun.Size = new System.Drawing.Size(89, 31);
			this.btn_fun.TabIndex = 3;
			this.btn_fun.Text = "Fun";
			this.btn_fun.UseVisualStyleBackColor = true;
			this.btn_fun.Click += new System.EventHandler(this.btn_fun_Click);
			// 
			// btn_config
			// 
			this.btn_config.Location = new System.Drawing.Point(12, 180);
			this.btn_config.Name = "btn_config";
			this.btn_config.Size = new System.Drawing.Size(89, 31);
			this.btn_config.TabIndex = 4;
			this.btn_config.Text = "Config";
			this.btn_config.UseVisualStyleBackColor = true;
			this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
			// 
			// lbl_clock
			// 
			this.lbl_clock.AutoSize = true;
			this.lbl_clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_clock.Location = new System.Drawing.Point(265, 12);
			this.lbl_clock.Name = "lbl_clock";
			this.lbl_clock.Size = new System.Drawing.Size(79, 20);
			this.lbl_clock.TabIndex = 5;
			this.lbl_clock.Text = "00:00:00";
			// 
			// lbl_elapsed_warmUp
			// 
			this.lbl_elapsed_warmUp.AutoSize = true;
			this.lbl_elapsed_warmUp.Location = new System.Drawing.Point(107, 21);
			this.lbl_elapsed_warmUp.Name = "lbl_elapsed_warmUp";
			this.lbl_elapsed_warmUp.Size = new System.Drawing.Size(49, 13);
			this.lbl_elapsed_warmUp.TabIndex = 6;
			this.lbl_elapsed_warmUp.Text = "00:00:00";
			// 
			// lbl_elapsed_riff
			// 
			this.lbl_elapsed_riff.AutoSize = true;
			this.lbl_elapsed_riff.Location = new System.Drawing.Point(107, 58);
			this.lbl_elapsed_riff.Name = "lbl_elapsed_riff";
			this.lbl_elapsed_riff.Size = new System.Drawing.Size(49, 13);
			this.lbl_elapsed_riff.TabIndex = 7;
			this.lbl_elapsed_riff.Text = "00:00:00";
			// 
			// lbl_elapsed_solo
			// 
			this.lbl_elapsed_solo.AutoSize = true;
			this.lbl_elapsed_solo.Location = new System.Drawing.Point(107, 95);
			this.lbl_elapsed_solo.Name = "lbl_elapsed_solo";
			this.lbl_elapsed_solo.Size = new System.Drawing.Size(49, 13);
			this.lbl_elapsed_solo.TabIndex = 8;
			this.lbl_elapsed_solo.Text = "00:00:00";
			// 
			// lbl_elapsed_fun
			// 
			this.lbl_elapsed_fun.AutoSize = true;
			this.lbl_elapsed_fun.Location = new System.Drawing.Point(107, 132);
			this.lbl_elapsed_fun.Name = "lbl_elapsed_fun";
			this.lbl_elapsed_fun.Size = new System.Drawing.Size(49, 13);
			this.lbl_elapsed_fun.TabIndex = 8;
			this.lbl_elapsed_fun.Text = "00:00:00";
			// 
			// lbl_elapse_tot
			// 
			this.lbl_elapse_tot.AutoSize = true;
			this.lbl_elapse_tot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_elapse_tot.Location = new System.Drawing.Point(20, 16);
			this.lbl_elapse_tot.Name = "lbl_elapse_tot";
			this.lbl_elapse_tot.Size = new System.Drawing.Size(128, 31);
			this.lbl_elapse_tot.TabIndex = 5;
			this.lbl_elapse_tot.Text = "00:00:00";
			// 
			// timerClock
			// 
			this.timerClock.Enabled = true;
			this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
			// 
			// gb_timer
			// 
			this.gb_timer.Controls.Add(this.btn_timer_raz);
			this.gb_timer.Controls.Add(this.btn_timer_pause);
			this.gb_timer.Controls.Add(this.btn_timer_start);
			this.gb_timer.Controls.Add(this.lbl_elapse_tot);
			this.gb_timer.Location = new System.Drawing.Point(186, 35);
			this.gb_timer.Name = "gb_timer";
			this.gb_timer.Size = new System.Drawing.Size(165, 86);
			this.gb_timer.TabIndex = 9;
			this.gb_timer.TabStop = false;
			this.gb_timer.Text = "Timer";
			// 
			// btn_timer_raz
			// 
			this.btn_timer_raz.Location = new System.Drawing.Point(112, 50);
			this.btn_timer_raz.Name = "btn_timer_raz";
			this.btn_timer_raz.Size = new System.Drawing.Size(47, 26);
			this.btn_timer_raz.TabIndex = 6;
			this.btn_timer_raz.Text = "RAZ";
			this.btn_timer_raz.UseVisualStyleBackColor = true;
			// 
			// btn_timer_pause
			// 
			this.btn_timer_pause.Location = new System.Drawing.Point(59, 50);
			this.btn_timer_pause.Name = "btn_timer_pause";
			this.btn_timer_pause.Size = new System.Drawing.Size(47, 26);
			this.btn_timer_pause.TabIndex = 6;
			this.btn_timer_pause.Text = "Pause";
			this.btn_timer_pause.UseVisualStyleBackColor = true;
			this.btn_timer_pause.Click += new System.EventHandler(this.btn_timer_pause_Click);
			// 
			// btn_timer_start
			// 
			this.btn_timer_start.Location = new System.Drawing.Point(6, 50);
			this.btn_timer_start.Name = "btn_timer_start";
			this.btn_timer_start.Size = new System.Drawing.Size(47, 26);
			this.btn_timer_start.TabIndex = 6;
			this.btn_timer_start.Text = "Start";
			this.btn_timer_start.UseVisualStyleBackColor = true;
			this.btn_timer_start.Click += new System.EventHandler(this.btn_timer_start_Click);
			// 
			// btn_raz_all
			// 
			this.btn_raz_all.Location = new System.Drawing.Point(186, 180);
			this.btn_raz_all.Name = "btn_raz_all";
			this.btn_raz_all.Size = new System.Drawing.Size(75, 23);
			this.btn_raz_all.TabIndex = 10;
			this.btn_raz_all.Text = "RAZ ALL";
			this.btn_raz_all.UseVisualStyleBackColor = true;
			this.btn_raz_all.Click += new System.EventHandler(this.btn_raz_all_Click);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 224);
			this.Controls.Add(this.btn_raz_all);
			this.Controls.Add(this.gb_timer);
			this.Controls.Add(this.lbl_elapsed_fun);
			this.Controls.Add(this.lbl_elapsed_solo);
			this.Controls.Add(this.lbl_elapsed_riff);
			this.Controls.Add(this.lbl_elapsed_warmUp);
			this.Controls.Add(this.lbl_clock);
			this.Controls.Add(this.btn_config);
			this.Controls.Add(this.btn_fun);
			this.Controls.Add(this.btn_solo);
			this.Controls.Add(this.btn_riff);
			this.Controls.Add(this.btn_warmUp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Guitar Trainer";
			this.gb_timer.ResumeLayout(false);
			this.gb_timer.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_warmUp;
		private System.Windows.Forms.Button btn_riff;
		private System.Windows.Forms.Button btn_solo;
		private System.Windows.Forms.Button btn_fun;
		private System.Windows.Forms.Button btn_config;
		private System.Windows.Forms.Label lbl_clock;
		private System.Windows.Forms.Label lbl_elapsed_warmUp;
		private System.Windows.Forms.Label lbl_elapsed_riff;
		private System.Windows.Forms.Label lbl_elapsed_solo;
		private System.Windows.Forms.Label lbl_elapsed_fun;
		private System.Windows.Forms.Label lbl_elapse_tot;
		private System.Windows.Forms.Timer timerClock;
		private System.Windows.Forms.GroupBox gb_timer;
		private System.Windows.Forms.Button btn_timer_raz;
		private System.Windows.Forms.Button btn_timer_pause;
		private System.Windows.Forms.Button btn_timer_start;
		private System.Windows.Forms.Button btn_raz_all;
	}
}

