package md5513f0621fcf5eb0521a1d90b3f7b1439;


public class PdfDocumentRenderingAsyncTask
	extends android.os.AsyncTask
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_doInBackground:([Ljava/lang/Object;)Ljava/lang/Object;:GetDoInBackground_arrayLjava_lang_Object_Handler\n" +
			"n_onPostExecute:(Ljava/lang/Object;)V:GetOnPostExecute_Ljava_lang_Object_Handler\n" +
			"n_onCancelled:()V:GetOnCancelledHandler\n" +
			"n_onPreExecute:()V:GetOnPreExecuteHandler\n" +
			"";
		mono.android.Runtime.register ("Syncfusion.SfPdfViewer.XForms.Droid.PdfDocumentRenderingAsyncTask, Syncfusion.SfPdfViewer.XForms.Android, Version=15.4451.0.20, Culture=neutral, PublicKeyToken=null", PdfDocumentRenderingAsyncTask.class, __md_methods);
	}


	public PdfDocumentRenderingAsyncTask ()
	{
		super ();
		if (getClass () == PdfDocumentRenderingAsyncTask.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfPdfViewer.XForms.Droid.PdfDocumentRenderingAsyncTask, Syncfusion.SfPdfViewer.XForms.Android, Version=15.4451.0.20, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public PdfDocumentRenderingAsyncTask (md5513f0621fcf5eb0521a1d90b3f7b1439.ImageViewEx p0)
	{
		super ();
		if (getClass () == PdfDocumentRenderingAsyncTask.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfPdfViewer.XForms.Droid.PdfDocumentRenderingAsyncTask, Syncfusion.SfPdfViewer.XForms.Android, Version=15.4451.0.20, Culture=neutral, PublicKeyToken=null", "Syncfusion.SfPdfViewer.XForms.Droid.ImageViewEx, Syncfusion.SfPdfViewer.XForms.Android, Version=15.4451.0.20, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public java.lang.Object doInBackground (java.lang.Object[] p0)
	{
		return n_doInBackground (p0);
	}

	private native java.lang.Object n_doInBackground (java.lang.Object[] p0);


	public void onPostExecute (java.lang.Object p0)
	{
		n_onPostExecute (p0);
	}

	private native void n_onPostExecute (java.lang.Object p0);


	public void onCancelled ()
	{
		n_onCancelled ();
	}

	private native void n_onCancelled ();


	public void onPreExecute ()
	{
		n_onPreExecute ();
	}

	private native void n_onPreExecute ();

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
