using UCSImporter.Domain.Exceptions;

namespace UCSImporter.Domain.ValueTypes;

public class ChartId
{
    private readonly int _id;

    private ChartId(int idInt)
    {
        _id = idInt;
    }

    public override string ToString()
    {
        return _id.ToString();
    }

    public static implicit operator ChartId(int idInt)
    {
        return From(idInt);
    }

    public static implicit operator int(ChartId value)
    {
        return value._id;
    }

    public static bool operator ==(ChartId v1, ChartId v2)
    {
        return v1.Equals(v2);
    }

    public static bool operator !=(ChartId v1, ChartId v2)
    {
        return !v1.Equals(v2);
    }

    public override bool Equals(object? obj)
    {
        switch (obj)
        {
            case ChartId other:
                return Equals(other);
            default:
                return false;
        }
    }

    public static bool TryParse(int idInt, out ChartId? result)
    {
        try
        {
            result = From(idInt);
            return true;
        }
        catch
        {
            result = default;
            return false;
        }
    }


    private bool Equals(ChartId otherParam)
    {
        return _id == otherParam._id;
    }

    public override int GetHashCode()
    {
        return _id.GetHashCode();
    }

    public static ChartId From(int id)
    {
        return id switch
        {
            < 1 => throw new InvalidChartIdException("ID must be greater than 0"),
            _ => new ChartId(id)
        };
    }
}