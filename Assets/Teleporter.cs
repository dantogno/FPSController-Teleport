using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Teleporter : MonoBehaviour
{
    [SerializeField]
    private Transform destination;

    private RigidbodyFirstPersonController playerController;
    // Start is called before the first frame update
    void Start()
    {
        // assuming there is only one of these in a scene!
        playerController = FindObjectOfType<RigidbodyFirstPersonController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        TeleportPlayerToDestination();
        Debug.Log("Entered Trigger");
    }

    private void TeleportPlayerToDestination()
    {
        playerController.enabled = false;
        playerController.transform.position = destination.position;
        playerController.enabled = true;
    }
}
