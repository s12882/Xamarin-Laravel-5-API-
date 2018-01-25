package md5853f2fa227842cb2d3ebe538aae508d0;


public class FormsWebViewBridge
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_InvokeAction:(Ljava/lang/String;)V:__export__\n" +
			"";
		mono.android.Runtime.register ("Xam.Plugin.WebView.Droid.FormsWebViewBridge, Xam.Plugin.WebView.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", FormsWebViewBridge.class, __md_methods);
	}


	public FormsWebViewBridge ()
	{
		super ();
		if (getClass () == FormsWebViewBridge.class)
			mono.android.TypeManager.Activate ("Xam.Plugin.WebView.Droid.FormsWebViewBridge, Xam.Plugin.WebView.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public FormsWebViewBridge (md5853f2fa227842cb2d3ebe538aae508d0.FormsWebViewRenderer p0)
	{
		super ();
		if (getClass () == FormsWebViewBridge.class)
			mono.android.TypeManager.Activate ("Xam.Plugin.WebView.Droid.FormsWebViewBridge, Xam.Plugin.WebView.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Xam.Plugin.WebView.Droid.FormsWebViewRenderer, Xam.Plugin.WebView.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}

	@android.webkit.JavascriptInterface

	public void invokeAction (java.lang.String p0)
	{
		n_InvokeAction (p0);
	}

	private native void n_InvokeAction (java.lang.String p0);

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
