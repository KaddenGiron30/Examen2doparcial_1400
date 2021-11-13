using Examen2doparcial_1400.Modelos.DAO;
using Examen2doparcial_1400.Modelos.Entidades;
using Examen2doparcial_1400.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2doparcial_1400.Controladores
{
    public class LoginController
    {
        LoginView vista;

        public LoginController(LoginView view)
        {
            vista = view;

            vista.AceptarButton.Click += new EventHandler(ValidarUsuario);
            vista.CancelarButton.Click += new EventHandler(Cancelar);
        }

        private void Cancelar(object sender, EventArgs e)
        {
            LimpiarControles();
        }
        private void LimpiarControles()
        {
            vista.EmailTextBox.Clear();
            vista.ContrasenaTextBox.Clear();
        }

        private void ValidarUsuario(object serder, EventArgs e)
        {
            bool esValido = false;
            UsuarioDAO userDAO = new UsuarioDAO();

            Usuario user = new Usuario();

            user.Email = vista.EmailTextBox.Text;
            user.Clave = EncriptarClave(vista.ContrasenaTextBox.Text);

            esValido = userDAO.ValidarUsuario(user);

            if(esValido)
            {
                MessageBox.Show("Usuario correcto");
                MenuView menu = new MenuView();
                vista.Hide();

                //menu.EmailUsuario = user.Email;

                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }
        public static string EncriptarClave(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] streams = null;
            StringBuilder sb = new StringBuilder();
            streams = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < streams.Length; i++) sb.AppendFormat("{0:x2}", streams[i]);
            return sb.ToString();
        }

    }
}
