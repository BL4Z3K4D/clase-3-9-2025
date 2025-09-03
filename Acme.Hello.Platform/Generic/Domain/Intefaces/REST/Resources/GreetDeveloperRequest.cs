namespace Acme.Hello.Platform.Generic.Domain.Intefaces.REST.Resources;
/// <summary>
/// Request to greet a developer.
/// </summary>
/// <remarks>
///This record is used in the GreetDeveloper endpoint to capture the first and last name of the developer.
/// </remarks>
/// <param name="firstName"> The first name of the developer to be greeted. Optional</param>
/// <param name="lastName"> The last name of the developer to be greeted. Optional</param>
public record GreetDeveloperRequest(string? firstName, string? lastName);