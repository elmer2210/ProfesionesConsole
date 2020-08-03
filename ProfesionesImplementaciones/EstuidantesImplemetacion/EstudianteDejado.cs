using profesionesApp.ProfecionesOcupaciones;
using profesionesApp.ProfesionesInterfaces;

namespace profesionesApp.ProfecionesImplementaciones.EstuidantesImplemetacion
{
    public class EstudianteDejado : Estudiantes, IEstudiante
    {
        public EstudianteDejado() : base()
        { }

        public string Estudiar()
        {
            return "No me gusta estudiar mucho";
        }

        public string HacerTareas()
        {
            return "Las tareas no son mi prioridad";
        }

        public string Presentarse()
        {
            return $"ME llamo {NombreCompleto} y utilizo {UtilesEscolares[1]} ";
        }

        public string PresentarTareas()
        {
            return "No presento mis tareas porqu no las hago";
        }

        public string RendirExamenes()
        {
            return "En los examenes no me va muy bien porque no estudio";
        }

        public string TipoEstudiante()
        {
            return "Soy un estudiante Bago";
        }
    }
}