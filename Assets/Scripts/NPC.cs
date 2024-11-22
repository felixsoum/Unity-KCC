using System.Collections;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] Transform pos2;
    [SerializeField] Transform pos3;
    [SerializeField] Animator animator;
    Vector3 originalPos;

    private void Awake()
    {
        originalPos = transform.position;
        StartCoroutine(MoveCoroutine());
    }

    IEnumerator MoveCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);

            animator.SetBool("IsMoving", true);
            while (Vector3.Distance(transform.position, pos2.position) > 0.001f)
            {
                transform.position = Vector3.MoveTowards(transform.position, pos2.position, 2f * Time.deltaTime);
                yield return null;
            }

            animator.SetBool("IsMoving", false);
            yield return new WaitForSeconds(1f);
            animator.SetTrigger("Dance");
            yield return new WaitForSeconds(2f);

            animator.SetBool("IsMoving", true);
            while (Vector3.Distance(transform.position, pos3.position) > 0.001f)
            {
                transform.position = Vector3.MoveTowards(transform.position, pos3.position, 2f * Time.deltaTime);
                yield return null;
            }

            animator.SetBool("IsMoving", false);

            yield return new WaitForSeconds(1f);
            animator.SetTrigger("Dance");
            yield return new WaitForSeconds(2f);

            animator.SetBool("IsMoving", true);
            while (Vector3.Distance(transform.position, originalPos) > 0.001f)
            {
                transform.position = Vector3.MoveTowards(transform.position, originalPos, 2f * Time.deltaTime);
                yield return null;
            }

            animator.SetBool("IsMoving", false); 
        }
    }
}
