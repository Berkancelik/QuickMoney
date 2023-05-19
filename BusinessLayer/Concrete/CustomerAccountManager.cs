using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerAccountManager : ICustomerAccountService
    {
        private readonly ICustomerAccountDal _customerAccountDal;
        public void TDelete(CustomerAccount t)
        {
            throw new NotImplementedException();
        }

        public CustomerAccount TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CustomerAccount> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(CustomerAccount t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(CustomerAccount t)
        {
            throw new NotImplementedException();
        }
    }
}
