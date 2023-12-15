using Microsoft.AspNetCore.Identity;

namespace Blazor.Api.Helper
{
    public interface ITokenService
    {
        string CreateToken(IdentityUser user);
    }
}
