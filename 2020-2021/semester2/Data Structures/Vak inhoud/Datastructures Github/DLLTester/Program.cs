using MyLibrary.DLL;
using System;

namespace DLLTester
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
                if (list.IsEmpty)
                    Console.WriteLine("List bevat: geen elementen");
                else {
                    NodeInt n = list.First;
                    Console.Write("list bevat: ");
                    while (n != null)
                    {
                        Console.Write(n + "-");
                        n = n.Next;
                    }
                    Console.WriteLine();
                    Console.Write("list bevat (reverse): ");
                    //and backwards travel is also possible....
                    n = list.Last;
                    while (n != null)
                    {
                        Console.Write(n + "-");
                        n = n.Prev;
                    }

                }
                Console.WriteLine();
                Console.WriteLine("Wil u een element toevoegen (A:nr), verwijderen (R:nr), tussenvoegen (I:nr:nr), Alles wissen (C), Ophouden (Q)");
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
                        case 'Q':
                            Loop = false;
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
