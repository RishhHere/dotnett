using Structure;
using System.Drawing;
namespace PaintApp;
public partial class Form1 : Form
{
    Structure.Point StartPoint;
    Structure.Point EndPoint;
    public Form1()
    {
        InitializeComponent();
        Paint += new System.Windows.Forms.PaintEventHandler(onPaint);
        MouseDown += new System.Windows.Forms.MouseEventHandler(onMouseDown);
        MouseUp += new System.Windows.Forms.MouseEventHandler(onMouseUp); 
    }
    public void onPaint(object sender, System.Windows.Forms.PaintEventArgs ev){
    }
    public void onMouseDown(object sender, System.Windows.Forms.MouseEventArgs ev){
        StartPoint=new Structure.Point(ev.X,ev.Y);
    }
    public void onMouseUp(object sender, System.Windows.Forms.MouseEventArgs ev){
        EndPoint=new Structure.Point(ev.X,ev.Y);
        Line l=new Line(StartPoint,EndPoint,"Black",13);
        Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255));
        Graphics g=this.CreateGraphics();
        g.DrawLine(pen,l.StartPoint.X, l.StartPoint.Y, l.EndPoint.X, l.EndPoint.Y);
    }
}
