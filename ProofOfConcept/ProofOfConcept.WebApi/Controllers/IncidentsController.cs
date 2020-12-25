using Microsoft.AspNetCore.Mvc;
using ProofOfConcept.Application.Interfaces;
using ProofOfConcept.Application.Parameters;
using System.Threading.Tasks;


namespace ProofOfConcept.Api.Controllers
{
    [Route("api/v1/[controller]")]
    public class IncidentsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public IncidentsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        /// <summary>
        /// SELECT records from mock library Bogus
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] RequestParameter filter)
        {
            var data = await unitOfWork.IncidentReport.GetAllAsync(filter.PageNumber, filter.PageSize);

            return Ok(data);
        }
    }
}