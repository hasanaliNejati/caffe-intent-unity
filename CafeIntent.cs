using UnityEngine;
using System.Collections;

public class CafeIntent : MonoBehaviour {



	//Modified by ALIyerEdon 
	//WebSite:https://cafebazaar.ir/developer/gamelof/
	//aliyeredonarbab@gmail.com
	//Iran Game Studio


	//Open app with cafe store 
	public void OpenAPP(string PackageName)
	{
		AndroidJavaClass intentClass = new AndroidJavaClass ("android.content.Intent");
		AndroidJavaObject intentObject = new AndroidJavaObject ("android.content.Intent");
		
		AndroidJavaClass uriClass = new AndroidJavaClass ("android.net.Uri");
		
		intentObject.Call<AndroidJavaObject> ("setAction", intentClass.GetStatic<string> ("ACTION_VIEW"));
		intentObject.Call<AndroidJavaObject> ("setData", uriClass.CallStatic<AndroidJavaObject> ("parse", "bazaar://details?id="+PackageName));
		intentObject.Call<AndroidJavaObject> ("setPackage", "com.farsitel.bazaar");
		
		AndroidJavaClass unity = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
		AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject> ("currentActivity");
		currentActivity.Call ("startActivity", intentObject);
	}
	public void OpenAPP()
	{
		OpenAPP(Application.identifier);
	}
	//like directly youre app in cafe store
	public void Like(string PackageName){
		AndroidJavaClass intentClass = new AndroidJavaClass ("android.content.Intent");
		AndroidJavaObject intentObject = new AndroidJavaObject ("android.content.Intent");
		
		AndroidJavaClass uriClass = new AndroidJavaClass ("android.net.Uri");
		
		intentObject.Call<AndroidJavaObject> ("setAction", intentClass.GetStatic<string> ("ACTION_EDIT"));
		intentObject.Call<AndroidJavaObject> ("setData", uriClass.CallStatic<AndroidJavaObject> ("parse", "bazaar://details?id="+PackageName));
		intentObject.Call<AndroidJavaObject> ("setPackage", "com.farsitel.bazaar");
		
		AndroidJavaClass unity = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
		AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject> ("currentActivity");
		currentActivity.Call ("startActivity", intentObject);
		
	}
	public void Like()
    {
		Like(Application.identifier);
    }

	//open developer products on cafe store
	public void OpenDeveloperWeb(string DeveloperName)
	{
		AndroidJavaClass intentClass = new AndroidJavaClass ("android.content.Intent");
		AndroidJavaObject intentObject = new AndroidJavaObject ("android.content.Intent");
		
		AndroidJavaClass uriClass = new AndroidJavaClass ("android.net.Uri");
		
		intentObject.Call<AndroidJavaObject> ("setAction", intentClass.GetStatic<string> ("ACTION_VIEW"));
		intentObject.Call<AndroidJavaObject> ("setData", uriClass.CallStatic<AndroidJavaObject> ("parse", "bazaar://collection?slug=by_author&aid="+DeveloperName));
		intentObject.Call<AndroidJavaObject> ("setPackage", "com.farsitel.bazaar");
		
		AndroidJavaClass unity = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
		AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject> ("currentActivity");
		currentActivity.Call ("startActivity", intentObject);
	}
}
