using RegistrationTest.Models.Abstraction;

namespace RegistrationTest.Models;

public class CarModel : IModel
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string? Color { get; set; }

    public string GenerateDefaultModel()
    {
        return "This is Car";
    }
}