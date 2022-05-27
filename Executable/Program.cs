using Lessons.Algorithms;
using Lessons.Delegates;
using Lessons.Models;
using Lessons.Tasks;

//var t = new Entry { Key = 2, Value = "thr" };
//var t2 = new Entry { Key = 3, Value = "tht" };
//var t3 = new Entry { Key = 4, Value = "tyhee" };
//var t4 = new Entry { Key = 2, Value = "ggg" };


//Lessons.Tasks.LinkedList<Entry> list = new Lessons.Tasks.LinkedList<Entry>();

HashTable<string, int> hashTable = new HashTable<string, int>();


hashTable.Add("hey", 5);
hashTable.Add("hi", 6);
hashTable.Add("hey", 9);
hashTable["hey"] = 1;
hashTable["hi"] = 2;
//var f = hashTable["hey"];
hashTable.Remove("hey");
Console.WriteLine($"{hashTable["hey"]} {hashTable["hi"]}");


//list.ReplaceOrAdd(t);
//list.ReplaceOrAdd(t2);
//list.ReplaceOrAdd(t3);

//var y = list.Find(x => x.Key == 3);
//Console.WriteLine($"key {y.Key} value {y.Value}");
//list.ReplaceOrAdd(t4);
//var current = list.first;

//while (current != null)
//{
//    Console.WriteLine($"key {current.Data.Key} value {current.Data.Value}");
//    current = current.Next;
//}



//public class Entry
//{
//    public int Key;
//    public string Value;

//    public override bool Equals(object obj)
//    {
//        Console.WriteLine("was called");
//        var r = obj as Entry;
//        return Key.Equals(r.Key);
//    }
//}

//List<Employee> emp = new List<Employee>();
//Predicate<Employee> predicate = x => x.Age == 5;
//emp.Add(new Employee
//{
//    Id = 1,
//    Name = "John Obi",
//    Age = 5
//});

//emp.Add(new Employee
//{
//    Id = 2,
//    Name = "Alex",
//    Age = 89
//});

//emp.Add(new Employee
//{
//    Id = 3,
//    Name = "Daniel Codes",
//    Age = 7
//});

//Console.WriteLine(emp.Find(predicate));

//bool check(Employee u)
//{
//    return true;
//}

//var t = emp.MyWhereVersion(check);

//foreach (Employee e in t)
//{
//    Console.WriteLine(e.Name);
//}

