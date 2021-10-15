using System;
using MyLibrary.SLL;

namespace SLLTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bool Loop = true;
            ListInt list = new ListInt();
            do
            {
                Console.WriteLine("List bevat: " + (list.IsEmpty ? "geen elementen" : list.First));
                Console.WriteLine();
                Console.WriteLine("Wil u een element toevoegen (A:nr), verwijderen (R:nr), tussenvoegen (I:nr:nr), Alles wissen (C)");
                string cmd = "";
                int value = 0;
                NodeInt node = null;
                cmd = Console.ReadLine();
                string[] splitcmd = cmd.Split(":");
                if (splitcmd != null)
                {
                    switch (cmd[0])
                    {
                        case 'A':
                            if (splitcmd.Length == 2 && int.TryParse(splitcmd[1], out value))
                                list.AddLast(value);
                            else
                                Console.WriteLine("Ik heb het getal dat u wil toevoegen niet begrepen");
                            break;
                        case 'R':
                            if (splitcmd.Length == 2 && int.TryParse(splitcmd[1], out value))
                            {
                                node = list.FindNode(value);
                                if (node != null)
                                    list.RemoveNode(node);
                                else
                                    Console.WriteLine("de waarde werd niet gevonden in de lijst");
                            }
                            else
                                Console.WriteLine("Ik heb het getal dat u wil verwijderen niet begrepen");
                            break;
                        case 'I':
                            if (splitcmd.Length == 3 && int.TryParse(splitcmd[1], out value))
                            {
                                node = list.FindNode(value);
                                if (node != null)
                                {
                                    if (int.TryParse(splitcmd[2], out value))
                                        list.AddAfter(node, value);
                                    else
                                        Console.WriteLine("Ik heb het getal dat u wil toevoegen niet begrepen");
                                }
                                else
                                    Console.WriteLine("de waarde werd niet gevonden in de lijst");
                            }
                            else
                                Console.WriteLine("Ik heb het getal waarna u wil toevoegen niet begrepen");
                            break;
                        case 'C':
                            list.Clear();
                            break;
                        default:
                            Console.WriteLine("Sorry, dit begrijp ik totaal niet. Probeer nog eens");
                            break;
                    }
                }
                Console.WriteLine();
            }
            while (Loop);
        }
    }
}
