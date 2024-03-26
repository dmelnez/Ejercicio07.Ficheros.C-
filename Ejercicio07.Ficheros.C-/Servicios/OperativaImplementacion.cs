using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07.Ficheros.C_.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        MenuInterfaz me = new MenuImplementacion();

        public void archivoAcciones(string rutaArchivo)
        {
            int seleccionModificacion = me.menuAcciones();

            bool cerrarAplicacions = false;

            do { 
            
                switch (seleccionModificacion)
                {
                    case 0:
                        // Seleccion de Acceder al Menu Principal
                        cerrarAplicacions = true;
                    break;

                    case 1:
                        // Seleccion de Modificacion en un Archivo
                        modificacionArchivos(rutaArchivo);
                    break;

                    case 2:
                        // Seleccion de Inserccion en la Posicion especifica en un Archivo
                        inserccionArchivo(rutaArchivo);
                    break;


                    default:
                        Console.WriteLine("[INFO] SELECCION NO VALIDA");
                    break;

    
                }

            }

            while (!cerrarAplicacions);


        }



        private void modificacionArchivos(string rutaArchivo)
        {
            // Division del Archivo. 
            // Cada una de las lineas contenientes del archivo, es almacenado en una posicion distinta del Array.
            // Las lineas en blanco, siguen siendo acumuladas en las posciones del array.
            string[] archivoDivido = File.ReadAllLines(rutaArchivo);

          
            for (int i = 0; i < archivoDivido.Length -1; i++)
            {
                Console.WriteLine(archivoDivido[i]);

            }

            Console.WriteLine("Linea Modificada: ");
            int numeroLinea = Convert.ToInt32(Console.WriteLine());

            Console.WriteLine("Texto a Sustituir");
            string contenidoSustido = Console.WriteLine();

            archivoDivido[numeroLinea] = contenidoSustido;

            File.WriteAllLines(rutaArchivo, archivoDivido);


        }



        private void inserccionArchivo(string rutaArchivo)
        {
            string[] archivoDivido = File.ReadAllLines(rutaArchivo);


            for (int i = 0; i < archivoDivido.Length - 1; i++)
            {
                Console.WriteLine(archivoDivido[i]);

            }

            Console.WriteLine("Linea Modificada: ");
            int numeroLinea = Convert.ToInt32(Console.WriteLine());

            Console.WriteLine("Posicion de la Linea: ");
            int posicionLinea = Convert.ToInt32(Console.WriteLine());

             Console.WriteLine("Texto a Sustituir");
            string contenidoInsertado = Console.WriteLine();

            string aux;

            

            archivoDivido[numeroLinea] = aux;

            aux.Insert(posicionLinea, contenidoInsertado);

            archivoDivido[numeroLinea] = aux;

            File.WriteAllLines(rutaArchivo, archivoDivido);

        }


    }


}
