using System.Reflection.Metadata;
using Entidades;

namespace PP_Escaner_RodriguezThomas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Libro lib = new Libro("2345", "Jeracho", 1990, "10010", "0", 100);
                Libro lib2 = new Libro("Pepe la rana", "Peep", 1990, "10000", "1", 100);

                Mapa map = new Mapa("Argentina", "Juan", 1800,  "00010", 50, 50);
                Mapa map2 = new Mapa("Argentina", "Pepe", 1800, "00010", 50, 50);

                Escaner escL = new Escaner("Espons", Escaner.TipoDoc.libro);
                Escaner escM = new Escaner("Lapos", Escaner.TipoDoc.mapa);

                bool pepe = escL + lib;

                bool w = escL + lib2;

                bool e = escL + map;



                throw new Exception("Error! Excepcion");

                //bool wert = escL + map;

                //if (escL == lib)
                //{
                //    Console.WriteLine("Se encuentra");
                //}

                //escL.CambiarEstadoDocumento(lib);

                //Console.WriteLine(lib.Estado);

                ////Console.WriteLine(map == map2);

                //Console.WriteLine(lib.ToString());

                //Console.WriteLine(map.ToString());
                int extension;
                int cantidad;
                string resumen;

                Informes.MostrarDistribuidos(escL, out extension, out cantidad, out resumen);

                Console.WriteLine($"Paginas: {extension}");
                Console.WriteLine($"N de libros: {cantidad}");
                Console.WriteLine($"Info:\n {resumen}");
            }
            catch (CastException e)
            {
                Console.WriteLine(e + "CastExcepcion."); 
            }
        
            catch(Exception e)
            {
                Console.WriteLine("Main Exception: " + e);
            }


        }
    }
}
