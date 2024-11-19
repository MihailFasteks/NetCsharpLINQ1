using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace NetCsharpLINQ1
{
    public class Firm
    {
        public string Name { get; set; }
        public DateTime FirmDate { get; set; }
        public string Profile {  get; set; }
        public string HeadName { get; set; }
        public string HeadLastName { get; set; }
        public string HeadSureName {  get; set; }
        public int CountOfEmployees {  get; set; }
        public string Adress {  get; set; }
       public Employee[] employees {  get; set; }

        public Firm(string n, DateTime dt, string prf, string hn, string hln, string hsn, int count, string ad, Employee[] empl)
        {
            Name = n;
            FirmDate = dt;
            Profile = prf;
            HeadName = hn;
            HeadLastName = hln;
            HeadSureName = hsn;
            CountOfEmployees = count;
            Adress = ad;
            employees = empl;
        }
        public override string ToString()
        {
            return $"{Name} - {FirmDate} - {Profile} - {HeadName} - {HeadLastName} - {HeadSureName} - {CountOfEmployees} - {Adress}";
        }
    }
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeSureName { get; set; }
        public string Job {  get; set; }
        public string Phone {  get; set; }
        public string Email {  get; set; }
        public  double Salary {  get; set; }
        public Employee(string n, string ln, string sn, string j, string ph, string em, double s)
        {
            EmployeeName = n;
            EmployeeLastName=ln;
            EmployeeSureName = sn;
            Job = j;
            Phone = ph;
            Email = em;
            Salary = s;
        }
        public override string ToString()
        {
            return $"{EmployeeName} - {EmployeeLastName} - {EmployeeSureName} - {Job} - {Phone} - {Email} - {Salary}";
        }
    }
}
