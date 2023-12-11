int[] array = {14,222,33,4,55,67,74,55,85};

//int n = array.Length;   //Количество элементов массива

int find = 222;

int index = 0;

while (index < array.Length)
{
    if(array[index] == find)
    {
      Console.WriteLine(index);
      break;
    }
    index = index + 1;

}


