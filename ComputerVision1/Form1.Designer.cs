namespace ComputerVision1
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
            BtnCalcola = new Button();
            PctPreview = new PictureBox();
            DlgApri = new OpenFileDialog();
            TxtRisultato = new TextBox();
            TrkSoglia = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)PctPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrkSoglia).BeginInit();
            SuspendLayout();
            // 
            // BtnCalcola
            // 
            BtnCalcola.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnCalcola.Location = new Point(12, 481);
            BtnCalcola.Name = "BtnCalcola";
            BtnCalcola.Size = new Size(955, 60);
            BtnCalcola.TabIndex = 0;
            BtnCalcola.Text = "Calcola";
            BtnCalcola.UseVisualStyleBackColor = true;
            BtnCalcola.Click += BtnCalcola_Click;
            // 
            // PctPreview
            // 
            PctPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PctPreview.Location = new Point(12, 12);
            PctPreview.Name = "PctPreview";
            PctPreview.Size = new Size(955, 367);
            PctPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            PctPreview.TabIndex = 1;
            PctPreview.TabStop = false;
            // 
            // DlgApri
            // 
            DlgApri.FileName = "openFileDialog1";
            DlgApri.Title = "Apri immagine da analizzare";
            // 
            // TxtRisultato
            // 
            TxtRisultato.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtRisultato.Location = new Point(12, 547);
            TxtRisultato.Multiline = true;
            TxtRisultato.Name = "TxtRisultato";
            TxtRisultato.ScrollBars = ScrollBars.Vertical;
            TxtRisultato.Size = new Size(955, 322);
            TxtRisultato.TabIndex = 2;
            TxtRisultato.WordWrap = false;
            // 
            // TrkSoglia
            // 
            TrkSoglia.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TrkSoglia.Location = new Point(12, 385);
            TrkSoglia.Maximum = 255;
            TrkSoglia.Name = "TrkSoglia";
            TrkSoglia.Size = new Size(955, 90);
            TrkSoglia.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 881);
            Controls.Add(TrkSoglia);
            Controls.Add(TxtRisultato);
            Controls.Add(PctPreview);
            Controls.Add(BtnCalcola);
            Name = "Form1";
            Text = "Computer Vision 1";
            ((System.ComponentModel.ISupportInitialize)PctPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrkSoglia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCalcola;
        private PictureBox PctPreview;
        private OpenFileDialog DlgApri;
        private TextBox TxtRisultato;
        private TrackBar TrkSoglia;
    }
}
