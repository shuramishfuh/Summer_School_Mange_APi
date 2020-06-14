

namespace Control.Interfaces
{
    interface IAdmin
    {
        int AdminId { get; set; }
        string Name { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string Email { get; set; }


    }
}
