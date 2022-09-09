using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Alumno
    {
        [Key]
        public int Id { get; set; }
        public String Nombre { get; set; }
        public Boolean? Sexo { get; set; }
        public String? Telefono { get; set; }
    }
}
