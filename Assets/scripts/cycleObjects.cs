using UnityEditor;
using UnityEngine;


public class cycleObjects : MonoBehaviour
{
    
    [SerializeField]
    GameObject[] listOfChimneys;

    int currentCycleID = 0;
    GameObject currentCycleObject;

    public void next()
    {
        if (currentCycleObject != null)
            Destroy(currentCycleObject);
        currentCycleID = (currentCycleID + 1) % listOfChimneys.Length;
        currentCycleObject = Instantiate(listOfChimneys[currentCycleID]);
        GameObject marker = GameObject.FindGameObjectWithTag("Marker");
        if (marker != null)
        {
            currentCycleObject.transform.parent = marker.transform;
            currentCycleObject.transform.localRotation = Quaternion.identity;
            currentCycleObject.transform.localPosition = Vector3.zero;
        }
    }

}
