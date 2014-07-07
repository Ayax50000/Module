using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace busqueda_RFC
{
    class fuente_datos
    {
      string dbconexion;
      public static string[] codigos;
      SqlConnection con;
      SqlCommand cmd, cmd1;
      SqlDataReader datos;
      SqlDataAdapter da;

      // METODOS PRINCIPALES

      public string[,] clientes(string razon,string rfc) 
      {
        string[,] resultados;
        int registros = 0;
        get_conexion();

        cmd = new SqlCommand("sp_razones_sociales", con);
        cmd.CommandType = CommandType.StoredProcedure;

        SqlParameter _razon = new SqlParameter("@Razon",razon);
        _razon.Direction = ParameterDirection.Input;
        _razon.DbType = DbType.String;
        cmd.Parameters.Add(_razon);

        SqlParameter _rfc = new SqlParameter("@rfc", rfc);
        _rfc.Direction = ParameterDirection.Input;
        _rfc.DbType = DbType.String;
        cmd.Parameters.Add(_rfc);

        SqlParameter _registros = new SqlParameter("@registros", registros);
        _registros.Direction = ParameterDirection.Output;
        _registros.DbType = DbType.Int32;
        cmd.Parameters.Add(_registros);

        try { 
            con.Open();
            cmd.ExecuteNonQuery();
            } catch(Exception ex) { MessageBox.Show(ex.Message); }

          registros = Convert.ToInt32(_registros.Value);
          resultados = new string[registros + 1, 2];
          codigos = new string[Convert.ToInt32(registros) + 1];
          resultados[0, 0] = Convert.ToString(registros);

          try
          {
              datos = cmd.ExecuteReader();
              if (registros > 0)
              {
                  for (int x = 1; x < registros + 1; x++)
                  {
                      datos.Read();
                      resultados[x, 0] = Convert.ToString(datos["cidclienteproveedor"]);
                      resultados[x, 1] = Convert.ToString(datos["Crazonsocial"]);
                      codigos[x] = Convert.ToString(datos["ccodigocliente"]);
                  }
              }
              datos.Close();
              con.Close();
          }  catch (Exception ex) { MessageBox.Show(ex.Message); }
        return resultados;
      }

      public Hashtable datos_cliente(int id) 
      {
        Hashtable retorno = new Hashtable();
        get_conexion();
        
        cmd = new SqlCommand("sp_verificar_saldo_razon", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd1 = new SqlCommand("sp_informacion_razon_social", con);
        cmd1.CommandType = CommandType.StoredProcedure;

        SqlParameter _id = new SqlParameter("@id", id);
        _id.DbType = DbType.Int32;
        _id.Direction = ParameterDirection.Input;
        cmd1.Parameters.Add(_id);

        SqlParameter _id2 = new SqlParameter("@id", id);
        _id2.DbType = DbType.Int32;
        _id2.Direction = ParameterDirection.Input;
        cmd.Parameters.Add(_id2);

        SqlParameter _saldo = new SqlParameter();
        _saldo.Direction = ParameterDirection.Output;
        _saldo.DbType = DbType.Decimal;
        _saldo.ParameterName = "@saldo";
        cmd.Parameters.Add(_saldo);

        try
        {
          con.Open();
          datos = cmd1.ExecuteReader();
          if (datos.Read()) 
          {
              retorno["domicilio"] = Convert.ToString(datos["colonia"]) + ", " + Convert.ToString(datos["calle"]) + " NO " + Convert.ToString(datos["exterior"]) + " Int " + Convert.ToString(datos["interior"]);
              retorno["localidad"] = Convert.ToString(datos["ciudad"]) + ", " + Convert.ToString(datos["municipio"]) + ", " + Convert.ToString(datos["estado"]) + ", " + Convert.ToString(datos["pais"]);
              retorno["telefonos"] = Convert.ToString(datos["telefono1"]) + ", " + Convert.ToString(datos["telefono2"]) + ", " + Convert.ToString(datos["telefono3"]) + ", " + Convert.ToString(datos["telefono4"]);
              retorno["razon"] = Convert.ToString(datos["razon social"]);
              retorno["rfc"] = Convert.ToString(datos["rfc"]);
              retorno["contactos"] = Convert.ToString(datos["contactos"]);
              retorno["ccontactos"] = Convert.ToString(datos["ccontactos"]);
              retorno["emails"] = Convert.ToString(datos["email1"]) + ", " + Convert.ToString(datos["email2"]);
              if (Convert.ToInt32(datos["estatus"]) == 0) {retorno["estatus"] = "Cliente Inactivo";} else {retorno["estatus"] = "Cliente Activo";
            }            
          }
          datos.Close();
          cmd.ExecuteNonQuery();
          try 
          { 
            decimal saldo = Convert.ToDecimal(_saldo.Value);
            retorno["deuda"] = "Saldo Pendiente " + saldo.ToString("C2");
          } catch (Exception ex) { retorno["deuda"] = "Saldo Pendiente " + 0.0.ToString("C2"); }
          con.Close();
        } catch(Exception ex) { MessageBox.Show(ex.Message); }

          return retorno;
      }

      public DataTable obtener_documentos(Hashtable fechas,int estado,int[] ids_razon, int razones, string producto)
      {
          DataTable dt = new DataTable();
          get_conexion();
          string ids = String.Join(",",ids_razon);
          configurar_datos_fecha(ref fechas);

          cmd = new SqlCommand("sq_obtener_documentos_razon", con);
          cmd.CommandType = CommandType.StoredProcedure;

          SqlParameter _fechai = new SqlParameter("@fechai", (fechas["firstanio"].ToString() + fechas["firstmes"].ToString() + fechas["firstdia"].ToString()));
          _fechai.Direction = ParameterDirection.Input;
          _fechai.DbType = DbType.String;
          cmd.Parameters.Add(_fechai);

          SqlParameter _fechaf = new SqlParameter("@fechaf", (fechas["lastanio"].ToString() + fechas["lastmes"].ToString() + fechas["lastdia"].ToString()));
          _fechaf.Direction = ParameterDirection.Input;
          _fechaf.DbType = DbType.String;
          cmd.Parameters.Add(_fechaf);

          SqlParameter _ids = new SqlParameter("@ids", ids);
          _ids.Direction = ParameterDirection.Input;
          _ids.DbType = DbType.String;
          cmd.Parameters.Add(_ids);

          SqlParameter _estado = new SqlParameter("@estado", estado);
          _estado.Direction = ParameterDirection.Input;
          _estado.DbType = DbType.Int32;
          cmd.Parameters.Add(_estado);

          SqlParameter _producto = new SqlParameter("@producto",producto);
          _producto.Direction = ParameterDirection.Input;
          _producto.DbType = DbType.String;
          cmd.Parameters.Add(_producto);

          try { llenar_dt(ref dt); } catch (Exception ex) { MessageBox.Show(ex.Message); }
          return dt;
      }

      public DataTable obtener_detalles_documento(int id)
      {
          DataTable dt = new DataTable();
          get_conexion();

          cmd = new SqlCommand("sq_obtener_detalles_documentos", con);
          cmd.CommandType = CommandType.StoredProcedure;

          SqlParameter _id = new SqlParameter("@id", id);
          _id.Direction = ParameterDirection.Input;
          _id.DbType = DbType.Int32;
          cmd.Parameters.Add(_id);

          try  { llenar_dt(ref dt); } catch (Exception ex) { MessageBox.Show(ex.Message); }
          return dt;
      }

      public void agente_informacion(int id,string razon) {

          get_conexion();
          cmd = new SqlCommand("sp_detecta_agenteV", con);
          cmd.CommandType = CommandType.StoredProcedure;

          SqlParameter _idcliente = new SqlParameter("@idcliente", id);
          _idcliente.Direction = ParameterDirection.Input;
          _idcliente.DbType = DbType.Int32;
          cmd.Parameters.Add(_idcliente);

          SqlParameter _dist = new SqlParameter();
          _dist.ParameterName = "@dist";
          _dist.DbType = DbType.Int32;
          _dist.Direction = ParameterDirection.Output;
          cmd.Parameters.Add(_dist);

          SqlParameter _desp = new SqlParameter();
          _desp.ParameterName = "@desp";
          _desp.DbType = DbType.Int32;
          _desp.Direction = ParameterDirection.Output;
          cmd.Parameters.Add(_desp);

          SqlParameter _inte = new SqlParameter();
          _inte.ParameterName = "@inte";
          _inte.DbType = DbType.Int32;
          _inte.Direction = ParameterDirection.Output;
          cmd.Parameters.Add(_inte);

          
          SqlParameter _nclas = new SqlParameter();
          _nclas.ParameterName = "@nclas";
          _nclas.DbType = DbType.Int32;
          _nclas.Direction = ParameterDirection.Output;
          cmd.Parameters.Add(_nclas);

          try {
              con.Open();
              cmd.ExecuteNonQuery();
              con.Close();
          } catch (Exception ex) { MessageBox.Show(ex.Message); }

          int dist, desp, inte, nclas;
          dist = Convert.ToInt32(_dist.Value);
          desp = Convert.ToInt32(_desp.Value);
          inte = Convert.ToInt32(_inte.Value);
          nclas = Convert.ToInt32(_nclas.Value);

          trabajo_access ta = new trabajo_access();
          int pendientes = ta.cuenta_pendientes(razon);
          string t_cliente = tipo_cliente(id);
          string t_poliza = "";
          int lineas = 0;
          obtener_polizas(id,ref t_poliza, ref lineas );

          if ((dist == 1)) {
              mostrar_alerta(" " + t_cliente + ", Atendido por el Distribuidor " + nombre_agente(id), t_poliza, true,lineas);
          }
          else if ((dist == 0) && (desp == 0) && (inte == 0) && (nclas == 0) && (pendientes == 0))
          {
              mostrar_alerta(" " + t_cliente + ", no se han registrado pendientes ni facturas ", t_poliza, false, lineas);
          }
          else if ( ((desp == 1) || (inte == 1) || (nclas == 1)) && (pendientes == 0))
          {
              mostrar_alerta(" " + t_cliente + ", solo tiene facturas registradas ", t_poliza, false, lineas);
          }
          else if ((dist == 0) && (desp == 0) && (inte == 0) && (nclas == 0) && (pendientes > 0))
          {
              mostrar_alerta(" " + t_cliente + ", no se le han hecho facturas , " + pendientes + " pendientes registrados", t_poliza, false, lineas);
          }
          else {
              mostrar_alerta(" " + t_cliente + ", " + pendientes + " pendientes registrados ", t_poliza, false, lineas);
               }              
          }

      public void obtener_polizas(int id,ref string  spoliza,ref int lineas){
          get_conexion();
          cmd = new SqlCommand("sp_getInfo_polizas", con);
          cmd.CommandType = CommandType.StoredProcedure;

          SqlParameter _id = new SqlParameter("@id",id);
          _id.DbType = DbType.Int32;
          cmd.Parameters.Add(_id);

          try {
              con.Open();
              datos = cmd.ExecuteReader();
              if (datos.Read()) {
                  lineas++;
                  spoliza += "  " + Convert.ToString(datos["Poliza"])  + 
                      "| Valida de " + Convert.ToString(datos["Inicio"]).Substring(0, 10) + " hasta " + Convert.ToString(Convert.ToDateTime(datos["Inicio"]).AddMonths(Convert.ToInt32(datos["Meses"]))).Substring(0, 10) + Environment.NewLine;
                  while (datos.Read()) {
                      lineas++;
                      spoliza += "  " + Convert.ToString(datos["Poliza"]) + 
                      "| Valida de " + Convert.ToString(datos["Inicio"]).Substring(0, 10) + " hasta " + Convert.ToString(Convert.ToDateTime(datos["Inicio"]).AddMonths(Convert.ToInt32(datos["Meses"]))).Substring(0, 10) + Environment.NewLine;
                  }
              }
              else {
                  spoliza = "    SIN POLIZAS";
              }
              con.Close();
          }
          catch(Exception ex){   
          }

      }

      public string verifica_credito(int id) {

          get_conexion();

          cmd = new SqlCommand("sp_exceder_permitido", con);
          cmd.CommandType = CommandType.StoredProcedure;

          SqlParameter _id = new SqlParameter("@id", id);
          _id.DbType = DbType.Int32;
          cmd.Parameters.Add(_id);

          SqlParameter _res = new SqlParameter();
          _res.ParameterName = "@res";
          _res.DbType = DbType.String;
          _res.Size = 50;
          _res.Direction = ParameterDirection.Output;
          cmd.Parameters.Add(_res);

          try { con.Open();
          cmd.ExecuteNonQuery();
          con.Close();
          }
          catch (Exception ex) { MessageBox.Show(ex.Message);}
          return ""+_res.Value;
      }

      




     //METODOS AUXILIARES

      private void llenar_dt(ref DataTable dt)
      {
          con.Open();
          da = new SqlDataAdapter(cmd);
          da.Fill(dt);
          con.Close();
      }

      private void configurar_datos_fecha(ref Hashtable datos ) 
      {
          Hashtable datosC = new Hashtable(datos);
          foreach (DictionaryEntry item in datosC) 
          {
              if (Convert.ToInt16(item.Value) < 10)
              { datos[item.Key] = "0" + item.Value; }
          }
      }

      private void get_conexion()
      {
          string[] datos = Fuente_Datos.leer_info();
          dbconexion = "Data Source=" + datos[0] + @"\" + datos[1] + ";Initial Catalog=" + datos[2] + ";user id=" + datos[3] + ";password=" + datos[4] + "";
          con = new SqlConnection(dbconexion);
      }

      private string nombre_agente(int id) {
          string nombre = "";
          get_conexion();
          cmd = new SqlCommand("sp_getnombres_agenteV", con);
          cmd.CommandType = CommandType.StoredProcedure;

          SqlParameter _idcliente = new SqlParameter("@idcliente", id);
          _idcliente.Direction = ParameterDirection.Input;
          _idcliente.DbType = DbType.Int32;
          cmd.Parameters.Add(_idcliente);

          SqlParameter _tipo = new SqlParameter("@tipo",41);
          _tipo.DbType = DbType.Int32;
          _tipo.Direction = ParameterDirection.Input;
          cmd.Parameters.Add(_tipo);

          try {
              con.Open();
              datos = cmd.ExecuteReader();
              while (datos.Read()) 
              {
                  nombre += Convert.ToString(datos["NOMBRES"]) + ", ";
              }
              con.Close();
          }catch(Exception ex) { }
          return nombre;
      }

      private string tipo_cliente(int id) {
          get_conexion();
          string tipo = "";

          cmd = new SqlCommand("sp_client_is_provider", con);
          cmd.CommandType = CommandType.StoredProcedure;

          SqlParameter _id = new SqlParameter("@id",id);
          _id.DbType = DbType.Int32;
          _id.Direction = ParameterDirection.Input;
          cmd.Parameters.Add(_id);

          SqlParameter _tipo = new SqlParameter();
          _tipo.DbType = DbType.String;
          _tipo.Size = 50;
          _tipo.Direction = ParameterDirection.Output;
          _tipo.ParameterName = "@tipo";
          cmd.Parameters.Add(_tipo);

          try { con.Open();
          cmd.ExecuteNonQuery();
          con.Close();
          } catch(Exception ex) { MessageBox.Show(ex.Message); }

          tipo = Convert.ToString(_tipo.Value);
          return tipo;
      }


      private void mostrar_alerta(string infoC, string infoP, bool icono,int lineas) 
      {
          Application.Run(new Alerta_busqueda(infoC, infoP, icono,lineas));
      }

    } 
}
