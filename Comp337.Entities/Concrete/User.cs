using Comp337.Entities.Abstract;

namespace Comp337.Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserAuthorizationId { get; set; }
    }
}