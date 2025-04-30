using System.Collections;
using System.IO;
using UnityEngine;

public class takeScreenshot : MonoBehaviour
{
    [SerializeField]
    GameObject[] Buttons;

    public IEnumerator CaptureScreen()
    {
        // Wait till the last possible moment before screen rendering to hide the UI
        yield return null;
        /*
        string myFileName = "Screenshot" + System.DateTime.Now.Hour + System.DateTime.Now.Minute + System.DateTime.Now.Second + ".png";
        ScreenCapture.CaptureScreenshot(myFileName);
        */

        foreach(GameObject go in Buttons) // turn off Buttons to avoid having them in the screenshot
            go.SetActive(false);

        // Wait for screen rendering to complete
        yield return new WaitForEndOfFrame();

        string fileName = GetAndroidExternalStoragePath() + "/screenshot_" + System.DateTime.Now.Ticks + ".png";
        Debug.Log("[Ario] "+ fileName);
        // Take screenshot
        var tex = ScreenCapture.CaptureScreenshotAsTexture();
        var bytes = tex.EncodeToPNG(); 
        File.WriteAllBytes(fileName, bytes);

        foreach(GameObject go in Buttons)
            go.SetActive(true);

    }


    public void snap()
    {
        StartCoroutine(CaptureScreen());
    }

    private string GetAndroidExternalStoragePath()
    {
        if (Application.platform != RuntimePlatform.Android)
            return Application.persistentDataPath;

        var jc = new AndroidJavaClass("android.os.Environment");
        var path = jc.CallStatic<AndroidJavaObject>("getExternalStoragePublicDirectory",
            jc.GetStatic<string>("DIRECTORY_DCIM"))
            .Call<string>("getAbsolutePath");
        return path;
    }

}
