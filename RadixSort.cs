public class RadixSort
{
    //Función que obtiene el elemento más grande
    public static int getBiggest(List<int> array, int size)
    {
        int biggest = array[0];
        for (int i = 1; i < size; i++)
            if (array[i] > biggest)
                biggest = array[i];
        return biggest;
    }
    public static List<int> radixSort(List<int> array, int size)
    {
        int[,] lista = new int[size,size];
        int[] cola = new int[size];
        int i, j, k, r, numColas = 0, divisor = 1, biggest, iter;
        biggest = getBiggest(array, size);


        //Obtengo el número de colas que voy a necesitar
        while (biggest > 0)
        {
            numColas++;
            biggest /= 10;
        }


        //Esto se lo voy a hacer a cada cola
        for (iter = 0; iter < numColas; iter++)
        {
            //Inicializo los valores de la cola en 0
            for (i = 0; i < size; i++)
            {
                cola[i] = 0;
            }

            //Divido los elementos de la lista por sus unidades (miles, centenas, decenas, unidades)
            for (i = 0; i < size; i++)
            {
                r = (array[i] / divisor) % 10;
                lista[r,cola[r]] = array[i];
                cola[r] += 1;
            }
            i = 0;

            //Pongo la cola hecha en la lista
            for (k = 0; k < 10; k++)
            {
                for (j = 0; j < cola[k]; j++)
                {
                    array[i] = lista[k,j];
                    i++;
                }
            }
            divisor *= 10;
            Console.WriteLine("\nIteración "+ (iter+1));
            printArray(array, size);
        }
        return array;
    }


    public static void printArray(List<int> array, int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write(array[i]+" ");
        }
        Console.WriteLine("\n");
    }
}