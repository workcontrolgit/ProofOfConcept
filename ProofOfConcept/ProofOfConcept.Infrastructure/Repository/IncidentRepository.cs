using Bogus;
using ProofOfConcept.Application.Interfaces;
using ProofOfConcept.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProofOfConcept.Infrastructure.Repository
{
    public class IncidentRepository : IIncidentReportRepository
    {
        public async Task<IEnumerable<Incident>> GetAllAsync()
        {
            Faker<Incident> fakeIncidentReport = FakeData();

            var result = await Task.Run(() => fakeIncidentReport.Generate(100));

            return result;
        }

        public async Task<IEnumerable<Incident>> GetAllAsync(int pageNumber, int pageSize)
        {

            Faker<Incident> fakeIncidentReport = FakeData();

            var result = await Task.Run(() => fakeIncidentReport.Generate(100));

            return result.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        }

        public async Task<Incident> GetByIdAsync(Guid id)
        {
            throw await Task.Run(() => new NotImplementedException());
        }


        public async Task<Guid> AddAsync(Incident entity)
        {
            throw await Task.Run(() => new NotImplementedException());
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            throw await Task.Run(() => new NotImplementedException());
        }


        public async Task<int> UpdateAsync(Incident entity)
        {
            throw await Task.Run(() => new NotImplementedException());

        }
        private static Faker<Incident> FakeData()
        {
            var fakeContact = new Faker<Contact>()
                .RuleFor(c => c.Id, f => Guid.NewGuid())
                .RuleFor(c => c.FirstName, f => f.Name.FirstName())
                .RuleFor(c => c.LastName, f => f.Name.LastName())
                .RuleFor(c => c.EmailAddress, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
                .RuleFor(c => c.PhoneNumber, f => f.Person.Phone);


            var fakeIncidentReport = new Faker<Incident>()
                .RuleFor(o => o.Id, f => Guid.NewGuid())
                .RuleFor(o => o.Description, f => f.Lorem.Paragraph(3))
                .RuleFor(o => o.ReportedOn, f => f.Date.Past())
                .RuleFor(o => o.ReportedBy, f => fakeContact.Generate());
            return fakeIncidentReport;
        }

    }
}
