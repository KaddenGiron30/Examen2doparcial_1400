using Examen2doparcial_1400.Modelos.DAO;
using Examen2doparcial_1400.Modelos.Entidades;
using Examen2doparcial_1400.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2doparcial_1400.Controladores
{
    public class DetalleController
    {
        DetallesView vista;
        DetalleDAO detalleDAO = new DetalleDAO();

        public DetalleController(DetallesView view)
        {
            vista = view;

            vista.Load += new EventHandler(Load);
        }
        private void Load(object serder, EventArgs e)
        {
            ListarUsuarios();
        }
        private void ListarUsuarios()
        {
            vista.DetalleDataGridView.DataSource = detalleDAO.GetDetalle();
        }

        
    }
}
