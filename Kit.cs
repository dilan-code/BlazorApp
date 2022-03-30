using System;
using System.Collections.Generic;

public static class Kit
{
    private static List<string> logs = new List<string>();

    public static void Log(string value = "##")
    {
        logs.Add(value);
    }

    public static List<string> GetLog()
    {
        return logs;
    }

    public static void ClearLog()
    {
        logs.Clear();
    }

    public static Int32 UnixEpoch()
    {
        return (Int32)(DateTime.UtcNow - DateTime.UnixEpoch).TotalSeconds;
    }
}
