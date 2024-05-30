using System;
namespace PrimerParcialPooII.Models
{
    public class EmployeeModel : EntityBaseModel
    {
        public EmployeeModel()
        {
        }

        public string Role { get; set; }
        public decimal Salary { set; get; }
        public int Seniority { set; get; }

        public string Sex { set; get; }
        



    }
     




}