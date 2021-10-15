using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace BookManager
{
    class Program
    {
        enum Keuzes { List, Show, Edit, Delete }

        static void Main(string[] args)
        {
            List<BookMark> sites = VraagEnVulBookmarkList();
            Console.Clear();
            ToonHoofdMenu(sites);

        }
        private static void ToonHoofdMenu(List<BookMark> sites)
        {
            while (true)
            {
                Console.WriteLine("Wat wil je doen? 0=list,1=show, 2=edit, 3=remove");
                Keuzes inp = (Keuzes)Convert.ToInt32(Console.ReadLine());
                switch (inp)
                {
                    case Keuzes.List:
                        ShowAll(sites);
                        break;
                    case Keuzes.Show:
                        OpenSite(sites);
                        break;
                    case Keuzes.Edit:
                        EditSite(sites);
                        break;
                    case Keuzes.Delete:
                        RemoveSite(sites);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Druk op een toets om verder te gaan.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private static List<BookMark> VraagEnVulBookmarkList()
        {
            Console.WriteLine("Geef je favoriete sites:");
            List<BookMark> sites = new List<BookMark>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Geef site {i} in:");
                Console.WriteLine("Naam?");
                string naam = Console.ReadLine();
                Console.WriteLine("URL?");
                string url = Console.ReadLine();

                BookMark siteToAdd = new BookMark()
                {
                    Naam = naam,
                    URL = url
                };
                sites.Add(siteToAdd);
            }

            return sites;
        }

        private static void RemoveSite(List<BookMark> sites)
        {
            int keuze = AskAction(sites, "verwijderen");
            sites.RemoveAt(keuze);
        }

        private static void EditSite(List<BookMark> sites)
        {
            int keuze = AskAction(sites, "editeren");
            Console.WriteLine("Geef nieuwe naam [leeglaten= niet veranderen]");
            string newna = Console.ReadLine();
            if (newna != "")
                sites[keuze].Naam = newna;

            Console.WriteLine("Geef nieuwe url [leeglaten= niet veranderen]");
            string newurl = Console.ReadLine();
            if (newurl != "")
                sites[keuze].URL = newurl;

        }

        private static void OpenSite(List<BookMark> sites)
        {
            int keuze = AskAction(sites, "openen");
            sites[keuze].OpenSite();
        }

        private static void ShowAll(List<BookMark> sites)
        {
            for (int i = 0; i < sites.Count; i++)
            {
                Console.WriteLine($"{i}.{sites[i].Naam} ({sites[i].URL})");
            }
        }

        private static int AskAction(List<BookMark> sites, string action)
        {
            Console.WriteLine($"Welke wil je {action}?");
            ShowAll(sites);
            int keuze = Convert.ToInt32(Console.ReadLine());
            return keuze;
        }























        class BookMark
        {

            public string Naam { get; set; }
            public string URL { get; set; }
            public void ToonSite()
            {
                WebClient wc = new WebClient();
                string result = wc.DownloadString(URL);
                Console.WriteLine(GetPlainTextFromHtml(result));
            }


            //Bron: https://www.mercator.eu/mercator/std/info_aruba/reporting-hoe-gegevens-afdrukken-met-html-tags.html
            private string GetPlainTextFromHtml(string htmlString)
            {
                string htmlTagPattern = "<.*?>";
                var regexCss = new Regex("(\\<script(.+?)\\</script\\>)|(\\<style(.+?)\\</style\\>)", RegexOptions.Singleline | RegexOptions.IgnoreCase);
                htmlString = regexCss.Replace(htmlString, string.Empty);
                htmlString = Regex.Replace(htmlString, htmlTagPattern, string.Empty);
                htmlString = Regex.Replace(htmlString, @"^\s+$[\r\n]*", "", RegexOptions.Multiline);
                htmlString = htmlString.Replace("&nbsp;", " ");
                return htmlString;
            }
        }
    }
}
