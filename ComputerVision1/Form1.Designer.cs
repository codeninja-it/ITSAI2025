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
            ((System.ComponentModel.ISupportInitialize)PctPreview).BeginInit();
            SuspendLayout();
            // 
            // BtnCalcola
            // 
            BtnCalcola.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnCalcola.Location = new Point(12, 763);
            BtnCalcola.Name = "BtnCalcola";
            BtnCalcola.Size = new Size(825, 60);
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
            PctPreview.Size = new Size(825, 745);
            PctPreview.TabIndex = 1;
            PctPreview.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 835);
            Controls.Add(PctPreview);
            Controls.Add(BtnCalcola);
            Name = "Form1";
            Text = "Computer Vision 1";
            ((System.ComponentModel.ISupportInitialize)PctPreview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCalcola;
        private PictureBox PctPreview;
    }
}
