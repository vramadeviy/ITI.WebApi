using ITI_DAL.Models;
namespace ITI.WebApi.Services
{
    public class RegisterService
    {
        public List<MstCountry> lstCountries()
        {
            using (var dbcontext= new ITIDBContext())
            {
               return  dbcontext.MstCountries.ToList();
            }
        }
    }
}
