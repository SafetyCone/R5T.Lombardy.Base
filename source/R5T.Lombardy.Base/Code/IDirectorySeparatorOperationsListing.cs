using System;

using R5T.Rugia;


namespace R5T.Lombardy.Base
{
    /// <summary>
    /// This is a private interface containing a unified, un-commented (for visual clarity), listing of all directory separator operations.
    /// This interface is *not* meant to be implemented, but instead serve as a clear, single-listing of all directory separator operations that are in reality spread throughout interfaces, interface extension methods, and static class, and riddled with comments making direct visual comparison difficult.
    /// </summary>
    interface IDirectorySeparatorOperationsListing
    {
        char InvalidDirectorySeparatorChar { get; } // Done in: DirectorySeparator,
        char WindowsDirectorySeparatorChar { get; } // Done in: DirectorySeparator,
        char NonWindowsDirectorySeparatorChar { get; } // Done in: DirectorySeparator,
        char ExecutingMachineDefaultDirectorySeparatorChar { get; } // Done in: DirectorySeparator,
        char PlatformDefaultDirectorySeparatorChar { get; } // Done in: DirectorySeparator,
        char DefaultDirectorySeparatorChar { get; } // Done in: DirectorySeparator,

        string InvalidDirectorySeparator { get; } // Done in: DirectorySeparator,
        string WindowsDirectorySeparator { get; } // Done in: DirectorySeparator,
        string NonWindowsDirectorySeparator { get; } // Done in: DirectorySeparator,
        string ExecutingMachineDefaultDirectorySeparator { get; } // Done in: DirectorySeparator,
        string PlatformDefaultDirectorySeparator { get; } // Done in: DirectorySeparator,
        string DefaultDirectorySeparator { get; } // Done in: DirectorySeparator,


        char GetDirectorySeparatorCharForPlatform(Platform platform); // Done in: DirectorySeparator,
        string GetDirectorySeparatorForPlatform(Platform platform); // Done in: DirectorySeparator,
        Platform GetPlatformForDirectorySeparator(char directorySeparator); // Done in: DirectorySeparator,
        Platform GetPlatformForDirectorySeparator(string directorySeparator); // Done in: DirectorySeparator,

        char GetDirectorySeparatorStringToCharUnchecked(string directorySeparator); // Done in: DirectorySeparator,
        char GetDirectorySeparatorStringToChar(string directorySeparator); // Done in: DirectorySeparator,
        string GetDirectorySeparatorCharToStringUnchecked(char directorySeparatorChar); // Done in: DirectorySeparator,
        string GetDirectorySeparatorCharToString(char directorySeparatorChar); // Done in: DirectorySeparator,

        bool IsInvalid(char directorySeparator); // Done in: DirectorySeparator,
        bool IsValid(char directorySeparator); // Done in: DirectorySeparator,
        void Validate(char directorySeparator); // Done in: DirectorySeparator, 
        void Validate(char directorySeparator, string argumentName); // Done in: DirectorySeparator, 
        void ValidateWindows(char directorySeparator); //  (Could be an extension) Done in: DirectorySeparator,
        void ValidateWindows(char directorySeparator, string argumentName); //  (Could be an extension) Done in: DirectorySeparator, 
        void ValidateNonWindows(char directorySeparator); //  (Could be an extension) Done in: DirectorySeparator,
        void ValidateNonWindows(char directorySeparator, string argumentName); //  (Could be an extension) Done in: DirectorySeparator, 
        bool IsDirectorySeparator(char possibleDirectorySeparator); // Done in: DirectorySeparator,
        bool IsDirectorySeparator(char value, char possibleDirectorySeparator); // Done in: DirectorySeparator,
        bool IsWindowsDirectorySeparator(char directorySeparator); // Done in: DirectorySeparator,
        bool IsNonWindowsDirectorySeparator(char directorySeparator); // Done in: DirectorySeparator,

        bool IsInvalid(string directorySeparator); // Done in: DirectorySeparator,
        bool IsValid(string directorySeparator); // Done in: DirectorySeparator,
        void Validate(string directorySeparator); // Done in: DirectorySeparator, 
        void Validate(string directorySeparator, string argumentName); // Done in: DirectorySeparator, 
        void ValidateWindows(string directorySeparator); // (Could be an extension) Done in: DirectorySeparator,
        void ValidateWindows(string directorySeparator, string argumentName); // (Could be an extension) Done in: DirectorySeparator,
        void ValidateNonWindows(string directorySeparator); // (Could be an extension) Done in: DirectorySeparator,
        void ValidateNonWindows(string directorySeparator, string argumentName); // (Could be an extension) Done in: DirectorySeparator,
        bool IsDirectorySeparator(string possibleDirectorySeparator); // Done in: DirectorySeparator,
        bool IsDirectorySeparator(string value, string possibleDirectorySeparator); // Done in: DirectorySeparator,
        bool IsWindowsDirectorySeparator(string directorySeparator); // (Extension) Done in: DirectorySeparator,
        bool IsNonWindowsDirectorySeparator(string directorySeparator); // (Extension) Done in: DirectorySeparator,

        char GetAlternateDirectorySeparatorUnchecked(char directorySeparator); // Done in: DirectorySeparator,
        char GetAlternateDirectorySeparator(char directorySeparator); // Done in: DirectorySeparator,

        string GetAlternateDirectorySeparatorUnchecked(string directorySeparator); // Done in: DirectorySeparator,
        string GetAlternateDirectorySeparator(string directorySeparator); // Done in: DirectorySeparator,

