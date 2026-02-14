// class Student
// {
//     public string name{get;set;}
//     public int age{get;set;}
//     public int marks{get;set;}
// }
// class Program
// {
//     public List<Student> CustomSort(List<Student> obj)
//     {
//         var res=from it in obj
//         orderby it.marks descending, it.age ascending
//         select it;
//         return res.ToList();
//     }
//     public static void Main(string[] args)
//     {
//         Program p=new Program();
//         List<Student> li=new List<Student>();
//         li.Add(new Student { name = "Abhi",  age = 21, marks = 95 });
//         li.Add(new Student { name = "Ravi",  age = 20, marks = 88 });
//         li.Add(new Student { name = "Neha",  age = 19, marks = 95 });
//         li.Add(new Student { name = "Aman",  age = 22, marks = 76 });
//         li.Add(new Student { name = "Pooja", age = 21, marks = 88 });
//         li.Add(new Student { name = "Karan", age = 20, marks = 95 });
//         var res=p.CustomSort(li);
//         foreach(var it in res)
//         {
//             Console.WriteLine(it.name+" "+it.marks+" "+it.age);
//         }
//     }
// }