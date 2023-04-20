namespace RegistrationTest.Models.Abstraction;

public interface IModel
{
    public Guid Id { get; set; }

    public string GenerateDefaultModel();
}