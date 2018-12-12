using System.Collections.Generic;

namespace Magasin.Model
{
    public class Article
    {
        public int Code { get; set; }
        public string Libelle { get; set; }
        public int PU { get; set; }
        public Article()
        {

        }
        static public List<Article> getList()
        {
            List<Article> lst = new List<Article>();
            lst.Add(new Article() { Code = 1, Libelle = "Pain", PU = 2 });
            lst.Add(new Article() { Code = 2, Libelle = "Lait", PU = 8 });
            lst.Add(new Article() { Code = 3, Libelle = "Sucre", PU = 10 });
            lst.Add(new Article() { Code = 4, Libelle = "Thé", PU = 15 });
            lst.Add(new Article() { Code = 5, Libelle = "Pomme", PU = 16 });
            lst.Add(new Article() { Code = 6, Libelle = "Bananes", PU = 11 });
            return lst;
        }
    }
}
