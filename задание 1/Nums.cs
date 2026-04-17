internal class Nums
{
    private int _num1;
    private int _num2;
    private int _num3;


    public Nums()
    {
        this._num1 = 0;
        this._num2 = 0;
        this._num3 = 0;
    }
    public Nums(int a, int b, int c)
    {
        this._num1 = a;
        this._num2 = b;
        this._num3 = c;
    }
    public Nums(Nums nums)
    {
        this._num1 = nums._num1;
        this._num2 = nums._num2;
        this._num3 = nums._num3;
    }


    public int Num1
    {
        get 
        {
            return _num1; 
        }
        private set 
        {
            _num1 = value; 
        }
    }
    public int Num2
    {
        get 
        {
            return _num2;
        }
        private set 
        {
            _num2 = value; 
        }
    }
    public int Num3
    {
        get 
        {
            return _num3;
        }
        private set 
        {
            _num3 = value;
        }
    }


    public int Multiply()
    {
        return Num1 * Num2 * this._num3;
    }
    public override string ToString()
    {
        return $"{this._num1}, {this._num2}, this.num3";
    }

}

