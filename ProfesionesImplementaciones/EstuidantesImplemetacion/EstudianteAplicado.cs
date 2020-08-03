using System.Collections.Generic;
using profesionesApp.ProfesionesInterfaces;

namespace profesionesApp.ProfesionesImplementaciones.EstuidantesImplemetacion
{
    public class EstudianteAplicado : IEstudiante
    {
        //Encapsulamientos
        private string nombre;
        private string apellido;
        private int edad;
        private List<string> utilesEscolares;
        //propiedades
        public int IdEstudiantes { get; set; }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string NombreCompleto { get; set; }
        public int Edad { get { return edad; } set { edad = value; } }
        public List<string> UtilesEscolares { get { return utilesEscolares; } set { utilesEscolares = value; } }

        //metodos
        public string Presentarse()
        {
            return $"Mi nombre es {NombreCompleto} y uso {UtilesEscolares[0]} ";
        }
        public string TipoEstudiante()
        {
            return "Soy un estudiante aplicado";
        }
        public string PresentarTareas()
        {
            return "Cada semana presento mis tareas puntualmente";
        }
        public string RendirExamenes()
        {
            return "En los examenes soy el Mejor";
        }
        public string HacerTareas()
        {
            return "Cada día hago mis tareas";
        }

        public string Estudiar()
        {
            return "Me gusta estudiart mucho para ser el mejor";
        }
    }
}