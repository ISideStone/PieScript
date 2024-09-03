using Skender.Stock.Indicators;

namespace DevelopEnvironment.Abstract;


#pragma warning disable IDE1006 // Naming Styles
public class ManipulationLanguageModelAbstract
{
    public int LOOKBACK_PERIODS { get; set; }   //for documentation
    public static Candle[] candle { get; set; } = Array.Empty<Candle>();
    public static WebHookSource.TelegramBot? TelegramWebHookSource { get; private set; }

    /*PRICE TRENDS*/

    public static dynamic[] atrStop(int lookbackPeriods = 21, double multiplier = 3.0, EndType endType = EndType.Close) => throw new NotImplementedException();
    public static AroonResult[] aroon(int lookbackPeriods = 21) => throw new NotImplementedException();
    public static AdxResult[] adx(int lookbackPeriods = 21) => throw new NotImplementedException();
    public static ElderRayResult[] elderRay(int lookbackPeriods = 13) => throw new NotImplementedException();
    public static GatorResult[] gator() => throw new NotImplementedException();
    public static HurstResult[] hurst(int lookbackPeriods = 100) => throw new NotImplementedException();
    public static IchimokuResultValue[] ichimoku(int tenkanPeriods = 9, int kijunPeriods = 26, int senkouBPeriods = 52) => throw new NotImplementedException();
    public static MacdResult[] macd(int fastPeriods = 12, int slowPeriods = 26, int signalPeriods = 9) => throw new NotImplementedException();
    public static dynamic/*SuperTrendResult*/[] superTrend(int lookbackPeriods = 10, double multiplier = 3.0) => throw new NotImplementedException();
    public static VortexResult[] vortex(int lookbackPeriods = 11) => throw new NotImplementedException();
    public static AlligatorResult[] aligator(int jawPeriods = 13, int jawOffset = 8, int teethPeriods = 8, int teethOffset = 5, int lipsPeriods = 5, int lipsOffset = 3) => throw new NotImplementedException();

    /**/

    /*PRICE CHANNELS*/

    public static BollingerBandsResult[] bb(int lookbackPeriods = 20, double standardDeviations = 2.0) => throw new NotImplementedException();
    public static dynamic/*DonchianResult*/[] donchian(int lookbackPeriods = 20) => throw new NotImplementedException();
    public static dynamic/*FcbResult*/[] fcb(int windowSpan = 2) => throw new NotImplementedException();
    public static KeltnerResult[] kelther(int emaPeriods = 20, double multiplier = 2.0, int atrPeriods = 10) => throw new NotImplementedException();
    public static MaEnvelopeResult[] maEnvelop(int lookbackPeriods = 21, double percentOffset = 2.5, MaType movingAverageType = MaType.SMA) => throw new NotImplementedException();
    public static dynamic/*PivotPointsResult*/[] pivotPoints(PeriodSize windowSize = PeriodSize.OneHour, PivotPointType pointType = PivotPointType.Standard) => throw new NotImplementedException();
    public static dynamic/*RollingPivotsResult*/[] rollingPivot(int windowPeriods = 2, int offsetPeriods = 2, PivotPointType pointType = PivotPointType.Standard) => throw new NotImplementedException();
    public static StarcBandsResult[] starcBands(int smaPeriods, double multiplier = 2.0, int atrPeriods = 10) => throw new NotImplementedException();
    public static StdDevChannelsResult[] stdDevChannel(int lookbackPeriods = 20, double stdDeviations = 2.0) => throw new NotImplementedException();


    /**/


    /*OSCILLATORS*/

    public static AwesomeResult[] awesome(int fastPeriods = 5, int slowPeriods = 34) => throw new NotImplementedException();
    public static CmoResult[] cmo(int lookbackPeriods = 13) => throw new NotImplementedException();
    public static CciResult[] cci(int lookbackPeriods = 20) => throw new NotImplementedException();
    public static ConnorsRsiResult[] connorsRsi(int rsiPeriods = 3, int streakPeriods = 2, int rankPeriods = 100) => throw new NotImplementedException();
    public static DpoResult[] dpo(int lookbackPeriods = 11) => throw new NotImplementedException();
    public static StochResult[] stoch(int lookbackPeriods = 14, int signalPeriods = 3, int smoothPeriods = 3) => throw new NotImplementedException();
    public static RsiResult[] rsi(int lookbackPeriods = 14) => throw new NotImplementedException();
    public static StcResult[] stc(int cyclePeriods = 10, int fastPeriods = 23, int slowPeriods = 50) => throw new NotImplementedException();
    public static SmiResult[] smi(int lookbackPeriods = 13, int firstSmoothPeriods = 25, int secondSmoothPeriods = 2, int signalPeriods = 3) => throw new NotImplementedException();
    public static StochRsiResult[] stochRsi(int rsiPeriods = 14, int stochPeriods = 1, int signalPeriods = 3, int smoothPeriods = 1) => throw new NotImplementedException();
    public static TrixResult[] trix(int lookbackPeriods = 13, int? signalPeriods = null) => throw new NotImplementedException();
    public static WilliamsResult[] williams(int lookbackPeriods = 14) => throw new NotImplementedException();

    /**/


    /*STOP AND REVERSE*/

