using System;
using System.Collections.Generic;
using System.Text;

namespace Magic.Domain
{
    public class Card
    {
        public string Name { get; set; }
        public List<CardColor> ManaCost { get; set; }
        public int Power { get; set; }
        public int Toughness { get; set; }
        public string BodyText { get; set; }
        public List<CardColor> CardColors { get; set; }
        public CardType Type { get; set; }
        public List<string> SubTypes { get; set; }
    }
}
