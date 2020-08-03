using profesionesApp.ProfecionesOcupaciones;
using profesionesApp.ProfesionesInterfaces;

namespace profesionesApp.ProfecionesImplementaciones.ArquitectoImplementacion
{
    public class ArquitectoCasas : Arquitectos, IArquitecto
    {
        public ArquitectoCasas() : base()
        {}
        public string Contruir()
        {
            return "Contruyo Casas";
        }

        public string HacerPlanos()
        {
            return "Hago planos de diseños de casas";
        }

        public string Presentarse()
        {
            return $"Hola me llamo {NombreCompleto} y uso {HerramientasTrabajo[0]}";
        }

        public string TipoArquitecto()
        {
            return "Soy un arquitecto que construye casas";
        }
    }
}