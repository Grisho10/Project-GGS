using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_GGS
{
    class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Level  { get; set; }

        public Note()
        {
        }
        public Note(int id, string title, string description, int level)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Level = level;
        }

    }
}
