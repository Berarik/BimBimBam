using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BimBim.Models;

namespace BimBim.Services
{
    public static class DocsSevices
    {
        static List<Docs> docsTestList { get; }
        static int nextId = 3;
        static DocsSevices()
        {
            docsTestList = new List<Docs>
            {
                new Docs { Id =0,Name = "Doc1.txt" },
                new Docs { Id =1,Name = "Bat1.bat" }
            };
        }
        public static List<Docs> GetAll() => docsTestList;

        public static Docs? Get(int id) => docsTestList.FirstOrDefault(p => p.Id == id);
        static void Add(Docs doc)
        {
            doc.Id = nextId++;
            docsTestList.Add(doc);
        }
        public static void Delete(int id)
        {
            var doc = Get(id);
            if (doc is null)
                return;
            docsTestList.Remove(doc);
        }

        public static void Update(Docs doc)
        {
            var id = docsTestList.FindIndex(p => p.Id == doc.Id);
            if (id == -1)
                return;
            docsTestList[id] = doc;
        }




    }
}
