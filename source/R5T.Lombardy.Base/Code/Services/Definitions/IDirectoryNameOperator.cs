using System;

using R5T.T0064;


namespace R5T.Lombardy
{
    [ServiceDefinitionMarker]
    public interface IDirectoryNameOperator : IServiceDefinition
    {
        char DefaultDirectoryNameSegmentSeparatorChar { get; }
        string DefaultDirectoryNameSegmentSeparator { get; }

        string CurrentRelativeDirectoryName { get; }
        string ParentRelativeDirectoryName { get; }

        string[] RelativeDirectoryNames { get; }

        
        // Classification.
        bool IsRelativeDirectoryName(string directoryName);

        // Miscellaneous.
        string GetRandomDirectoryName();
        string GetGUIDedDirectoryName();
    }
}
