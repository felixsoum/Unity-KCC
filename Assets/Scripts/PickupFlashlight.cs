using KinematicCharacterController.Examples;
using UnityEngine;

public class PickupFlashlight : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        var camera = FindAnyObjectByType<ExampleCharacterCamera>();
        camera.GetComponent<Light>().intensity = 1.0f;

        FindAnyObjectByType<MyCharacterController>().hasFlashlight = true;

        Destroy(gameObject);
    }
}
