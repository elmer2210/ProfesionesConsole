using profesionesApp.ProfecionesImplementaciones.EstuidantesImplemetacion;
using profesionesApp.ProfesionesImplementaciones.EstuidantesImplemetacion;
using profesionesApp.ProfesionesInterfaces;

namespace profesionesApp.ProfesionesInstituciones
{
    public class UnidadEducativa
    {
        //Propiedades
        public IEstudiante estudiantes {get; set; }    
        public EstudianteAplicado estudianteAplicado {get; set; }
        public EstudianteDejado estudianteDejado {get; set; }

        //metodos 
        public string MatricularEstudiante (IEstudiante estudiante)
        {
            estudiante = estudiantes;
            return "Se matriculo un nuevo estudiantes";
        }
        public string EstudiantesAplicados()
        {
            estudianteAplicado = new EstudianteAplicado();
            return "Hay estudiantes aplicados";
        }
        public string EstudianteDejado()
        {
            estudianteDejado = new EstudianteDejado();
            return "Hay estudiantes dejados";

        }
    }
}