using System;
using System.Collections.Generic;
using System.Text;

namespace Magic.Domain.Service
{
    public class PersonService
    {
        public PersonService()
        {
            //initiate data source
        }

        public Person GetPerson(int personId)
        {
            return new Person();
        }

        public void AddCardToPerson(int persondId, int cardId)
        {
            //Add personCard record
        }

        public void RemoveCardsFromPerson(int personId, List<int> cardIds)
        {
            //Remove personCard records where matching personId an cardIds
        }

        public void UpdatePerson(Person person)
        {
            //Update person
        }

        public void RemovePerson(int personId)
        {
            //Remove person
        }

        public void AddPerson(Person person)
        {
            //Add person
        }
    }
}
