using System;

namespace BuildingBlocks.Abstractions
{
    public interface IDateTime
    {
        DateTime UtcNow { get; }
    }
}
