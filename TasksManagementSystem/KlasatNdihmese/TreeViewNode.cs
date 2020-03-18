    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    namespace TasksManagementSystem.KlasatNdihmese
    {
        public class Kategori
        {
            public int id { get; set; }
            public int parentId { get; set; }
            public string text { get; set; }
        public IList<Kategori> kategorite { get; set; }
        public Kategori()
        {
            kategorite = new List<Kategori>();
        }

        }
    public class Tipe
    {
        public int id { get; set; }
        public int parentId { get; set; }
        public string text { get; set; }
        public IList<Tipe> Tipet { get; set; }
        public Tipe()
        {
            Tipet = new List<Tipe>();
        }

    }

}
