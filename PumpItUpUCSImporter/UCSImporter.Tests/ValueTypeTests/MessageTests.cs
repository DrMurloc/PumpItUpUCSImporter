using UCSImporter.Domain.Exceptions;
using UCSImporter.Domain.ValueTypes;
using Xunit;

namespace UCSImporter.Tests.ValueTypeTests;

public sealed class MessageTests
{
    [Theory]
    [InlineData("")]
    [InlineData("    ")]
    [InlineData(null)]
    public void NullOrEmptyMessagesThrowsException(string message)
    {
        Assert.Throws<InvalidMessageException>(() => Message.From(message));
    }

    [Theory]
    [InlineData(" Message ")]
    public void ValidMessageHasWhitespaceTrimmed(string message)
    {
        var result = Message.From(message);
        Assert.Equal(message.Trim(), result);
    }

    [Theory]
    [InlineData("MeSsAgE")]
    public void MessageEqualityIgnoresCase(string message)
    {
        var upperCase = Message.From(message.ToUpper());
        var lowerCase = Message.From(message.ToLower());
        Assert.Equal(upperCase, lowerCase);
    }

    [Theory]
    [InlineData("Start\r\nMessage")]
    public void MessageStripsReturns(string message)
    {
        var result = Message.From(message);
        Assert.Equal(message.Replace("\r", ""), result);
    }
}