using System;

using R5T.Rugia;


namespace R5T.Lombardy.Base
{
    /// <summary>
    /// This is a private interface containing a single, unified, un-commented (for visual clarity), listing of all directory separator operations.
    /// This interface is *not* meant to be implemented, but instead serve as a clear, single listing of all directory separator operations that are in reality spread throughout interfaces, interface extension methods, and static class, and riddled with comments making direct visual comparison difficult.
    /// </summary>
    interface IDirectorySeparatorOperationsListing
    {
        char InvalidDirectorySeparatorChar { get; } // Done in: DirectorySeparator, DirectorySeparatorOperator
        char WindowsDirectorySeparatorChar { get; } // Done in: DirectorySeparator, DirectorySeparatorOperator
        char NonWindowsDirectorySeparatorChar { get; } // Done in: DirectorySeparator, DirectorySeparatorOperator
        char ExecutingMachineDefaultDirectorySeparatorChar { get; } // Done in: DirectorySeparator, DirectorySeparatorOperator
        char PlatformDefaultDirectorySeparatorChar { get; } // Done in: DirectorySeparator, DirectorySeparatorOperator
        char DefaultDirectorySeparatorChar { get; set; } // Done in: DirectorySeparator, DirectorySeparatorOperator

        string InvalidDirectorySeparator { get; } // Done in: DirectorySeparator, DirectorySeparatorOperator
        string WindowsDirectorySeparator { get; } // Done in: DirectorySeparator, DirectorySeparatorOperator
        string NonWindowsDirectorySeparator { get; } // Done in: DirectorySeparator, DirectorySeparatorOperator
        string ExecutingMachineDefaultDirectorySeparator { get; } // Done in: DirectorySeparator, DirectorySeparatorOperator
        string PlatformDefaultDirectorySeparator { get; } // Done in: DirectorySeparator, DirectorySeparatorOperator
        string DefaultDirectorySeparator { get; set; } // Done in: DirectorySeparator, DirectorySeparatorOperator


        void ResetDefaultDirectorySeparator(); // Done in: DirectorySeparator, DirectorySeparatorOperator

