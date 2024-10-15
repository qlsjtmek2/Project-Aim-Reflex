using System;

public class SuspiciousPlayerException : Exception
{
    public string SuspiciousAction { get; }
    public DateTime Timestamp { get; }

    public SuspiciousPlayerException(string suspiciousAction)
        : base($"플레이어의 의심스러운 활동이 감지되었습니다. {suspiciousAction}")
    {
        SuspiciousAction = suspiciousAction;
        Timestamp = DateTime.UtcNow;
    }

    public SuspiciousPlayerException(string suspiciousAction, string message)
        : base(message)
    {
        SuspiciousAction = suspiciousAction;
        Timestamp = DateTime.UtcNow;
    }

    public SuspiciousPlayerException(string suspiciousAction, string message, Exception innerException)
        : base(message, innerException)
    {
        SuspiciousAction = suspiciousAction;
        Timestamp = DateTime.UtcNow;
    }
}