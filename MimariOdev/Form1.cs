using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MimariOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Resim res = new Resim();
        Video video = new Video();

        private void btnimgplay_Click(object sender, EventArgs e)
        {
            Player p = new Player(res);
            MessageBox.Show(p.Play());
        }

        private void btnımgstop_Click(object sender, EventArgs e)
        {
            Player p = new Player(res);
            MessageBox.Show(p.Stop());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            res.Ad = txtAdimg.Text;
            res.RenkDagilimi = txtDagilim.Text;
            res.ResmiCeken = txtCeken.Text;

            video.Ad = txtAdvideo.Text;
            video.ImdbPuani = float.Parse(txtIMDB.Text);
            video.Sure = uint.Parse(txtSure.Text);
        }

        private void btnvideoplay_Click(object sender, EventArgs e)
        {
            Player p = new Player(video);
            MessageBox.Show(p.Play());

        }

        private void btnvideostop_Click(object sender, EventArgs e)
        {
            Player p = new Player(video);
            MessageBox.Show(p.Stop());

        }


    }
}
