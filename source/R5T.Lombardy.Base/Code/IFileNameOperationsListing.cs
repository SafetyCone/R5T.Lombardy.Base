using System;


namespace R5T.Lombardy.Base
{
    /// <summary>
    /// This is a private interface containing a single, unified, un-commented (for visual clarity), listing of all file name operations.
    /// This interface is *not* meant to be implemented, but instead serve as a clear, single listing of all file name operations that are in reality spread throughout interfaces, interface extension methods, and static class, and riddled with comments making direct visual comparison difficult.
    /// </summary>
    interface IFileNameOperationsListing
    {
        char DefaultFileNameSegmentSeparatorChar { get; } // Done in: IFileNameOperator, FileName, FileNameOperator
        string DefaultFileNameSegmentSeparator { get; } // Done in: IFileNameOperator, FileName, FileNameOperator

        // Combine.
        string GetFileName(string fileNameWithoutExtension, string fileExtension); // Done in: IFileNameOperator, FileName, FileNameOperator

        // Separate.
        string[] GetFileNameSegments(string fileName, string fileNameSegmentSeparator); // Done in: IFileNameOperator, FileName, FileNameOperator

        string GetFileNameWithoutExtension(string fileName); // Done in: IFileNameOperator, FileName, FileNameOperator
        string GetFileExtension(string fileName); // Done in: IFileNameOperator, FileName, FileNameOperator

        // Miscellaneous.
        string GetRandomFileNameWithoutExtension(); // Done in: IFileNameOperator, FileName, FileNameOperator
        string GetRandomFileName(); // Uses temporary file extension. Done in: IFileNameOperator, FileName, FileNameOperator
        string GetRandomFileName(string fileExtension); // Done in: IFileNameOperator, FileName, FileNameOperator
        string GetGUIDedFileNameWithoutExtension(); // Done in: IFileNameOperator, FileName, FileNameOperator
        string GetGUIDedFileName(); // Done in: IFileNameOperator, FileName, FileNameOperator
        string GetGUIDedFileName(string fileExtension); // Done in: IFileNameOperator, FileName, FileNameOperator
    }
}
