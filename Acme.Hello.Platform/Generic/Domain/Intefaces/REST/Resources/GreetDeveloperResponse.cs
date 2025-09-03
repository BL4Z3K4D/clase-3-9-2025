using Acme.Hello.Platform.Generic.Domain.Model.Entities;

namespace Acme.Hello.Platform.Generic.Domain.Intefaces.REST.Resources;
/// <summary>
/// Response returned when greeting a developer.
/// </summary>
/// <remarks>
/// This record encapsulates the response details 
/// </remarks>
/// <param name="Id"></param>
/// <param name="FullName"></param>
/// <param name="Message"></param>
public record GreetDeveloperResponse(Guid? Id, string? FullName, string? Message)
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GreetDeveloperResponse"/> class.
    /// </summary>
    /// <remarks>
    ///This constructor is used to create a response with a message.
    /// </remarks>
    /// <param name="message">The mess</param>
    public GreetDeveloperResponse(string message) : this(null, null, message)
    {
        
    }
}