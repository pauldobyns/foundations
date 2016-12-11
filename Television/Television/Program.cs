// Class Exercise No. 1
// Rewrite TV Class, use properties instead of methods

class Television
{
    private int channel = 0;
    private int volume = 0;
    private bool isOn = false;

    public bool On
    {
        get
        {
            return isOn;
        }
        set
        {
            isOn = value;
            if (isOn)
            {
                isOn = true;
            }
            else
            {
                isOn = false;
            }
        }
    }

    public int Volume
    {
        get
        {
            return volume;
        }
        set
        {
            if (value >= 0 && value <= 100)
            {
                volume = value;
            }
        }
    }

    public int Channel
    {
        get
        {
            return channel;
        }
        set
        {
            if (value > 0 && value < 50)
            {
                channel = value;
            }
        }
    }
}

class pex1
{
    static void Main()
    {
        Television tv = new Television();

        if (tv.On == false)
        {
            tv.On = true;
        }

        tv.Channel = 3;

        tv.Volume++;
        tv.Volume++;
        tv.Volume++;
        tv.Volume--;

        tv.On = false;
    }
}