using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace CovidHost
{
   
    
    [ServiceContract]
    
    public interface IService1
    {
        // [OperationContract(IsInitiating = true, IsTerminating = false)]
        [OperationContract]
        bool InsertCase(PersonCase obj);

      //  [OperationContract(IsInitiating = false, IsTerminating = false)]
        [OperationContract]
        List<PersonCase> GetAllPerson();

        //  [OperationContract(IsInitiating = false, IsTerminating = false)]
        [OperationContract]
        bool AddConcact(PersonCase obj);

        // //  [OperationContract(IsTerminating = true, IsInitiating = false)]
        [OperationContract]
        List<PersonCase> FinishSession();

       
       

    }

    [DataContract(IsReference = true)]
    public class PersonCase
    {
        [DataMember]
        public int ID;
        [DataMember]
        public string Name;
        [DataMember]
        public string CityCase;
        [DataMember]
        public string DateResults;
        [DataMember]
        public string DateTest;
        [DataMember]
        public string DateConcact;
        [DataMember]
        public string CityConcact;
    }

    //public class PersonConcact
    //{
    //    [DataMember]
    //    public int ID;
    //    [DataMember]
    //    public string Name;
    //    [DataMember]
    //    public string CityCase;
    //    [DataMember]
    //    public DateTime DateCase;
    //}


    //[DataContract]
    //public class People
    //{
    //    [DataMember]
    //    public DataTable PeopleTable
    //    {
    //        get;
    //        set;
    //    }
    //}

}
