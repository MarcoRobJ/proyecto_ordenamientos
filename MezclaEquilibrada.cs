public class MezclaEquilibrada{
    public static void prueba(){
        /* int[] list1 = new int[] { };
        int[] list2 = new int[] { };
        int[] sublist1=new int[] { 0};
        int[] sublist2=new int[] { 0};
        sublist1[0] = new int (1);
        sublist1[1] = 2;
        sublist1[2] = 3;
        sublist1[3] = 4;
        Console.WriteLine(sublist1.Length);
        sublist1[4] = 1;
        sublist1[5] = 2;
        sublist1[6] = 3;
        sublist1[7] = 4;
        Console.WriteLine(sublist1.Length);
        */

        
        Console.WriteLine("Esto funciona");
        List<List<int>> lista1 = new List<List<int>>();
        List<List<int>> lista2 = new List<List<int>>();
        List<int> listAux1 = new List<int>();
        List<int> listAux2 = new List<int>();
        int[] arr1;
        int[] arr2;
        {
            arr1=new int[4];
            for (int i = 0; i < 4; i++) { 
                arr1[i]=i*2;
            }
            Console.Write("Arreglo\n");
            Console.Write(String.Join(" ", arr1));
            listAux1 = arr1.ToList();
            Console.Write("\nLista\n");
            foreach (var z in listAux1)
            {
                Console.WriteLine(z);
            }
        }
        { 
            arr1 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                arr1[i]= i * 4 ;
            }
            Console.Write("Arreglo\n");
            Console.Write(String.Join(" ", arr1));
            listAux1 = arr1.ToList();
            Console.Write("\nLista\n");
            foreach (var z in listAux1)
            {
                Console.WriteLine(z);
            }

        }
        int[] vs = new int[4];
        Console.Write(String.Join(" ", vs));
        Console.WriteLine("\n___________");
        listAux1[0] = 1;
        listAux1[1] = 2;
        foreach (var z in listAux1)
        {
            Console.Write(" "+z);
        }
        Console.WriteLine();
        listAux1[0] = 3;
        listAux1[1] = 4;
        foreach (var z in listAux1)
        {
            Console.Write(" "+z);
        }
        Console.WriteLine();
    }
    
    public static void mezclaEqEnteros(List<int> array, int size)
    {
        //List<List<int>> lista1 = new List<List<int>>();
        //List<List<int>> lista2 = new List<List<int>>();

        List<int[]> lista1 = new List<int[]>();
        List<int[]> lista2 = new List<int[]>();
       
        int[] arr1=new int[size];
        int[] arr2=new int[size];
        
        //los codigos no pueden ser cero
        //int[] pos=new int[size];
        bool completo=false;
        //int a1, a2, a3=0, a4;
        //int aux1=1;
        for (int i = 0; i < size; i++) {
            arr1[i] = array[i];
            if (array[i] <= array[i + 1]) { 
                i++;
                if (i == size) {
                    completo = true;
                    break;
                }
                arr1[i] = array[i];
                lista1.Add(arr1);

            }
            if (completo == true) {
                break;
            }

            i++;
            if (i == size)
            {
                break;
            }
            arr2[i] = array[i];
            if (array[i] <= array[i + 1])
            {
                i++;
                if (i == size)
                {
                    break;
                }
                arr2[i] = array[i];
                lista2.Add(arr2);
            }


        }
        
        foreach (var z in lista1)
        {
            Console.Write(String.Join(" ", z));
        }
        Console.WriteLine();
        foreach (var z in lista2)
        {
            Console.Write(String.Join(" ", z));
        }
        Console.WriteLine();
        
        Console.WriteLine(array.Count());
        for (int i = 0; i < array.Count; i++) { 

        }
        for (int i = 0; i < array.Count; i++) {
            arr1[i] = (array[0]);

        }
        /*
        do
        {
            arr1=
        } while (array.Count != 0);
        int j=0, k;
        do { 
            for (int i = 0; i < size; i++) {
                lista1[j].Add(1);//array[i];
            }
           
            
        } while (true);
            return array;
        }*/
        
    }
/*
    public static void printArray(List<int> array, int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("\n");
    }*/

}

