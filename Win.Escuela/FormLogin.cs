using BL.Escuela; // Librería Escuela
using System;
using System.Windows.Forms;

namespace Win.Escuela
{
    public partial class FormLogin : Form
    {
        SeguridadBL _Seguridad; // Variable gobal

        public FormLogin()
        {
            InitializeComponent();

            _Seguridad = new SeguridadBL();

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAcceder_Click(object sender, EventArgs e)
        {
            string usuario;
            string contrasenia;

            //Asignamos los valores de los TextBox.
            usuario = textBoxUser.Text;
            contrasenia = textBoxPass.Text;

            var resultado = _Seguridad.Autorizar(usuario, contrasenia);

            if (resultado == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta!");
            }


        } // Fin buttonAcceder_Click
    } // Fin partial class FormLogin : Form.
}
