using System;


namespace R5T.Lombardy.Base
{
    /// <summary>
    /// This is a private interface containing a single, unified, un-commented (for visual clarity), listing of all file name operations.
    /// This interface is *not* meant to be implemented, but instead serve as a clear, single listing of all file name operations that are in reality spread throughout interfaces, interface extension methods, and static class, and riddled with comments making direct visual comparison difficult.
    /// </summary>
    interface IFileNameOperationsListing
    {
        char DefaultFileNameSegmentSeparatorChar { get; } // Done in: FileName

        string DefaultFileNameSegmentSeparator { get; } // Done in: FileName


        string[] GetFileNameSegments(string fileName, string fileNameSegmentSeparator); // Done in: FileName

        string GetFileNameWithoutExtension(string fileName); // Done in: FileName

        string GetFileExtension(string fileName); // Done in: FileName
    }
}
