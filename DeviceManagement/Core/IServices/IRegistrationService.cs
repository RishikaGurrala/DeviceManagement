using DeviceManagement.DTO;
using DeviceManagement.Models;

namespace DeviceManagement.Core.IServices
{
    public interface IRegistrationService
    {
        string SignIn(LoginDTO loginDTO);
        string SignUp(User user);
    }
}
