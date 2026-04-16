internal class QuadraticEquation : Nums
{
    // поля
    private float x1;
    private float x2;
    private float d;
    
    // конструкторы
    public QuadraticEquation() : base()
    {
        Discriminant();
        Solve();
    }

    public QuadraticEquation(int a, int b, int c) : base(a, b, c)
    {
        Discriminant();
        Solve();
    }

    public QuadraticEquation(QuadraticEquation other) : base(other.Num1, other.Num2, other.Num3)
    {
        Discriminant();
        Solve();
    }

    public QuadraticEquation(Nums other) : base(other)
    {
        Discriminant();
        Solve();
    }

    // свойства
    public float D
    {
        get { return d; }
    }
    public float X1
    {
        get { return x1; }
    }
    public float X2
    {
        get{ return x2; }
    }
    public float A
    {
        get { return Num1; }
    }
    public float B
    {
        get { return Num2; }
    }
    public float C
    {
        get { return Num3; }
    }

    // методы
    private void Discriminant()
    {
        this.d = B*B - 4 * A * C;
    }
    private void Solve()
    {
        if (D == 0)
        {
            x1 = -B/(2*A);
            x2 = x1;
        }
        else if (D < 0)
        {
            x1 = float.NaN;
            x2 = float.NaN;
        }
        else
        {
            x1 = (-B + float.Sqrt(D)) / (2 * A);
            x2 = (-B - float.Sqrt(D)) / (2 * A);
        }        
    }

    public string PrintAnsver()
    {
        if (D>0)
        {
            return X1 + ", " + X2;
        }
        else
        {
            return "дискриминант < 0, нет решений в действительных числах";
        }
    }
    public override string ToString()
    {
        string s = "";
        if (A!=0)
        {
            s+= A + "x^2";
        }
        if (B != 0)
        {
            if (B > 0)
            {
                s += "+" + B + "x";
            }
            else
            {
                s += B + "x";
            }
        }

        if (C != 0)
        {
            if (C > 0)
            {
                s += "+" + C;
            }
            else
            {
                s += C;
            }
        }

        return s;
    }
}
