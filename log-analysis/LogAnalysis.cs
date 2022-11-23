using System;

public static class LogAnalysis
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string separator) => str.Split(separator)[1];
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string initialDelimiter, string finalDelimiter)
    => str.Split(finalDelimiter)[0].SubstringAfter(initialDelimiter);
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str) => str.SubstringAfter(": ");
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
}