    public static ChandelierResult[] chandelier(int lookbackPeriods = 22, double multiplier = 3.0, ChandelierType type = ChandelierType.Long) => throw new NotImplementedException();
    public static ParabolicSarResult[] parabolicSar(double accelerationStep = 0.02, double maxAccelerationFactor = 0.2) => throw new NotImplementedException();
    public static VolatilityStopResult[] volatilityStop(int lookbackPeriods = 7, double multiplier = 3.0) => throw new NotImplementedException();

    /**/


    /*OTHER PRICE PATTERNS*/

    public static dynamic/*PivotsResult*/[] pivots(int leftSpan = 2, int rightSpan = 2, int maxTrendPeriods = 20, EndType endType = EndType.HighLow) => throw new NotImplementedException();

    public static dynamic/*FractalResult*/[] fractal(int windowSpan = 2, EndType endType = EndType.HighLow) => throw new NotImplementedException();

    /**/


    /*VOLUME-BASED*/

    public static AdlResult[] adl(int? smaPeriods = null) => throw new NotImplementedException();
    public static CmfResult[] cmf(int lookbackPeriods = 20) => throw new NotImplementedException();
    public static ChaikinOscResult[] chaikinOsc(int fastPeriods = 3, int slowPeriods = 10) => throw new NotImplementedException();
    public static ForceIndexResult[] forceIndex(int lookbackPeriods = 2) => throw new NotImplementedException();
    public static KvoResult[] kvo(int fastPeriods = 34, int slowPeriods = 55, int signalPeriods = 13) => throw new NotImplementedException();
    public static MfiResult[] mfi(int lookbackPeriods = 14) => throw new NotImplementedException();
    public static ObvResult[] obv(int? smaPeriods = null) => throw new NotImplementedException();
    public static PvoResult[] pvo(int fastPeriods = 12, int slowPeriods = 26, int signalPeriods = 9) => throw new NotImplementedException();

    /**/

    /*MOVING AVERAGES*/
    public static AlmaResult[] alma(int lookbackPeriods = 9, double offset = 0.85, double sigma = 6.0) => throw new NotImplementedException();
    public static DemaResult[] dema(int lookbackPeriods = 9) => throw new NotImplementedException();
    public static EpmaResult[] epma(int lookbackPeriods = 9) => throw new NotImplementedException();
    public static EmaResult[] ema(int lookbackPeriods = 9) => throw new NotImplementedException();
    public static HtlResult[] htl() => throw new NotImplementedException();
    public static HmaResult[] hma(int lookbackPeriods = 11) => throw new NotImplementedException();
    public static KamaResult[] kama(int erPeriods = 10, int fastPeriods = 2, int slowPeriods = 30) => throw new NotImplementedException();
    public static MamaResult[] mama(double fastLimit = 0.5, double slowLimit = 0.05) => throw new NotImplementedException();
    public static DynamicResult[] dynamic(int lookbackPeriods = 11, double kFactor = 0.6) => throw new NotImplementedException();
    public static SmmaResult[] smma(int lookbackPeriods = 7) => throw new NotImplementedException();
    public static SmaResult[] sma(int lookbackPeriod = 7) => throw new NotImplementedException();
    public static T3Result[] t3(int lookbackPeriods = 5, double volumeFactor = 0.7) => throw new NotImplementedException();
    public static TemaResult[] tema(int lookbackPeriods = 5) => throw new NotImplementedException();
    public static VwapResult[] vwap() => throw new NotImplementedException();
    public static VwmaResult[] vwma(int lookbackPeriods = 7) => throw new NotImplementedException();
    public static WmaResult[] wma(int lookbackPeriods = 7) => throw new NotImplementedException();

    /**/


    /*PRICE CHARACTERISTICS*/
    public static AtrResult[] atr(int lookbackPeriods = 14) => throw new NotImplementedException();
    public static BopResult[] bop(int lookbackPeriods = 14) => throw new NotImplementedException();
    public static ChopResult[] chop(int lookbackPeriods = 14) => throw new NotImplementedException();
    public static StdDevResult[] stdDev(int lookbackPeriods = 14, int? smaPeriods = null) => throw new NotImplementedException();
    public static RocResult[] roc(int lookbackPeriods = 13, int? smaPeriods = null) => throw new NotImplementedException();
    public static PmoResult[] pmo(int timePeriods = 35, int smoothPeriods = 20, int signalPeriods = 10) => throw new NotImplementedException();
    public static RocWbResult[] rocWb(int lookbackPeriods, int emaPeriods, int stdDevPeriods) => throw new NotImplementedException();
    public static UlcerIndexResult[] ulcerIndex(int lookbackPeriods = 14) => throw new NotImplementedException();

    /**/

    public static void openPosition(PositionSide positionSide, double? takeProfit, double? stopLoss)
    {
        if (takeProfit == null)
            throw new NullReferenceException(nameof(takeProfit));
        if (stopLoss == null)
            throw new NullReferenceException(nameof(stopLoss));
    }

    public static void openPosition(PositionSide positionSide, double? takeProfit, int leverage)
    {
        if (takeProfit == null)
            throw new NullReferenceException(nameof(takeProfit));
    }

    public static void notify(string text)
    {
        TelegramWebHookSource = new WebHookSource.TelegramBot(0, text);
    }
}

#pragma warning restore IDE1006 // Naming Styles
