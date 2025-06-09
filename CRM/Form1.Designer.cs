namespace CRM
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
            LstContatti = new ListBox();
            BtnSalva = new Button();
            SuspendLayout();
            // 
            // LstContatti
            // 
            LstContatti.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            LstContatti.FormattingEnabled = true;
            LstContatti.Location = new Point(12, 12);
            LstContatti.Name = "LstContatti";
            LstContatti.Size = new Size(240, 676);
            LstContatti.TabIndex = 0;
            // 
            // BtnSalva
            // 
            BtnSalva.Location = new Point(1060, 642);
            BtnSalva.Name = "BtnSalva";
            BtnSalva.Size = new Size(150, 46);
            BtnSalva.TabIndex = 1;
            BtnSalva.Text = "button1";
            BtnSalva.UseVisualStyleBackColor = true;
            BtnSalva.Click += BtnSalva_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 722);
            Controls.Add(BtnSalva);
            Controls.Add(LstContatti);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox LstContatti;
        private Button BtnSalva;
    }
}
