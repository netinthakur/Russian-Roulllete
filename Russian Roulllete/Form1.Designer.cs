using System;
using System.Windows.Forms;

namespace Russian_Roulllete
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_spin = new System.Windows.Forms.Button();
            this.btn_shout = new System.Windows.Forms.Button();
            this.btn_shoutAway = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_playgame = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Button_Load = new System.Windows.Forms.Button();
            this.picture_box_Main = new System.Windows.Forms.PictureBox();
            this.win = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_spin
            // 
            this.btn_spin.Location = new System.Drawing.Point(110, 84);
            this.btn_spin.Name = "btn_spin";
            this.btn_spin.Size = new System.Drawing.Size(84, 43);
            this.btn_spin.TabIndex = 6;
            this.btn_spin.Text = "Spin";
            this.btn_spin.UseVisualStyleBackColor = true;
            this.btn_spin.Click += new System.EventHandler(this.btn_spin_Click_1);
            // 
            // btn_shout
            // 
            this.btn_shout.Location = new System.Drawing.Point(110, 151);
            this.btn_shout.Name = "btn_shout";
            this.btn_shout.Size = new System.Drawing.Size(84, 46);
            this.btn_shout.TabIndex = 7;
            this.btn_shout.Text = "Shoot";
            this.btn_shout.UseVisualStyleBackColor = true;
            this.btn_shout.Click += new System.EventHandler(this.btn_shout_Click);
            // 
            // btn_shoutAway
            // 
            this.btn_shoutAway.Location = new System.Drawing.Point(110, 217);
            this.btn_shoutAway.Name = "btn_shoutAway";
            this.btn_shoutAway.Size = new System.Drawing.Size(84, 50);
            this.btn_shoutAway.TabIndex = 8;
            this.btn_shoutAway.Text = "Shoot Away";
            this.btn_shoutAway.UseVisualStyleBackColor = true;
            this.btn_shoutAway.Click += new System.EventHandler(this.btn_shoutAway_Click);
            // 
            // btn_playgame
            // 
            this.btn_playgame.Location = new System.Drawing.Point(110, 359);
            this.btn_playgame.Name = "btn_playgame";
            this.btn_playgame.Size = new System.Drawing.Size(95, 44);
            this.btn_playgame.TabIndex = 10;
            this.btn_playgame.Text = "Play Game";
            this.btn_playgame.UseVisualStyleBackColor = true;
            this.btn_playgame.Click += new System.EventHandler(this.Btn_playgame_Click);
            // 
            // Button_Load
            // 
            this.Button_Load.Location = new System.Drawing.Point(110, 12);
            this.Button_Load.Name = "Button_Load";
            this.Button_Load.Size = new System.Drawing.Size(84, 41);
            this.Button_Load.TabIndex = 12;
            this.Button_Load.Text = "Load";
            this.Button_Load.UseVisualStyleBackColor = true;
            this.Button_Load.Click += new System.EventHandler(this.Button_Load_Click_1);
            // 
            // picture_box_Main
            // 
            this.picture_box_Main.Image = global::Russian_Roulllete.Properties.Resources.firearm_409252_1280;
            this.picture_box_Main.Location = new System.Drawing.Point(262, -104);
            this.picture_box_Main.Name = "picture_box_Main";
            this.picture_box_Main.Size = new System.Drawing.Size(437, 371);
            this.picture_box_Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box_Main.TabIndex = 13;
            this.picture_box_Main.TabStop = false;
            this.picture_box_Main.Click += new System.EventHandler(this.Picture_box_Main_Click);
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.Location = new System.Drawing.Point(58, 46);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(0, 13);
            this.win.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "lose";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "win";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(705, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "shoot";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(705, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "shootaway";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.win);
            this.Controls.Add(this.picture_box_Main);
            this.Controls.Add(this.Button_Load);
            this.Controls.Add(this.btn_playgame);
            this.Controls.Add(this.btn_shoutAway);
            this.Controls.Add(this.btn_shout);
            this.Controls.Add(this.btn_spin);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Btn_playgame_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Picture_box_Main_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button_Load_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn_spin_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn_shoutAway_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn_shout_Click(object sender, EventArgs e)
        {

            Button_Load.Enabled = false;
            btn_spin.Enabled = false;
            btn_shout.Enabled = false;
            btn_shoutAway.Enabled = true;

            //coding for sounds//
            try
            {
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(global::Russian_Roulllete.Properties.Resources.gunshot);
                snd.Play();

                {
                    // below code is helps to load only 1 bullet.
                    Play load_value = new Play();
                    load_value.Load_sound();

                    loadvalue = 1;

                    btn_spin.Enabled = true;
                    Button_Load.Enabled = false;
                }
            }




#pragma warning disable CS0162 // Unreachable code detected
            catch (Exception ex)
#pragma warning restore CS0162 // Unreachable code detected
            {
                MessageBox.Show("Error Message" + ex.Message);
            }

        }

        #endregion
        private System.Windows.Forms.Button btn_spin;
        private System.Windows.Forms.Button btn_shout;
        private System.Windows.Forms.Button btn_shoutAway;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_playgame;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button Button_Load;
        private System.Windows.Forms.PictureBox picture_box_Main;
        private System.Windows.Forms.Label win;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        public EventHandler Form1_load { get; private set; }
    }
}

