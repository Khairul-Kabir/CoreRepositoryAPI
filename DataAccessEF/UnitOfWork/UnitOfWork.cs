using DataAccessEF.EF.EntityModel;
using DataAccessEF.Repository;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private CoreAPIContext context;
        public UnitOfWork(CoreAPIContext context)
        {
            this.context = context;
            Address = new AddressRepository(this.context);
            Email = new EmailRepository(this.context);
            Person = new PersonRepository(this.context);
        }
        public IAdressRepository Address { get; private set; }
        public IEmailRepository Email { get; private set; }
        public IPersonRepository Person { get; private set; }

        public void Dispose()
        {
            context.Dispose();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }
    }
}
