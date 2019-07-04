using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_Roulllete.Properties
{
    class Play
    {
        public static int Score = 0, Win = 0, Loss = 0, Count = 0;

        public void Load_sound()
        {

            //below code is for uploading sound affect
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\hp\source\repos\Rouelette\Rouelette\resource\loading.wav");
            player.Play();


        }

        public void Spin_sound()
        {
            //below code is for uploading sound affect
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\hp\source\repos\Rouelette\Rouelette\resource\spinnn.wav");
            player.Play();


        }

        public int Shotbullet(int loadvalue, int Spinvalue)
        {
            // below code is for uploading the sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\hp\source\repos\Rouelette\Rouelette\resource\gun.wav");
            player.Play();
            if (Count < 2)
            {
                if (Spinvalue == loadvalue)
                {
                    Win = Win + 1;

                    if (Count == 0)
                    {
                        Score = Score + 10;
                    }
                    else
                    {
                        Score = Score + 5;
                    }

                    Count = 3;

                }
                else
                {

                    Count = Count + 1;

                }


            }
            else
            {
                Loss = Loss + 1;


            }

            return Score;
        }

        public void Tryagain()
        {
            Score = 0;
            Win = 0;
            Loss = 0;
            Count = 0;
        }

        public static implicit operator Play(int v)
        {
            throw new NotImplementedException();
        }
    }
}
