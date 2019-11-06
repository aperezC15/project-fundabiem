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
        private const string userTag = "preferred_username";

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

        protected string getUser()
        {
            try
            {
                var identity = (ClaimsIdentity)User.Identity;
                //logger.LogInformation("Operatin whith user {0}",)
                return identity.Claims.Where(x => x.Type.Equals(userTag)).First().Value;
            }
            catch (Exception ex)
            {
                logger.LogError("Error al obtener usuario");
                return "Undefined_user";
                throw ex;
            }
        }
    }
}
