using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Data;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PryEjercicio2
{
    internal class conexionBD
    {
        OleDbCommand comando;
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        string cadena;

        public conexionBD()
        {
            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./DB.accdb;";
        }

        public void agregarUsuario(string nom, string ape, string tel, string correo, int categ)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"INSERT INTO Usuarios(Nombre, Apellido, Telefono, Correo, Categoria) VALUES('{nom}', '{ape}', '{tel}', '{correo}', '{categ}')";

                conexion.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cuidado!" + ex.Message + " Pero se enlistará el resto de usuarios.");
            }
        }

        public void imprimirUsuarios(DataGridView dgvGrilla)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;


                comando.CommandText = "SELECT Usuarios.Nombre, Usuarios.Apellido, Usuarios.Telefono, Usuarios.Correo, Categorias.Categoria "+
"FROM Categorias INNER JOIN Usuarios ON Categorias.Id = Usuarios.Categoria";

                DataTable tablaUsuarios = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaUsuarios);

                dgvGrilla.DataSource = tablaUsuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ModificarTodo(string nombre, string apellido, string tel, string correo, int cat)
        {
            try
            {
                using (conexion = new OleDbConnection(cadena))
                {
                    comando = new OleDbCommand();

                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;

                    comando.CommandText = "UPDATE Usuarios SET Telefono = @tel, Correo = @correo, Categoria = @cat " +
                                          "WHERE Nombre = @nombre AND Apellido = @apellido";

                    comando.Parameters.AddWithValue("@tel", tel);
                    comando.Parameters.AddWithValue("@correo", correo);
                    comando.Parameters.AddWithValue("@cat", cat);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@apellido", apellido);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cuidado! " + ex.Message + " Revise el nombre y/o apellido.");
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public void ImprimirPorNom(DataGridView dgvGrilla, string nom)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;

                comando.CommandText = "SELECT Usuarios.Nombre, Usuarios.Apellido, Usuarios.Telefono, Usuarios.Correo, Categorias.Categoria " +
$"FROM Categorias INNER JOIN Usuarios ON Categorias.Id = Usuarios.Categoria WHERE Nombre = '{nom}'";


                DataTable tablaUsuarios = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaUsuarios);

                dgvGrilla.DataSource = tablaUsuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cuidado! " + ex.Message + "Es probable que el nombre no exista en la base de datos.");
            }
        }

        public void ImprimirNomFlex(DataGridView dgvGrilla, string nom)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;

                comando.CommandText = "SELECT Usuarios.Nombre, Usuarios.Apellido, Usuarios.Telefono, Usuarios.Correo, Categorias.Categoria " +
$"FROM Categorias INNER JOIN Usuarios ON Categorias.Id = Usuarios.Categoria WHERE Nombre LIKE '%{nom}%'";


                DataTable tablaUsuarios = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaUsuarios);

                dgvGrilla.DataSource = tablaUsuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cuidado! " + ex.Message + "Es probable que el nombre no exista en la base de datos.");
            }
        }

        public void ImprimirPorCat(DataGridView dgvGrilla, string cat)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;


                comando.CommandText = "SELECT Usuarios.Nombre, Usuarios.Apellido, Usuarios.Telefono, Usuarios.Correo, Categorias.Categoria " +
 "FROM Categorias INNER JOIN Usuarios ON Categorias.Id = Usuarios.Categoria WHERE Categorias.Categoria = @cat";
                comando.Parameters.AddWithValue("@cat", cat);

                DataTable tablaUsuarios = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaUsuarios);

                dgvGrilla.DataSource = tablaUsuarios;

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cuidado! " + ex.Message + " Es probable que la categoría no exista en la base de datos.");
            }
        }

        public void EliminarUsuario (string nom, string ape)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;


                comando.CommandText = "DELETE FROM Usuarios WHERE Nombre = @nom AND Apellido = @ape";
                comando.Parameters.AddWithValue("@nom", nom);
                comando.Parameters.AddWithValue("@ape", ape);


                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cuidado! " + ex.Message + " Es posible que el nombre o apellido no exista en la base de datos.");
            }
        }


        public void AgregarCategoria(string categ)
        {
            try
            {
                using (var conexion = new OleDbConnection(cadena))
                {
                    using (var comando = new OleDbCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "INSERT INTO Categorias(Categoria) VALUES(@categoria)";
                        comando.Parameters.AddWithValue("@categoria", categ);

                        conexion.Open(); 
                        comando.ExecuteNonQuery(); 

                        MessageBox.Show("Se ha agregado la categoría correctamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public List<string> ImprimirCateg(ComboBox Combo)
        {
            List<string> categorias = new List<string>();
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT Categoria FROM Categorias";

                DataTable tablaJugadores = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaJugadores);

                foreach (DataRow fila in tablaJugadores.Rows)
                {
                    categorias.Add(fila["Categoria"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return categorias;
        }

        public int DevolverId(string cat)
        {
            int id_categoria = 0;
            try
            {

                using (var conexion = new OleDbConnection(cadena))
                {
                    using (var comando = new OleDbCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = $"SELECT Id FROM Categorias WHERE Categoria = @categoria";
                        comando.Parameters.AddWithValue("@categoria", cat);

                        conexion.Open();

                        var result = comando.ExecuteScalar();
                        if (result != null)
                        {
                            id_categoria = Convert.ToInt32(result);
                        }
                    }
                }
                return id_categoria;
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public bool verificarUsuario(string nom, string ape)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Nombre = @nom AND Apellido = @ape";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nom", nom);
                        comando.Parameters.AddWithValue("@ape", ape);
                        conexion.Open();

                        int contador = (int)comando.ExecuteScalar();
                        return contador > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar usuario: " + ex.Message);
                return false;
            }
        }

        public bool VerificarPorNom(string nom)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Nombre = @nom";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nom", nom);
                        conexion.Open();

                        int contador = (int)comando.ExecuteScalar();
                        return contador > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar usuario: " + ex.Message);
                return false;
            }
        }

        public bool verificarCateg(string cat)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    string query = "SELECT COUNT(*) FROM Categorias WHERE Categoria = @cat";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@cat", cat);
                        conexion.Open();

                        int contador = (int)comando.ExecuteScalar();
                        return contador > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar usuario: " + ex.Message);
                return false;
            }
        }

    }
}
