﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_Gastos
{
    public class SQLiteDAO
    {

        #region Tipo de Gasto
        public List<string> listarTiposGasto()
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<string>("select tipo from TiposGasto order by tipo", new DynamicParameters());
                return output.ToList();
            }
        }
        public List<string> buscarTiposGasto(string filter)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<string>("select tipo from TiposGasto where tipo like '%" + filter + "%' order by tipo", new DynamicParameters());
                return output.ToList();
            }
        }
        public void guardarTiposGasto(string tipo)
        {

            tipo = char.ToUpper(tipo[0]) + tipo.Substring(1);
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var cuenta = listarTiposGasto().Count + 1;
                string sql = "insert into TiposGasto values (" + cuenta + ",'" + tipo + "')";
                SQLiteConnection conn = new SQLiteConnection(LoadConnectionString());
                conn.Open();
                SQLiteCommand command1 = new SQLiteCommand(sql, conn);
                command1.ExecuteNonQuery();
                conn.Close();
                //CommandDefinition command = new CommandDefinition("insert into TiposGasto values ("+cuenta+",'"+tipo+"')");
                //cnn.Execute(command);
            }
        }
        #endregion
        #region Comercios
        public List<string> listarComercios()
        {
            //using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            //{

            //}
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<string>("select nombreComercio from Comercios order by nombreComercio", new DynamicParameters());
                return output.ToList();
            }
        }
        public List<string> buscarComercio(string filter)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<string>("select nombreComercio from Comercios where nombreComercio like '%" + filter + "%' order by nombreComercio", new DynamicParameters());
                return output.ToList();
            }
        }
        #endregion

        public DataTable listarGastosReporte()
        {
            var dt = new DataTable();
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Tipo de Gasto");
            dt.Columns.Add("Lugar");
            dt.Columns.Add("Monto");
            DataRow dr = null;
            IDictionary<string, object> fields;


            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query("select * from GastoUnitarioTable").ToList();
                foreach (var row in output)
                {
                    dr = dt.NewRow();
                    fields = row as IDictionary<string, object>;
                    dr["Fecha"] = fields["Fecha"];
                    dr["Tipo de Gasto"] = fields["TipoGasto"];
                    dr["Lugar"] = fields["Lugar"];
                    dr["Monto"] = "₡ "+fields["Monto"];
                    dt.Rows.Add(dr);
                }
            }
            dt.AcceptChanges();
            return dt;
        }
        public List<string> listarGastos()
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output= cnn.Query<string>("select id from GastoUnitarioTable", new DynamicParameters());
                return output.ToList();
            }
        }
        public void registrarGasto(string fecha,string tipo, string comercio, decimal monto)
        {

            tipo = char.ToUpper(tipo[0]) + tipo.Substring(1);
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var cuenta = int.Parse(listarGastos().Last()) + 1;
                string sql = "insert into GastoUnitarioTable values (" + cuenta + ",'" + fecha + "','" + tipo + "','" + comercio + "'," + monto + ")";
                SQLiteConnection conn = new SQLiteConnection(LoadConnectionString());
                conn.Open();
                SQLiteCommand command1 = new SQLiteCommand(sql, conn);
                command1.ExecuteNonQuery();
                conn.Close();
            }
        }
        private static string LoadConnectionString(string id = "SQLite")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
