namespace RegistrationTest.Services.Abstraction;

using RegistrationTest.Models.Abstraction;

public interface IModelProvider<TModel>
    where TModel : IModel
{
    string GetModel();
}