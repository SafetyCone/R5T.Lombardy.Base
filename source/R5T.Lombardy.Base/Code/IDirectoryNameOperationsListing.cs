using System;


namespace R5T.Lombardy.Base
{
    /// <summary>
    /// This is a private interface containing a single, unified, un-commented (for visual clarity), listing of all directory name operations.
    /// This interface is *not* meant to be implemented, but instead serve as a clear, single listing of all directory name operations that are in reality spread throughout interfaces, interface extension methods, and static class, and riddled with comments making direct visual comparison difficult.
    /// </summary>
    interface IDirectoryNameOperationsListing
    {
        char DefaultDirectoryNameSegmentSeparatorChar { get; } // Done in: IDirectoryNameOperator, DirectoryName, DirectoryNameOperator
        string DefaultDirectoryNameSegmentSeparator { get; } // Done in: IDirectoryNameOperator, DirectoryName, DirectoryNameOperator

        string CurrentRelativeDirectoryName { get; } // Done in: IDirectoryNameOperator, DirectoryName, DirectoryNameOperator
        string ParentRelativeDirectoryName { get; } // Done in: IDirectoryNameOperator, DirectoryName, DirectoryNameOperator

        string[] RelativeDirectoryNames { get; } // Done in: IDirectoryNameOperator, DirectoryName, DirectoryNameOperator


        // Classification.
        bool IsRelativeDirectoryName(string directoryName); // Done in: IDirectoryNameOperator, DirectoryName, DirectoryNameOperator

        // Miscellaneous.
        string GetRandomDirectoryName(); // Done in: IDirectoryNameOperator, DirectoryName, DirectoryNameOperator
        string GetGUIDedDirectoryName(); // Done in: IDirectoryNameOperator, DirectoryName, DirectoryNameOperator
    }
}
