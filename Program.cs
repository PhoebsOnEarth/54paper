using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using _2dstringarray;

namespace twostringarray
{
   
    class Program
    {
        static void Main()
        {
            bool continueLoop = true;
            do
            {
                try
                {
                    int[] nums = new int[4];
                    Console.WriteLine("Please enter a positive integer");
                    int num = Int32.Parse(Console.ReadLine());
                    if (num < 0)
                        throw new MyException();
                    nums[0] = num;

                    Console.WriteLine("Enter number 1");
                    num = Int32.Parse(Console.ReadLine());
                    if (num < 0)
                        throw new MyException();
                    nums[1] = num;

                    Console.WriteLine("Enter number 2");
                    num = Int32.Parse(Console.ReadLine());
                    if (num < 0)
                        throw new MyException();
                    nums[2] = num;

                    Console.WriteLine("Enter number 3");
                    num = Int32.Parse(Console.ReadLine());
                    if (num < 0)
                        throw new MyException();
                    nums[3] = num;

                    int sum = MyException.Sum(nums);
                    Console.WriteLine($"Sum is {sum}");
                    continueLoop = false;

                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (MyException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (continueLoop);

            Console.WriteLine();
            MyBookRentals myBookRentals = new MyBookRentals();
            myBookRentals.Add(new RegularBookRental("C# How to Program", 1.0, 2));
            myBookRentals.Add(new RegularBookRental("Pride and Prejudice", 0.5, 6));
            myBookRentals.Add(new NewReleaseBookRental("ASP.NET Core in Action",2.0, 5));
            myBookRentals.PrintSummary();
            Console.WriteLine();
            string[,] merchantOrder = new string[,]
            {
                {"orderNumber", "9091"},
                {"createdAt","2022-03-11 17:33:12"},
                {"merchantId","123"},
                {"description","General Product"},
                {"extra", ""},
                {"amount","1"},
                {"clientSignature","71494a725948788af30615f4f68ee407"}
            };
            string[,] sortedOrder = SortOrder(merchantOrder);
            string formattedOrderString = ConcatenateOrder(sortedOrder);

            Console.WriteLine();
            bool b = Double.TryParse("6749 8789".Replace(" ",""), out double a);
            Console.WriteLine(b.ToString());
            Console.WriteLine(a);

            Message msg1 = new Message("This is message 1", "1 Jan 2022, 1:11am");
            Message msg2 = new Message("This is message 2");
            Console.WriteLine(msg1);
            Console.WriteLine(msg2);
            Console.WriteLine(); // New line

            Message email1 = new Email("This is email 1", "3 Mar 2022, 3:33pm", "sender1@example.com", "receiver1@example.com", "Subject 1");
            Message email2 = new Email("This is email 2", "4 Mar 2022, 4:44am", "sender2@example.com", "receiver2@example.com", "Subject 2");
            Console.WriteLine(email1);
            Console.WriteLine(email2);

            Message sms1 = new SMS("This is sms 1", "1 Feb 2022, 1:11pm", "8182 8384");
            Message sms2 = new SMS("This is sms 2", "2 Feb 2022, 2:22pm", "9192 9394");
            Console.WriteLine(sms1);
            Console.WriteLine(sms2);
            Console.WriteLine(); // New line

        }

        private static void PrintOrder(string[,] merchantOrder)
        {
            for(int row = 0; row < merchantOrder.GetLength(0); row++)
            {
                Console.WriteLine($"{merchantOrder[row, 0]}-{merchantOrder[row, 1]}");
            }
        }

        private static string[,] SortOrder(string[,] merchantOrder)
        {
            int rnum = merchantOrder.GetLength(0);
            int cnum = merchantOrder.GetLength(1);

            string[] keys = new string[rnum];
            string[] values = new string[rnum];

            for(int row = 0; row < rnum; row++)
            {
                keys[row] = merchantOrder[row, 0];
                values[row] = merchantOrder[row, 1];
            }

            Array.Sort(keys, values);

            for(int row = 0; row < rnum; row++)
            {
                merchantOrder[row, 0] = keys[row];
                merchantOrder[row, 1] = values[row];
            }
            PrintOrder(merchantOrder);
            return merchantOrder;
        }

        private static string ConcatenateOrder(string[,] sortedOrder)
        {
            StringBuilder sb = new StringBuilder();
            int rnum = sortedOrder.GetLength(0);
            for (int row = 0; row < rnum; row++)
            {
                if (sortedOrder[row, 0].Equals("clientSignature"))
                    continue;
                if (String.IsNullOrEmpty(sortedOrder[row, 1]))
                    continue;

                sb.Append(sortedOrder[row, 0]+'='+sortedOrder[row, 1]);

                if (row != rnum - 1)
                    sb.Append('&');
            }

            Console.WriteLine(sb);
            return sb.ToString();
        }
    }
}