using System;

using R5T.T0064;


namespace R5T.Lombardy
{
    [ServiceDefinitionMarker]
    public interface IFileExtensionOperator : IServiceDefinition
    {
        char FileExtensionSeparatorChar { get; }
        string FileExtensionSeparator { get; }
    }
}
