using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    // Çıplak Class Kalmasın.
    // iş(operasyon) sınıfı
    public class PersonManager : IApplicantService
    {
        //kullanıcıya maske verdigimiz ortam

        // encapsulation 
        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList()
        {
            return null;

        }

        public bool CheckPerson(Person person) // mernis e bağlanıp kişi doğru mu kontrol edecek
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);// bunun dokumantasyonunu incele oradan otomatik bulup yazdık.
            // mernis kontrolü yapılacak
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
