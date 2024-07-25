using Biblioteca.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BL.Interfaces
{
    public interface IAutorService
    {
        public Task<List<AutorDTO>> GetAutoresAsync();
        public Task<AutorDTO> GetAutoresByIdAsync(int id);
        public Task<int> InsertarAutorAsync(AutorDTO autor);
        public Task<AutorDTO> UpdateAutorAsync(AutorDTO autor);
        public Task<bool> DeleteAutorAsync(int id);
    }
}
