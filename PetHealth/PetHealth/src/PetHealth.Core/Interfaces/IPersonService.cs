using PetHealth.Core.DTOs;
using PetHealth.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Core.Interfaces
{
    public interface IPersonService
    {
        List<PersonDTO> GetPersons();

        Task<PersonDTO> CreatePerson(CreatePersonDTO request, CancellationToken cancellationToken);

        PersonDTO GetPersonById(int id);

        PersonDTO UpdatePerson(int id, CreatePersonDTO personDTO);

        void DeletePersonById(int id);

    }
}
