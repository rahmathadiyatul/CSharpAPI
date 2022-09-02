using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface.repositories
{
    public interface IMahasiswaRepository
    {
        public Task<bool> Create(Mahasiswa model);
        public Task<List<Mahasiswa>> GetAll();
        public Task<bool> Delete(int id);

    }
}
