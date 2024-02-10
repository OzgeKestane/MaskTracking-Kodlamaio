using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        //fieldlar classın içinde _ ile yazılır
        //string ad ; -> string _ad
        //private IAplplicantService _aplplicantService;
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) //Constructor, new yapıldığında çalışır
        {
            _applicantService = applicantService;
        }


        public void GiveMask(Person person)
        {
            //PersonManager personManager = new PersonManager();
            if (_applicantService.CheckPerson(person)) //== true
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ");
            }
        }
    }
}
