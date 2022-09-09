using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Alumno Alumno { get; set; }
        public Notas Notaas { get; set; }

    }
}
