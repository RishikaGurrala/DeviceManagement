using DeviceManagement.Core.IServices;
using DeviceManagement.DTO;
using DeviceManagement.Models;

namespace DeviceManagement.Core.Services
{
    public class RegisterService : IRegistrationService
    {
        private readonly MobileContext Model;
        public RegisterService(MobileContext mobileContext)
        {
                Model = mobileContext;
        }
        public string SignIn(LoginDTO loginDTO)
        {
            try
            {
              var login=Model.Users.FirstOrDefault(x => x.UserName == loginDTO.UserName && x.Password== loginDTO.Password);
                if (login != null)
                {
                    return "Login Succefull";
                }
                else
                {
                    return "Login Failed";
                }
            }
            catch(Exception ex)
            {
                return "Something went wrong";
            }
        }

        public string SignUp(User user)
        {
            try
            {
                if (user != null)
                {
                    Model.Users.Add(user);
                    Model.SaveChanges();
                    return "registered succesfully";
                }
                else
                {
                    return "registration failed";
                }
            }
            catch(Exception ex)
            {
             return "Something went wrong";
            }
        }
    }
}
