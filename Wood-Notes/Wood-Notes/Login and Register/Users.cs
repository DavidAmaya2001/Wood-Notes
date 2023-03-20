﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wood_Notes
{
    public class Users : Conexion
    {
        // Apertura de conexion con la base de datos WoodNotesDB
        static string conexionstring = "server= DESKTOP-DGI3QEQ\\SQLEXPRESS; database= WoodNotesDB; integrated security= true";
        SqlConnection conexion = new SqlConnection(conexionstring);
        private string hashpass = "wood-pass";

        #region Encapsulamiento de Credenciales
        // Clase de guardado de datos de usuario y contraseña
        private int id { get; set; }
        private string usuario { get; set; }
        private string password { get; set; }

        private string email { get; set; }

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getUsuario()
        {
            return usuario;
        }
        public void setUsuario(string usuario)
        {
            usuario = usuario.Trim();
            this.usuario = usuario;
        }
        public string getPassword()
        {
            return password;
        }
        public void setPassword(string password)
        {
            password = password.Trim();
            this.password = password;
        }
        public string getEmail()
        {
            return email;
        }
        public void setEmail(string email)
        {
            email = email.Trim();
            this.email = email;
        }
        #endregion

        #region Encapsulamiento de Datos Adicionales
        // Guardado de datos adicionales de la cuenta

        private string nombre { get; set; }
        private string apellido { get; set; }
        private string pais { get; set; }
        private string codigo { get; set; }
        private string telefono { get; set; }
        private string fecha_union { get; set; }

        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            nombre = nombre.Trim();
            this.nombre = nombre;
        }
        public string getApellido()
        {
            return apellido;
        }
        public void setApellido(string apellido)
        {
            apellido = apellido.Trim();
            this.apellido = apellido;
        }
        public string getPais()
        {
            return pais;
        }
        public void setPais(string pais)
        {
            this.pais = pais;
        }
        public string getCodigo()
        {
            return codigo;
        }
        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }
        public string getTelefono()
        {
            return telefono;
        }
        public void setTelefono(string telefono)
        {
            telefono = telefono.Trim();
            this.telefono = telefono;
        }
        public string getFecha_union()
        {
            return fecha_union;
        }
        public void setFecha_union(string fecha)
        {
            this.fecha_union = fecha;
        }
        #endregion

        #region Verificacion de Usuarios
        public bool Verificador()
        {
            // Apertura de la conexion
            conexion.Open();
            bool result = false;

            //Lectura de cadena SQL donde con ayuda del SQLDataReader verifica si existe usuario en el Login
            // Usando Encriptación para ocultar contraseñas en la base de datos
            string cadena = "select idCredencial,nickname,pPassword from UserCredentials where nickname = '" + getUsuario() + "' and CONVERT(varchar(max),DECRYPTBYPASSPHRASE('" + hashpass + "',pPassword)) = '" + getPassword() + "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader reader = null;
            reader = comando.ExecuteReader();

            // Usuario verificado == true
            if (reader.Read())
            {
                // Guardado de datos en variables 
                string credential = reader["idCredencial"].ToString();
                string username = reader["nickname"].ToString();
                string password = reader["pPassword"].ToString();

                // Guradado de datos en clase para llamarlos en el frmWorkStation
                setId(int.Parse(credential));
                setUsuario(username);
                setPassword(password);

                result = true;
            }
            // Usuario no encontrado == false
            else
            {
                result = false;
            }
            conexion.Close();
            return result;

        }

        #endregion

        #region Nuevo Registro Usuarios

        // Creacion de SQLCommand para trabajar el ingreso de la imagen a la base de datos
        SqlCommand cmd = new SqlCommand();
        public bool NewRegister(PictureBox imagen)
        {
            // Linea de codigo SQL de tabla Users

            // Uso de MmeoryStream para la conversion del dato a binario
            if(imagen.Image != null)
            {
                cmd.Connection = conexion;
                cmd.CommandText = "insert into Users([nombre],[apellido],[pais],[codigo],[telefono],[foto],[fecha_union]) values('" + getNombre() + "','" + getApellido() + "','" + getPais() + "','" + getCodigo() + "','" + getTelefono() + "','@foto','" + getFecha_union() + "')";

                // Declaracion del campo foto con un parametro de tipo Image
                cmd.Parameters.Add("@foto", SqlDbType.Image);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                cmd.Parameters["@foto"].Value = ms.GetBuffer();
            }
            else
            {
                cmd.Connection = conexion;
                cmd.CommandText = "insert into Users([nombre],[apellido],[pais],[codigo],[telefono],[fecha_union]) values('" + getNombre() + "','" + getApellido() + "','" + getPais() + "','" + getCodigo() + "','" + getTelefono() + "','" + getFecha_union() + "')";
            }

            

            // Linea de codigo SQL de la tabla relacionada de UserCredentials con encryptado de Password (lo encripta el comando)
            string cadena2 = "insert into UserCredentials([nickname],[pPassword],[correo]) values('" + getUsuario() + "',ENCRYPTBYPASSPHRASE('" + hashpass + "','" + getPassword() + "'),'" + getEmail() + "')";
            SqlCommand comando2 = new SqlCommand(cadena2, conexion);

            // Apertura, ejecución de comandos y cierre de conexión
            conexion.Open();
            int i = cmd.ExecuteNonQuery();
            int i2 = comando2.ExecuteNonQuery();
            conexion.Close();

            if (i > 0 && i2 > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Comprobador de Usuarios creados
        public bool VerificadorDeCuentas(string nickname)
        {
            // Apertura de la conexión
            conexion.Open();
            bool result = false;

            // Lectura de cadena SQL donde con ayuda del SQLDataReader verifica si ya hay usuarios con ese nickname
            string cadena = "select nickname from UserCredentials where nickname = '" + nickname + "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader reader = null;
            reader = comando.ExecuteReader();

            // Verificador que comprueba si existe ya un nickname como el ingresado 
            if (reader.Read())
            {
                result = true;
            }
            else
            {
                result = false;
            }
            conexion.Close();
            return result;
        }
        #endregion

        #region Verificador de correos
        public bool VerificadorDeCorreos(string correo)
        {
            // Apertura de la conexión
            conexion.Open();
            bool result = false;

            // Lectura de cadena SQL donde con ayuda del SQLDataReader verifica si ya se creo cuenta con ese correo
            string cadena = "select correo from UserCredentials where correo = '" + correo + "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader reader = null;
            reader = comando.ExecuteReader();

            // Verifica si ya hay cuenta con ese correo
            if (reader.Read())
            {
                result = true;
            }
            else
            {
                result = false;
            }

            conexion.Close();
            return result;

        }
        #endregion
    }
}