using DataAccsessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerAccountProcessDal : ICustomerAccountProcessDal
    {
        private readonly ICustomerAccountProcessDal _customerAccountProcessDal;

        public CustomerAccountProcessDal(ICustomerAccountProcessDal customerAccountProcessDal)
        {
            _customerAccountProcessDal = customerAccountProcessDal;
        }

        public void Delete(ICustomerAccountProcessDal t)
        {
            _customerAccountProcessDal.Delete(t);
         }

        public ICustomerAccountProcessDal GetById(int id)
        {
            return _customerAccountProcessDal.GetById(id);
        }

        public List<ICustomerAccountProcessDal> GetList()
        {
           return _customerAccountProcessDal.GetList();
        }

        public void Insert(ICustomerAccountProcessDal t)
        {
            _customerAccountProcessDal.Insert(t);
        }

        public void Update(ICustomerAccountProcessDal t)
        {
            _customerAccountProcessDal.Update(t);
        }
    }
}
