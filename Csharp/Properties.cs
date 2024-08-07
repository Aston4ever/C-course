namespace Csharp;

public class Properties {
    private int length;
    private int height;
    //private int width;
    private int volume;

    public int FronSurface {
        get {
            return this.length * this.height;
        }
    }
    public Properties(int length, int width, int height) {
        this.length = length;
        this.height = height;
        this.Width = width;
    }
    public int Volume {
        get {
            return this.length * this.height * this.Width;
        }
        set {
            this.volume = value;
        }
    }
    public int Width { get; set; }
    public int Height {
        get {
            return height;
        }
        set {
            this.height = value;
        }
    }
    public void SetLength(int length) {
        if ( length <0 ) {
            throw new Exception( "Enter just positivew numbers" );
        }
        this.length = length;
    }

    public int GetLength() {
        return this.length;
    }

    public int GetVolume() {
        return this.length * this.height * this.Width;
    }
    public void DisplayInfo() {
        Console.WriteLine( $"Length is {length}, height is {height}. Width is {Width} and volume is {length*height*Width}" );
    }
}
