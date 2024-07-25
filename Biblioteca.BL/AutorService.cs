using Biblioteca.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.DAL.Interfaces;
using AutoMapper;
using Biblioteca.Entities.DTO;
using Biblioteca.Entities.Models;

namespace Biblioteca.BL
{
    public class AutorService : IAutorService
    {
        private readonly IAutorRepository repository;
        private readonly IMapper mapper;

        public AutorService(IAutorRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<AutorDTO>> GetAutoresAsync()
        {
            try
            {
                var result = await repository.GetAutoresAsync();
                return mapper.Map<List<Autor>, List<AutorDTO>>(result);
            }
            catch (Exception ex)
            {
                return new List<AutorDTO>();
            }
        }

        public async Task<AutorDTO> GetAutoresByIdAsync(int id)
        {
            try
            {
                var result = await repository.GetAutorByIdAsync(id);
                return mapper.Map<Autor, AutorDTO>(result);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<int> InsertarAutorAsync(AutorDTO model)
        {
            try
            {
                var entity = mapper.Map<AutorDTO, Autor>(model);
                Console.WriteLine(entity);
                return await repository.InsertAutorAsync(entity);
            }
            catch (Exception ex)
            {
                string excep = ex.ToString();
                Console.WriteLine(excep);
                return -1;
            }

        }

        public async Task<AutorDTO> UpdateAutorAsync(AutorDTO model)
        {
            try
            {
                var entity = mapper.Map<AutorDTO, Autor>(model);
                var result = await repository.UpdateAutorAsync(entity);
                return mapper.Map<Autor, AutorDTO>(result);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> DeleteAutorAsync(int id)
        {
            try
            {
                return await repository.DeleteAutorAsync(id);

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //    public async Task<List<AutorDTO>> InsertarAutorAsync()
        //    {
        //        try
        //        {
        //            var result = await repository.GetAutoresAsync();
        //            return mapper.Map<List<Autor>, List<AutorDTO>>(result);
        //        }
        //        catch (Exception ex)
        //        {
        //            return new List<AutorDTO>();
        //        }
        //    }
        //}
    }
}
