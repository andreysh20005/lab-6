internal class Time
{
    private byte hours;
    private byte minutes;


    public Time(byte hours, byte minutes)
    {
        int total = hours * 60 + minutes;
        total %= 24 * 60;
        this.hours = (byte)(total / 60);
        this.minutes = (byte)(total % 60);
    }

    public Time()
    {
        this.hours = 0;
        this.minutes = 0;
    }

    public byte Hours
    {
        get 
        {
            return hours;
        }
        private set 
        {
            hours = value;
        }
    }

    public byte Minutes
    {
        get 
        {
            return minutes;
        }
        private set 
        {
            minutes = value;
        }
    }


    public static Time operator -(Time t1, Time t2)
    {
        int total1 = t1.hours * 60 + t1.minutes;
        int total2 = t2.hours * 60 + t2.minutes;
        int diff = Math.Abs(total1 - total2);
        byte hoursDiff = (byte)(diff / 60);
        byte minutesDiff = (byte)(diff % 60);
        return new Time(hoursDiff, minutesDiff);
    }
    public static Time operator ++(Time t)
    {
        int total = t.hours * 60 + t.minutes + 1;
        total %= 24 * 60;
        return new Time((byte)(total / 60), (byte)(total % 60));
    }

    public static Time operator --(Time t)
    {
        int total = t.hours * 60 + t.minutes - 1;
        total %= 24 * 60;
        if (total < 0) total += 24 * 60;
        return new Time((byte)(total / 60), (byte)(total % 60));
    }

    public static implicit operator int(Time t)
    {
        return t.hours * 60 + t.minutes;
    }

    public static explicit operator bool(Time t)
    {
        return t.hours != 0 || t.minutes != 0;
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
        return $"{Hours}:{minutes}";
    }
}