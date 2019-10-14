using System;


namespace R5T.Lombardy.Base
{
    /// <summary>
    /// This is a private interface containing a single, unified, un-commented (for visual clarity), listing of all file extension operations.
    /// This interface is *not* meant to be implemented, but instead serve as a clear, single listing of all file extension operations that are in reality spread throughout interfaces, interface extension methods, and static class, and riddled with comments making direct visual comparison difficult.
    /// </summary>
    interface IFileExtensionOperationsListing
    {
        char FileExtensionSeparatorChar { get; } // Done in: IFileExtensionOperator, FileExtension, FileExtensionOperator
        string FileExtensionSeparator { get; } // Done in: IFileExtensionOperator, FileExtension, FileExtensionOperator
    }
}
