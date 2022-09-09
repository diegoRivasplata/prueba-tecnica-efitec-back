using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using System.Data;
using System.Data.SqlTypes;
using Repository.Interfaces;
using Model.Entities;
using System.Data.SqlClient;

namespace Repository
{
    public class AlumnoRepository : IAlumnoRepository
    {
        private readonly ConexionSQL _conexionSQL;
        public AlumnoRepository(IOptions<ConexionSQL> conexionSQL)
        {
            _conexionSQL = conexionSQL.Value;
        }
        public List<Alumno> findAll()
        {
            List<Alumno> alumnos = new List<Alumno>();
            using(var conexion = new SqlConnection(_conexionSQL.CadenaSQL))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("FindAllAlumnos", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using(var dr  = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        alumnos.Add(new Alumno()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Nombre = dr["nombre"].ToString(),
                            Sexo = Convert.ToBoolean(dr["sexo"]),
                            Telefono = dr["telefono"].ToString()
                        });
                    }
                }
            }
            return alumnos;
        }
    }
}
