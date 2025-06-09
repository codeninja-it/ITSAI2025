namespace ComputerVision2
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
            DlgApri = new OpenFileDialog();
            PctPreview = new PictureBox();
            TrkMinimo = new TrackBar();
            TrkMassimo = new TrackBar();
            BtnAnalizza = new Button();
            label1 = new Label();
            label2 = new Label();
            BtnApri = new Button();
            label3 = new Label();
            TrkLight = new TrackBar();
            BtnContorni = new Button();
            ((System.ComponentModel.ISupportInitialize)PctPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrkMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrkMassimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrkLight).BeginInit();
            SuspendLayout();
            // 
            // DlgApri
            // 
            DlgApri.FileName = "openFileDialog1";
            // 
            // PctPreview
            // 
            PctPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PctPreview.Location = new Point(12, 12);
            PctPreview.Name = "PctPreview";
            PctPreview.Size = new Size(776, 634);
            PctPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            PctPreview.TabIndex = 0;
            PctPreview.TabStop = false;
            // 
            // TrkMinimo
            // 
            TrkMinimo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TrkMinimo.Location = new Point(148, 800);
            TrkMinimo.Maximum = 360;
            TrkMinimo.Name = "TrkMinimo";
            TrkMinimo.Size = new Size(640, 90);
            TrkMinimo.TabIndex = 1;
            // 
            // TrkMassimo
            // 
            TrkMassimo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TrkMassimo.Location = new Point(148, 896);
            TrkMassimo.Maximum = 360;
            TrkMassimo.Name = "TrkMassimo";
            TrkMassimo.Size = new Size(640, 90);
            TrkMassimo.TabIndex = 2;
            // 
            // BtnAnalizza
            // 
            BtnAnalizza.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnAnalizza.Location = new Point(12, 999);
            BtnAnalizza.Name = "BtnAnalizza";
            BtnAnalizza.Size = new Size(776, 46);
            BtnAnalizza.TabIndex = 3;
            BtnAnalizza.Text = "analizza";
            BtnAnalizza.UseVisualStyleBackColor = true;
            BtnAnalizza.Click += BtnAnalizza_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(12, 800);
            label1.Name = "label1";
            label1.Size = new Size(106, 32);
            label1.TabIndex = 4;
            label1.Text = "Hue min";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(12, 896);
            label2.Name = "label2";
            label2.Size = new Size(109, 32);
            label2.TabIndex = 5;
            label2.Text = "Hue max";
            // 
            // BtnApri
            // 
            BtnApri.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnApri.Location = new Point(12, 652);
            BtnApri.Name = "BtnApri";
            BtnApri.Size = new Size(776, 46);
            BtnApri.TabIndex = 6;
            BtnApri.Text = "apri";
            BtnApri.UseVisualStyleBackColor = true;
            BtnApri.Click += BtnApri_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(12, 704);
            label3.Name = "label3";
            label3.Size = new Size(130, 32);
            label3.TabIndex = 8;
            label3.Text = "Luminosità";
            // 
            // TrkLight
            // 
            TrkLight.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TrkLight.Location = new Point(148, 704);
            TrkLight.Maximum = 100;
            TrkLight.Name = "TrkLight";
            TrkLight.Size = new Size(640, 90);
            TrkLight.SmallChange = 5;
            TrkLight.TabIndex = 7;
            TrkLight.TickFrequency = 10;
            // 
            // BtnContorni
            // 
            BtnContorni.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnContorni.Location = new Point(12, 1051);
            BtnContorni.Name = "BtnContorni";
            BtnContorni.Size = new Size(776, 46);
            BtnContorni.TabIndex = 9;
            BtnContorni.Text = "trova contorni";
            BtnContorni.UseVisualStyleBackColor = true;
            BtnContorni.Click += BtnContorni_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 1109);
            Controls.Add(BtnContorni);
            Controls.Add(label3);
            Controls.Add(TrkLight);
            Controls.Add(BtnApri);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnAnalizza);
            Controls.Add(TrkMassimo);
            Controls.Add(TrkMinimo);
            Controls.Add(PctPreview);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PctPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrkMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrkMassimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrkLight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog DlgApri;
        private PictureBox PctPreview;
        private TrackBar TrkMinimo;
        private TrackBar TrkMassimo;
        private Button BtnAnalizza;
        private Label label1;
        private Label label2;
        private Button BtnApri;
        private Label label3;
        private TrackBar TrkLight;
        private Button BtnContorni;
    }
}
