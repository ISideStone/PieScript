using Skender.Stock.Indicators;

namespace DevelopEnvironment;

public sealed class IchimokuResultValue : ResultBase
{
    public double? TenkanSen { get; set; }

    public double? KijunSen { get; set; }

    public double? SenkouSpanA { get; set; }

    public double? SenkouSpanB { get; set; }

    public double? ChikouSpan { get; set; }

    public IchimokuResultValue(DateTime date)
    {
        base.Date = date;
    }
}