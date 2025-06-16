namespace ComputerVision3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DlgCartella = new FolderBrowserDialog();
            TxtVideo = new TextBox();
            BtnVideo = new Button();
            label1 = new Label();
            label2 = new Label();
            BtnSintetiche = new Button();
            TxtSintetiche = new TextBox();
            BtnPreview = new Button();
            TrkThreshold = new TrackBar();
            label3 = new Label();
            DlgVideo = new OpenFileDialog();
            PctPreview = new PictureBox();
            label4 = new Label();
            TrkArea = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)TrkThreshold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PctPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrkArea).BeginInit();
            SuspendLayout();
            // 
            // TxtVideo
            // 
            TxtVideo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtVideo.Location = new Point(222, 6);
            TxtVideo.Name = "TxtVideo";
            TxtVideo.ReadOnly = true;
            TxtVideo.Size = new Size(612, 39);
            TxtVideo.TabIndex = 0;
            // 
            // BtnVideo
            // 
            BtnVideo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnVideo.Location = new Point(840, 2);
            BtnVideo.Name = "BtnVideo";
            BtnVideo.Size = new Size(89, 46);
            BtnVideo.TabIndex = 1;
            BtnVideo.Text = "...";
            BtnVideo.UseVisualStyleBackColor = true;
            BtnVideo.Click += BtnVideo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 2;
            label1.Text = "File Video";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(204, 32);
            label2.TabIndex = 5;
            label2.Text = "Cartella sintetiche";
            // 
            // BtnSintetiche
            // 
            BtnSintetiche.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSintetiche.Location = new Point(840, 47);
            BtnSintetiche.Name = "BtnSintetiche";
            BtnSintetiche.Size = new Size(89, 46);
            BtnSintetiche.TabIndex = 4;
            BtnSintetiche.Text = "...";
            BtnSintetiche.UseVisualStyleBackColor = true;
            BtnSintetiche.Click += BtnSintetiche_Click;
            // 
            // TxtSintetiche
            // 
            TxtSintetiche.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSintetiche.Location = new Point(222, 51);
            TxtSintetiche.Name = "TxtSintetiche";
            TxtSintetiche.ReadOnly = true;
            TxtSintetiche.Size = new Size(612, 39);
            TxtSintetiche.TabIndex = 3;
            // 
            // BtnPreview
            // 
            BtnPreview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnPreview.Location = new Point(12, 288);
            BtnPreview.Name = "BtnPreview";
            BtnPreview.Size = new Size(917, 46);
            BtnPreview.TabIndex = 6;
            BtnPreview.Text = "preview";
            BtnPreview.UseVisualStyleBackColor = true;
            BtnPreview.Click += BtnPreview_Click;
            // 
            // TrkThreshold
            // 
            TrkThreshold.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TrkThreshold.LargeChange = 10;
            TrkThreshold.Location = new Point(222, 96);
            TrkThreshold.Maximum = 255;
            TrkThreshold.Name = "TrkThreshold";
            TrkThreshold.Size = new Size(707, 90);
            TrkThreshold.SmallChange = 5;
            TrkThreshold.TabIndex = 7;
            TrkThreshold.TickFrequency = 5;
            TrkThreshold.Value = 100;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(195, 32);
            label3.TabIndex = 8;
            label3.Text = "Livello Threshold";
            // 
            // DlgVideo
            // 
            DlgVideo.FileName = "openFileDialog1";
            // 
            // PctPreview
            // 
            PctPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PctPreview.Location = new Point(12, 340);
            PctPreview.Name = "PctPreview";
            PctPreview.Size = new Size(917, 588);
            PctPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            PctPreview.TabIndex = 9;
            PctPreview.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 192);
            label4.Name = "label4";
            label4.Size = new Size(163, 32);
            label4.TabIndex = 11;
            label4.Text = "Area Poligono";
            // 
            // TrkArea
            // 
            TrkArea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TrkArea.LargeChange = 10;
            TrkArea.Location = new Point(222, 192);
            TrkArea.Maximum = 3000;
            TrkArea.Name = "TrkArea";
            TrkArea.Size = new Size(707, 90);
            TrkArea.SmallChange = 5;
            TrkArea.TabIndex = 10;
            TrkArea.TickFrequency = 5;
            TrkArea.Value = 1000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 940);
            Controls.Add(label4);
            Controls.Add(TrkArea);
            Controls.Add(PctPreview);
            Controls.Add(label3);
            Controls.Add(TrkThreshold);
            Controls.Add(BtnPreview);
            Controls.Add(label2);
            Controls.Add(BtnSintetiche);
            Controls.Add(TxtSintetiche);
            Controls.Add(label1);
            Controls.Add(BtnVideo);
            Controls.Add(TxtVideo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)TrkThreshold).EndInit();
            ((System.ComponentModel.ISupportInitialize)PctPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrkArea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog DlgCartella;
        private TextBox TxtVideo;
        private Button BtnVideo;
        private Label label1;
        private Label label2;
        private Button BtnSintetiche;
        private TextBox TxtSintetiche;
        private Button BtnPreview;
        private TrackBar TrkThreshold;
        private Label label3;
        private OpenFileDialog DlgVideo;
        private PictureBox PctPreview;
        private Label label4;
        private TrackBar TrkArea;
    }
}
