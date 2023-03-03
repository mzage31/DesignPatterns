namespace DesignPatterns.Patterns.Structural.Bridge;

public class AdvancedRemoteControl : RemoteControl
{
    public AdvancedRemoteControl(IDevice device) : base(device)
    {
    }

    public void Mute()
    {
        Device.SetVolume(0);
    }
}