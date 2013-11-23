using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DonOfDesign.AdapterPattern.MediaLib;
using DonOfDesign.ClassAdapter.MediaAdapter;

namespace DonOfDesign.AdapterPattern.MediaPlayer {
    public partial class MainForm : Form {
        private IMedia m_media = new Mp3();

        //类的Adapter模式,在UI中与对象的Adapter模式实现唯一的区别
        private IMedia m_radio = new FmRadioAdapter();

        public MainForm() {
            InitializeComponent();
        }

        private void btnPlayMedia_Click(object sender, EventArgs e) {
            m_media.Play();
        }

        private void btnStopMedia_Click(object sender, EventArgs e) {
            m_media.Stop();
        }

        private void btnForwardMedia_Click(object sender, EventArgs e) {
            m_media.Forward();
        }

        private void btnBackwardMedia_Click(object sender, EventArgs e) {
            m_media.Backward();
        }

        private void btnPlayRadio_Click(object sender, EventArgs e) {
            m_radio.Play();
        }

        private void btnStopRadio_Click(object sender, EventArgs e) {
            m_radio.Stop();
        }

        private void btnForwardRadio_Click(object sender, EventArgs e) {
            m_radio.Forward();
        }

        private void btnBackwardRadio_Click(object sender, EventArgs e) {
            m_radio.Backward();
        }
    }
}