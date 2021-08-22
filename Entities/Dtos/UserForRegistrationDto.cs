using Core.Entities;

namespace Entities.Dtos
{
    public class UserForRegistrationDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}