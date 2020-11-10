using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CovidHost
{
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)] // dla całej sesji od każdego klienta
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)] //Dla wszystkich
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)] //Na kazde zapytanie
    public class Service1 : IService1
    {

        public bool InsertCase(PersonCase obj)
        {
            
            
            obj.ID = personCase.Count +1;
            personCase.Add(obj);
            return true;
        }

        public bool AddConcact(PersonCase obj)
        {
            var list = personCase;
            personCase.Where(p => p.ID ==
            obj.ID).Update(p => p.CityConcact = obj.CityConcact);

            var list2 = personCase;
            personCase.Where(p => p.ID ==
            obj.ID).Update(p => p.DateConcact = obj.DateConcact);

            return true;
        }
        public List<PersonCase> GetAllPerson()
        {
            return personCase;
        }

        public List<PersonCase> FinishSession()
        {
            return personCase;
        }


        public static List<PersonCase> personCase = new List<PersonCase>();
         

    }
    public static class LinqUpdates
    {
        public static void Update<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
                action(item);
        }
    }
}
