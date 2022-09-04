using AutoMapper;
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
    public class PersonRepository : GenericRepository<PersonVM>, IPersonRepository
    {
        public PersonRepository(CoreAPIContext context) : base(context)
        {

        }

        IEnumerable<PersonVM> IPersonRepository.GetAdultPersons()
        {
            
           List<Person> people = context.People.Where(pers => pers.Age >= 18).ToList();

           //Auto Mappper start
           var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Person, PersonVM>();
           });

           IMapper iMapper = config.CreateMapper();
           var sourceObject = new Person();
           var destinationObject = iMapper.Map<Person, PersonVM>(sourceObject);
           //Auto Mappper end

            return iMapper.Map<List<Person>, List<PersonVM>>(people);

        }
    }
}
