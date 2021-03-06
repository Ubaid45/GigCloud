﻿using GigCloud.Core.Models;
using System.Collections.Generic;

namespace GigCloud.Core.IRepositories
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> GetGenres();
    }
}