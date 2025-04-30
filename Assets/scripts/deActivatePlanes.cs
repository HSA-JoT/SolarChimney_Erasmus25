using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class deActivatePlanes : MonoBehaviour
{

    bool on = true;
    [SerializeField]
    ARPlaneManager arp;

    public void run()
    {
        on = !on;  // Heut ist mal wieder Gegenteil-Tag
        GameObject[] gos = GameObject.FindGameObjectsWithTag("Plane");
        foreach (GameObject go in gos)
        {
            if (go.GetComponent<ARPlaneMeshVisualizer>() != null)
                go.GetComponent<ARPlaneMeshVisualizer>().enabled = on;
        }
    }
}
