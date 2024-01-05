namespace Structure;
public class Point{
    public int X{get;set;}
    public int Y{get; set;}
    public Point(){
        this.X = 0;
        this.Y = 0;
    }
    public Point(int X, int Y) {
        this.X = X;
        this.Y = Y;
    }
    public override string ToString(){
        string x = string.Format(" X={0}, Y={1}", this.X, this.Y);
        return x;
    }
}