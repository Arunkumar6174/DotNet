using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FamilyTree
    {

        static void Main()
        {
            FamilyTree tree = new FamilyTree();
            tree.PrintFamilydetails("ArunKumar");
            Console.WriteLine("------------------------------------------------");
            tree.PrintFamilydetails("Kiran");
            Console.ReadLine();
        }
        public void PrintFamilydetails(string name)
        {
            Child c =new Child();
            c.ChildName1 = name;
            Familydetails(c);

        }

        public void Familydetails(Child obj)
        {
            string result = $"Surename :{obj.Surname} \n GrandFater :{obj.GrandParentName1} ,GrandMother :{obj.GrandParentName2} \n"
                + $" Father :{obj.ParentName1} ,Mother :{obj.ParentName2} \n Child :{obj.ChildName1} \n"
                + $"Location :{obj.Location} , City :{obj.City}";
            Console.WriteLine(result);

        }
    }


    public class GrandParent
    {

        public string GrandParentName1 { get; set; } = "Laxmaiah";
        public string GrandParentName2 { get; set; } = "Narsamma";
        public string Location { get; set; } = "2-32,Jogipet,Meadak,TS";

        public string Surname { get; set; } = "Etikyala";
        public string City { get; set; } = "Jogipet";
    }
    public class Parent : GrandParent
    {
        public string ParentName1 { get; set; } = "Shekar";
        public string ParentName2 { get; set; } = "Sujatha";
    }
    public class Child : Parent
    {
        public string ChildName1 { get; set; }

    }
}