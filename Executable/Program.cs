using Lessons.Algorithms;
using Lessons.Delegates;
using Lessons.Models;
using Lessons.Tasks;

int[] num = rearrange(new int[]{-12, 11, -13, -5, 6, -7, 5, -3, -6});

foreach(int i in num)
{
    Console.WriteLine(i);
}

int[] rearrange(int[] numbers)
{
    int j = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] < 0)
        {
            int temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
            j++;
        }
    }

    return numbers;
}















//int[] arr1 = new int[] { 2, 5, 6, 8 };

//int[] arr2 = new int[] { 6, 8 };
//List<int> list = new List<int>();
//int j = 0;
//for(int i = 0; i < arr1.Length; i++)
//{
//   if(arr1[i] < arr2[j])
//    {
//        continue;
//    }
//    if (arr1[i] > arr2[j])
//    {
//        j++;
//    }
//   if(arr1[i] == arr2[j])
//    {
//        list.Add(arr1[i]);
//    }
//}

//foreach(int i in list)
//{
//    Console.WriteLine(i);
//}
//int[] arr = new int[] { -12, 11, -13, -5, 6, -7, 5, -3, -6 };
//List<int> list = new List<int>();
//for(int i = 0; i < arr.Length; i++)
//{
//    for(int j = i + 1; j < arr.Length; j++)
//    {
//        if(arr[i] < 0)
//        {
//            continue;
//        }
//        if(arr[i] > 0 && arr[j] < 0)
//        {
//            int temp = arr[i];
//            arr[i] = arr[j];
//            arr[j] = temp;
//            break;
//        }

//    }
//}

//foreach(int i in arr)
//{
//    if(i < 0)
//        list.Add(i);
//}
//foreach(int i in arr)
//{
//    if(i > 0)
//        list.Add(i);
//}

//foreach (int i in list)
//{
//    Console.WriteLine(i);
//}


















//int n = 2;

//Console.WriteLine(1 & 1);


//static string SpinWords(string sentence)
//{
//    return String.Join(' ', sentence.Split(' ').Select(x => x.Length >= 5 ? string.Concat(x.Reverse()) : x));
//}


////var t = new Entry { Key = 2, Value = "thr" };
////var t2 = new Entry { Key = 3, Value = "tht" };
////var t3 = new Entry { Key = 4, Value = "tyhee" };
////var t4 = new Entry { Key = 2, Value = "ggg" };


////Lessons.Tasks.LinkedList<Entry> list = new Lessons.Tasks.LinkedList<Entry>();

///*HashTable<string, int> hashTable = new HashTable<string, int>();
//hashTable.Add*/

////hashTable.Add("hey", 5);
////hashTable.Add("hi", 6);
////hashTable.Add("hey", 9);
////hashTable["hey"] = 1;
////hashTable["hi"] = 2;
//////var f = hashTable["hey"];
////hashTable.Remove("hey");
////Console.WriteLine($"{hashTable["hey"]} {hashTable["hi"]}");


////list.ReplaceOrAdd(t);
////list.ReplaceOrAdd(t2);
////list.ReplaceOrAdd(t3);

////var y = list.Find(x => x.Key == 3);
////Console.WriteLine($"key {y.Key} value {y.Value}");
////list.ReplaceOrAdd(t4);
////var current = list.first;

////while (current != null)
////{
////    Console.WriteLine($"key {current.Data.Key} value {current.Data.Value}");
////    current = current.Next;
////}



////public class Entry
////{
////    public int Key;
////    public string Value;

////    public override bool Equals(object obj)
////    {
////        Console.WriteLine("was called");
////        var r = obj as Entry;
////        return Key.Equals(r.Key);
////    }
////}

////List<Employee> emp = new List<Employee>();
////Predicate<Employee> predicate = x => x.Age == 5;
////emp.Add(new Employee
////{
////    Id = 1,
////    Name = "John Obi",
////    Age = 5
////});

////emp.Add(new Employee
////{
////    Id = 2,
////    Name = "Alex",
////    Age = 89
////});

////emp.Add(new Employee
////{
////    Id = 3,
////    Name = "Daniel Codes",
////    Age = 7
////});

////Console.WriteLine(emp.Find(predicate));

////bool check(Employee u)
////{
////    return true;
////}

////var t = emp.MyWhereVersion(check);

////foreach (Employee e in t)
////{
////    Console.WriteLine(e.Name);
////}

