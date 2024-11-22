using UnityEngine;

public class ElevatorButton : MonoBehaviour, IInteractable
{
    public int floorNumber;

    public void Interact()
    {
        FindAnyObjectByType<Elevator>().GotoFloor(floorNumber);
    }
}
