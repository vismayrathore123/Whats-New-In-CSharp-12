
internal class Program
{
    public static void Main(string [] args)
    {
        int[] arr1 = { 1, 2, 3, 4, 5 };
        //for now we are using array like this in older version
        //but in c#12 we can declare array as a 
        int[] arr2 = [1,2,3,4,5];

        List<int> list = new List<int>() { 1,2,3,4,5};
        //for now we are using list like this in older version
      //but in c#12 we can declare list as a 
    
      List<int> list1 =  [1, 2, 3, 4, 5];
        List<int> list2 = [.. list1,6,7,8];
        foreach (var item in list)
        {
            Console.WriteLine(item);
            Console.ReadLine();
        }
        foreach (var item in list2)
        {
            Console.WriteLine();
            Console.ReadLine() ;
        }
    }
}
