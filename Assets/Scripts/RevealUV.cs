using UnityEngine;

public class RevealUV : MonoBehaviour
{
    public MeshRenderer codeMesh;
    private MyCharacterController myCharacter;

    private void Start()
    {
        myCharacter = FindAnyObjectByType<MyCharacterController>();
    }

    private void Update()
    {
        if (!myCharacter.hasFlashlight)
        {
            return;
        }

        codeMesh.material.SetVector("_LightPos", transform.position);
        codeMesh.material.SetVector("_LightDir", transform.forward);
        codeMesh.material.SetFloat("_LightAngle", Mathf.Deg2Rad * 30f);
    }
}
