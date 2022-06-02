﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmPedidoPendienteDetalles : Form
    {
        Pedidos _owner;

        public FrmPedidoPendienteDetalles()
        {
            InitializeComponent();
        }

        public FrmPedidoPendienteDetalles(Pedidos owner)
        {
            _owner = owner;
            String fecha_requerido = "";

            InitializeComponent();

            if (String.IsNullOrWhiteSpace(_owner.ObtenerSeleccionPedidos().Cells["REQUERIDO"].Value.ToString()))
            {
                fecha_requerido = null;
            }

            else
            {
                fecha_requerido = Convert.ToDateTime(_owner.ObtenerSeleccionPedidos().Cells["REQUERIDO"].Value).ToString("dd/MM/yyyy");
            }

            this.labelNumeroPedido.Text = _owner.ObtenerSeleccionPedidos().Cells["CÓDIGO"].Value.ToString();
            this.textBoxCliente.Text = _owner.ObtenerSeleccionPedidos().Cells["CLIENTE"].Value.ToString();
            this.textBoxTransporte.Text = _owner.ObtenerSeleccionPedidos().Cells["TRANSPORTE"].Value.ToString();
            this.textBoxEmpleado.Text = _owner.ObtenerSeleccionPedidos().Cells["RESPONSABLE"].Value.ToString();
            this.textBoxFechaOrdenado.Text = Convert.ToDateTime(_owner.ObtenerSeleccionPedidos().Cells["ORDENADO"].Value).ToString("dd/MM/yyyy");
            this.textBoxFechaRequerido.Text = fecha_requerido;
            this.textBoxCostoEnvio.Text = Convert.ToDecimal(_owner.ObtenerSeleccionPedidos().Cells["COSTO DE ENVÍO"].Value).ToString("0.00#");
            this.dataGridViewProductos.DataSource = NPedidoDetalles.MostrarPedidoDetalles(Convert.ToInt32(_owner.ObtenerSeleccionPedidos().Cells[1].Value));
            this.dataGridViewProductos.Columns[4].DefaultCellStyle.Format = "0.00# '$'";
            this.dataGridViewProductos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewProductos.Columns[5].DefaultCellStyle.Format = "0.00# '%'";
            this.dataGridViewProductos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewProductos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            this.dataGridViewProductos.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
