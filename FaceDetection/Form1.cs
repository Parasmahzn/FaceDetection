using FaceRecognition;
using System;
using System.Windows.Forms;

namespace FaceDetection
{
    public partial class Form1 : Form
    {
        private static readonly FaceRec _faceRec = new FaceRec();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenCam_Click(object sender, EventArgs e)
        {
            _faceRec.openCamera(pbCamera, pbCaptured);
        }
        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            _faceRec.Save_IMAGE(rtName.Text);
            MessageBox.Show("Image Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDetectFaces_Click(object sender, EventArgs e)
        {
            _faceRec.isTrained = true;
        }
    }
}
