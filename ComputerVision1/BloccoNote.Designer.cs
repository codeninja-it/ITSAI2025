namespace ComputerVision1
{
    partial class BloccoNote
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
            TxtFile = new TextBox();
            DlgApri = new OpenFileDialog();
            DlgSalva = new SaveFileDialog();
            BtnNuovo = new Button();
            BtnApri = new Button();
            BtnSalva = new Button();
            SuspendLayout();
            // 
            // TxtFile
            // 
            TxtFile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtFile.Location = new Point(12, 10);
            TxtFile.Multiline = true;
            TxtFile.Name = "TxtFile";
            TxtFile.ScrollBars = ScrollBars.Both;
            TxtFile.Size = new Size(724, 448);
            TxtFile.TabIndex = 0;
            // 
            // DlgApri
            // 
            DlgApri.FileName = "openFileDialog1";
            // 
            // BtnNuovo
            // 
            BtnNuovo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNuovo.Location = new Point(742, 12);
            BtnNuovo.Name = "BtnNuovo";
            BtnNuovo.Size = new Size(183, 46);
            BtnNuovo.TabIndex = 1;
            BtnNuovo.Text = "nuovo";
            BtnNuovo.UseVisualStyleBackColor = true;
            BtnNuovo.Click += BtnNuovo_Click;
            // 
            // BtnApri
            // 
            BtnApri.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnApri.Location = new Point(742, 64);
            BtnApri.Name = "BtnApri";
            BtnApri.Size = new Size(183, 46);
            BtnApri.TabIndex = 2;
            BtnApri.Text = "apri";
            BtnApri.UseVisualStyleBackColor = true;
            BtnApri.Click += BtnApri_Click;
            // 
            // BtnSalva
            // 
            BtnSalva.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSalva.Location = new Point(742, 116);
            BtnSalva.Name = "BtnSalva";
            BtnSalva.Size = new Size(183, 46);
            BtnSalva.TabIndex = 3;
            BtnSalva.Text = "salva";
            BtnSalva.UseVisualStyleBackColor = true;
            BtnSalva.Click += BtnSalva_Click;
            // 
            // BloccoNote
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 470);
            Controls.Add(BtnSalva);
            Controls.Add(BtnApri);
            Controls.Add(BtnNuovo);
            Controls.Add(TxtFile);
            Name = "BloccoNote";
            Text = "BloccoNote";
            FormClosing += BloccoNote_FormClosing;
            Leave += BloccoNote_Leave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtFile;
        private OpenFileDialog DlgApri;
        private SaveFileDialog DlgSalva;
        private Button BtnNuovo;
        private Button BtnApri;
        private Button BtnSalva;
    }
}