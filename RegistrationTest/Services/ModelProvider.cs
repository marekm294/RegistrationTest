using RegistrationTest.Models.Abstraction;
using RegistrationTest.Services.Abstraction;

namespace RegistrationTest.Services;

public class ModelProvider<TModel> : IModelProvider<TModel>
    where TModel : IModel, new()
{
    public string GetModel()
    {
        return new TModel().GenerateDefaultModel();
    }
}
