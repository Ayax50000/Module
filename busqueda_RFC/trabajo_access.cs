using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace busqueda_RFC
{
    class trabajo_access
    {
        string CadenaConexion, query;
        OleDbConnection con;
        OleDbDataReader dr;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataTable tabla;

        // METODOS PRINCIPALES

        public DataTable pendientes(string cliente, Hashtable fechas) 
        {
            get_conexion();
            tabla = new DataTable();
            
            query =  " SELECT  Pendientes.Fecha as Fecha, Pendientes.Nombre as Razon, Pendientes.Envia as \'Enviado por\', Asesores.Nombre as \'Recibido por\',"+
                     " Pendientes.Company as Contacto, Pendientes.DEscEstado as estado, Pendientes.idPendiente as id , Pendientes.Asunto as Asunto, Pendientes.Notas as Notas" +
                     " FROM Pendientes inner join Asesores on Pendientes.DirigidoA = Asesores.Codigo "+
                     " WHERE  Pendientes.Nombre like \'%" + cliente + "%\'  " +
                     " and ( Pendientes.Fecha between #" + fechas["lastmes"] + "/" + fechas["lastdia"] + "/" + fechas["lastanio"] + "#  "+
                     " and   #" + fechas["firstmes"] + "/" + fechas["firstdia"] + "/" + fechas["firstanio"] + "# );";
            try {            
            con.Open();
            da = new OleDbDataAdapter(query,con);
            da.Fill(tabla);
            con.Close();
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
            return tabla;
        }

        public int cuenta_pendientes(string razon) {
            int conteo = 0;
            get_conexion();
            query = " select count(*) from pendientes where Nombre like \'" + razon + "\'";
            cmd = new OleDbCommand(query, con);
            try {
                con.Open();
                if (cmd.ExecuteScalar() != null) { 
                conteo = Convert.ToInt32(cmd.ExecuteScalar()); }
                con.Close();
            }
            catch(Exception ex){}
            return conteo;
        }

        public DataTable seguimiento(int id)
        {
            get_conexion();
            tabla = new DataTable();
            query = "SELECT Fecha, (hour(Hora)&':'&Minute(Hora))  as Horas , Comentarios, StatusLetra as Estado, MovUsuario as Responsable " +  
                    "FROM SeguimientoPendientes WHERE idPendiente = "+id+";";
            try
            {
                con.Open();
                da = new OleDbDataAdapter(query, con);
                da.Fill(tabla);
                con.Close();
            } catch (Exception ex) { MessageBox.Show(ex.Message); }

            return tabla;
        }

        public bool login(string usuario, string contrasenia)
        {
            get_conexion();
            bool flag = false;
            query = "SELECT count(*) from Asesores where usuario =  \'" + usuario + "\'  and contraseña = \'" + contrasenia + "\' ;";

            try
            {
                con.Open();
                OleDbCommand cmdAcceso = new OleDbCommand(query, con);
                dr = cmdAcceso.ExecuteReader();
                if (dr.Read()) { if ((Convert.ToInt32(dr[0])) > 0) { flag = true; } }
                dr.Close();
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            return flag;
        }

        //  METODOS AUXILIARES

        private void get_conexion()
        {
            string[] datos = Fuente_Datos.leer_info();
            CadenaConexion = @"Provider=" + @datos[7] + ";Data Source=" + @datos[5] + @datos[6] + ";";
            con = new OleDbConnection(CadenaConexion);
        }
       
    }
}
