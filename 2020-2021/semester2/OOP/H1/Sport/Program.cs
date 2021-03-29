using System;

namespace Sport
{
    class Program
    {
        static void Main(string[] args)
        {
            Zwmmer jens = new Zwmmer();
            jens.StelIn("jens", "zs", 8,4);

            jens.ZwemBaan();
            jens.KeerPunt();
            jens.KomtAaan();
            

        } 
    }
}
