namespace FaceDetection
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDetectFaces = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnOpenCamera = new System.Windows.Forms.Button();
            this.rtName = new System.Windows.Forms.RichTextBox();
            this.lblCamera = new System.Windows.Forms.Label();
            this.pbCaptured = new System.Windows.Forms.PictureBox();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptured)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetectFaces
            // 
            this.btnDetectFaces.Location = new System.Drawing.Point(825, 130);
            this.btnDetectFaces.Name = "btnDetectFaces";
            this.btnDetectFaces.Size = new System.Drawing.Size(196, 65);
            this.btnDetectFaces.TabIndex = 26;
            this.btnDetectFaces.Text = "DETECT FACES";
            this.btnDetectFaces.UseVisualStyleBackColor = true;
            this.btnDetectFaces.Click += new System.EventHandler(this.btnDetectFaces_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(825, 491);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(195, 65);
            this.btnSaveImage.TabIndex = 25;
            this.btnSaveImage.Text = "SAVE IMAGE";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnOpenCamera
            // 
            this.btnOpenCamera.Location = new System.Drawing.Point(824, 59);
            this.btnOpenCamera.Name = "btnOpenCamera";
            this.btnOpenCamera.Size = new System.Drawing.Size(196, 65);
            this.btnOpenCamera.TabIndex = 24;
            this.btnOpenCamera.Text = "OPEN CAMERA";
            this.btnOpenCamera.UseVisualStyleBackColor = true;
            this.btnOpenCamera.Click += new System.EventHandler(this.btnOpenCam_Click);
            // 
            // rtName
            // 
            this.rtName.Location = new System.Drawing.Point(825, 434);
            this.rtName.Name = "rtName";
            this.rtName.Size = new System.Drawing.Size(196, 30);
            this.rtName.TabIndex = 23;
            this.rtName.Text = "";
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Location = new System.Drawing.Point(63, 25);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(64, 16);
            this.lblCamera.TabIndex = 21;
            this.lblCamera.Text = "CAMERA";
            // 
            // pbCaptured
            // 
            this.pbCaptured.Location = new System.Drawing.Point(825, 201);
            this.pbCaptured.Name = "pbCaptured";
            this.pbCaptured.Size = new System.Drawing.Size(196, 227);
            this.pbCaptured.TabIndex = 19;
            this.pbCaptured.TabStop = false;
            // 
            // pbCamera
            // 
            this.pbCamera.Location = new System.Drawing.Point(66, 59);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(711, 574);
            this.pbCamera.TabIndex = 18;
            this.pbCamera.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 673);
            this.Controls.Add(this.btnDetectFaces);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnOpenCamera);
            this.Controls.Add(this.rtName);
            this.Controls.Add(this.lblCamera);
            this.Controls.Add(this.pbCaptured);
            this.Controls.Add(this.pbCamera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Face Detection";
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptured)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetectFaces;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button btnOpenCamera;
        private System.Windows.Forms.RichTextBox rtName;
        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.PictureBox pbCaptured;
        private System.Windows.Forms.PictureBox pbCamera;
    }
}

