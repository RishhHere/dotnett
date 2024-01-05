namespace Structure;
public abstract class Shape{
    public abstract void Draw();
    public string Color{get; set;}
    public int Width{get; set;}
    public Shape(){
        this.Color = "black";
        this.Width = 4;
    }
    public Shape(string Color, int Width){
        this.Color = Color;
        this.Width = Width;
    }
    public override string ToString(){
        return "Width = " + this.Width + " Color is = " + this.Color;
    }
}
