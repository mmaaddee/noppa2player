using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace noppa2player
{
    public partial class Form1 : Form
    {
        private Random rng = new Random();
        List<Dice> Nopat = new List<Dice>();

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 2; i++)
            {
                PictureBox tempPB = new PictureBox();

                this.Controls.Add(tempPB);

                Dice tempNoppa = new Dice(6, tempPB);

                Nopat.Add(tempNoppa);
            }

        }

        private void buttonPlayerOne_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < Nopat.Count; i++)
            {
                Nopat[i].Heitto(rng);
                editPicturebox(Nopat[i], i);
            }
        }

        private void editPicturebox(Dice tempNoppa, int count)
        {
            const int spacing = 300;

            string key = tempNoppa.GetPictureKey();
            tempNoppa.Boxi.Image = Dice.GetPictureResourceX(key);
            tempNoppa.Boxi.Location = new Point(150 + count * spacing, 170);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();           
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
