using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace demomvc.Models
{
    [Table("t_alumno")]
    public class Alumno
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id { get; set; }
        [Column("dni")]
        public int dni { get; set; }
        [Column("apellidos")]
        public string apellidos { get; set; }
        [Column("nombres")]
        public string nombres{get; set;}
        [Column("carrera")]
        public string carrera {get; set; }     
        public DateTime fechanac { get; set; }
        [Column("genero")]
        public string genero { get; set; }

    }
}