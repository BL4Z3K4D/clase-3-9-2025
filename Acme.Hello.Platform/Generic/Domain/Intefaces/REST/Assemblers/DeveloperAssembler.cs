using Acme.Hello.Platform.Generic.Domain.Intefaces.REST.Resources;
using Acme.Hello.Platform.Generic.Domain.Model.Entities;

namespace Acme.Hello.Platform.Generic.Domain.Intefaces.REST.Assemblers;
/// <summary>
/// Assembler for Developer entiy and related request/response.
/// </summary>
/// <remarks>
///This class provides methos to convert from REST request to Developer entity and vice versa.
/// </remarks>
public static class DeveloperAssembler
{
    /// <summary>
    /// Converts a <see cref="GreetDeveloperRequest"/> to a <see cref="Developer"/> entity.
    /// Returns null if the request is null or if required fields are missing
    /// </summary>
    /// <param name="request">The <see cref="GreetDeveloperRequest"/> object to convert</param>
    /// <returns></returns>
    public static Developer ToEntityFromRequest(GreetDeveloperRequest? request)
    {
        if (request == null ||
            string.IsNullOrWhiteSpace(request.firstName) || string.IsNullOrWhiteSpace(request.lastName))
            return null;
        return new Developer(request.firstName,request.lastName);
            
    }
}