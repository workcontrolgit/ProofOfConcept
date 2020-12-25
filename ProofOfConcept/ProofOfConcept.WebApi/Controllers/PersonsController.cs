using Microsoft.AspNetCore.Mvc;
using ProofOfConcept.Application.Interfaces;
using System.Threading.Tasks;

namespace ProofOfConcept.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public PersonsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        /// <summary>
        /// SELECT records from mock library GenFu
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAll(int pageNumber, int pageSize)
        {
            var data = await unitOfWork.Persons.GetAllAsync(pageNumber, pageSize);
            return Ok(data);
        }
    }
}