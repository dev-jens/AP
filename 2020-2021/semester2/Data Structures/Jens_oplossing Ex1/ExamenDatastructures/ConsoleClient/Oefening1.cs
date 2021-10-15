using ClassLibrary.Tree.Binary.Generic;
using DLL = ClassLibrary.DLL.Generic;
using System;
using ClassLibrary.Tree.BST.Generic;

namespace ConsoleClient
{
    public class Oefening1
    {
        /// <summary>
        /// Startpunt van oef1: BST, DLL en recursie
        /// zie opgave pdf voor meer info
        /// </summary>
        public void Start()
        {
            //Vul deze code aan. In de classlibrary vind je reeds een 'Binary Search Tree' die je kan gebruiken.
            //(Je mag ook je eigen Tree class in dit project toevoegen en gebruiken)

            Console.WriteLine("Welkom bij oef 1. Geef na elkaar 5 verschillende gehele getallen in");
            int counter = 1;
            int getal = 0;

            //tree aanmaken
            var BST = new Tree<int>();
            while (counter <= 5)
            {
                var text = Console.ReadLine();
                if (int.TryParse(text, out getal))
                {
                    //TODO: voeg het getal telkens toe aan de BST
                    BST.Insert(getal);
                    counter++;
                }
                else
                    Console.WriteLine("een GEHEEL GETAL ingeven AUB.");
            }

            //Opdracht A: gebruik hiervoor de methode ZoekMax()
            Console.WriteLine("Het grootste getal dat u heeft ingevoerd is :" + ZoekMax(BST.Root)); // + ZoekMax());

            //Opdracht B: gebruik hiervoor de methode Som()
            Console.WriteLine("De som van alle getallen die u heeft ingegeven is: " + Som(BST.Root));// + Som());

            //Opdracht C: gebruik hiervoor de methode Convert()

            //var list = Convert(...);
            Console.WriteLine("Hieronder worden alle getallen weergegeven in stijgende volgorde");
            //TODO: toon alle getallen in de lijst.

            var node = Convert(BST.Root, new DLL.List<int>()).First;
            while (node != null)
            {
                Console.WriteLine(node.Value);

                node = node.Next;
            }

        }

        /// <summary>
        /// Opdracht A: Haal de hoogste waarde uit de gegeven BST.
        /// Doe dit op een iteratieve manier !
        /// </summary>
        /// <returns>de hoogste waarde</returns>
        private int ZoekMax(Node<int> rootNode)
        {
            while (rootNode.Right != null)
            {
                // zolang de volgende node niet null is verplaatsen we de root. 
                //als het volgende getal null is weten we da we het meest rechtse getal hebben gevonden. dit is het grootste ( eigenschap BST)
                rootNode = rootNode.Right;
            }

            return rootNode.Value;
        }

        /// <summary>
        /// Opdracht B: Bereken de Som van alle waarden in de BST
        /// Doe dit op een recursieve manier
        /// </summary>
        /// <returns></returns>
        private int Som(Node<int> rootNode)
        {
            if (rootNode == null)
            {
                return 0;
            }

            return rootNode.Value + Som(rootNode.Right) + Som(rootNode.Left);
        }

        /// <summary>
        /// Opdracht C: Zet de BST om naar een DLL, waarbij alle nodes ineens in volgorde staan van klein naar groot.
        /// Doe dit bij voorkeur op een recursieve manier. 
        /// Indien het je niet lukt mag het ook iteratief maar dat kost je enkele punten.
        /// </summary>
        /// <returns></returns>
        private DLL.List<int> Convert(Node<int> rootNode, DLL.List<int> list)
        {
            //moeilijk
            if (list.IsEmpty)
                list.AddFirst(rootNode.Value);

            if (rootNode.Left == null && rootNode.Right == null)
                return new DLL.List<int>();

            if (rootNode.Left != null)
            {
                list.AddBefore(list.FindNode(rootNode.Value), rootNode.Left.Value);
                Convert(rootNode.Left, list);
            }

            if (rootNode.Right != null)
            {
                list.AddAfter(list.FindNode(rootNode.Value), rootNode.Right.Value);
                Convert(rootNode.Right, list);
            }

            return list;
        }
    } 
}
