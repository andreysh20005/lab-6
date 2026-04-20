using System;

internal class Time
{
    private byte _hours;
    private byte _minutes;

    public Time(int hours, int minutes)
    {
        int totalMinutes = hours * 60 + minutes;
        totalMinutes %= 1440;
        if (totalMinutes < 0)
        {
            totalMinutes += 1440;
        }

        this._hours = (byte)(totalMinutes / 60);
        this._minutes = (byte)(totalMinutes % 60);
    }

    public Time()
    {
        this._hours = 0;
        this._minutes = 0;
    }

    public byte Hours
    {
        get { return _hours; }
        set
        {
            if (value >= 0 && value < 24)
            {
                _hours = value;
            }
        }
    }

    public byte Minutes
    {
        get { return _minutes; }
            set
        {
            if (value < 0 || value >= 60)
            {
                
            }
            _minutes = value;
        }
        
    }

    public static Time Input()
    {
        Console.WriteLine("введите часы:");
        bool ok1 = int.TryParse(Console.ReadLine(), out int h1);
        if (!ok1)
        {
            throw new FormatException("не удалось разобрать часы");
        }
        Console.WriteLine("введите минуты:");
        bool ok2 = int.TryParse(Console.ReadLine(), out int m1);
        if (!ok2)
        {
            throw new FormatException("Не удалось разобрать минуты");
        }
        Time manual1 = new Time(h1, m1);

        
        return manual1;
    }

    public static Time operator -(Time t1, Time t2)
    {
        int total1 = t1._hours * 60 + t1._minutes;
        int total2 = t2._hours * 60 + t2._minutes;

        int diff = total1 - total2;

        return new Time(0, diff);
    }

    public static Time operator ++(Time t)
    {
        return new Time(t._hours, t._minutes + 1);
    }

    public static Time operator --(Time t)
    {
        return new Time(t._hours, t._minutes - 1);
    }

    public static implicit operator int(Time t)
    {
        return t._hours * 60 + t._minutes;
    }

    public static explicit operator bool(Time t)
    {
        if (t._hours == 0 && t._minutes == 0)
        {
            return false;
        }
        return true;
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
        return _hours.ToString("D2") + ":" + _minutes.ToString("D2");
    }
}