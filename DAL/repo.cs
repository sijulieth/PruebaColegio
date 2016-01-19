using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace DAL
{
   public class repo
    {
       colegiobdEntities bd = new colegiobdEntities();
       public string r_matricula(DTOmatriculas dto)
       {
           try
           {

               colegiobdEntities bds = new colegiobdEntities();
               tblmatriculas b = new tblmatriculas();
               b.Idcurso = dto.Idcurso;
               b.Idest = dto.Idestudiante;
               b.Nota = dto.Nota;
               bds.tblmatriculas.Add(b);
               bds.SaveChanges();
               return "La matricula ha sido agregada";
           }
           catch (Exception bb)
           {

               return bb.Message.ToString();
           }
           }


           public string e_matricula(DTOmatriculas dto)
           {
                
               try 
	            {	        
		            colegiobdEntities bds = new colegiobdEntities();
                    tblmatriculas b = bds.tblmatriculas.Where(t => t.Idcurso == dto.Idcurso && t.Idest == dto.Idestudiante).FirstOrDefault();
                    
                    if (b != null)
                    {
                        bds.tblmatriculas.Remove(b);
                        return "matricula eliminada";
                    }
                    else
                    {
                        return "Esta matricula no existe";
                    }

	            }
	            catch (Exception ex)
	            {
		
		            return ex.Message.ToString();
	            }
           
           }


           public string m_matricula(DTOmatriculas dto)
           {
               {
                
               try 
	            {	        
		            colegiobdEntities bds = new colegiobdEntities();
                    tblmatriculas b = bds.tblmatriculas.Where(t => t.Idcurso == dto.Idcurso && t.Idest == dto.Idestudiante).FirstOrDefault();
                    
                    if (b != null)
                    {
                        b.Idest=dto.Idestudiante;
                        b.Idcurso=dto.Idcurso;
                        b.Nota=dto.Nota;
                        bds.SaveChanges();
                        return "matricula actualizada";
                    }
                    else
                    {
                        return "Esta matricula no existe";
                    }

	            }
	            catch (Exception ex)
	            {
		
		            return ex.Message.ToString();
	            }
           }
 
           

       

    }

}
