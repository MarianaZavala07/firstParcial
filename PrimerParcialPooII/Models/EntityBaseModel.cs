using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace PrimerParcialPooII
{
    public class EntityBaseModel
    {
        public EntityBaseModel()
        {
      
        }
         public Guid Id { get; set;}
        public string Name { get; set;}

        public DataSetDateTime CreationDate { get; set;}

        public DataSetDateTime ModificationDate { get; set;}
        
    }




     





}
