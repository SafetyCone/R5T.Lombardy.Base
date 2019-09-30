using System;


namespace R5T.Lombardy
{
    public interface IStringlyTypedPathOperator
    {
        string CombineUnresolvedUnchecked(string directorySeparator, string pathPart1, string pathPart2);
        string CombineUnresolvedSimple(string directorySeparator, string pathPart1, string pathPart2);
        string CombineTwoUnresolved(string directorySeparator, string pathPart1, string pathPart2);
        string CombineUnresolved(string directorySeparator, params string[] paths);
        string CombineTwo(string directorySeparator, string pathPart1, string pathPart2);
        string CombineSpecifySeparator(string directorySeparator, params string[] paths);
        string CombineTwo(string pathPart1, string pathPart2);
        string Combine(params string[] paths);
    }
}
