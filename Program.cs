// See https://aka.ms/new-console-template for more information



int[] numbers = { 5, 2, 3, 7, 9, 1, 10 };


// LINQ

var nm = from n in numbers orderby n descending select n;

foreach (int n in nm)
{
    Console.WriteLine(n);
}

Console.WriteLine("------------------------");

student[] studs = new student[]
{
    new student(){roll=1,name="rajesh",city="pune"},
    new student(){roll=2,name="pankaj",city="nashik"},

    new student(){roll=4,name="manoj",city="pune"},
    new student(){roll=5,name="darshan",city="solapur"},
    new student(){roll=3,name="dinesh",city="nagar"},
     new student(){roll=5,name="mahesh",city="solapur"},
      new student(){roll=7,name="anand",city="solapur"},
};

////var std = from s in studs where s.city == "pune" select s;
//var std = studs.Where(s => s.roll % 2 == 0);

//Console.WriteLine("students from pune");

//foreach (var item in std)
//{
//    Console.WriteLine(item.roll+" "+item.name+" "+item.city);
//}

Console.WriteLine("student from solapur whos roll =5");
var s = studs.Where(x => x.roll == 5 && x.city == "solapur").Last();
if (s!=null)
{
    Console.WriteLine(s.roll + " " + s.name + " " + s.city);
}
else
{
    Console.WriteLine("student not found!!!!!");
}




class student
{
    public int roll { get; set; }
    public string  name { get; set; }
    public string  city { get; set; }
}