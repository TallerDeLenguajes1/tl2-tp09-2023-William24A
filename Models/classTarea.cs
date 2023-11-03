namespace UtilizarTarea
{
    public enum EstadoTarea
    {
         Ideas, 
         ToDo, 
         Doing, 
         Review, 
         Done
    }
    public class Tarea
    {
        private int? id;
        private int IdUsuarioPropietario;
        private string? nombre;
        private string? descripcion;
        private string? color;
        private EstadoTarea estado;
        private int? IdUsuarioAsignado;

        public int? Id { get => id; set => id = value; }
        public int IdUsuarioPropietario1 { get => IdUsuarioPropietario; set => IdUsuarioPropietario = value; }
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Descripcion { get => descripcion; set => descripcion = value; }
        public string? Color { get => color; set => color = value; }
        public EstadoTarea Estado { get => estado; set => estado = value; }
        public int? IdUsuarioAsignado1 { get => IdUsuarioAsignado; set => IdUsuarioAsignado = value; }
    }
    
}