namespace Acme.Hello.Platform.Generic.Domain.Model.Entities;

public class Developer(string? firstName, string? lastName)
{
    public Guid Id {get; } = Guid.NewGuid(); 
    public string FirstName { get; } = string.IsNullOrWhiteSpace(firstName) ?string.Empty : firstName.Trim();
    public string LastName { get; } = string.IsNullOrWhiteSpace(lastName) ? string.Empty : lastName.Trim();
    /// <summary>
    /// Gets the full name of the developer by concatenating the first and last name.
    /// </summary>
    /// <returns></returns>
    public string GetFullName() => $"{FirstName} {LastName}".Trim();
    public bool HasAnyNameEmpty() => string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName);
}