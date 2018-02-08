using System;

public static class CustomLogger {

    public static LoggerType Type = LoggerType.UnityLogger;

    public static string currentLogString = string.Empty;

    public static void Log(string message, params Object[] args)
    {
        switch (Type)
        {
            case LoggerType.UnityLogger:
                UnityEngine.Debug.LogFormat(message,args);
                break;
            case LoggerType.ScreenLogger:
                currentLogString = currentLogString + Environment.NewLine + String.Format(message, args);
                UnityEngine.Debug.Log(currentLogString);
                break;
            default:
                UnityEngine.Debug.LogFormat(message, args);
                break;
        }
        
    }

}
public enum LoggerType {
    UnityLogger,
    ScreenLogger,
}
