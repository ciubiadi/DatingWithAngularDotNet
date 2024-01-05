using API.Entities;

namespace API.Interfaces
{
    // this interface is a contract
    public interface ITokenService
    {
        string CreateToken(AppUser user);    
    }
}