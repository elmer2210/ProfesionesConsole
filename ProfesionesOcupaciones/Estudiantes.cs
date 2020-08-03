using System.Collections.Generic;

namespace profesionesApp.ProfecionesOcupaciones
{
    public class Estudiantes
    {
        //Encapsulamientos
        private string nombre; 
        private string apellido;
        public string NombreCompleto { get; set; }
        private int edad; 
        private List<string> utilesEscolares;
        //propiedades
        public int IdEstudiantes { get; set; }
        public string Nombre { get{return nombre;} set{nombre = value;} }
        public string Apellido { get{return apellido;} set{apellido=value;} }
        public int Edad { get{return edad;} set{edad=value;} }
        public List<string> UtilesEscolares {get{return utilesEscolares;} set{utilesEscolares = value;} }
        //metodos
        public Estudiantes()
        {
            NombreCompleto = $"{Nombre} {Apellido}";
        }
    }
}