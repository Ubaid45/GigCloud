using GigCloud.Core.IRepositories;
using GigCloud.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace GigCloud.Persistence.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly ApplicationDbContext _context;

        public GenreRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Genre> GetGenres()
        {
            return _context.Genres.ToList();
        }
    }
}