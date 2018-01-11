package md53a21ac63cd1f5d397f74a77844dbf16e;


public class ViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Com.Syncfusion.Autocomplete.ViewHolder, Syncfusion.SfAutoComplete.Android, Version=15.4451.0.20, Culture=neutral, PublicKeyToken=null", ViewHolder.class, __md_methods);
	}


	public ViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == ViewHolder.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Autocomplete.ViewHolder, Syncfusion.SfAutoComplete.Android, Version=15.4451.0.20, Culture=neutral, PublicKeyToken=null", "Android.Views.View, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
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
