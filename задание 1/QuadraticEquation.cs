internal class QuadraticEquation : Nums
{

    private float _x1;
    private float _x2;
    private float _d;
    

    public QuadraticEquation() : base()
    {
        Solve();
    }

    public QuadraticEquation(int a, int b, int c) : 
        base(a, b, c)
    {
        Solve();
    }

    public QuadraticEquation(QuadraticEquation other) : 
        base(other.Num1, other.Num2, other.Num3)
    {
        Solve();
    }

    public QuadraticEquation(Nums other) : 
        base(other)
    {
        Solve();
    }


    public float D
    {
        get 
        { 
            return _d; 
        }
    }
    public float X1
    {
        get 
        { 
            return _x1;
        }
    }
    public float X2 
    {
        get
        { 
            return _x2; 
        }
    }
    public int A
    {
        get 
        { 
            return Num1; 
        }
        set
        {
            Num1 = value;
            Solve();
        }
    }
    public int B
    {
        get 
        {
            return Num2; 
        }
        set
        {
            Num2 = value;
            Solve();
        }
    }
    public int C
    {
        get 
        { 
            return Num3; 
        }
        set
        {
            Num3 = value;
            Solve();
        }
    }


    private void Discriminant()
    {
        this._d = B*B - 4 * A * C;
    }
    private void Solve()
    {
        Discriminant();
        if (A == 0)
        {
            if (B != 0)
            {
                _x1 = -C / B;
                
            }
            else
            {
                _x1 = 0;

            }
            _x2 = X1;
        }
        else
        if (D == 0)
        {
            _x1 = -B/(2*A);
            _x2 = _x1;
        }
        else if (D < 0)
        {
            _x1 = float.NaN;
            _x2 = float.NaN;
        }
        else
        {
            _x1 = (-B + float.Sqrt(D)) / (2 * A);
            _x2 = (-B - float.Sqrt(D)) / (2 * A);
        }        
    }

    public string PrintAnsver()
    {
        if (D>=0)
        {
            return $"x1 = {X1}, x2 = {X2}";
        }
        else
        {
            return "дискриминант < 0, " +
                "нет решений в действительных числах";
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
        if (s == "")
        {
            s = "0 = 0";
        }
        else
        {
            s += " = 0";
        }
        return s;
    }
}
