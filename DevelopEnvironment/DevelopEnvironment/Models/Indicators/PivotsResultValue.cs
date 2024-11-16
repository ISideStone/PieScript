
using Skender.Stock.Indicators;

public record PivotsResultValue
{
    public double? HighPoint { get; set; }
    public double? LowPoint { get; set; }
    public double? HighLine { get; set; }
    public double? LowLine { get; set; }
    public PivotTrend? HighTrend { get; set; }
    public PivotTrend? LowTrend { get; set; }
}