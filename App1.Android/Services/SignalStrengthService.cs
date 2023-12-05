using System;
using static Android.Telephony.TelephonyCallback;



public class AndroidSignalStrengthService : ISignalStrengthService
{
    public event EventHandler<SignalStrengthChangedEventArgs> SignalStrengthChanged;

    private SignalStrengthListener listener;

    public AndroidSignalStrengthService()
    {
        listener = new SignalStrengthListener();
       // listener.SignalStrengthChanged += (s, e) =>
        {
        //    SignalStrengthChanged?.Invoke(this, new SignalStrengthChangedEventArgs { SignalStrength = e.SignalStrength });
        };

     
    }
}

