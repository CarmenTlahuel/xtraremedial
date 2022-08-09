using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using ClassAcceso;
using CapaEntidad;

namespace CapaNegocio
{
    public class LogicaNegocio
    {
        public AcessoSQL nuevo = null;

        public LogicaNegocio(string conec)
        {
            nuevo = new AcessoSQL(conec);
        }
    }

    public List<Usuario> VerUsuarios (ref string m)
    {
        List<Usuario> lista = new List<Usuario>();

        SqlDataReader atrapa = null;

        SqlConnection nuev = null;
        nuev = nuevo.AbrirConexion(ref m);

        string consulta = "Select NOMBRE from EMPLEDO";

        atrapa = nuevo.Consulta_DataReader(consulta, nuev, ref m);

        if (atrapa != null)
        {
            while (atrapa.Read())
            {
                lista.Add(new Usuario()
                {

                    nombre = (string)atrapa[0]
                }
                );
            }
        }
        nuev.Close();
        nuev.Dispose();
        return lista;

    }
    public DataTable VerPublicaciones(ref string m)
    {
        string Ver = "";
        DataSet guarda = null;
        DataTable resultado = null;
        guarda = nuevo.Consulta_DataSet_Simple(Ver, nuevo.AbrirConexion(ref m), ref m);
        if (guarda != null)
        {
            resultado = guarda.Tables[0];

        }
        return resultado;
    }
    public Boolean UsuarioNuevo(Usuario nueva, ref string m)
    {
        string Insertar = "insert into Usuario(nombre, colonia, numero, cp, nom_centroTrabajo, telefono)" +
            " values (@nom, @col, @num, @cp, @nct, @tel )";
        SqlParameter[] coleccion = new SqlParameter[]
        {

                new SqlParameter("nom", SqlDbType.VarChar,40),
                new SqlParameter("col", SqlDbType.VarChar,20),
                new SqlParameter("num", SqlDbType.Int),
                new SqlParameter("cp", SqlDbType.Int),
                new SqlParameter("nct", SqlDbType.VarChar,30),
                new SqlParameter("tel", SqlDbType.VarChar,12)

        };

        coleccion[0].Value = nueva.nombre;
        coleccion[1].Value = nueva.colonia;
        coleccion[2].Value = nueva.numero;
        coleccion[3].Value = nueva.cp;
        coleccion[4].Value = nueva.nom_centroTrabajo;
        coleccion[5].Value = nueva.telefono;

        Boolean salida = false;

        salida = nuevo.InsertarBD(Insertar, nuevo.AbrirConexion(ref m), ref m, coleccion);

        return salida;
    }
}
