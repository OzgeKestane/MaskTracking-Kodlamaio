using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    //Sonar cube, yazılım kalitesini ölçen uygulama
    public class ForeignerManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
