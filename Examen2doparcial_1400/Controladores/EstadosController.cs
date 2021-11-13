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
    public class EstadosController
    {
        EstadosView vista;
        string operacion = string.Empty;
        EstadosDAO EstadosDAO = new EstadosDAO();
        Estados user = new Estados();

        public EstadosController(EstadosView view)
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
            user.SinResolver = vista.ResolverCheckBox.Checked;
            user.Espera = vista.EsperaCheckBox.Checked;
            user.Abierto = vista.AbiertoCheckBox.Checked;
            user.Cerrado = vista.CerradoCheckBox.Checked;

            if (operacion == "Nuevo")
            {
                bool inserto = EstadosDAO.InsertarNuevoTipo(user);

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
                bool modifico = EstadosDAO.ActualizarUsuario(user);

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
            bool elimino = EstadosDAO.EliminarUsuario(Convert.ToInt32(vista.EstadosDataGridView.CurrentRow.Cells[0].Value.ToString()));

            if (elimino)
            {
                DesabilitarControles();
                LimpiarControles();

                MessageBox.Show("Usuario Eliminado Exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarUsuarios();
            }
        }

        private void Modificar(object serder, EventArgs e)
        {
            operacion = "Modificar";

            if (vista.EstadosDataGridView.SelectedRows.Count > 0)
            {
                vista.IdTextBox.Text = vista.EstadosDataGridView.CurrentRow.Cells["ID"].Value.ToString();
               //vista.SoporteTextBox.Text = vista.TiposDataGridView.CurrentRow.Cells["SOPORTE"].Value.ToString();


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
            vista.ResolverCheckBox.Enabled = true;
            vista.AbiertoCheckBox.Enabled = true;
            vista.CerradoCheckBox.Enabled = true;

            vista.GuardarButton.Enabled = true;
            vista.ModificarButton.Enabled = false;
            vista.NuevoButton.Enabled = false;

        }

        private void ListarUsuarios()
        {
            vista.EstadosDataGridView.DataSource = EstadosDAO.GetUsuarios();
        }
        private void LimpiarControles()
        {
            vista.IdTextBox.Clear();
            vista.ResolverCheckBox.Enabled = false;
            vista.AbiertoCheckBox.Enabled = false;
            vista.CerradoCheckBox.Enabled = false;
        }
        private void DesabilitarControles()
        {
            vista.IdTextBox.Enabled = false;
            vista.ResolverCheckBox.Enabled = false;
            vista.AbiertoCheckBox.Enabled = false;
            vista.CerradoCheckBox.Enabled = false;

            vista.GuardarButton.Enabled = false;
            vista.ModificarButton.Enabled = true;
            vista.NuevoButton.Enabled = true;

        }
    }
}