        bool TryDetectDirectorySeparator(string pathSegment, out string directorySeparator, string defaultDirectorySeparator); // Done in: DirectorySeparator,
        bool TryDetectDirectorySeparatorOrInvalid(string pathSegment, out string directorySeparator); // (Extension) Done in: DirectorySeparator,
        bool TryDetectDirectorySeparatorOrDefault(string pathSegment, out string directorySeparator); // (Extension) Done in: DirectorySeparator,
        bool TryDetectDirectorySeparator(string pathSegment, out string directorySeparator); // Done in: DirectorySeparator,
        string DetectDirectorySeparator(string pathSegment); // Done in: DirectorySeparator,
        string DetectDirectorySeparatorOrDefault(string pathSegment); // Done in: DirectorySeparator,
        string DetectDirectorySeparatorOrDefault(string pathSegment, string defaultDirectorySeparator); // Done in: DirectorySeparator,
        string DetectDirectorySeparatorOrWindows(string pathSegment); // (Extension) Done in: DirectorySeparator,
        string DetectDirectorySeparatorOrNonWindows(string pathSegment); // (Extension) Done in: DirectorySeparator,

        bool IsDirectorySeparatorDetected(string pathSegment); // Done in: DirectorySeparator,
        bool IsDirectorySeparatorDetectedUnchecked(string pathSegment, string directorySeparator); // Done in: DirectorySeparator,
        bool IsDirectorySeparatorDetected(string pathSegment, string directorySeparator); // Done in: DirectorySeparator,
        bool IsWindowsDirectorySeparatorDetected(string pathSegment); // Done in: DirectorySeparator,
        bool IsWindowsDirectorySeparatorDetectedAssumeWindows(string pathSegment); // Done in: DirectorySeparator,
        bool IsNonWindowsDirectorySeparatorDetected(string pathSegment); // Done in: DirectorySeparator,
        bool IsNonWindowsDirectorySeparatorDetectedAssumeNonWindows(string pathSegment); // Done in: DirectorySeparator,
        bool IsMixedDirectorySeparatorsDetected(string pathSegment); // Done in: DirectorySeparator,

        bool ContainsDirectorySeparator(string pathSegment); // See bool IsDirectorySeparatorDetected(string pathSegment). // Done in: DirectorySeparator,
        bool ContainsDirectorySeparatorUnchecked(string pathSegment, string directorySeparator); // See bool IsDirectorySeparatorDetectedUnchecked(string pathSegment, string directorySeparator). // Done in: DirectorySeparator,
        bool ContainsDirectorySeparator(string pathSegment, string directorySeparator); // See bool IsDirectorySeparatorDetected(string pathSegment, string directorySeparator); // Done in: DirectorySeparator,
        bool ContainsWindowsDirectorySeparator(string pathSegment); // See bool IsWindowsDirectorySeparatorDetected(string pathSegment). // Done in: DirectorySeparator,
        bool ContainsNonWindowsDirectorySeparator(string pathSegment); // See bool IsNonWindowsDirectorySeparatorDetected(string pathSegment). // Done in: DirectorySeparator,
        bool ContainsMixedDirectorySeparator(string pathSegment); // bool HasMixedDirectorySeparators(string pathSegment). // Done in: DirectorySeparator,

        bool TryGetDominantDirectorySeparator(string pathSegment, out string dominantDirectorySeparator); // Done in: DirectorySeparator,
        string GetDominantDirectorySeparator(string pathSegment); // Done in: DirectorySeparator,
        bool TryGetDominantDirectorySeparatorPlatform(string pathSegment, out Platform platform); // Done in: DirectorySeparator,
        Platform GetDominantDirectorySeparatorPlatform(string pathSegment); // Done in: DirectorySeparator,

        string GetInvalidDirectorySeparatorExceptionMessage(string invalidDirectorySeparator); // Done in: DirectorySeparator,
        Exception GetInvalidDirectorySeparatorException(string invalidDirectorySeparator); // Done in: DirectorySeparator,
        ArgumentException GetInvalidDirectorySeparatorArgumentException(string invalidDirectorySeparator, string parameterName); // Done in: DirectorySeparator,
        string GetWindowsDirectorySeparatorExpectedExceptionMessage(string notWindowsDirectorySeparator); // Done in: DirectorySeparator,
        Exception GetWindowsDirectorySeparatorExpectedException(string notWindowsDirectorySeparator); // Done in: DirectorySeparator,
        ArgumentException GetWindowsDirectorySeparatorExpectedArgumentException(string found, string parameterName); // Done in: DirectorySeparator,
        string GetNonWindowsDirectorySeparatorExpectedExceptionMessage(string notNonWindowsDirectorySeparator); // Done in: DirectorySeparator,
        Exception GetNonWindowsDirectorySeparatorExpectedException(string notNonWindowsDirectorySeparator); // Done in: DirectorySeparator,
        ArgumentException GetNonWindowsDirectorySeparatorExpectedArgumentException(string found, string parameterName); // Done in: DirectorySeparator,
        string GetUnableToDetectDirectorySeparatorExceptionMessage(string pathSegment); // Done in: DirectorySeparator,
        Exception GetUnableToDetectDirectorySeparatorException(string pathSegment); // Done in: DirectorySeparator,
        ArgumentException GetUnableToDetectDirectorySeparatorArgumentException(string pathSegment, string parameterName); // Done in: DirectorySeparator,
    }
}
