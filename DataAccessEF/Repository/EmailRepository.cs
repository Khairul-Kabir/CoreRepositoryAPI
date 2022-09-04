using DataAccessEF.EF.EntityModel;
using Domain;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF.Repository
{
    class EmailRepository : GenericRepository<EmailVM>, IEmailRepository
    {
        public EmailRepository(CoreAPIContext context) : base(context)
        {

        }
    }
}
