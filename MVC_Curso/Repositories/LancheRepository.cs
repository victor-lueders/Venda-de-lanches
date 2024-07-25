using Microsoft.EntityFrameworkCore;
using MVC_Curso.Context;
using MVC_Curso.Models;
using MVC_Curso.Repositories.Interfaces;

namespace MVC_Curso.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(l => l.IsFavorite).Include(c => c.Categoria);

        public Lanche GetLancheByID(int id)
        {
            return _context.Lanches.FirstOrDefault(l => l.Id == id);
        }
    }
}
