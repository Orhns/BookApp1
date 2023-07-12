using BookApp1.Abstract;
using BookApp1.Entities;
using BookApp1.MernisServiceAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp1.Adapters
{
    public class MernisServiceAdapter : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(long.Parse(user.NationalityId), user.FirstName, user.LastName, user.BirthDate.Year);
        }
    }
}
