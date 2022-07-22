using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaygroundRespawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    public GrapplingGun grappling;

    private void OnTriggerEnter (Collider other) {
        if (other.CompareTag("Player")) {


            grappling.StopGrapple();
            player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
        }
    }
}
