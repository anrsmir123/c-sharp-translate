/*
 * Created by SharpDevelop.
 * User: user
 * Date: 24.10.2019
 * Time: 12:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.ObjectModel; 
using System.Runtime.Serialization.Formatters.Binary; 
using System.Runtime.InteropServices; 
using System.Data; 

namespace transleid
{
	public class DataGrid
	{
		public System.Data.DataSet dataset1;
		public System.Data.DataTable table1;
		public System.Data.DataColumn russia;
		public System.Data.DataColumn eng;
		public System.Data.DataColumn ger;

		public DataGrid()
		{
		}

		public void DataG()
		{
			dataset1 = new System.Data.DataSet();
			table1 = new System.Data.DataTable();
			russia = new System.Data.DataColumn();
			eng = new System.Data.DataColumn();
			ger = new System.Data.DataColumn();



			table1.TableName = "EngRusDet";
			russia.ColumnName = "Русский";
			eng.ColumnName = "Английский";
			ger.ColumnName = "Немецкий";

			table1.Columns.AddRange(new DataColumn[]{
			                        	russia,
			                        	eng,
			                        	ger
			                        });
			
			russia.DataType = typeof(System.String);
			russia.AllowDBNull = false;
			russia.ReadOnly = true;
			russia.Unique = false;

			eng.DataType = typeof(System.String);
			eng.AllowDBNull = false;
			eng.ReadOnly = true;
			eng.Unique = false;
			
			

			ger.DataType = typeof(System.String);
			ger.AllowDBNull = false;
			ger.ReadOnly = true;
			ger.Unique = false;

			dataset1.Tables.AddRange(new DataTable[]{
			                         	table1
			                         });
		}
	}
}
