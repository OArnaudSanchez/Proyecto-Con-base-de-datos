using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace CDatos
{
    public class Conexion
    {
		SqlConnection conexion = new SqlConnection("Data Source=ADMINISTRADOR;Initial Catalog=Production;Integrated Security=True");

		SqlCommand comando;

		public const string ProductNumber = "AA-0000";
		public const int SafetyStockLevel = 10000;
		public const int ReorderPoint = 700;
		public const string rowguid = "1aaaaa-bbbbbb-cccc";
		//DateTime time = new DateTime(2016,12,24)
		public const string time = "19/10/2019";
		public string Color = "black";
		public string MakeFlag = "";
		public string FinishedGoodsFlag = "";
		public double StandardCost = 121.0000;
		public double ListPrice = 233.0000;
		public int DaysToManufacture = 10;
		public string SellStartDate = "16/10/2019";
		public char Size = 'S';



		public void guardar(string nombre, DateTime fecha, string category)
		{
			
				conexion.Open();
				string query = $"insert into Product (Name,ProductNumber,Color,SafetyStockLevel,ReorderPoint,StandardCost,ListPrice,Size,DaysToManufacture,SellStartDate,rowguid,ModifiedDate,Category) values ('{nombre}','{ProductNumber}','{Color}',{SafetyStockLevel},'{ReorderPoint}','{StandardCost}','{ListPrice}','{Size}','{DaysToManufacture}','{SellStartDate}','{rowguid}','{fecha}','{category}')";
				
				comando = new SqlCommand(query, conexion);

				comando.ExecuteNonQuery();

				conexion.Close();

			
		}


		public void modificar(int id, string nombre, DateTime fecha, string categoria)
		{
			conexion.Open();

			string LineaComando = $"update Product set Name='{nombre}', ModifiedDate='{fecha}',  Category='{categoria}' where ProductID='{id}'";


			comando = new SqlCommand(LineaComando, conexion);
			comando.ExecuteNonQuery();


			conexion.Close();
		}


		public void eliminar(int id)
		{
			conexion.Open();

		   string LineaComando = $"delete from Product where ProductID ='{id}'";
			comando = new SqlCommand(LineaComando, conexion);

			comando.ExecuteNonQuery();

			conexion.Close();
		}


		public DataTable llenarGrid1()
		{
			conexion.Open();
			string query = "Select * from Product";
			comando = new SqlCommand(query, conexion);
			comando.ExecuteNonQuery();
			SqlDataAdapter datos = new SqlDataAdapter(comando);

			DataTable tabla = new DataTable();

			datos.Fill(tabla);
			conexion.Close();

			return tabla;

		}
		public DataTable llenarGrid2()
		{
			conexion.Open();
			string query = "Select Name, Category from Product";

			//queryString = "select p.ProductID as ID, c.name as Categoria, p.name as Nombre  from Production.ProductCategory c inner join Production.ProductSubcategory s on c.ProductCategoryID=s.ProductCategoryID inner join Production.Product p  on s.ProductSubcategoryID=p.ProductSubcategoryID";
			comando = new SqlCommand(query, conexion);
			comando.ExecuteNonQuery();
			SqlDataAdapter datos = new SqlDataAdapter(comando);

			DataTable tabla = new DataTable();

			datos.Fill(tabla);
			conexion.Close();

			return tabla;

		}
	}
}

