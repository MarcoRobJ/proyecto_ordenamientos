using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Collections;
using System.IO;



public class ManejoDeArchivos
{

    public static void escrituraArchivoNumeros(List<int> lista)
    {
        string nombreArchivo;
        Console.WriteLine("\nIngresa el nombre del archivo con el que quieres guardar los datos ordenados: ");
        nombreArchivo=Console.ReadLine();
        try
        {
            string direccionArchivo = "C:\\Users\\marj1\\Desktop\\Me\\Uni\\4 Semestre\\EDA 2\\Proyectos de Programacion\\Proyecto 1\\Programa\\Grupo_6_Proyecto_1_Equipo_3\\" + nombreArchivo + ".txt"; ;
            //Hago un nuevo escritor y le paso la dirección en donde se encuentra el archivo
            StreamWriter escribir = new StreamWriter(@direccionArchivo, true);
            //Escribo el mensaje
            for (int i = 0; i < lista.Count; i++)
            {
                escribir.WriteLine(lista[i]+",");
            }

            //Cierro el archivo
            escribir.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        finally
        {
            Console.WriteLine("\nEl archivó se guardó exitosamente en la carpeta de este proyecto\n");
        }
    }


    public static List<string> lecturaArchivoNumeros(string nombreArchivo)
    {
        string direccion = "C:\\Users\\marj1\\Desktop\\Me\\Uni\\4 Semestre\\EDA 2\\Proyectos de Programacion\\Proyecto 1\\Programa\\Grupo_6_Proyecto_1_Equipo_3\\" + nombreArchivo + ".txt";
        StreamReader reader = new StreamReader(File.OpenRead(@direccion));
        List<string> listStrings = new List<string>();
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line.Split(",");
            listStrings.Add(values[0]);
        }
        return listStrings;
    }


    public static List<string> lecturaArchivoNombres(string nombreArchivo)
    {
        string direccion = "C:\\Users\\marj1\\Desktop\\Me\\Uni\\4 Semestre\\EDA 2\\Proyectos de Programacion\\Proyecto 1\\Programa\\Grupo_6_Proyecto_1_Equipo_3\\" + nombreArchivo + ".txt";
        StreamReader reader = new StreamReader(File.OpenRead(@direccion));
        List<string> listaNombres = new List<string>();
        List<string> listaApellidos = new List<string>();
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line.Split(",");
            listaNombres.Add(values[0]);//El 0 es la columna de los nombres
            listaNombres.Add(values[1]);//El 1 es la columna de los apellidos
        }
        return listaNombres;
    }


    public static List<int> convierteAEntero(List<string> lista)
    {
        List<int> listaEnteros = lista.ConvertAll<int>(Convert.ToInt32);
        return listaEnteros;
    }


    public static void ImprimeListaStrings(List<string> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            Console.Write(lista[i] + " ");
            if (i % 2 != 0)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }

    public static void ImprimeListaEnteros(List<int> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            Console.Write(lista[i] + " ");
        }
        Console.WriteLine();
    }
}


