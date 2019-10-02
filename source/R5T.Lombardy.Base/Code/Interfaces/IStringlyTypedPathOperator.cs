using System;


namespace R5T.Lombardy
{
    public interface IStringlyTypedPathOperator
    {
        string CombineUnresolvedUnchecked(string directorySeparator, string pathSegment1, string pathSegment2);
        string CombineUnresolvedSimple(string directorySeparator, string pathSegment1, string pathSegment2);
        string CombineTwoUnresolved(string directorySeparator, string pathSegment1, string pathSegment2);
        string CombineUnresolved(string directorySeparator, params string[] paths);
        string CombineTwo(string directorySeparator, string pathSegment1, string pathSegment2);
        string CombineSpecifySeparator(string directorySeparator, params string[] paths);
        string CombineTwo(string pathSegment1, string pathSegment2);
        string Combine(params string[] paths);
    }
}
