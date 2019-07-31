﻿using System.Threading.Tasks;
using Contoso.Core.Domain;
using LanguageExt;

namespace Contoso.Core.Interfaces.Repositories
{
    public interface IDepartmentRepository
    {
        Task<Option<Department>> Get(int id);
    }
}
