using System;
using System.Text.RegularExpressions;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimiter){
        int startingIndex = str.IndexOf(delimiter) + delimiter.Length;
      
        return str.Substring(startingIndex, str.Length - startingIndex);
    }

    public static string SubstringBetween(this string str, string delimiter1, string delimiter2){
        int startingIndex = str.IndexOf(delimiter1) + delimiter1.Length;
        int endingIndex = str.IndexOf(delimiter2);

        return str.Substring(startingIndex, endingIndex - startingIndex);
    }
    
    public static string Message(this string str){
        string[] delimitingStrings = {"[INFO]: ", "[WARNING]: ", "[ERROR]: ", "\\t", "\\r", "\\n"};
        string trimmedResult = str.Split(delimitingStrings, System.StringSplitOptions.RemoveEmptyEntries)[0].Trim();

        return trimmedResult;
    }

    public static string LogLevel(this string str){
        Regex pattern = new Regex("[A-Z]*");
        string trimmedResult = pattern.Match(str).NextMatch().ToString();

        return trimmedResult;
    }
}