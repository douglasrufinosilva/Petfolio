using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCase.Pets.GetById;

public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "pipita",
            Birthday = new DateTime(year: 2022, month: 04, day: 27),
            Type = Communication.Enums.PetType.Cat
        };
    }
}
