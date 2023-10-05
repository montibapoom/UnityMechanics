using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Portal connectedPortal;
    public Transform spawnPoint;
    private Vector3 SpawnPoint => spawnPoint.position;
    private Quaternion SpawnRotation => this.transform.rotation;

    public static int PortalLayer => LayerMask.NameToLayer("Portal");

    public void Teleport(Transform requested)
    {
        var destination = connectedPortal.SpawnPoint;
        var rotation = connectedPortal.SpawnRotation;

        requested.position = destination;
        requested.rotation = rotation;
    }
}
