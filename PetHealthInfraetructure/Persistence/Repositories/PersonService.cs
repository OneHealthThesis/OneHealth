using AutoMapper;
using PetHealth.Core.DTOs;
using PetHealth.Core.Entities;
using PetHealth.Core.Exceptions;
using PetHealth.Core.Interfaces;
using PetHealth.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Infrastructure.Persistence.Repositories
{
    public class PersonService: IPersonService
    {
        private readonly IMapper _mapper;
        private readonly PetHealthContext _context;

        public PersonService(PetHealthContext context,IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }


        public async Task<PersonDTO> CreatePerson(CreatePersonDTO request, CancellationToken cancellationToken)
        {
            var person = this._mapper.Map<Person>(request);

            this._context.Persons.Add(person);
            int saved = await this._context.SaveChangesAsync(cancellationToken);

            if(saved > 0)
            {
                return this._mapper.Map<PersonDTO>(person);
            }

            throw new InvalidOperationException("Unable to create a new Person entity.");
        }

        public void DeletePersonById(int personId)
        {
            var person = this._context.Persons.Find(personId);

            if (person != null)
            {
                this._context.Persons.Remove(person);
                int saved = this._context.SaveChanges();
                if (saved == 0)
                {
                    throw new InvalidOperationException("Unable to remove Person entity.");
                }
            }
            else
            {
                throw new NotFoundException();
            }
        }

        public PersonDTO GetPersonById(int personId)
        {
            var person = this._context.Persons.Find(personId);
            if (person != null)
            {
                return this._mapper.Map<PersonDTO>(person);
            }

            throw new NotFoundException();
        }

        public List<PersonDTO> GetPersons()
        {
            return this._context.Persons.Select(p => this._mapper.Map<PersonDTO>(p)).ToList();
        }

        public PersonDTO UpdatePerson(int personId, CreatePersonDTO request)
        {
            var person = this._context.Persons.Find(personId);
            if (person != null)
            {
                person.Name = request.Name;
                person.LastName = request.LastName;
                person.Address = request.Address;
                person.BirthDate = request.BirthDate;

                this._context.Persons.Update(person);
                int saved = this._context.SaveChanges();

                if (saved > 0)
                {
                    return this._mapper.Map<PersonDTO>(person);
                }

                throw new InvalidOperationException("Unable to update Person entity.");
            }

            throw new NotFoundException();
        }

    }
}
