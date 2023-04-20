using RegistrationTest.Models.Abstraction;

namespace RegistrationTest.Models;

public class UserModel : IModel
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public int Age { get; set; }

    public string GenerateDefaultModel()
    {
        return "This is User";
    }
}