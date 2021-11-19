using Microsoft.EntityFrameworkCore;
using Model;
using Repository.VM;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class PerosnRepository : GeneralSave, IGeneralRepository<Person>
    {
        private readonly DatabaseCTX _db;
        public PerosnRepository(DatabaseCTX db)
        {
            _db = db;
        }
        public async Task<ResultMessageVM> Add(Person entity)
        {
            _db.People.Add(entity);
            return await save(_db);
        }

        public async Task<ResultMessageVM> Delete(Person entity)
        {
            _db.Entry(entity).State=EntityState.Deleted;
            return await save(_db);
        }

        public async Task<List<Person>> GetAll()
        {
            return await _db.People.ToListAsync();
        }

        public async Task<Person> GetSingle(int Id)
        {
            return await _db.People.FindAsync(Id);
        }

        public async Task<ResultMessageVM> Update(Person entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            return await save(_db);
        }
    }
}
