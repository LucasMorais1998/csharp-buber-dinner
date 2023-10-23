namespace BuberDinner.Application.Services.Authentication;

public record AuthenticationResult(
    Guid Id,
    string FirstName,
    string lastName,
    string Email,
    string Token
);