using KinematicCharacterController;
using UnityEngine;

public class Elevator : MonoBehaviour, IMoverController
{
    public Transform topTransform;
    Vector3 originalPosition;
    Vector3 targetPosition;

    void Start()
    {
        GetComponent<PhysicsMover>().MoverController = this;

        originalPosition = transform.position;
        targetPosition = originalPosition;
    }

    public void UpdateMovement(out Vector3 goalPosition, out Quaternion goalRotation, float deltaTime)
    {
        goalPosition = Vector3.MoveTowards(transform.position, targetPosition, 2 * deltaTime);
        goalRotation = Quaternion.identity;
    }

    internal void GotoFloor(int floorNumber)
    {
        if (floorNumber == 1)
        {
            targetPosition = originalPosition;
        }
        else // sinon c'est floor 2 certainement
        {
            targetPosition = topTransform.position;
        }
    }
}
