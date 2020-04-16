using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public class Repository : IRepository
    {
        public Repository()
        {
            // TODO?
        }

        public Task<bool> AuthenticationRequest(string githubToken)
        {
            throw new NotImplementedException();
        }

        public Task<IList<string>> FastRequest()
        {
            throw new NotImplementedException();
        }

        public Task<IList<string>> MediumRequest()
        {
            throw new NotImplementedException();
        }

        public Task<IList<string>> SlowRequest()
        {
            throw new NotImplementedException();
        }
    }
}
