using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;

namespace tp3.Models.repositories
{
    public class EmployeRepository :repository<Employe>
    {
        List<Employe> _employes;
        private object _context;

        public EmployeRepository()
        {
            _employes = new List<Employe>
            {
                new Employe { Id = 1, Name = "sofien ben ali", Departement = "comptabilité", Salary = 600 },
                new Employe { Id = 2, Name = "mourad triki", Departement = "rh", Salary = 1500 },
                new Employe { Id = 3, Name = "ali ben mohamed", Departement = "info", Salary = 1700 },
                new Employe { Id = 4, Name = "tarek aribi", Departement = "info", Salary = 1100 }
            };
        }
        public void Add(Employe entity)
        {
            _employes.Add(entity);
        }
        public void Delete(int id)
        {
            var employe = FindById(id);
            if (employe != null)
            {
                _employes.Remove(employe);
            }
        }
        public Employe FindById(int id)
        {
            return _employes.FirstOrDefault(e => e.Id == id);
        }
        public List<Employe> GetAll()
        {
            return _employes;
        }
        public List<Employe> Search(string term)
        {
            return _employes
                .Where(e => e.Name.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                            e.Departement.Contains(term, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
        public void Update(int id, Employe e)
        {
            var existingEmploye = FindById(e.Id);
            if (existingEmploye != null)
            {
                existingEmploye.Name = e.Name;
                existingEmploye.Departement = e.Departement;
                existingEmploye.Salary = e.Salary;
            }
        }

        


    }
}
