
namespace ProofOfConcept.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
        IPersonRepository Persons { get; }
    }
}
