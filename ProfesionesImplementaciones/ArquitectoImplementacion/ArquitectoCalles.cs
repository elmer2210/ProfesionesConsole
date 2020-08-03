using profesionesApp.ProfecionesOcupaciones;
using profesionesApp.ProfesionesInterfaces;

namespace profesionesApp.ProfesionesImplementaciones.ArquitectoImplementacion
{
    public class ArquitectoCalles : Arquitectos, IArquitecto
    {
        public ArquitectoCalles() : base()
        { }
        public string Contruir()
        {
            return "Soy arquitecto y construyo Calles";
        }

        public string HacerPlanos()
        {
            return "Mis planos estan enfocados a vias vehiculres";
        }

        public string Presentarse()
        {
            return $"Hola mi nombre es {NombreCompleto} y utilizo {HerramientasTrabajo} ";
        }

        public string TipoArquitecto()
        {
            return "Me decico a contruir carreteras";
        }
    }
}