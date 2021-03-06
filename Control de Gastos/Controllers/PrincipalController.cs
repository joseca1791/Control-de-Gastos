﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Gastos.Controllers
{

    public class PrincipalController
    {
        public PrincipalController() {}
        SQLiteDAO sqlitedao = new SQLiteDAO();
        public List<string> llenarComercios(Form form)
        {
            return sqlitedao.listarComercios();

        }
        public List<string> llenarTipodeGasto(Form form)
        {
            return sqlitedao.listarTiposGasto();
        }

        public void registrarGasto(string fecha, string tipo, string comercio, decimal monto)
        {
            sqlitedao.registrarGasto(fecha,tipo,comercio,monto);
        }

        public DataTable generarReporte()
        {
            return sqlitedao.listarGastosReporte();
        }
    }
}
