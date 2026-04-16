internal class Nums
{
    // поля
    private int num1;
    private int num2;
    private int num3;

    // конструкторы
    public Nums()
    {
        this.num1 = 0;
        this.num2 = 0;
        this.num3 = 0;
    }

    public Nums(int a, int b, int c)
    {
        this.num1 = a;
        this.num2 = b;
        this.num3 = c;
    }

    public Nums(Nums nums)
    {
        this.num1 = nums.num1;
        this.num2 = nums.num2;
        this.num3 = nums.num3;
    }

    // свойства
    public int Num1
    {
        get { return num1; }
        private set { num1 = value; }
    }
    public int Num2
    {
        get { return num2; }
        private set { num2 = value; }
    }
    public int Num3
    {
        get { return num3; }
        private set { num3 = value; }
    }
    // методы
    public int Multiply()
    {
        return Num1 * Num2 * this.num3;
    }
    // перегрузки
    public override string ToString()
    {
        return this.num1 + ", " + this.num2 + ", " + this.num3;
    }

}

