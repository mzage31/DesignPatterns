namespace DesignPatterns.Patterns.Structural.Bridge;

public class RemoteControl
{
    protected readonly IDevice Device;

    public RemoteControl(IDevice device)
    {
        Device = device;
    }

    public void TogglePower()
    {
        if (Device.IsOn())
            Device.TurnOff();
        else
            Device.TurnOn();
    }

    public void VolumeUp()
    {
        Device.SetVolume(Device.GetVolume() + 10);
    }

    public void VolumeDown()
    {
        Device.SetVolume(Device.GetVolume() - 10);
    }
}