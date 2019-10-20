using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDatos;
using CLogica;

namespace CPresentacion
{
	public partial class Form1 : Form
	{

		Conexion c = new Conexion();
		Producto p = new Producto();

		int posicion;
		public Form1()
		{
			InitializeComponent();
		}



		private void bCrear_Click(object sender, EventArgs e)
		{
			try
			{
				p.id = int.Parse(tId.Text);
				p.nombre = tNombre.Text;
				p.fecha = DateTime.Parse(tFecha.Text);
				p.categoria = tCategoria.Text;

				c.guardar(p.nombre, p.fecha, p.categoria);

				MessageBox.Show("El producto se agrego correctamente");
			}
			catch (Exception error)
			{
				MessageBox.Show(error.Message);
			}

			getDatos1();
			getDatos2();
			limpiar();
		}
		public void getDatos1()
		{
			data.DataSource = c.llenarGrid1();
		}
		public void getDatos2()
		{
			data2.DataSource = c.llenarGrid2();
		}



		public void limpiar()
		{
			tId.Clear();
			tNombre.Clear();
			tCategoria.Clear();
			tFecha.Clear();
		}

		private void bModificar_Click(object sender, EventArgs e)
		{
			try
			{
				p.id = int.Parse(tId.Text);
				p.nombre = tNombre.Text;
				p.fecha = DateTime.Parse(tFecha.Text);
				p.categoria = tCategoria.Text;
				c.modificar(p.id, p.nombre, p.fecha,p.categoria);

				data[0, posicion].Value = tId.Text;
				data[1, posicion].Value = tNombre.Text;
				data[12, posicion].Value = tFecha.Text;
				data[13, posicion].Value = tCategoria.Text;

				MessageBox.Show("La modificacion se realizo correctamente");

			}
			catch (Exception error)
			{
				MessageBox.Show(error.Message);
			}
			limpiar();
		}

		private void bEliminar_Click(object sender, EventArgs e)
		{
			try
			{
				p.id = int.Parse(tId.Text);
				c.eliminar(p.id);
				data.Rows.Remove(data.CurrentRow);
				MessageBox.Show("Se elimino Correctamente");
			} catch (Exception error) {
				MessageBox.Show("Hubo un error al eliminar");
			}
			limpiar();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: esta línea de código carga datos en la tabla 'productionDataSet.Product' Puede moverla o quitarla según sea necesario.
			this.productTableAdapter.Fill(this.productionDataSet.Product);
			try
			{
				getDatos1();
				getDatos2();
			} catch (Exception error) {
				MessageBox.Show("NO se pudieron cargar los datos");
			}

		}

		private void bSalir_Click(object sender, EventArgs e)
		{

			this.Close();
		}

		private void data_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			posicion = data.CurrentRow.Index;

			tId.Text = data[0, posicion].Value.ToString();
			tNombre.Text = data[1, posicion].Value.ToString();
			tFecha.Text = data[12, posicion].Value.ToString();
			tCategoria.Text = data[13, posicion].Value.ToString();
		}

	}
}
