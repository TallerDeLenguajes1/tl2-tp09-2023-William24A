using UtilizarTarea;

namespace RepoTareaU
{
    public class RepoTareaC : IDTareaRepositorio
    {
        private string cadenaConexion = "Data Soucer=DB/kanban.db;Cache=Shared";
        public void AsignarUsuTarea(int idUsuario, int idTarea)
        {
            throw new NotImplementedException();
        }

        public Tarea BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tarea> BuscarTareasTablero(int idTablero)
        {
            throw new NotImplementedException();
        }

        public List<Tarea> BuscarTodasTarea(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public Tarea CreaTarea(int idTablero, Tarea tarea) //Consultar si es que esta modificacion esta bien
        {
            var query = $"INSERT INTO Tarea(id_tablero,nombre, estado, descripcion,color) VALUES(@idTablero,@nombre_tarea, @estado );";
        }

        public void DeleteTarea(int idTarea)
        {
            throw new NotImplementedException();
        }

        public void Modificar(int id, Tarea tarea)
        {
            throw new NotImplementedException();
        }
    }
}