using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _001_TodoApplicationRestApp.Entities
{
    public class TodoInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
        public DateTime LastUpdate { get; set; } = DateTime.Now;
        public bool Completed { get; set; } 

    }
}
