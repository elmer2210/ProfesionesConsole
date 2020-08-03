using profesionesApp.ProfesionesImplementaciones.ArquitectoImplementacion;
using profesionesApp.ProfecionesImplementaciones.ArquitectoImplementacion;
using profesionesApp.ProfesionesInterfaces;

namespace profesionesApp.ProfesionesInstituciones
{
    public class Constructora
    {
        public IArquitecto Arquitecto{get; set; }
        public ArquitectoCalles arquitectoCalles {get; set; }
        public ArquitectoCasas arquitectoCasas {get; set; }

        //métodos
        public string ContruirEdificio ()
        {
            return Arquitecto.Contruir()+"Edificio";
        }
        public string ContratarArquitecto (IArquitecto arquitecto)
        {
            Arquitecto = arquitecto;
            return "Contraté a un Arquitecto";
        }
        public string ConstruirVialVehiculares()
        {
            arquitectoCalles = new ArquitectoCalles();
            return "Contraté un Arquitecto especializado en hacer calles";
        } 
        public string ConstruirCasas ()
        {
            arquitectoCasas = new ArquitectoCasas();
            return "Contraté un Arquitecti especializado en hacer casas";
        } 
    }
}