using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        int colonIndex = logLine.IndexOf(':');
        
        if (colonIndex == -1) 
            return string.Empty;

        string message = logLine.Substring(colonIndex + 2);

        message = message.Trim();
        
        return message;
    }

    public static string LogLevel(string logLine)
    {
        int colonIndexStart = logLine.IndexOf('[');
        int colonIndexEnd = logLine.IndexOf(']');
        
        if (colonIndexStart == -1 ||  colonIndexEnd == -1) 
            return string.Empty;

        string message = logLine.Substring(colonIndexStart+1, colonIndexEnd - colonIndexStart - 1);

        message = message.Trim();
        
        return message.ToLower();
    }

    public static string Reformat(string logLine)
    {

         int colonIndexStart = logLine.IndexOf('[');
        int colonIndexEnd = logLine.IndexOf(']');
        
        if (colonIndexStart == -1 ||  colonIndexEnd == -1) 
            return string.Empty;

        string message = logLine.Substring(colonIndexStart+1, colonIndexEnd - colonIndexStart - 1);


        int colonIndex = logLine.IndexOf(':');
        
        if (colonIndex == -1) 
            return string.Empty;

        string message2 = logLine.Substring(colonIndex + 2);
        
        message = message.Trim().ToLower();
        
        return $"{message2.Trim()} ({message})";
        
    }
}
