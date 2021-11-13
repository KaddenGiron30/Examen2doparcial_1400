using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Examen2doparcial_1400.Vistas
{
    public partial class MenuView : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        TiposView vistaTipos;
        EstadosView vistaEstados;
        TicketsView vistaTicket;
        DetallesView vistaDetalle;

        
        private void toolStripTabItem1_Click(object sender, EventArgs e)
        {

        }

        
        private void TiposToolStripButton_Click(object sender, EventArgs e)
        {
            if(vistaTipos == null)
            {
                vistaTipos = new TiposView();
                vistaTipos.MdiParent = this;
                vistaTipos.FormClosed += Vista_FormClosed;
                vistaTipos.Show();
            }
        }

        private void Vista_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaTipos = null;
            vistaDetalle = null;
            vistaEstados = null;
            vistaTicket = null;
        }

        private void EstadosToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaEstados == null)
            {
                vistaEstados = new EstadosView();
                vistaEstados.MdiParent = this;
                vistaEstados.FormClosed += Vista_FormClosed;
                vistaEstados.Show();
            }
        }

        private void TicketsToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaTicket == null)
            {
                vistaTicket = new TicketsView();
                vistaTicket.MdiParent = this;
                vistaTicket.FormClosed += Vista_FormClosed;
                vistaTicket.Show();
            }
        }

        private void DetallesToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaDetalle == null)
            {
                vistaDetalle = new DetallesView();
                vistaDetalle.MdiParent = this;
                vistaDetalle.FormClosed += Vista_FormClosed;
                vistaDetalle.Show();
            }
        }
    }
}
