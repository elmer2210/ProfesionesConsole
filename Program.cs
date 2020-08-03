using System;
using profesionesApp.ProfecionesImplementaciones.ArquitectoImplementacion;
using profesionesApp.ProfecionesImplementaciones.EstuidantesImplemetacion;
using profesionesApp.ProfesionesInstituciones;

namespace profesionesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Constructora
            Constructora MiConstructora = new Constructora();
            MiConstructora.ContratarArquitecto(new ArquitectoCasas());
            MiConstructora.ContruirEdificio();
            MiConstructora.ContratarArquitecto(new ArquitectoCalles());
            MiConstructora.ConstruirCasas();
            Console.ReadKey();

            //UnidadEducativa
            UnidadEducativa Institucion = new UnidadEducativa();
            Institucion.MatricularEstudiante(new EstudianteAplicado());
            Institucion.EstudiantesAplicados();
            Institucion.MatricularEstudiante(new EstudianteDejado());
            Institucion.EstudianteDejado();
            
        }
    }
}
