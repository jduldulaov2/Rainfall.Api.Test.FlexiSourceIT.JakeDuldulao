namespace Rainfall.Api.Domain.Common;

public interface ISoftDeletable
{
    public bool? IsDeleted { get; set; }

    public DateTimeOffset? Deleted { get; set; }

    public string? DeletedBy { get; set; }
}
