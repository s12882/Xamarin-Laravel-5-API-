package md5853f2fa227842cb2d3ebe538aae508d0;


public class FormsWebViewChromeClient
	extends android.webkit.WebChromeClient
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Xam.Plugin.WebView.Droid.FormsWebViewChromeClient, Xam.Plugin.WebView.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", FormsWebViewChromeClient.class, __md_methods);
	}


	public FormsWebViewChromeClient ()
	{
		super ();
		if (getClass () == FormsWebViewChromeClient.class)
			mono.android.TypeManager.Activate ("Xam.Plugin.WebView.Droid.FormsWebViewChromeClient, Xam.Plugin.WebView.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public FormsWebViewChromeClient (md5853f2fa227842cb2d3ebe538aae508d0.FormsWebViewRenderer p0)
	{
		super ();
		if (getClass () == FormsWebViewChromeClient.class)
			mono.android.TypeManager.Activate ("Xam.Plugin.WebView.Droid.FormsWebViewChromeClient, Xam.Plugin.WebView.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Xam.Plugin.WebView.Droid.FormsWebViewRenderer, Xam.Plugin.WebView.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}

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
