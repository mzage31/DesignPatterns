namespace DesignPatterns.Patterns.Structural.Bridge;

public class Tv : IDevice
{
    private bool _power;
    private int _volume;

    public Tv()
    {
        _power = false;
        _volume = 0;
    }
    public bool IsOn()
    {
        return _power;
    }

    public void TurnOn()
    {
        _power = true;
    }

    public void TurnOff()
    {
        _power = false;
    }

    public void SetVolume(int volume)
    {
        _volume = volume;
    }

    public int GetVolume()
    {
        return _volume;
    }
}