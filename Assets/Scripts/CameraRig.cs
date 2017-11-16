using UnityEngine;

public class CameraRig : MonoBehaviour {

    //Create a static reference so we can find it easily
    public static CameraRig instance;

    //Set the camera rig's components in the inspector
    public Transform headset, leftController, rightController;

    private void Awake()
    {
        //Assign the static reference
        instance = this;
    }
}
