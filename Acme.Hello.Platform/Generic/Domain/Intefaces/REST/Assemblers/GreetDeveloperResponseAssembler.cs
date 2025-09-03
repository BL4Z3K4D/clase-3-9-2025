using System.Xml;
using Acme.Hello.Platform.Generic.Domain.Intefaces.REST.Resources;
using Acme.Hello.Platform.Generic.Domain.Model.Entities;

namespace Acme.Hello.Platform.Generic.Domain.Intefaces.REST.Assemblers;

public class GreetDeveloperResponseAssembler
{
    /// <summary>
    /// Conver
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public static GreetDeveloperResponse ToResponseFromEntity(Developer? entity)
    {
        if(entity == null||entity.HasAnyNameEmpty())
            return new GreetDeveloperResponse("Welcome Anonymoues ASP.NET Developer");
        return new GreetDeveloperResponse(entity.Id, entity.GetFullName(), $"Congrats{entity.GetFullName()}! You are an ASP.NET Core Developer");
    }
}