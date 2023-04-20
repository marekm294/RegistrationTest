using RegistrationTest.Models.Abstraction;

namespace RegistrationTest.Models;

public class ProjectModel : IModel
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string GenerateDefaultModel()
    {
        return "This is Project";
    }
}