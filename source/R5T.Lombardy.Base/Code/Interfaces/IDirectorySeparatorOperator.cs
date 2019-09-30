using System;

using R5T.Rugia;


namespace R5T.Lombardy
{
    public interface IDirectorySeparatorOperator
    {
        char InvalidDirectorySeparatorChar { get; }
        char WindowsDirectorySeparatorChar { get; }
        char NonWindowsDirectorySeparatorChar { get; }
        char PlatformDefaultDirectorySeparatorChar { get; }
        char DefaultDirectorySeparatorChar { get; }

        string InvalidDirectorySeparator { get; }
        string WindowsDirectorySeparator { get; }
        string NonWindowsDirectorySeparator { get; }
        string PlatformDefaultDirectorySeparator { get; }
        string DefaultDirectorySeparator { get; }


        char GetDirectorySeparatorCharForPlatform(Platform platform);
        string GetDirectorySeparatorForPlatform(Platform platform);

        char GetDirectorySeparatorStringToCharUnchecked(string directorySeparator);
        string GetDirectorySeparatorCharToStringUnchecked(char directorySeparatorChar);

        bool IsInvalid(char directorySeparator);
        bool IsValid(char directorySeparator);
        void Validate(char directorySeparator);
        void Validate(char directorySeparator, string argumentName);
        void ValidateWindows(char directorySeparator);
        void ValidateWindows(char directorySeparator, string argumentName);
        void ValidateNonWindows(char directorySeparator);
        void ValidateNonWindows(char directorySeparator, string argumentName);
        bool IsDirectorySeparator(char possibleDirectorySeparator);
        bool IsDirectorySeparator(char value, char possibleDirectorySeparator);
        bool IsWindowsDirectorySeparator(char directorySeparator);
        bool IsNonWindowsDirectorySeparator(char directorySeparator);

        bool IsInvalid(string directorySeparator);
        bool IsValid(string directorySeparator);
        void Validate(string directorySeparator);
        void Validate(string directorySeparator, string argumentName);
        void ValidateWindows(string directorySeparator);
        void ValidateWindows(string directorySeparator, string argumentName);
        void ValidateNonWindows(string directorySeparator);
        void ValidateNonWindows(string directorySeparator, string argumentName);
        bool IsDirectorySeparator(string possibleDirectorySeparator);
        bool IsDirectorySeparator(string value, string possibleDirectorySeparator);
        bool IsWindowsDirectorySeparator(string directorySeparator);
        bool IsNonWindowsDirectorySeparator(string directorySeparator);

        char GetAlternateDirectorySeparatorUnchecked(char directorySeparator);
        char GetAlternateDirectorySeparator(char directorySeparator);

        string GetAlternateDirectorySeparatorUnchecked(string directorySeparator);
        string GetAlternateDirectorySeparator(string directorySeparator);

        bool TryDetectDirectorySeparator(string pathSegment, out string directorySeparator, string defaultDirectorySeparator);
        bool TryDetectDirectorySeparatorOrInvalid(string pathSegment, out string directorySeparator);
        bool TryDetectDirectorySeparatorOrDefault(string pathSegment, out string directorySeparator);
        bool TryDetectDirectorySeparator(string pathSegment, out string directorySeparator);
        string DetectDirectorySeparator(string pathSegment);
        string DetectDirectorySeparatorOrDefault(string pathSegment);
        string DetectDirectorySeparatorOrDefault(string pathSegment, string defaultDirectorySeparator);
        string DetectDirectorySeparatorOrWindows(string pathSegment);
        string DetectDirectorySeparatorOrNonWindows(string pathSegment);

        bool IsDirectorySeparatorDetected(string pathSegment);
        bool IsDirectorySeparatorDetectedUnchecked(string pathSegment, string directorySeparator);
        bool IsDirectorySeparatorDetected(string pathSegment, string directorySeparator);
        bool IsWindowsDirectorySeparatorDetected(string pathSegment);
        bool IsWindowsDirectorySeparatorDetectedAssumeWindows(string pathSegment);
        bool IsNonWindowsDirectorySeparatorDetected(string pathSegment);
        bool IsNonWindowsDirectorySeparatorDetectedAssumeNonWindows(string pathSegment);
        bool HasMixedDirectorySeparators(string pathSegment);
        bool ContainsDirectorySeparator(string pathSegment); // See bool IsDirectorySeparatorDetected(string pathSegment).
        bool ContainsDirectorySeparatorUnchecked(string pathSegment, string directorySeparator); // See bool IsDirectorySeparatorDetectedUnchecked(string pathSegment, string directorySeparator).
        bool ContainsDirectorySeparator(string pathSegment, string directorySeparator); // See bool IsDirectorySeparatorDetected(string pathSegment, string directorySeparator);
        bool ContainsWindowsDirectorySeparator(string pathSegment); // See bool IsWindowsDirectorySeparatorDetected(string pathSegment).
        bool ContainsNonWindowsDirectorySeparator(string pathSegment); // See bool IsNonWindowsDirectorySeparatorDetected(string pathSegment).
        bool ContainsMixedDirectorySeparator(string pathSegment); // bool HasMixedDirectorySeparators(string pathSegment).

        string GetInvalidDirectorySeparatorExceptionMessage(string invalidDirectorySeparator);
        Exception GetInvalidDirectorySeparatorException(string invalidDirectorySeparator);
        ArgumentException GetInvalidDirectorySeparatorArgumentException(string invalidDirectorySeparator, string parameterName);
        string GetWindowsDirectorySeparatorExpectedExceptionMessage(string notWindowsDirectorySeparator);
        Exception GetWindowsDirectorySeparatorExpectedException(string notWindowsDirectorySeparator);
        ArgumentException GetWindowsDirectorySeparatorExpectedArgumentException(string found, string parameterName);
        string GetNonWindowsDirectorySeparatorExpectedExceptionMessage(string notNonWindowsDirectorySeparator);
        Exception GetNonWindowsDirectorySeparatorExpectedException(string notNonWindowsDirectorySeparator);
        ArgumentException GetNonWindowsDirectorySeparatorExpectedArgumentException(string found, string parameterName);
    }
}
