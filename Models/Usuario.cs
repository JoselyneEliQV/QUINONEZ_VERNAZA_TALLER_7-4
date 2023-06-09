using Microsoft.EntityFrameworkCore.SqlServer.Migrations.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QUIÑONEZ_VERNAZA_TALLER_7_4.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string NombreUsuario { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string clave { get; set; }
        [Required]
        public Boolean estado { get; set; }

        public int GeneroId { get; set; }
        public Genero Genero { get; set; }
        public List<HistorialAcceso> ListhistorialAccesos { get; set; }
    }    
}
        
    
