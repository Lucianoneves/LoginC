namespace WinFormsAppLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Equals("Luciano") && txtSenha.Text.Equals("123"))
                {
                    var menu = new MenuRestrito();
                    menu.Show();


                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("Usuário ou senha Incorretos",
                        "Desculpe",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);

                    txtUsuario.Focus();
                    txtSenha.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe",
                                 ex.Message,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.LightYellow;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.White;

        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.LightYellow;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.White;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;

            if (!char.IsLetterOrDigit(e.KeyChar) && tecla != 08)
            {
                e.Handled = true;

                MessageBox.Show("Digite  apenas letras ou números", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtUsuario.SelectionStart = 0;
                txtUsuario.SelectionLength = txtUsuario.Text.Length;

                txtUsuario.Focus();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
                               
                               
                               

