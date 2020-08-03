using System.Collections.Generic;

namespace profesionesApp.ProfecionesOcupaciones
{
    public class Arquitectos
    {
        //Encapsulamientos
        private string nombre; 
        private string apellido;
        public string NombreCompleto { get; set; }
        private int edad; 
        private List<string> herramientasTrabajo;
        //propiedades
        public int IdArquitecto { get; set; }
        public string Nombre { get{return nombre;} set{nombre = value;} }
        public string Apellido { get{return apellido;} set{apellido=value;} }
        public int Edad { get{return edad;} set{edad=value;} }
        public List<string> HerramientasTrabajo {get{return herramientasTrabajo;} set{herramientasTrabajo = value;} }
        //metodos
        public Arquitectos()
        {
            NombreCompleto = $"{Nombre} {Apellido}";
        }        
    }
}