package md57f9fa05f81ea3b9553fc237aa1b40da0;


public class OpenMap_Android
	extends md5d4dd78677dce656d5db26c85a3743ef3.FormsApplicationActivity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Countries.Droid.OpenMap_Android, Countries.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OpenMap_Android.class, __md_methods);
	}


	public OpenMap_Android () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OpenMap_Android.class)
			mono.android.TypeManager.Activate ("Countries.Droid.OpenMap_Android, Countries.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	java.util.ArrayList refList;
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
