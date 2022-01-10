using Comp337.Entities.Abstract;

namespace Comp337.Entities.Concrete
{
    public class User : IEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public char UserAuthorization { get; set; }
        public bool DeleteFlag { get; set; }
    }
}