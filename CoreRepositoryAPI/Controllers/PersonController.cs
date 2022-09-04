using DataAccessEF.EF.EntityModel;
using Domain;
using Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreRepositoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public PersonController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<PersonVM> GetAllPersons()
        {
            return unitOfWork.Person.GetAll();
        }

        [HttpGet]
        [Route("GetAdultPersons")]
        public IEnumerable<PersonVM> GetAdultPersons()
        {
            return unitOfWork.Person.GetAdultPersons();
        }
    }
}