        char GetDirectorySeparatorCharForPlatform(Platform platform); // Done in: DirectorySeparator, DirectorySeparatorOperator
        string GetDirectorySeparatorForPlatform(Platform platform); // Done in: DirectorySeparator, DirectorySeparatorOperator
        Platform GetPlatformForDirectorySeparator(char directorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        Platform GetPlatformForDirectorySeparator(string directorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator

        char GetDirectorySeparatorStringToCharUnchecked(string directorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        char GetDirectorySeparatorStringToChar(string directorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        string GetDirectorySeparatorCharToStringUnchecked(char directorySeparatorChar); // Done in: DirectorySeparator, DirectorySeparatorOperator
        string GetDirectorySeparatorCharToString(char directorySeparatorChar); // Done in: DirectorySeparator, DirectorySeparatorOperator

        bool IsInvalid(char directorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        bool IsValid(char directorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        void Validate(char directorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        void Validate(char directorySeparator, string argumentName); // Done in: DirectorySeparator, DirectorySeparatorOperator
        void ValidateWindows(char directorySeparator); // (Could be an extension) Done in: DirectorySeparator, DirectorySeparatorOperator
        void ValidateWindows(char directorySeparator, string argumentName); // (Could be an extension) Done in: DirectorySeparator, DirectorySeparatorOperator
        void ValidateNonWindows(char directorySeparator); // (Could be an extension) Done in: DirectorySeparator, DirectorySeparatorOperator
        void ValidateNonWindows(char directorySeparator, string argumentName); // (Could be an extension) Done in: DirectorySeparator, DirectorySeparatorOperator
        bool IsDirectorySeparator(char possibleDirectorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        bool IsDirectorySeparator(char value, char possibleDirectorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        bool IsWindowsDirectorySeparator(char directorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        bool IsNonWindowsDirectorySeparator(char directorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator

        bool IsInvalid(string directorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        bool IsValid(string directorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        void Validate(string directorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        void Validate(string directorySeparator, string argumentName); // Done in: DirectorySeparator, DirectorySeparatorOperator
        void ValidateWindows(string directorySeparator); // (Could be an extension) Done in: DirectorySeparator, DirectorySeparatorOperator
        void ValidateWindows(string directorySeparator, string argumentName); // (Could be an extension) Done in: DirectorySeparator, DirectorySeparatorOperator
        void ValidateNonWindows(string directorySeparator); // (Could be an extension) Done in: DirectorySeparator, DirectorySeparatorOperator
        void ValidateNonWindows(string directorySeparator, string argumentName); // (Could be an extension) Done in: DirectorySeparator, DirectorySeparatorOperator
        bool IsDirectorySeparator(string possibleDirectorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        bool IsDirectorySeparator(string value, string possibleDirectorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        bool IsWindowsDirectorySeparator(string directorySeparator); // (Extension) Done in: DirectorySeparator, DirectorySeparatorOperator
        bool IsNonWindowsDirectorySeparator(string directorySeparator); // (Extension) Done in: DirectorySeparator, DirectorySeparatorOperator

        char GetAlternateDirectorySeparatorUnchecked(char directorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        char GetAlternateDirectorySeparator(char directorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator

        string GetAlternateDirectorySeparatorUnchecked(string directorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        string GetAlternateDirectorySeparator(string directorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator

        bool TryDetectDirectorySeparator(string pathSegment, out string directorySeparator, string defaultDirectorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        bool TryDetectDirectorySeparatorOrInvalid(string pathSegment, out string directorySeparator); // (Extension) Done in: DirectorySeparator, DirectorySeparatorOperator
        bool TryDetectDirectorySeparatorOrDefault(string pathSegment, out string directorySeparator); // (Extension) Done in: DirectorySeparator, DirectorySeparatorOperator
        bool TryDetectDirectorySeparator(string pathSegment, out string directorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        string DetectDirectorySeparator(string pathSegment); // Done in: DirectorySeparator, DirectorySeparatorOperator
        string DetectDirectorySeparatorOrDefault(string pathSegment); // Done in: DirectorySeparator, DirectorySeparatorOperator
        string DetectDirectorySeparatorOrDefault(string pathSegment, string defaultDirectorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        string DetectDirectorySeparatorOrWindows(string pathSegment); // (Extension) Done in: DirectorySeparator, DirectorySeparatorOperator
        string DetectDirectorySeparatorOrNonWindows(string pathSegment); // (Extension) Done in: DirectorySeparator, DirectorySeparatorOperator

        bool IsDirectorySeparatorDetected(string pathSegment); // Done in: DirectorySeparator, DirectorySeparatorOperator
        bool IsDirectorySeparatorDetectedUnchecked(string pathSegment, string directorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        bool IsDirectorySeparatorDetected(string pathSegment, string directorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        bool IsWindowsDirectorySeparatorDetected(string pathSegment); // Done in: DirectorySeparator, DirectorySeparatorOperator
        bool IsWindowsDirectorySeparatorDetectedAssumeWindows(string pathSegment); // Done in: DirectorySeparator, DirectorySeparatorOperator
        bool IsNonWindowsDirectorySeparatorDetected(string pathSegment); // Done in: DirectorySeparator, DirectorySeparatorOperator
        bool IsNonWindowsDirectorySeparatorDetectedAssumeNonWindows(string pathSegment); // Done in: DirectorySeparator, DirectorySeparatorOperator
        bool IsMixedDirectorySeparatorsDetected(string pathSegment); // Done in: DirectorySeparator, DirectorySeparatorOperator

        bool ContainsDirectorySeparator(string pathSegment); // See bool IsDirectorySeparatorDetected(string pathSegment). // Done in: DirectorySeparator, DirectorySeparatorOperator
        bool ContainsDirectorySeparatorUnchecked(string pathSegment, string directorySeparator); // See bool IsDirectorySeparatorDetectedUnchecked(string pathSegment, string directorySeparator). // Done in: DirectorySeparator, DirectorySeparatorOperator
        bool ContainsDirectorySeparator(string pathSegment, string directorySeparator); // See bool IsDirectorySeparatorDetected(string pathSegment, string directorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        bool ContainsWindowsDirectorySeparator(string pathSegment); // See bool IsWindowsDirectorySeparatorDetected(string pathSegment). // Done in: DirectorySeparator, DirectorySeparatorOperator
        bool ContainsNonWindowsDirectorySeparator(string pathSegment); // See bool IsNonWindowsDirectorySeparatorDetected(string pathSegment). // Done in: DirectorySeparator, DirectorySeparatorOperator
        bool ContainsMixedDirectorySeparator(string pathSegment); // bool HasMixedDirectorySeparators(string pathSegment). // Done in: DirectorySeparator, DirectorySeparatorOperator

        bool TryGetDominantDirectorySeparator(string pathSegment, out string dominantDirectorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        string GetDominantDirectorySeparator(string pathSegment); // Done in: DirectorySeparator, DirectorySeparatorOperator
        bool TryGetDominantDirectorySeparatorPlatform(string pathSegment, out Platform platform); // Done in: DirectorySeparator, DirectorySeparatorOperator
        Platform GetDominantDirectorySeparatorPlatform(string pathSegment); // Done in: DirectorySeparator, DirectorySeparatorOperator

        string GetInvalidDirectorySeparatorExceptionMessage(string invalidDirectorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        Exception GetInvalidDirectorySeparatorException(string invalidDirectorySeparator); // Done in: DirectorySeparator, DirectorySeparatorOperator
        ArgumentException GetInvalidDirectorySeparatorArgumentException(string invalidDirectorySeparator, string parameterName); // Done in: DirectorySeparator, DirectorySeparatorOperator
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
