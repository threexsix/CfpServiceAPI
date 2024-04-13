namespace CfpService.Contracts.Dtos.Application;

public record PutApplicationDto(
    Guid Id,
    string? Activity,
    string? Name,
    string? Description,
    string? Outline
);