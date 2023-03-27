public abstract class Figura
{
    private string? color;
    private int l, a, x, y;
    public Figura(int L,int A,string? color, int x, int y)
    {
        this.l = L;
        this.a = A;
        this.color = color;
        this.x = x;
        this.y = y;
    }
    public abstract float Area();
    public abstract void Dibuja();
}
public class Rectangulo
    :Figura
{
    public Rectangulo(int largo, int ancho, string color, int x, int y)
        :base(l,a,color,x,y)
    {

    }
    public override float Area(){return l*a;}
    public override void Dibuja()
    {
        Console.WriteLine("Se dibuja un rectángulo");
    }
}
public class Circulo
    :Figura
{
    private int diametro;
    public Circulo(int l, int a, string? color, int x, int y, int diametro)
        :base(l,a,color,x,y)
    {
        this.diametro = diametro;
    }
    public override float Area(){return MathF.Pow((MathF.PI*diametro)/2,2);}
    public override void Dibuja()
    {
        Console.WriteLine("Se dibuja un círculo");
    }
}
public class Triangulo
    :Figura
{
    private int bas, altura;
    public Triangulo(int l, int a, string? color, int x, int y, int bas, int altura)
        :base(l,a,color,x,y)
    {
        this.bas = bas;
        this.altura = altura;
    }
    public override float Area(){return (bas*altura)/2}
    public override void Dibuja()
    {
        Console.WriteLine("Se dibuja un triángulo");
    }
}