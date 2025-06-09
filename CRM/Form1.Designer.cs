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
            TxtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtCognome = new TextBox();
            label3 = new Label();
            TxtTelefono = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // LstContatti
            // 
            LstContatti.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            LstContatti.FormattingEnabled = true;
            LstContatti.IntegralHeight = false;
            LstContatti.Location = new Point(12, 12);
            LstContatti.Name = "LstContatti";
            LstContatti.Size = new Size(240, 510);
            LstContatti.TabIndex = 0;
            LstContatti.SelectedIndexChanged += LstContatti_SelectedIndexChanged;
            // 
            // BtnSalva
            // 
            BtnSalva.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnSalva.Location = new Point(1048, 476);
            BtnSalva.Name = "BtnSalva";
            BtnSalva.Size = new Size(150, 46);
            BtnSalva.TabIndex = 1;
            BtnSalva.Text = "salva";
            BtnSalva.UseVisualStyleBackColor = true;
            BtnSalva.Click += BtnSalva_Click;
            // 
            // TxtNome
            // 
            TxtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtNome.Location = new Point(423, 12);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(775, 39);
            TxtNome.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 15);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 60);
            label2.Name = "label2";
            label2.Size = new Size(119, 32);
            label2.TabIndex = 5;
            label2.Text = "Cognome";
            // 
            // TxtCognome
            // 
            TxtCognome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtCognome.Location = new Point(423, 57);
            TxtCognome.Name = "TxtCognome";
            TxtCognome.Size = new Size(775, 39);
            TxtCognome.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 105);
            label3.Name = "label3";
            label3.Size = new Size(107, 32);
            label3.TabIndex = 7;
            label3.Text = "Telefono";
            // 
            // TxtTelefono
            // 
            TxtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtTelefono.Location = new Point(423, 102);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(775, 39);
            TxtTelefono.TabIndex = 6;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(736, 476);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 8;
            button1.Text = "elimina";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(892, 476);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 9;
            button2.Text = "aggiungi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 534);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(TxtTelefono);
            Controls.Add(label2);
            Controls.Add(TxtCognome);
            Controls.Add(label1);
            Controls.Add(TxtNome);
            Controls.Add(BtnSalva);
            Controls.Add(LstContatti);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstContatti;
        private Button BtnSalva;
        private TextBox TxtNome;
        private Label label1;
        private Label label2;
        private TextBox TxtCognome;
        private Label label3;
        private TextBox TxtTelefono;
        private Button button1;
        private Button button2;
    }
}
