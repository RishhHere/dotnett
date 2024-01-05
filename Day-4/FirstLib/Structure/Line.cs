using Structure;
public class Line:Shape{
    public Point StartPoint{get;set;}
    public Point EndPoint{get;set;}
    public Line():base(){
        this.StartPoint = new Point(0,0);
        this.EndPoint = new Point(0,0);
    }
    public Line(Point StartPoint, Point EndPoint, string Color, int Width) : base(Color, Width) {
        this.StartPoint = StartPoint;
        this.EndPoint = EndPoint;
    }
    public override void Draw(){
        Console.WriteLine("Drawing....");
    }
    public override string  ToString(){
        return base.ToString() + this.StartPoint + " " + this.EndPoint;
    }
} 