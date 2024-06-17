using System;
using System.Text.RegularExpressions;

static class LogLine
{
    public static string Message(string logLine)
    {
        string[] delimitingStrings = {"[INFO]: ", "[WARNING]: ", "[ERROR]: ", "\\t", "\\r", "\\n"};
        string trimmedResult = logLine.Split(delimitingStrings, System.StringSplitOptions.RemoveEmptyEntries)[0].Trim();
        
        return trimmedResult;
    }

    public static string LogLevel(string logLine)
    {
        Regex pattern = new Regex("[A-Z]*");
        string trimmedResult = pattern.Match(logLine).NextMatch().ToString().ToLower();
        
        return trimmedResult;
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}

/*
Instructions
In this exercise you'll be processing log-lines.

Each log line is a string formatted as follows: "[<LEVEL>]: <MESSAGE>".

There are three different log levels:

INFO
WARNING
ERROR
You have three tasks, each of which will take a log line and ask you to do something with it.

1. Get message from a log line
Implement the (static) LogLine.Message() method to return a log line's message:

LogLine.Message("[ERROR]: Invalid operation")
// => "Invalid operation"
Any leading or trailing white space should be removed:

LogLine.Message("[WARNING]:  Disk almost full\r\n")
// => "Disk almost full"

2. Get log level from a log line
Implement the (static) LogLine.LogLevel() method to return a log line's log level, which should be returned in lowercase:

LogLine.LogLevel("[ERROR]: Invalid operation")
// => "error"

3. Reformat a log line
Implement the (static) LogLine.Reformat() method that reformats the log line, putting the message first and the log level after it in parentheses:

LogLine.Reformat("[INFO]: Operation completed")
// => "Operation completed (info)"
*/