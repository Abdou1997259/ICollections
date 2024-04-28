// See https://aka.ms/new-console-template for more information

using ICollections;

List<Car> carList = new List<Car>()
            {
                new Car { Id = 1, Model = "Toyota Camry", Price = 25000 },
                new Car { Id = 2, Model = "Honda Civic", Price = 22000 },
                new Car { Id = 3, Model = "Ford Mustang", Price = 35000 },
                // Add more cars here...
                new Car { Id = 28, Model = "Tesla Model S", Price = 80000 },
                new Car { Id = 29, Model = "Chevrolet Silverado", Price = 40000 },
                new Car { Id = 30, Model = "Jeep Wrangler", Price = 35000 }
            };

HashSet<Car> Cars = new HashSet<Car>(carList);

List<Car> anotherCarList = new List<Car>()
            {
                new Car { Id = 4, Model = "Nissan Altima", Price = 27000 },
                new Car { Id = 5, Model = "Chevrolet Cruze", Price = 20000 },
                new Car { Id = 6, Model = "BMW 3 Series", Price = 40000 }
                // Add more cars here...
            };



HashSet<Car> Cars2 = new HashSet<Car>(anotherCarList);
Cars2.UnionWith(Cars);
foreach (var item in Cars2)
{
    Console.WriteLine(item);
}
SortedSet<Car> orderedset = new SortedSet<Car>(Cars2);
Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||");
foreach (var item in orderedset)
{
    Console.WriteLine(item);
}
LinkedList<Car> LinkedCars = new LinkedList<Car>(orderedset);
LinkedListNode<Car> node = new LinkedListNode<Car>(new Car { Id = 500, Model = "Lamborgeny", Price = 400000 });
LinkedCars.AddAfter(LinkedCars.First.Next, node);
Console.WriteLine("Linked List");
foreach (var item in LinkedCars)
{
    Console.WriteLine(item);
}
Console.WriteLine("Hello, World!");
Console.ReadKey(); 