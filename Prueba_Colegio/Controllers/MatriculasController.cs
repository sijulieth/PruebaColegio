using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ENTIDADES;
using DAL;
using System.Web.Http;

namespace Prueba_Colegio.Controllers
{
    [RoutePrefix("api/matriculas")]
    public class MatriculasController: ApiController
    {
        //GET api/matriculas
        
        [AcceptVerbs("rmatri")]
        public string rmatri([FromBody]DTOmatriculas dto)
        {
            repo p = new repo();
            return p.r_matricula(dto);
        }

        [AcceptVerbs("ematri")]
        public string ematri ([FromBody] DTOmatriculas dto)
        {
            repo p=new repo();
            return p.e_matricula(dto);
        }
        
        [AcceptVerbs("mmatri")]
        public string mmatri ([FromBody] DTOmatriculas dto)
        {
            repo p=new repo()
            return p.m_matricula(dto);
        }
    }
}