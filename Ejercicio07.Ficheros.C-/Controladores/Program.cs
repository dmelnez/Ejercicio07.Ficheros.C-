using Ejercicio07.Ficheros.C_.Servicios;

namespace Ejercicio07.Ficheros.C_.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {

            MenuInterfaz me = new MenuImplementacion();

            OperativaInterfaz op = new OperativaImplementacion();

            bool cerrarAplicacion = false;

            string rutaArchivo;

            do
            {
                int seleccionFicheros = me.menuArchivos();

                switch (seleccionFicheros)
                {

                    case 0:
                        Console.WriteLine("SE CERRARA LA APLICACION");
                        cerrarAplicacion = true;
                        break;

                    case 1:
                        rutaArchivo = "C:\\Users\\david\\Desktop\\Empleado.txt";
                        op.archivoAcciones(rutaArchivo);

                        break;

                    case 2:
                        rutaArchivo = "C:\\Users\\david\\Desktop\\Gerencia.txt";
                        op.archivoAcciones(rutaArchivo);
                        break;

                    case 3:
                        rutaArchivo = "C:\\Users\\david\\Desktop\\Apuntes.txt";
                        op.archivoAcciones(rutaArchivo);
                        break;

                    default:
                        Console.WriteLine("SELECCION NO VALIDA");
                        break;



                }


            }

            while(!cerrarAplicacion);


        }
    }

}