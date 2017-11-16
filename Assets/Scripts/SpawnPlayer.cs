using BeardedManStudios.Forge.Networking.Unity;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    void Start()
    {
        //Spawn a player when the scene loads
        NetworkManager.Instance.InstantiateVRPlayer();
    }
}
