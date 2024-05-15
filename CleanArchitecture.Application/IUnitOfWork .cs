using CleanArchitecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application
{
    public interface IUnitOfWork : IDisposable
    {
        // Repository properties
        IRepository<Movie> Movies { get; }

        // Add more repository properties as needed

        // Save changes method
        Task<int> SaveChangesAsync();
    }
}
