namespace DesignPatterns.Patterns.Structural.Bridge;

public interface IDevice
{
    public bool IsOn();
    public void TurnOn();
    public void TurnOff();
    public void SetVolume(int volume);
    public int GetVolume();
}