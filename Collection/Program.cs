using Collections;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new Collection<int>();
            Console.WriteLine(collection.Count);
            Console.WriteLine(collection.Capacity);
            collection.Add(5);
            Console.WriteLine(collection);
            Console.WriteLine(collection.Count);
            Console.WriteLine(collection.Capacity);
            collection.Add(10);
            Console.WriteLine(collection);
            Console.WriteLine(collection.Count);
            Console.WriteLine(collection.Capacity);
        }
    }
}