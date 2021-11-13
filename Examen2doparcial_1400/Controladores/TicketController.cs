using Examen2doparcial_1400.Modelos.DAO;
using Examen2doparcial_1400.Modelos.Entidades;
using Examen2doparcial_1400.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2doparcial_1400.Controladores
{
   public class TicketController
   {
        TicketsView vista;
        string operacion = string.Empty;
        TicketDAO ticketDAO = new TicketDAO();
        Ticket user = new Ticket();

        public TicketController(TicketsView view)
        {
            vista = view;

            vista.NuevoButton.Click += new EventHandler(Nuevo);
            vista.GuardarButton.Click += new EventHandler(Guardar);
            vista.ModificarButton.Click += new EventHandler(Modificar);
            vista.EliminarButton.Click += new EventHandler(Eliminar);
            vista.Load += new EventHandler(Load);
        }

        private void Nuevo(object serder, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
            ListarUsuarios();
        }

        private void Guardar(object serder, EventArgs e)
        {
            if (vista.NombreTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.NombreTextBox, "Ingrese un nombre");
                vista.NombreTextBox.Focus();
                return;
            }
            if (vista.IdentidadTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.IdentidadTextBox, "Ingrese una Identidad");
                vista.IdentidadTextBox.Focus();
                return;
            }
            if (vista.TelefonoTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.TelefonoTextBox, "Ingrese Un Numero De Telefono");
                vista.TelefonoTextBox.Focus();
                return;
            }

            user.Nombre  = vista.NombreTextBox.Text;
            user.Identidad = vista.IdentidadTextBox.Text;
            user.Telefono= vista.TelefonoTextBox.Text;
            user.Fecha  = vista.FechaDateTimePicker.Value;

            if (operacion == "Nuevo")
            {
                bool inserto = ticketDAO.InsertarNuevoTicket(user);

                if (inserto)
                {
                    DesabilitarControles();
                    LimpiarControles();
                    MessageBox.Show("Usuario Creado Exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el usuario", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (operacion == "Modificar")
            {
                user.Id = Convert.ToInt32(vista.IdTextBox.Text);
                bool modifico = ticketDAO.ActualizarUsuario(user);

                if (modifico)
                {
                    DesabilitarControles();
                    LimpiarControles();
                    MessageBox.Show("Usuario Modificado Exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el usuario", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Eliminar(object serder, EventArgs e)
        {
            bool elimino = ticketDAO.EliminarTicket(Convert.ToInt32(vista.TicketDataGridView.CurrentRow.Cells[0].Value.ToString()));

            if (elimino)
            {
                DesabilitarControles();
                LimpiarControles();

                MessageBox.Show("Ticket Eliminado Exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarUsuarios();
            }
        }

        private void Modificar(object serder, EventArgs e)
        {
            operacion = "Modificar";

            if (vista.TicketDataGridView.SelectedRows.Count > 0)
            {
                vista.IdTextBox.Text = vista.TicketDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                vista.NombreTextBox.Text = vista.TicketDataGridView.CurrentRow.Cells["NOMBRE"].Value.ToString();
                vista.IdentidadTextBox.Text = vista.TicketDataGridView.CurrentRow.Cells["IDENTIDAD"].Value.ToString();
                vista.TelefonoTextBox.Text = vista.TicketDataGridView.CurrentRow.Cells["TELEFONO"].Value.ToString();


                HabilitarControles();

            }

        }

        private void Load(object serder, EventArgs e)
        {
            ListarUsuarios();
        }

        private void HabilitarControles()
        {
            vista.IdTextBox.Enabled = true;
            vista.NombreTextBox.Enabled = true;
            vista.IdentidadTextBox.Enabled = true;
            vista.TelefonoTextBox.Enabled = true;

            vista.GuardarButton.Enabled = true;
            vista.ModificarButton.Enabled = false;
            vista.NuevoButton.Enabled = false;

        }
        private void ListarUsuarios()
        {
            vista.TicketDataGridView.DataSource = ticketDAO.GetUsuarios();
        }
        private void LimpiarControles()
        {
            vista.IdTextBox.Clear();
            vista.NombreTextBox.Enabled = false;
            vista.IdentidadTextBox.Enabled = false;
            vista.TelefonoTextBox.Enabled = false;
        }
        private void DesabilitarControles()
        {
            vista.IdTextBox.Enabled = false;
            vista.NombreTextBox.Enabled = false;
            vista.IdentidadTextBox.Enabled = false;
            vista.TelefonoTextBox.Enabled = false;

            vista.GuardarButton.Enabled = false;
            vista.ModificarButton.Enabled = true;
            vista.NuevoButton.Enabled = true;

        }
    }
}
