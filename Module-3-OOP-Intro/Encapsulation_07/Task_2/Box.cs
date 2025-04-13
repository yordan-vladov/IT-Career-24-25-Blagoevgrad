public class Box
{

    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {
        this.length = length;
        this.height = height;
        this.width = width;
    }

    public double Length
    {
        get => this.length;
        set
        {
            this.length = value;
        }
    }

    public double Width
    {
        get => this.width;
        set
        {
            this.width = value;
        }
    }

    public double Height
    {
        get => this.height;
        set
        {
            this.height = value;
        }
    }

    public double CalculateVolume()
    {
        return Length * Width * Height;
    }
}
