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
        load Game = new load();// defining the object of (Game) of  the load class
        

        public Form1()
        {
            InitializeComponent();
        }
            

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
                    //new Random;
                    MessageBox.Show("you miss shot     play again ");


                    //new Random;
                    MessageBox.Show("3more to do ");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message" + ex.Message);
            }
        }

        private void Btn_playgame_Click(object sender, EventArgs e)
        {
            Button_Load.Enabled = true;
            btn_spin.Enabled = false;
            btn_shout.Enabled = false;
            btn_shoutAway.Enabled = false;
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

            //  picture_box_Main.Image = Russian_Roulllete.Properties.Resources.spin;
            
        }

        private void Btn_shout_Click(object sender, EventArgs e)
        {
            Button_Load.Enabled = false;
            btn_spin.Enabled = false;
            btn_shout.Enabled = true;
            btn_shoutAway.Enabled = true;
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Russian_Roulllete.Resources.gighyy.gif");
            Bitmap bmp = new Bitmap(myStream);
            picture_box_Main.Image = bmp;


            //coding for sounds//
            try
            {
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(Russian_Roulllete.Properties.Resources.gun);
                snd.Play();
                {
                    //new Random;
                    MessageBox.Show(" miss");

                   //new Random;
                    MessageBox.Show("you hit");

                    //new Random;
                    MessageBox.Show("you win");

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
                MessageBox.Show("Error Message" + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button_Load.Enabled = true; // enabling Load button
            btn_spin.Enabled = false;
            btn_shout.Enabled = false;
            btn_shoutAway.Enabled = false;
        }

        private void Picture_box_Main_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
