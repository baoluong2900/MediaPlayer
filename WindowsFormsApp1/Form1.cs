using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Core.Tokens;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 
        string[] paths, files;
        int Startindex = 0;
        string[] FileName, FilePath;
        Boolean playnext = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            Startindex = 0;
            playnext = false;
            Play.Visible = false;
         //   Pause.Visible = false;
            StopPlayer();

        }

        private bool _isPlaying = false;

        public bool Isplaying
        {
            get { return _isPlaying; }
            set
            {
                _isPlaying = value;

                if (_isPlaying)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
//                    action.Image = Play.Image;
                }
                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
  //                  action.Image = Pause.Image;
                }
            }
        }

        public void StopPlayer()
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
        public void Playfile(int playlistindex)
        {
            if (listBox1.Items.Count <= 0)
            {
                return;
            }
            if (playlistindex < 0)
            {
                return;
            }
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.URL = FilePath[playlistindex];
            axWindowsMediaPlayer1.Ctlcontrols.next();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Startindex = listBox1.SelectedIndex;
            Playfile(Startindex);
            lblNameSong.Text = listBox1.Text;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Startindex = 0;
            playnext = false;
            OpenFileDialog opfd = new OpenFileDialog();
            opfd.Multiselect = true;
            opfd.Filter = ("(mp3,mp4)|*.mp3;*.mp4|all files|*.*");
            if (opfd.ShowDialog() == DialogResult.OK)
            {
                FileName = opfd.SafeFileNames;
                FilePath = opfd.FileNames;
                for(int i = 0; i <= FileName.Length - 1; i++)
                {
                    listBox1.Items.Add(FileName[i]);
                }
                Startindex = 0;
                Playfile(0);


            }
        }

        private void btnPlaying_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.BringToFront();
        }

        private void btnPlayList_Click(object sender, EventArgs e)
        {
            listBox1.BringToFront();
        }

        private void bunifuHSlider2_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = HSVolume.Value;

        }

        private void btnSpeaker_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume +=10;
            HSVolume.Value += 10;
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume=0;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            Pause.Visible =false;
            Play.Visible = true;
        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {
   
        }

        private void Play_Click(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.Ctlcontrols.play();
            Pause.Visible = true;
            Play.Visible = false;
        }
        public EventHandler noaction = null;
        private void action_Click(object sender, EventArgs e)
        {
   

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
