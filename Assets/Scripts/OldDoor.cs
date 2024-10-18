using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldDoor : MonoBehaviour, IInteractable
{
    public GameObject door;

    public void Interact()
    {
        if (FindAnyObjectByType<MyPlayer>().HasOldKey && door != null)
        {
            Destroy(door);
        }
    }
}
