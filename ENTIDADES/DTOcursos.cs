using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class DTOcursos
    {
        public int Id { get; set; }
        public string Nivel { get; set; }
    }

    public class DTOestudiantes
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
    }

    public class DTOmatriculas
    {
        public int Id { get; set; }
        public int Idcurso { get; set; }
        public int Idestudiante { get; set; }
        public string Nota { get; set; }
    }

}
