using System;


namespace R5T.Lombardy.Base
{
    /// <summary>
    /// This is a private interface containing a single, unified, un-commented (for visual clarity), listing of all stringly-typed path utility operations.
    /// This interface is *not* meant to be implemented, but instead serve as a clear, single listing of all stringly-typed path utility operations that are in reality spread throughout interfaces, interface extension methods, and static class, and riddled with comments making direct visual comparison difficult.
    /// </summary>
    interface IStringlyTypedPathUtilitiesListing
    {
        bool IsDirectoryRecursivelyEmpty(string directoryPath);
    }
}
