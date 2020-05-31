using System.Collections.Generic;
using GigCloud.Core.Models;

namespace GigCloud.Core.IRepositories
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> GetGenres();
    }
}