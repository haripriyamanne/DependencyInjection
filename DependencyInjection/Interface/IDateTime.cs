using System;

namespace DependencyInjection.Interface
{
    public interface IDateTime
    {
        DateTime Now { get; }
    }
}