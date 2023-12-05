// En tu módulo compartido
using System;

public interface ISignalStrengthService
{
    event EventHandler<SignalStrengthChangedEventArgs> SignalStrengthChanged;
}

public class SignalStrengthChangedEventArgs : EventArgs
{
    public int SignalStrength { get; set; }
}
