namespace DiagramAnalysisTest
{/// <summary>
/// a rectangle is a typeof square in my domain
/// </summary>
    public class Rectangle:IShape
    {
        public virtual decimal Height { get; set; }
        public virtual decimal Width { get; set; }
        public virtual decimal Area => Height * Width;
    }
}
