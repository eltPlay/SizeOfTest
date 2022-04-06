namespace SizeOfTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int类型的存储空间大小：{0}", sizeof(int));
            Console.WriteLine("long类型的存储空间大小：{0}", sizeof(long));
            Console.WriteLine("float类型的存储空间大小：{0}", sizeof(float));
            Console.WriteLine("double类型的存储空间大小：{0}", sizeof(double));
            Console.WriteLine("decimal类型的存储空间大小：{0}", sizeof(decimal));
            Console.ReadKey();
        }
    }
}