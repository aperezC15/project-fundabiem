using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace fundabiemAPI.Middleware
{
    public class coreControllerFundabiem<T> : ControllerBase
    {
        protected readonly ILogger<T> logger;
        private const string roleTag = "role";

        public coreControllerFundabiem(ILogger<T> logger)
        {
            this.logger = logger;
        }

        protected IEnumerable<string> getRoles()
        {
            try
            {
                var identity = (ClaimsIdentity)User.Identity;
                var claims = identity.Claims;
                return claims.Where(user => user.Type.Equals(roleTag)).Select(x => x.Value);
            }
            catch (Exception ex)
            {
                logger.LogError(ex,"Was ocurred a error to read roles for user");
                throw ex;
            }
        }
    }
}
