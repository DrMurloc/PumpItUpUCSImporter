using UCSImporter.Domain.Exceptions;

namespace UCSImporter.Domain.ValueTypes;

public readonly struct Message
{
    private readonly string _message;

    private Message(string messageString)
    {
        _message = messageString;
    }

    public override string ToString()
    {
        return _message;
    }

    public static implicit operator Message(string messageString)
    {
        return From(messageString);
    }

    public static implicit operator string(Message value)
    {
        return value._message;
    }

    public static bool operator ==(Message v1, Message v2)
    {
        return v1.equals(v2);
    }

    public static bool operator !=(Message v1, Message v2)
    {
        return !v1.equals(v2);
    }

    public override bool Equals(object? obj)
    {
        switch (obj)
        {
            case Message other:
                return equals(other);
            default:
                return false;
        }
    }

    public static bool TryParse(string messageString, out Message? result)
    {
        try
        {
            result = From(messageString);
            return true;
        }
        catch
        {
            result = default;
            return false;
        }
    }

    private bool equals(Message otherParam)
    {
        return string.Equals(_message, otherParam._message, StringComparison.OrdinalIgnoreCase);
    }

    public override int GetHashCode()
    {
        return _message.ToLower().GetHashCode();
    }

    public static Message From(string messageParameterParam)
    {
        if (messageParameterParam == null) throw new InvalidMessageException("Message was null.");

        if (string.IsNullOrWhiteSpace(messageParameterParam)) throw new InvalidMessageException("Message was empty.");

        return new Message(messageParameterParam.Trim().Replace("\r", ""));
    }
}