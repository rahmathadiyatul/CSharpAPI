using DataInterface.repositories;
using Model.Entities;
using ServiceInterface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.repositories
{
    public class MahasiswaRepository : IMahasiswaRepository
    {
        private readonly IDbService _dbService;

        public MahasiswaRepository(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<bool> Create(Mahasiswa model)
        {
            await _dbService.ModifyData("INSERT INTO mahasiswa " +
                "(id, nama, alamat, usia, jurusan_id)" +
                "values" +
                "(@Id, @Nama, @Alamat, @Usia, @JurusanId)", model);
            return true;
        }

        public async Task<List<Mahasiswa>> GetAll()
        {
            var result = await _dbService.GetData<Mahasiswa>("select * from mahasiswa", new { });
            return result;

        }
        public async Task<bool> Delete(int id)
        {
            await _dbService.DeleteData("delete from mahasiswa " +
                "where id = @Id", new {id});
            return true;
        }
    }
}
