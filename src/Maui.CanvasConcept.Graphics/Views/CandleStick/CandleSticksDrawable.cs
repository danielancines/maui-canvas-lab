namespace Maui.CanvasConcept.Graphics.Views;

public sealed class CandleSticksDrawable : IDrawable
{
    List<CandleStick> _candleSticks = new();
    #region Public Methods
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        var x = 20;
        var y = 10;
        for (int i = 0; i < 10; i++)
        {
            canvas.FillColor = Colors.Green;
            canvas.FillRectangle(x, y, 20, 100);
            canvas.StrokeColor = Colors.Green;
            canvas.DrawRectangle(x, y, 20, 100);
            x += 30;
            y += Random.Shared.Next(5, 30);
        }
    }

    #endregion
}

public static class CanvasExtensions
{
    #region Public Methods

    public static void DrawCandle(this ICanvas canvas, CandleStick candleStick)
    {
        canvas.FillRectangle(10, 10, 20, candleStick.High - candleStick.Bottom);
    }

    #endregion
}

public sealed class CandleStick
{
    #region Constructor

    public CandleStick(float open, float close, float high, float bottom)
    {
        this.Open = open;
        this.Close = close;
        this.High = high;
        this.Bottom = bottom;
    }

    #endregion

    #region Properties

    public float Open { get; set; }
    public float Close { get; set; }
    public float High { get; set; }
    public float Bottom { get; set; }

    #endregion
}