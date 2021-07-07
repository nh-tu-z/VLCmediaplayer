using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLC_Media_Player
{
    public partial class Form1 : Form, IMessageFilter
    {
        private bool enableShortcut = false;
        private int selectedItem = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string path = "file:///" + ofd.FileName;
                addToPlayList(ofd.SafeFileName, path);
                enableShortcut = true;
            }
        }

        private void axVLCPlugin21_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                axVLCPlugin21.playlist.togglePause();
            }
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(selectedItem);
        }

        private void playlistVLC_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedItem = playlistVLC.SelectedIndex;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.AddMessageFilter(this);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.RemoveMessageFilter(this);
        }

        #region IMessageFilter Members

        private const UInt32 WM_KEYDOWN = 0x0100;

        public bool PreFilterMessage(ref Message m)

        {
            if (enableShortcut)
            {
                if (m.Msg == WM_KEYDOWN)
                {

                    Keys keyCode = (Keys)(int)m.WParam & Keys.KeyCode;
                    /* Exit Fullscreen Mode */
                    if (keyCode == Keys.Escape)
                    {
                        this.axVLCPlugin21.video.fullscreen = false;
                    }
                    /* Fullscreen Mode */
                    else if (keyCode == Keys.F)
                    {
                        this.axVLCPlugin21.video.toggleFullscreen();

                    }
                    /* Pause and play */
                    else if (keyCode == Keys.Space)
                    {
                        this.axVLCPlugin21.playlist.togglePause();
                        var str = TimeSpan.FromMilliseconds(axVLCPlugin21.input.time).ToString(@"hh\:mm\:ss\.fff");
                    }
                    /* Next 5s */
                    else if (keyCode == Keys.Right)
                    {
                        this.axVLCPlugin21.input.time += 5000;
                    }
                    /* Back 5s */
                    else if (keyCode == Keys.Left)
                    {
                        this.axVLCPlugin21.input.time -= 5000;
                    }
                    return true;
                }
            }
            return false;
        }

        #endregion

        private void addToPlayList(string fileName, string path)
        {
            bool enableAdd = true;
            foreach (string item in playlistVLC.Items)
            {
                if (fileName == item)
                {
                    MessageBox.Show("The video has been already added.", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    enableAdd = false;
                }
            }
            if (enableAdd)
            {
                playlistVLC.Items.Add(fileName);
                axVLCPlugin21.playlist.add(@path, null, null);
            }
        }
    }
}
