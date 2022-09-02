using DataInterface.repositories;
using Model.Entities;
using ServiceInterface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class MahasiswaService : IMahasiswaService
    {
        private readonly IMahasiswaRepository mahasiswaRepository;

        public MahasiswaService(IMahasiswaRepository mahasiswaRepository)
        {
            this.mahasiswaRepository = mahasiswaRepository;
        }

        public async Task<bool> Create(Mahasiswa mahasiswa)
        {
            var result = await mahasiswaRepository.Create(mahasiswa);
            return result;
        }

        public async Task<List<Mahasiswa>> GetAll()
        {
            var result = await mahasiswaRepository.GetAll();
            return result;
        }
        public async Task<bool> Delete(int id)
        {
            var result = await mahasiswaRepository.Delete(id);
            return result;
        }
    }
}
