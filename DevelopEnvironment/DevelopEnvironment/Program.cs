using DevelopEnvironment;
using static DevelopEnvironment.Abstract.ManipulationLanguageModelAbstract;

/**** CODE PLACE ****/

if (candle[0].Open < candle[0].Close)
{
    openPosition(PositionSide.BUY, candle[0].Close * 1.001, candle[0].Close * 0.999);
    notify($"Opened - LONG - position: Entry {candle[0].Close}, TP {candle[0].Close * 1.001}, SL {candle[0].Close * 0.999}");
}
else
{
    openPosition(PositionSide.SELL, candle[0].Close * 0.999, candle[0].Close * 1.001);
    notify($"Opened - SHORT - position: Entry {candle[0].Close}, TP {candle[0].Close * 0.999}, SL {candle[0].Close * 1.001}");
}
