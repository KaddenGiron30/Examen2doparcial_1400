﻿using Examen2doparcial_1400.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2doparcial_1400.Vistas
{
    public partial class TiposView : Form
    {
        public TiposView()
        {
            InitializeComponent();
            TiposController controller = new TiposController(this);
        }

    }
}
