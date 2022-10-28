using System;
namespace SA54PAPER
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            Console.WriteLine("Please type target person's id: ");
            string? targetId = Console.ReadLine();
            string[]? targetRecord = SectionA.GetRecord(targetId);
            if (targetRecord == null)
            {
                Console.WriteLine("You have provided an invalid id.");
                return;
            }
            DateTime targetEntryTime = SectionA.GetTimeFromTimeStampString(targetRecord[2]);
            DateTime targetExitTime = SectionA.GetTimeFromTimeStampString(targetRecord[3]);
            string targetLocation = targetRecord[4];
            SectionA.PrintLinkedIds(targetId, targetEntryTime, targetExitTime, targetLocation);
            Console.WriteLine("\nType any key to exit.");
            
            Person p1 = new Person("elise@example.com", "Elise", 1998);
            Person p2 = new Person("kyle@example.com", "Kyle", 2003);
            Person p3 = new Person("Keaton@example.com", "Keaton");
            Employee e1 = new Employee("corma@example.com", "Cormac", 2002, 3000);
            Faculty f1 = new Faculty("amalia@example.com", "Amalia", 2001, 4000, false);
            Student s1 = new Student("dennis@example.com", "Dennis", 1999, "Computing");
            p1.Dispaly();
            Console.WriteLine();
            PersonRecords personRecords = new PersonRecords();
            personRecords.Add(p1);
            personRecords.Add(p2);
            personRecords.Add(p3);
            personRecords.Add(e1);
            personRecords.Add(f1);
            personRecords.Add(s1);
            personRecords.Display();
            */
            bool continueLoop = true;
            do
            {
                try
                {
                    Console.WriteLine("Please input an integer number: ");
                    int n = Int32.Parse(Console.ReadLine());
                    Console.WriteLine($"Your number is {n}");
                    continueLoop = false;
                }
                catch(FormatException f)
                {
                    Console.WriteLine(f.Message);
                    Console.WriteLine("Ouch! FormatException.");
                }
                catch (OverflowException o)
                {
                    Console.WriteLine(o.Message);
                    Console.WriteLine("Ouch! OverflowException.");
                }
            } while (continueLoop);
         
            
          Console.ReadKey();
        }
    }
}
