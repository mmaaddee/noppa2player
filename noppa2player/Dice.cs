using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace noppa2player
{
    class Dice
    {
        public int Luku;
        public int Koko;
        public PictureBox Boxi;

        public Dice(int koko, PictureBox boxi) // constructor
        {
            Koko = koko;
            Luku = 1;
            Boxi = boxi;
            Boxi.Size = new Size(40, 40);
            Boxi.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public void Heitto(Random rng)
        {
            Luku = rng.Next(1, Koko + 1);
        }

        public string GetPictureKey()
        {
            string returnValue = "N";

            return returnValue + Luku;
        }

        public static Image GetPictureResourceX(string key)
        {
            return noppa2player.Resource1.ResourceManager.GetObject(key) as Image;
        }
    }
}
