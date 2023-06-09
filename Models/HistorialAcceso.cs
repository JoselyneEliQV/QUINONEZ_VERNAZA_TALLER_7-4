namespace QUIÑONEZ_VERNAZA_TALLER_7_4.Models
{
    public class HistorialAcceso
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set;}
    }
}
