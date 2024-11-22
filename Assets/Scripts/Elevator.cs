using KinematicCharacterController;
using System.Collections;
using UnityEngine;

public class Elevator : MonoBehaviour, IMoverController
{
    [SerializeField] PhysicsMover physicsMover;
    Vector3 originalPos;
    Vector3 upperPos;
    Vector3 targetPos;

    void Awake()
    {
        physicsMover.MoverController = this;
        originalPos = transform.position;
        upperPos = transform.position + Vector3.up * 7f;
        StartCoroutine(MoveCoroutine());
    }

    IEnumerator MoveCoroutine()
    {
        while (true)
        {
            targetPos = originalPos;
            yield return new WaitForSeconds(2f);
            targetPos = upperPos;
            yield return new WaitForSeconds(2f); 
        }
    }

    public void UpdateMovement(out Vector3 goalPosition, out Quaternion goalRotation, float deltaTime)
    {
        goalPosition = Vector3.MoveTowards(transform.position, targetPos, deltaTime * 5f);
        goalRotation = Quaternion.identity;
    }


}
