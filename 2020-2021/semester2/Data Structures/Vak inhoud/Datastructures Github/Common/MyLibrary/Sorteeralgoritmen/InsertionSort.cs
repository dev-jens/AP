using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Sorteeralgoritmen
{
    public class InsertionSort
    {
        public void Sort(int[] list)
        {
            for (int i = 1; i < list.Length; i++)
            {
                int current = list[i];
                int newIndex = i;
                while (newIndex > 0)
                {
                    if (current < list[newIndex - 1])
                    {
                        list[newIndex] = list[newIndex - 1];
                        newIndex--;
                    }
                    else
                        break;
                }
                list[newIndex] = current;
            }
        }

        public void Sort(Auto[] list)
        {
            for (int i = 1; i < list.Length; i++)
            {
                var current = list[i];       //type 'Auto' kan ook ipv. 'var', maar dit bespaart werk als ik nadien bv. ook een sorteer 'Persoon', 'Fruit',... versie wil maken
                int newIndex = i;
                while (newIndex > 0)
                {
                    if (current.AantalKm < list[newIndex - 1].AantalKm)  //Crusiaal verschil de bovenste versie, we vergelijken hier de km stand om Auto's te kunnen rangschikken, maar.. is dit de beste manier ????
                    {
                        list[newIndex] = list[newIndex - 1];
                        newIndex--;
                    }
                    else
                        break;
                }
                list[newIndex] = current;
            }
        }
    }
}
