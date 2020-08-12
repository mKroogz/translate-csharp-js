using System;
using System.Collections.Generic;

namespace Dinner_Party
{
    public class Guest
    {
        public string Name { get; set; }
        public string Occupation { get; set; }
        public string Bio { get; set; }

        public Guest(string name, string occupation, string bio)
        {
            this.Name = name;
            this.Occupation = occupation;
            this.Bio = bio;
        }

    }
}