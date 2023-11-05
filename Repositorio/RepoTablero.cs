using System.Data.SQLite;
using UtilizarTablero;

namespace RepoTableroU
{
    public class RepoTableroC : IDtableroRepositorio
    {
        private string cadenaConexion ="Data Source=DB/kanban.db;Cache=Shared";
        public Tablero CrearTablero(Tablero tablero) //modificacion preguntar
        {
            string query = $"INSERT INTO Tablero(id_usuario_propietario,nombre,descripcion) VALUES(@id_usuario, @nombre,@descripcion);";
            using (SQLiteConnection connection = new SQLiteConnection(cadenaConexion))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                command.Parameters.Add(new SQLiteParameter("id_usuario", tablero.Id_usuario_propietario));
                command.Parameters.Add(new SQLiteParameter("@nombre", tablero.Nombre));
                command.Parameters.Add(new SQLiteParameter("@descripcion", tablero.Descripcion));
                command.ExecuteNonQuery();
                connection.Close();
            }
            return tablero;
        }

        public void DeleteTablero(int idTablero)
        {
            throw new NotImplementedException();
        }

        public List<Tablero> ListarTableros()
        {
            throw new NotImplementedException();
        }

        public List<Tablero> ListarTablerosUsuario(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public void ModificarTablero(int id, Tablero tablero)
        {
            throw new NotImplementedException();
        }

        public Tablero ObtenerTableroID(int id)
        {
            throw new NotImplementedException();
        }
    }
}