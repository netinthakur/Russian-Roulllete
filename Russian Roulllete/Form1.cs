using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Reflection;

namespace Russian_Roulllete
{
    public partial class Form1 : Form
    {
        private const bool  = false;
        load Game = new load();// defining the object of (Game) of  the load class
        private object btnspin;
        private object btnload;
        private int loadvalue;

        public Form1()
        {
            InitializeComponent();
        }

        public int Spinvalue { get; private set; }
        public int Count1 { get; private set; }

        public int Spin_chamber(int Spin_value1)
        {
            if (Spin_value1 == 6)
            {
                Spin_value1 = 1;
            }
            else
            {
                Spin_value1 = Spin_value1 + 1;
            }

            return Spin_value1;




            private void Btn_shoutAway_Click(object sender, EventArgs e)
        {
            Button_Load.Enabled = false;
            btn_spin.Enabled = false;
            btn_shout.Enabled = true;
            btn_shoutAway.Enabled = true;

            //coding for sounds//
            try
            {
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(Russian_Roulllete.Properties.Resources.gunshot);
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

            private void Btn_spin_Click_1(object sender, EventArgs e)
        {
            Game.Spin(); //Calling Spin function from Game Class
            Button_Load.Enabled = false;
            btn_spin.Enabled = false;
            btn_shout.Enabled = true;
            btn_shoutAway.Enabled = true;
            picture_box_Main.Visible = true;
            //below coide helps to show the image
            //coding for images//
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Russian_Roulllete.Resources.giphy (1).gif");
            Bitmap bmp = new Bitmap(myStream);
            picture_box_Main.Image = bmp;
                //below code is call the spin function from play class to set the spin value
                Play SpinObj = new Play();
                SpinObj.Spin_sound();

                //below code for spining the chamber and it will pick bullet randomly
                Random rnd = new Random();
                //below code helps to pick random number between 1-7.
                Spinvalue = rnd.Next(1, 7);

            Button_Load.Enabled = false;
            Button_Load.Enabled = false;
                btn_shout.Enabled = true;
                btn_spin.Enabled = false;

                //  picture_box_Main.Image = Russian_Roulllete.Properties.Resources.spin;

            }

        private void Btn_shout_Click(object sender, EventArgs e)
        {
            Button_Load.Enabled = false;
            btn_spin.Enabled = false;
            btn_shout.Enabled = false;
            btn_shoutAway.Enabled = true;
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Russian_Roulllete.Resources.gighyy.gif");
            Bitmap bmp = new Bitmap(myStream);
            picture_box_Main.Image = bmp;


            //coding for sounds//
            try
            {
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(Russian_Roulllete.Properties.Resources.gunshot);
                snd.Play();

                {
                        Play ShotObj = new Play();

                        int score1 = ShotObj.Shotbullet(loadvalue, Spinvalue);

                        if (score1 != 0 && Count1 < 2)
                        {
                            if (score1 == 10)
                            {
                                MessageBox.Show("you won and your score is 10");
                                btn_shout.Enabled = false;
                            }

                            else if (score1 == 5)
                            {
                                MessageBox.Show("you won and your score is 5");
                                btn_shout.Enabled = false;
                            }
                        }

                        else
                        {
                            Count1++;
                            Spinvalue = Spin_chamber(Spinvalue);
                        }

                        if (Count1 == 2 && score1 == 0)
                        {
                            MessageBox.Show("you loss and your score is 0");
                            btn_shout.Enabled = false;

                        }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message" + ex.Message);
            }
        }






        private void Button_Load_Click_1(object sender, EventArgs e)
        {
            Game.Load(); //Calling Load function from Game Class//
            Button_Load.Enabled = false; // Disabling Load button
            btn_spin.Enabled = true;
            btn_shout.Enabled = false;
            btn_shoutAway.Enabled = false;
            //below coide helps to show the image
            //coding for images//
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Russian_Roulllete.Resources.giphy.gif");
            Bitmap bmp = new Bitmap(myStream);
            picture_box_Main.Image = bmp;
            //coding for sounds//
            try
            {
                //   SoundPlayer player = new SoundPlayer(Russian_Roulllete.Properties.Resources.giphy);
                //   player.Play();
            }
            catch (Exception ex)
            {
                    // below code is helps to load only 1 bullet.
                    Play load_value = new Play();
                    load_value.Load_sound();

                    loadvalue = 1;

                    btn_spin.Enabled = true;
                    Button_Load.Enabled = false;
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button_Load.Enabled = true; // enabling Load button
            btn_spin.Enabled = false;
            btn_shout.Enabled = false;
            btn_shoutAway.Enabled = false;
        }

        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
