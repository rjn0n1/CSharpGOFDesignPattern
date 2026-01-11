using DesignPatterns.Creational.Singleton;
Console.WriteLine("LazySingleton");

LazySingleton lazySingleton1 = LazySingleton.Instance;
LazySingleton lazySingleton2 = LazySingleton.Instance;

Console.WriteLine($"Instance 1 HashCode: {lazySingleton1.GetHashCode()}");
Console.WriteLine($"Instance 2 HashCode: {lazySingleton2.GetHashCode()}");

Console.WriteLine("LazySingleton");
ThreadSafeLogger t1 = ThreadSafeLogger.Instance;
ThreadSafeLogger t2 = ThreadSafeLogger.Instance;

Console.WriteLine($"Instance 1 HashCode: {t1.GetHashCode()}");
Console.WriteLine($"Instance 2 HashCode: {t2.GetHashCode()}");

// See https://aka.ms/new-console-template for more information


