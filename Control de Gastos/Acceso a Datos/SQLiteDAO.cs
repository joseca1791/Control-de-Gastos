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
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<dynamic>("select * from GastoUnitarioTable", new DynamicParameters());
                foreach (var row in output)
                {
                    var fields = row as IDictionary<string, object>;
                    var element = fields["id"];
                }
                return dt;
            }
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
                var cuenta = listarGastos().Count + 1;
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