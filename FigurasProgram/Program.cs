public abstract class Figura
{
    protected string? color;
    protected int l, a, x, y;
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
    public Rectangulo(int l, int a, string color, int x, int y)
        :base(l,a,color,x,y)
    {

    }
    public override float Area(){return l*a;}
    public override void Dibuja()
    {
        Console.WriteLine($"Se dibuja un rectángulo en las coordenadas [{x},{y}]");
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
    public override float Area(){return MathF.PI*MathF.Pow(((diametro)/4),2);}
    public override void Dibuja()
    {
        Console.WriteLine($"Se dibuja un círculo en las coordenadas [{x},{y}]");
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
    public override float Area(){return (bas*altura)/2;}
    public override void Dibuja()
    {
        Console.WriteLine($"Se dibuja un triángulo en las coordenadas [{x},{y}]");
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        Rectangulo r1 = new Rectangulo(25,15,"azul",25,15);
        Triangulo t1 = new Triangulo(14,25,"verde",15,15,65,25);
        Circulo c1 = new Circulo(25,15,"negro",15,48,15);
        
        t1.Dibuja();
        Console.WriteLine($"el area es {t1.Area()}\n");
        c1.Dibuja();
        Console.WriteLine($"el area es {c1.Area()}\n");
        r1.Dibuja();
        Console.WriteLine($"el area es {r1.Area()}\n");
    }
}