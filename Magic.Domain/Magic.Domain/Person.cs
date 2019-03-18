using System;
using System.Collections.Generic;
using System.Text;

namespace Magic.Domain
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Card> CardList { get; set; }
    }
}
