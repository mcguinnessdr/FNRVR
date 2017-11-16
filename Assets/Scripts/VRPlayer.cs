using BeardedManStudios.Forge.Networking.Generated;
using UnityEngine;

public class VRPlayer : VRPlayerBehavior {

    //Avatar
    public Transform head, leftHand, rightHand;

    void Update () {
        if (networkObject.IsOwner)
        {
            //Send the positions and rotations of the headset and controllers if we are the owner
            networkObject.HeadsetPosition = CameraRig.instance.headset.position;
            networkObject.HeadsetRotation = CameraRig.instance.headset.rotation;
            networkObject.LeftControllerPosition = CameraRig.instance.leftController.position;
            networkObject.LeftControllerRotation = CameraRig.instance.leftController.rotation;
            networkObject.RightControllerPosition = CameraRig.instance.rightController.position;
            networkObject.RightControllerRotation = CameraRig.instance.rightController.rotation;
        }

        //Read the positions and rotations of the headset and controllers
        head.position = networkObject.HeadsetPosition;
        head.rotation = networkObject.HeadsetRotation;
        leftHand.position = networkObject.LeftControllerPosition;
        leftHand.rotation = networkObject.LeftControllerRotation;
        rightHand.position = networkObject.RightControllerPosition;
        rightHand.rotation = networkObject.RightControllerRotation;
    }
}
