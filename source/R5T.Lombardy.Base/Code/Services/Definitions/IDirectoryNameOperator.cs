using System;


namespace R5T.Lombardy
{
    public interface IDirectoryNameOperator
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
