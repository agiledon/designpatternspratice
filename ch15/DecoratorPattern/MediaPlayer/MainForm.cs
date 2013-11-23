using System;
using System.Configuration;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DonOfDesign.DecoratorPattern.MediaLib;
using DonOfDesign.DecoratorPattern.VideoMedia;

namespace DonOfDesign.DecoratorPattern.MediaPlayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private IMedia m_media;


        private void mnuOpen_Click(object sender, EventArgs e)
        {
            dlgOpenFile.Filter = "Mp3 File(*.mp3)|*.mp3|Wav File(*.wav)|*.wav|Rm File(*.rm)|*.rm|Mpeg File(*.mpeg)|*.mpeg";
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                string mediaType = Path.GetExtension(dlgOpenFile.FileName).Substring(1).ToLower();
                
                m_media = Create(mediaType);
            }
        }

        private IMedia Create(string mediaType) {
            string typeName = ConfigurationManager.AppSettings[mediaType].ToString();
            string assemblyName = typeName.Substring(0, typeName.LastIndexOf("."));

            return (IMedia)Assembly.Load(assemblyName).CreateInstance(typeName);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (m_media != null)
            {      
                m_media.Play();
            }
        }

        private void btnTune_Click(object sender, EventArgs e)
        {
            if (m_media != null)
            {
                if (m_media is IAudioMedia)
                {
                    IAudioMedia audio = m_media as IAudioMedia;
                    audio.Tune(2);
                }               
            }
        }

        private void btnShowScript_Click(object sender, EventArgs e)
        {
            if (m_media != null)
            {
                if (m_media is IVideoMedia)
                {
                    IVideoMedia video = m_media as IVideoMedia;
                    video.ShowScript();
                }
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlayCR_Click(object sender, EventArgs e)
        {
            if (m_media is IPlay)
            {
                IPlay video = m_media as IPlay;
                CopyRightPlayer copyrightMedia = new CopyRightPlayer(video);
                copyrightMedia.CopyRightMark = new CopyRight(@"Copyright @2006");
                copyrightMedia.Play();
            }
        }

        private void btnPlayAd_Click(object sender, EventArgs e)
        {
            if (m_media is IPlay)
            {
                IPlay video = m_media as IPlay;
                AdvertisementPlayer adMedia = new AdvertisementPlayer(video);
                adMedia.Advertisement = new Advertisement("http://www.agiledon.com");
                adMedia.Play();

            }
        }

        private void btnPlayAdCR_Click(object sender, EventArgs e)
        {
            CopyRightPlayer copyrightMedia = new CopyRightPlayer(new Rm());
            copyrightMedia.CopyRightMark = new CopyRight(@"Copyright @2006");
            AdvertisementPlayer adMedia = new AdvertisementPlayer(copyrightMedia);
            adMedia.Advertisement = new Advertisement("http://www.agiledon.com");
            adMedia.Play();
        }        
    }
}