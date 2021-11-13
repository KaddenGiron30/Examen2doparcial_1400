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
    public class TiposController
    {
        TiposView vista;
        string operacion = string.Empty;
        TiposDAO tipoDAO = new TiposDAO();
        Tipos user = new Tipos();

        public TiposController(TiposView view)
        {
            vista = view;

            vista.NuevoButton.Click += new EventHandler(Nuevo);
            vista.GuardarButton.Click += new EventHandler(Guardar);
            vista.ModificarButton.Click += new EventHandler(Modificar);
            vista.EliminarButton.Click += new EventHandler(Eliminar);
            vista.Load += new EventHandler(Load);
        }

        private void Eliminar (object serder, EventArgs e)
        {
            bool elimino = tipoDAO.EliminarUsuario(Convert.ToInt32(vista.TiposDataGridView.CurrentRow.Cells[0].Value.ToString()));

            if (elimino)
            {
                DesabilitarControles();
                LimpiarControles();

                MessageBox.Show("Usuario Eliminado Exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarUsuarios();
            }
        }

        private void Nuevo(object serder, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
            ListarUsuarios();
        }

        private void Modificar(object serder, EventArgs e)
        {
            operacion = "Modificar";

            if (vista.TiposDataGridView.SelectedRows.Count > 0)
            {
                vista.IdTextBox.Text = vista.TiposDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                vista.SoporteTextBox.Text = vista.TiposDataGridView.CurrentRow.Cells["SOPORTE"].Value.ToString();


                HabilitarControles();

            }

        }

        private void Load(object serder, EventArgs e)
        {
            ListarUsuarios();
        }

        private void Guardar(object serder, EventArgs e)
        {
            if (vista.SoporteTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.SoporteTextBox, "Ingrese un nombre");
                vista.SoporteTextBox.Focus();
                return;
            }

            user.TipoSoporte = vista.SoporteTextBox.Text;
    
            if(operacion == "Nuevo")
            {
                bool inserto = tipoDAO.InsertarNuevoTipo(user);

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
                bool modifico = tipoDAO.ActualizarUsuario(user);

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

        private void ListarUsuarios()
        {
            vista.TiposDataGridView.DataSource = tipoDAO.GetUsuarios();
        }

        private void LimpiarControles()
        {
            vista.IdTextBox.Clear();
            vista.SoporteTextBox.Clear();
        }

        private void HabilitarControles()
        {
            vista.IdTextBox.Enabled = true;
            vista.SoporteTextBox.Enabled = true;

            vista.GuardarButton.Enabled = true;
            vista.CancelarButton.Enabled = true;
            vista.ModificarButton.Enabled = false;
            vista.NuevoButton.Enabled = false;

        }

        private void DesabilitarControles ()
        {
            vista.IdTextBox.Enabled = false;
            vista.SoporteTextBox.Enabled = false;

            vista.GuardarButton.Enabled = false;
            vista.CancelarButton.Enabled = false;
            vista.ModificarButton.Enabled = true;
            vista.NuevoButton.Enabled = true;

        }
    }
}
