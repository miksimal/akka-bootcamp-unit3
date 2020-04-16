using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public interface IRepository
    {
        // TODO
        Task<IList<string>> FastRequest();
        Task<IList<string>> SlowRequest();
        Task<IList<string>> MediumRequest();
        Task<bool> AuthenticationRequest(string githubToken);

    }
}
