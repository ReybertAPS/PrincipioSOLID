using System;

namespace PrincipioSOLID
{
    class ProgramCelular
    {
        //Creamos una clase anstracta superior llamada padre
        public abstract class Celular
        {
            public abstract int precioMedio();
            public abstract int tamanoMemoriaRAM();
        }

        //Creamos las subclases y le heredamos la clase abstracta superior
        public class Huawei : Celular
        {
            public override int precioMedio()
            {
                return 120000;
            }

            public override int tamanoMemoriaRAM()
            {
                return 4;
            }
        }

        public class Samsung : Celular
        {
            public override int precioMedio()
            {
                return 1700000;
            }

            public override int tamanoMemoriaRAM()
            {
                return 8;
            }
        }

        public class Xiaomi : Celular
        {
            public override int precioMedio()
            {
                return 980000;
            }

            public override int tamanoMemoriaRAM()
            {
                return 6;
            }
        }

        public static void Main(string[] args)
        {
            //Creamos un array de los objetos (subclases) que deseamos imprimir sus propiedades en consola
            Celular[] arrayCelulares =
            {
                new Huawei(),
                new Samsung(),
                new Xiaomi()
            };
            //Imprimimos el precio promedio llamando al método 'imprimirPrecioMedio' que recibe un array del tipo Celular como parámetro
            Console.WriteLine("Precio medio: ");
            imprimirPrecioMedio(arrayCelulares);

            //Imprimimos el tamaño de la memoria RAM llamando al método 'imprimirTamanoMemoriaRAM' que recibe un array del tipo Celular como parámetro
            Console.WriteLine("Tamaño de memoria RAM: ");
            imprimirTamanoMemoriaRAM(arrayCelulares);

            Console.ReadLine();
        }

        //En este método se recibe un array del tipo Celular y segudiamente se itera con un foreach imprimiendo cada uno de los nombres y precios de las subclases
        public static void imprimirPrecioMedio(Celular[] arrayCelulares)
        {
            foreach (Celular celular in arrayCelulares)
            {
                Console.WriteLine(celular.GetType().Name.ToString());
                Console.WriteLine(celular.precioMedio());
            }
        }

        //En este método se recibe un array del tipo Celular y segudiamente se itera con un foreach imprimiendo cada uno de los nombres y tamaño de memoria RAM de las subclases
        public static void imprimirTamanoMemoriaRAM(Celular[] arrayCelulares)
        {
            foreach (Celular celular in arrayCelulares)
            {
                Console.WriteLine(celular.GetType().Name.ToString());
                Console.WriteLine(celular.tamanoMemoriaRAM());
            }
        }
        //Nota: de esta forma no dependemos de modificar el código cada que se deba implementar una nueva subclase, ya que todo se implementa dentro de la clase superior
    }
}
