using Core.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Core.Utilities.Security.Jwt
{
    public class AccessToken : ITokenHelper
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }

        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            throw new NotImplementedException();
        }
    }
}