using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportableMan : MonoBehaviour
{
    private Collider[] portalCollidersBuffer = new Collider[1];

    public bool AlreadyTeleported { get; private set; }

    void Update()
    {
        DetectPortal();
    }

    private void DetectPortal()
    {
        var hits = Physics.OverlapSphereNonAlloc(this.transform.position, 2f, portalCollidersBuffer, 1 << Portal.PortalLayer);

        if (hits > 0)
        {
            if (!AlreadyTeleported)
            {
                var portal = portalCollidersBuffer[0].GetComponent<Portal>();

                portal.Teleport(this.transform, portal);
                AlreadyTeleported = true;
            }
        }
        else
        {
            AlreadyTeleported = false;
        }
    }
}
