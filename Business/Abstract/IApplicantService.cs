using Entities.Concrete;

namespace Business.Abstract
{
    //Abstract add class interface seçtik
    //interface'de sadece imzaları çağırırız.
    //birbirinin alternatifi olan sistemlerin farklı iplementasyon yapmalarını sağlar.(maske dağıtımı için yabancı(foreignerManager) ve tc uyruklular(PersonManager) için ayrı) farklı classlarda check person yapılır
    //interfaceler new'lenemez. Referans tutucudurlar

    public interface IApplicantService
    {
        void ApplyForMask(Person person);

        List<Person> GetList();

        bool CheckPerson(Person person);

    }
}
