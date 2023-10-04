using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Portal next;
    public Transform spawnPoint;
    private Vector3 SpawnPoint => spawnPoint.position;
    private Quaternion SpawnRotation => this.transform.rotation;

    public static int PortalLayer => LayerMask.NameToLayer("Portal");

    public void Teleport(Transform requested, Portal invoker)
    {
        var nextPortal = invoker.next;

        var destination = nextPortal.SpawnPoint;
        var rotation = nextPortal.SpawnRotation;

        requested.position = destination;
        requested.rotation = rotation;
    }
}
