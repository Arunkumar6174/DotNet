using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AnimalCLass
    {
    }

    class AnimalKingdom : Tiger, Lion, hynea, fox, elephant
    {

        public List<AnimalsBehaviour> tiger_details(List<AnimalsBehaviour> lists)
        {

            lists.Add(new AnimalsBehaviour { drinking = "tigers can drink water ", eating = "tigers can eat Meet", running = "tigers can run Faster than Lion " });
            return lists;
        }
        public List<AnimalsBehaviour> lion_details(List<AnimalsBehaviour> lists)
        {
            lists.Add(new AnimalsBehaviour { drinking = "Lion can drink water & blood", eating = "Lion can eat Meet", running = "Lion can run Faster than Elephant" });
            return lists;
        }
        public List<AnimalsBehaviour> hynea_details(List<AnimalsBehaviour> lists)
        {
            lists.Add(new AnimalsBehaviour { drinking = "Hyna can drink water", eating = "Hyna can eat Meet", running = "Hyna can run Fastly" });
            return lists;

        }
        public List<AnimalsBehaviour> fox_details(List<AnimalsBehaviour> lists)
        {
            lists.Add(new AnimalsBehaviour { drinking = "Fox can drink water", eating = "Fox can eat Meet", running = "Fox can run Fastly" });
            return lists;
        }
        public List<AnimalsBehaviour> elephant_details(List<AnimalsBehaviour> lists)
        {
            lists.Add(new AnimalsBehaviour { drinking = "Elephant can drink water", eating = "Elephant can eat Grass", running = "Elephant can run Slowly" });
            return lists;
        }



        static void Main()
        {
            AnimalKingdom ak = new AnimalKingdom();

            List<AnimalsBehaviour> list = new List<AnimalsBehaviour>();

            ak.tiger_details(list);

            ak.fox_details(list);
            ak.lion_details(list);
            ak.hynea_details(list);
            ak.elephant_details(list);
            foreach (var animal in list)
            {
                Console.WriteLine(animal.drinking + " ," + animal.eating + "," + animal.running);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
    interface Tiger
    {
        List<AnimalsBehaviour> tiger_details(List<AnimalsBehaviour> obj);
    }
    interface Lion
    {
        List<AnimalsBehaviour> lion_details(List<AnimalsBehaviour> obj);
    }
    interface hynea
    {
        List<AnimalsBehaviour> hynea_details(List<AnimalsBehaviour> obj);
    }
    interface fox
    {
        List<AnimalsBehaviour> fox_details(List<AnimalsBehaviour> obj);
    }
    interface elephant
    {
        List<AnimalsBehaviour> elephant_details(List<AnimalsBehaviour> obj);
    }
    public class AnimalsBehaviour
    {
        public string eating { get; set; }
        public String running { get; set; }
        public string drinking { get; set; }
    }



}