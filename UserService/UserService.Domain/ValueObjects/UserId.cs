namespace UserService.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

[Owned]
public record UserId(Guid Value);