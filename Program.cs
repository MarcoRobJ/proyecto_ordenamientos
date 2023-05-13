using System;
using System.Text;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

public class Grupo6Proyecto1Equipo3
{


    static void Main()
    {
        int opcion, bandera = 1, opcion2, bandera2 = 1;
        string archivoNombres, archivoNumeros;

        List<int> listaEnteros;
        List<string> listaNombres, listaStrings;
        Console.WriteLine("Bienvenido al menú de ordenamientos externos del equipo 3 :)");
        do
        {
            Console.WriteLine("Selecciona el tipo de archivo en el que quieres realizar los ordenamientos: ");
            Console.WriteLine("1) Archivo con claves de texto (nombres)");
            Console.WriteLine("2) Archivo con claves numéricas");
            Console.WriteLine("0) Salir");
            Console.Write("Opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    {

                        Console.WriteLine("Seleccionaste: Archivo con claves de texto");
                        Console.WriteLine("Ingresa el nombre del archivo: ");
                        archivoNombres = Convert.ToString(Console.ReadLine());
                        listaNombres = ManejoDeArchivos.lecturaArchivoNombres(archivoNombres);
                        Console.WriteLine("La lista de nombres de tu archivo es la siguiente: ");
                        ManejoDeArchivos.ImprimeListaStrings(listaNombres);


                        do
                        {
                            Console.WriteLine("Selecciona el método de ordenamiento deseado: ");
                            Console.WriteLine("1) Polifase (ordenamiento por nombre)");
                            Console.WriteLine("2) Mezcla equilibrada (ordenamiento por apellido)");
                            Console.WriteLine("0) Escoger otro archivo");
                            Console.Write("Opción: ");
                            opcion2 = Convert.ToInt32(Console.ReadLine());
                            switch (opcion2)
                            {
                                case 1:
                                    {

                                        Console.WriteLine("Seleccionaste: Polifase (ordenamiento por nombre)");


                                        break;
                                    }
                                case 2:
                                    {

                                        Console.WriteLine("Seleccionaste: Mezcla equilibrada (ordenamiento por apellido)");
                                        /*List<int> arregloOrdenado;
                                        var nombres= listaNombres;
                                        //ManejoDeArchivos.ImprimeListaStrings(nombres);

                                        nombres.Sort((a1, a2) => a1.Split(" ")[1].CompareTo(a2.Split(" ")[1]));
                                        Console.WriteLine(string.Join(",", nombres));
                                        */
                                        break;
                                    }

                                case 0: bandera2 = 0; break;

                                default: Console.WriteLine("Ingrese una opción válida"); break;
                            }
                        } while (bandera2 != 0);

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Seleccionaste: Archivo con claves numéricas");
                        Console.WriteLine("Ingresa el nombre del archivo: ");
                        archivoNumeros = Convert.ToString(Console.ReadLine());

                        listaStrings = ManejoDeArchivos.lecturaArchivoNumeros(archivoNumeros);

                        ManejoDeArchivos.convierteAEntero(listaStrings);
                        Console.WriteLine("La lista de enteros de tu archivo es la siguiente: ");
                        listaEnteros = ManejoDeArchivos.convierteAEntero(listaStrings);
                        ManejoDeArchivos.ImprimeListaEnteros(listaEnteros);



                        do
                        {
                            Console.WriteLine("Selecciona el método de ordenamiento deseado: ");
                            Console.WriteLine("1) Polifase");
                            Console.WriteLine("2) Mezcla equilibrada");
                            Console.WriteLine("3) Método por distribución (Radix)");
                            Console.WriteLine("0) Escoger otro archivo");
                            Console.Write("Opción: ");
                            opcion2 = Convert.ToInt32(Console.ReadLine());
                            switch (opcion2)
                            {
                                case 1:
                                    {

                                        Console.WriteLine("Seleccionaste: Polifase");


                                        break;
                                    }
                                case 2:
                                    {
                                        List<int> arregloOrdenado;
                                        Console.WriteLine("Seleccionaste: Mezcla equilibrada");
                                        //MezclaEquilibrada.mezclaEqEnteros(listaEnteros, listaEnteros.Count);
                                        //arregloOrdenado = RadixSort.radixSort(listaEnteros, listaEnteros.Count);
                                        MezclaEquilibrada.mezclaEqEnteros(listaEnteros, listaEnteros.Count);

                                        break;
                                    }
                                case 3:
                                    {
                                        List<int> arregloOrdenado;
                                        Console.WriteLine("Seleccionaste: Método por distribución (Radix)");
                                        arregloOrdenado = RadixSort.radixSort(listaEnteros, listaEnteros.Count);
                                        ManejoDeArchivos.escrituraArchivoNumeros(arregloOrdenado);
                                        break;
                                    }

                                case 0: bandera2 = 0; break;

                                default: Console.WriteLine("Ingrese una opción válida"); break;
                            }
                        } while (bandera2 != 0);

                        break;
                    }

                case 0: Console.WriteLine("Hasta luego :)"); bandera = 0; break;

                default: Console.WriteLine("Ingrese una opción válida"); break;
            }
        } while (bandera != 0);
    }
}



