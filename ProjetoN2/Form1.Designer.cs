namespace ProjetoN2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtLetra = new MaskedTextBox();
            txtTema = new TextBox();
            txtPalavra = new TextBox();
            txtLetrasUsadas = new TextBox();
            botaotentarletra = new Button();
            bindingSource1 = new BindingSource(components);
            botaoEnviar = new Button();
            TxtForca = new TextBox();
            labelLetrasUtilizadas = new Label();
            Forca2 = new PictureBox();
            Forca1 = new PictureBox();
            Forca3 = new PictureBox();
            Forca4 = new PictureBox();
            Forca7 = new PictureBox();
            Forca6 = new PictureBox();
            Forca5 = new PictureBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Forca2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Forca1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Forca3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Forca4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Forca7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Forca6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Forca5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(294, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 23);
            label1.TabIndex = 4;
            label1.Text = "Digite a Palavra:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(377, 38);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 5;
            label2.Text = " Tema:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 413);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(157, 23);
            label3.TabIndex = 6;
            label3.Text = "Digite uma Letra:";
            // 
            // txtLetra
            // 
            txtLetra.BackColor = Color.FromArgb(255, 224, 192);
            txtLetra.BorderStyle = BorderStyle.FixedSingle;
            txtLetra.Enabled = false;
            txtLetra.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLetra.Location = new Point(185, 410);
            txtLetra.Margin = new Padding(4);
            txtLetra.Mask = "a";
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(120, 26);
            txtLetra.TabIndex = 22;
            txtLetra.Enter += botaotentarletra_Click;
            // 
            // txtTema
            // 
            txtTema.BackColor = Color.FromArgb(255, 224, 192);
            txtTema.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTema.Location = new Point(469, 38);
            txtTema.Margin = new Padding(4);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(127, 26);
            txtTema.TabIndex = 2;
            // 
            // txtPalavra
            // 
            txtPalavra.BackColor = Color.FromArgb(255, 224, 192);
            txtPalavra.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPalavra.Location = new Point(469, 9);
            txtPalavra.Margin = new Padding(4);
            txtPalavra.Name = "txtPalavra";
            txtPalavra.PasswordChar = '*';
            txtPalavra.Size = new Size(127, 26);
            txtPalavra.TabIndex = 1;
            // 
            // txtLetrasUsadas
            // 
            txtLetrasUsadas.BackColor = Color.FromArgb(255, 224, 192);
            txtLetrasUsadas.BorderStyle = BorderStyle.None;
            txtLetrasUsadas.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLetrasUsadas.Location = new Point(255, 167);
            txtLetrasUsadas.Margin = new Padding(4);
            txtLetrasUsadas.Name = "txtLetrasUsadas";
            txtLetrasUsadas.Size = new Size(361, 19);
            txtLetrasUsadas.TabIndex = 10;
            // 
            // botaotentarletra
            // 
            botaotentarletra.BackColor = Color.Transparent;
            botaotentarletra.Enabled = false;
            botaotentarletra.Location = new Point(333, 414);
            botaotentarletra.Name = "botaotentarletra";
            botaotentarletra.Size = new Size(75, 23);
            botaotentarletra.TabIndex = 11;
            botaotentarletra.Text = "Tentar";
            botaotentarletra.UseVisualStyleBackColor = false;
            botaotentarletra.Click += botaotentarletra_Click;
            // 
            // botaoEnviar
            // 
            botaoEnviar.BackColor = Color.Transparent;
            botaoEnviar.Location = new Point(521, 71);
            botaoEnviar.Name = "botaoEnviar";
            botaoEnviar.Size = new Size(75, 23);
            botaoEnviar.TabIndex = 13;
            botaoEnviar.Text = "Enviar";
            botaoEnviar.UseVisualStyleBackColor = false;
            botaoEnviar.Click += botaoEnviar_Click;
            // 
            // TxtForca
            // 
            TxtForca.BackColor = Color.FromArgb(255, 224, 192);
            TxtForca.BorderStyle = BorderStyle.None;
            TxtForca.Enabled = false;
            TxtForca.Font = new Font("Times New Roman", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtForca.Location = new Point(72, 325);
            TxtForca.Name = "TxtForca";
            TxtForca.Size = new Size(524, 50);
            TxtForca.TabIndex = 1;
            // 
            // labelLetrasUtilizadas
            // 
            labelLetrasUtilizadas.Location = new Point(278, 130);
            labelLetrasUtilizadas.Name = "labelLetrasUtilizadas";
            labelLetrasUtilizadas.Size = new Size(378, 33);
            labelLetrasUtilizadas.TabIndex = 14;
            // 
            // Forca2
            // 
            Forca2.Image = (Image)resources.GetObject("Forca2.Image");
            Forca2.Location = new Point(22, 117);
            Forca2.Name = "Forca2";
            Forca2.Size = new Size(226, 220);
            Forca2.SizeMode = PictureBoxSizeMode.Zoom;
            Forca2.TabIndex = 15;
            Forca2.TabStop = false;
            // 
            // Forca1
            // 
            Forca1.Image = (Image)resources.GetObject("Forca1.Image");
            Forca1.Location = new Point(22, 117);
            Forca1.Name = "Forca1";
            Forca1.Size = new Size(226, 220);
            Forca1.SizeMode = PictureBoxSizeMode.Zoom;
            Forca1.TabIndex = 16;
            Forca1.TabStop = false;
            // 
            // Forca3
            // 
            Forca3.Image = (Image)resources.GetObject("Forca3.Image");
            Forca3.Location = new Point(20, 117);
            Forca3.Name = "Forca3";
            Forca3.Size = new Size(226, 220);
            Forca3.SizeMode = PictureBoxSizeMode.Zoom;
            Forca3.TabIndex = 17;
            Forca3.TabStop = false;
            Forca3.Visible = false;
            // 
            // Forca4
            // 
            Forca4.Image = (Image)resources.GetObject("Forca4.Image");
            Forca4.Location = new Point(22, 117);
            Forca4.Name = "Forca4";
            Forca4.Size = new Size(226, 220);
            Forca4.SizeMode = PictureBoxSizeMode.Zoom;
            Forca4.TabIndex = 18;
            Forca4.TabStop = false;
            Forca4.Visible = false;
            // 
            // Forca7
            // 
            Forca7.Image = (Image)resources.GetObject("Forca7.Image");
            Forca7.Location = new Point(20, 117);
            Forca7.Name = "Forca7";
            Forca7.Size = new Size(226, 220);
            Forca7.SizeMode = PictureBoxSizeMode.Zoom;
            Forca7.TabIndex = 19;
            Forca7.TabStop = false;
            Forca7.Visible = false;
            // 
            // Forca6
            // 
            Forca6.Image = (Image)resources.GetObject("Forca6.Image");
            Forca6.Location = new Point(20, 117);
            Forca6.Name = "Forca6";
            Forca6.Size = new Size(226, 220);
            Forca6.SizeMode = PictureBoxSizeMode.Zoom;
            Forca6.TabIndex = 20;
            Forca6.TabStop = false;
            Forca6.Visible = false;
            // 
            // Forca5
            // 
            Forca5.Image = (Image)resources.GetObject("Forca5.Image");
            Forca5.Location = new Point(23, 117);
            Forca5.Name = "Forca5";
            Forca5.Size = new Size(226, 220);
            Forca5.SizeMode = PictureBoxSizeMode.Zoom;
            Forca5.TabIndex = 21;
            Forca5.TabStop = false;
            Forca5.Visible = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 224, 192);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 10);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(249, 101);
            textBox1.TabIndex = 23;
            textBox1.Text = "Jogo da Forca Spinola";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(668, 479);
            Controls.Add(textBox1);
            Controls.Add(Forca5);
            Controls.Add(Forca6);
            Controls.Add(Forca7);
            Controls.Add(Forca4);
            Controls.Add(Forca3);
            Controls.Add(Forca1);
            Controls.Add(Forca2);
            Controls.Add(labelLetrasUtilizadas);
            Controls.Add(TxtForca);
            Controls.Add(botaoEnviar);
            Controls.Add(botaotentarletra);
            Controls.Add(txtLetrasUsadas);
            Controls.Add(txtPalavra);
            Controls.Add(txtTema);
            Controls.Add(txtLetra);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogo da Forca";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Forca2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Forca1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Forca3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Forca4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Forca7).EndInit();
            ((System.ComponentModel.ISupportInitialize)Forca6).EndInit();
            ((System.ComponentModel.ISupportInitialize)Forca5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox txtLetra;
        private TextBox txtTema;
        private TextBox txtPalavra;
        private TextBox txtLetrasUsadas;
        private Button botaotentarletra;
        private BindingSource bindingSource1;
        private Button botaoEnviar;
        private TextBox TxtForca;
        private Label labelLetrasUtilizadas;
        private PictureBox Forca2;
        private PictureBox Forca1;
        private PictureBox Forca3;
        private PictureBox Forca4;
        private PictureBox Forca7;
        private PictureBox Forca6;
        private PictureBox Forca5;
        private TextBox textBox1;
    }
}