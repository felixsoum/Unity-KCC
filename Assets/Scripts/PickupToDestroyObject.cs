using UnityEngine;

public class PickupToDestroyObject : MonoBehaviour, IInteractable
{
    public GameObject otherObjectToDestroy;

    public void Interact()
    {
        FindAnyObjectByType<MyCharacterController>();
        Destroy(otherObjectToDestroy);
        Destroy(gameObject);
    }
}
