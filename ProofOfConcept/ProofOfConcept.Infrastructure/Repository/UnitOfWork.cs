using ProofOfConcept.Application.Interfaces;

namespace ProofOfConcept.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IProductRepository productRepository, 
            IPersonRepository personRepository,
            IIncidentReportRepository incidentReportRepository)
        {
            Products = productRepository;
            Persons = personRepository;
            IncidentReport = incidentReportRepository;
        }
        public IProductRepository Products { get; }

        public IPersonRepository Persons { get; }
        public IIncidentReportRepository IncidentReport { get; }


    }
}
