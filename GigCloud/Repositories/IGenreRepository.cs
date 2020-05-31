using System.Collections.Generic;
using GigCloud.Models;

namespace GigCloud.Repositories
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> GetGenres();
    }
}