using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_task
{
    class PublishingHouse
    {
        public int Id {get; set;}

        public string Name { get; set;}

        public string Adress { get; set;}

        public PublishingHouse(int id, string name, string adress)
        {
            Id = id; 
            Name = name; 
            Adress = adress;
        }
    }
}
