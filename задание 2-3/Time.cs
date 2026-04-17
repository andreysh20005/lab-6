internal class Time
{
    private byte _hours;
    private byte _minutes;


    public Time(byte hours, byte minutes)
    {
        int total = hours * 60 + minutes;
        total %= 24 * 60;
        this._hours = (byte)(total / 60);
        this._minutes = (byte)(total % 60);
    }

    public Time()
    {
        this._hours = 0;
        this._minutes = 0;
    }

    public byte Hours
    {
        get 
        {
            return _hours;
        }
        private set 
        {
            _hours = value;
        }
    }

    public byte Minutes
    {
        get 
        {
            return _minutes;
        }
        private set 
        {
            _minutes = value;
        }
    }


    public static Time operator -(Time t1, Time t2)
    {
        int total1 = t1._hours * 60 + t1._minutes;
        int total2 = t2._hours * 60 + t2._minutes;
        int diff = Math.Abs(total1 - total2);
        byte hoursDiff = (byte)(diff / 60);
        byte minutesDiff = (byte)(diff % 60);
        return new Time(hoursDiff, minutesDiff);
    }
    public static Time operator ++(Time t)
    {
        int total = t._hours * 60 + t._minutes + 1;
        total %= 24 * 60;
        return new Time((byte)(total / 60), (byte)(total % 60));
    }

    public static Time operator --(Time t)
    {
        int total = t._hours * 60 + t._minutes - 1;
        total %= 24 * 60;
        if (total < 0) total += 24 * 60;
        return new Time((byte)(total / 60), (byte)(total % 60));
    }

    public static implicit operator int(Time t)
    {
        return t._hours * 60 + t._minutes;
    }

    public static explicit operator bool(Time t)
    {
        return t._hours != 0 || t._minutes != 0;
    }

    public static bool operator <(Time t1, Time t2)
    {
        return (int)t1 < (int)t2;
    }

    public static bool operator >(Time t1, Time t2)
    {
        return (int)t1 > (int)t2;
    }
    public override string ToString()
    {
        return $"{Hours}:{Minutes}";
    }
}