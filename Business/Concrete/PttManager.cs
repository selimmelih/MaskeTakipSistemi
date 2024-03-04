using Business.Abstract;
using Entities.Concrete;
using Microsoft.VisualStudio.Web.CodeGeneration.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        // dependency injection

        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) // Contructor oluşturucu, new yapıldığında çalışır.
        {
            _applicantService = applicantService;

        }
        public void GiveMask(Person person)
        {
            bool maskResult = _applicantService.CheckPerson(person);
        
            if (maskResult == true)
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ.");

            }
        }
    }
}
