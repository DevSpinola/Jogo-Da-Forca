namespace ProjetoN2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char letra;
        char[] escondido;
        string palavra, tema;
        int tamanhopalavra, faltamletras, tentativas = 6;

        private void botaotentarletra_Click(object sender, EventArgs e)
        {
            bool usou = false;
            bool achou = false;
            int contador = 0;
            if (txtLetra.Text.Length > 0)
            {
                letra = txtLetra.Text[0];
                txtLetra.Text = "";
                foreach (char c in palavra)
                {
                    if (escondido[contador] == letra)
                    {
                        MessageBox.Show("A letra ja foi utilizada");
                        usou = true;
                        break;
                    }
                    contador += 2;
                }
                contador = 0;
                if (usou == false)
                {
                    foreach (char c in palavra)
                    {
                        if (c == letra)
                        {
                            escondido[contador] = c;
                            faltamletras -= 1;
                            achou = true;
                        }
                        contador += 2;
                    }
                    if (achou == false)//Se nao achou nenhuma letra na palavra
                    {
                        tentativas--;
                        if (tentativas == 5)
                        {
                            Forca1.Visible = false;
                            Forca2.Visible = true;
                        }
                        if (tentativas == 4)
                        {
                            Forca2.Visible = false;
                            Forca3.Visible = true;
                        }
                        if (tentativas == 3)
                        {
                            Forca3.Visible = false;
                            Forca4.Visible = true;
                        }
                        if (tentativas == 2)
                        {
                            Forca4.Visible = false;
                            Forca5.Visible = true;

                        }
                        if (tentativas == 1)
                        {
                            Forca5.Visible = false;
                            Forca6.Visible = true;

                        }
                        if (tentativas == 0)
                        {
                            Forca6.Visible = false;
                            Forca7.Visible = true;
                            MessageBox.Show($"Você perdeu, a palavra era: {palavra}");
                            tentativas = 6;
                            txtLetra.Text = "";
                            letra = ' ';
                            palavra = "";
                            labelLetrasUtilizadas.Text = "";
                            txtPalavra.Text = "";
                            txtTema.Text = "";
                            TxtForca.Text = "";
                            botaotentarletra.Enabled = false;
                            txtLetra.Enabled = false;
                            TxtForca.Enabled = false;

                            for (int i = 0; i != escondido.Length; i++)
                            {
                                escondido[i] = ' ';
                            }
                        }
                    }
                    TxtForca.Text = "";
                    for (int i = 0; i < escondido.Length; i++)
                    {
                        TxtForca.Text += escondido[i];
                    }
                    labelLetrasUtilizadas.Text += letra.ToString().ToUpper() + " ";
                    if (faltamletras == 0)
                    {
                        MessageBox.Show($"Palavra adivinhada : {palavra}");
                        txtLetra.Text = "";
                        letra = ' ';
                        palavra = "";
                        labelLetrasUtilizadas.Text = "";
                        txtPalavra.Text = "";
                        txtTema.Text = "";
                        TxtForca.Text = "";
                        botaotentarletra.Enabled = false;
                        txtLetra.Enabled = false;
                        TxtForca.Enabled = false;

                        for (int i = 0; i != escondido.Length; i++)
                        {
                            escondido[i] = ' ';
                        }
                    }


                }
            }
            else
            {
                MessageBox.Show("A letra nao foi digitada");
            }

        }
        private void botaoEnviar_Click(object sender, EventArgs e)
        {
            if (txtPalavra.Text == "")
            {
                MessageBox.Show("A Palavra nao foi digitada, tente novamente");
            }
            else if (txtPalavra.Text != null && txtTema.Text == "")
            {
                //Criando o Obj palavra pelo construtor simples
                palavra = txtPalavra.Text;
                tema = txtTema.Text;
                tamanhopalavra = txtPalavra.Text.Length;
                faltamletras = tamanhopalavra;
                Palavra obj = new Palavra(tamanhopalavra, palavra, tema);
                escondido = new char[obj.tamanho * 2];
                for (int i = 0; i < escondido.Length; i += 2)
                {
                    escondido[i] = '_';
                    escondido[i + 1] = ' ';
                }
                TxtForca.Text = "";
                for (int i = 0; i < escondido.Length; i++)
                {
                    TxtForca.Text += escondido[i];
                }
                botaotentarletra.Enabled = true;
                txtLetra.Enabled = true;
                TxtForca.Enabled = true;
            }
            else
            {
                //Criando o Obj palavra pelo construtor completo
                palavra = txtPalavra.Text;
                tema = txtTema.Text;
                tamanhopalavra = txtPalavra.Text.Length;
                faltamletras = tamanhopalavra;
                Palavra obj = new Palavra(tamanhopalavra, palavra, tema);
                escondido = new char[obj.tamanho * 2];
                for (int i = 0; i < escondido.Length; i += 2)
                {
                    escondido[i] = '_';
                    escondido[i + 1] = ' ';
                }
                TxtForca.Text = "";
                for (int i = 0; i < escondido.Length; i++)
                {
                    TxtForca.Text += escondido[i];
                }
                botaotentarletra.Enabled = true;
                txtLetra.Enabled = true;
                TxtForca.Enabled = true;
            }
        }
    }
}