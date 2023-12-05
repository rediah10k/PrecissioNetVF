package crc64b685a0ffaec041a4;


public class SignalStrengthListener
	extends android.telephony.PhoneStateListener
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSignalStrengthsChanged:(Landroid/telephony/SignalStrength;)V:GetOnSignalStrengthsChanged_Landroid_telephony_SignalStrength_Handler\n" +
			"";
		mono.android.Runtime.register ("SignalStrengthListener, App1.Android", SignalStrengthListener.class, __md_methods);
	}


	public SignalStrengthListener ()
	{
		super ();
		if (getClass () == SignalStrengthListener.class) {
			mono.android.TypeManager.Activate ("SignalStrengthListener, App1.Android", "", this, new java.lang.Object[] {  });
		}
	}


	public SignalStrengthListener (java.util.concurrent.Executor p0)
	{
		super (p0);
		if (getClass () == SignalStrengthListener.class) {
			mono.android.TypeManager.Activate ("SignalStrengthListener, App1.Android", "Java.Util.Concurrent.IExecutor, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public void onSignalStrengthsChanged (android.telephony.SignalStrength p0)
	{
		n_onSignalStrengthsChanged (p0);
	}

	private native void n_onSignalStrengthsChanged (android.telephony.SignalStrength p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
