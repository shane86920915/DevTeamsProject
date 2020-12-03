using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//streaming content

namespace DevTeamsProject
{   
    public enum DevRole
    {
        Junior = 1, 
        Midlevel,
        Senior,
    }
    public class Developer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasPluralsight { get; set; }
        public DevRole Devroles { get; set; }

        public Developer()
        {

        }
        public Developer (int id, string name, bool haspluralsight, DevRole devroles)
	    {   
            Id = id;
            Name = name; 
            HasPluralsight = haspluralsight;
            Devroles = devroles; 

	    }




    }
}
