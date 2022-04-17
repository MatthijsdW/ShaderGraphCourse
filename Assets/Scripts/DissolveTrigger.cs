using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveTrigger : MonoBehaviour
{
    public SkinnedMeshRenderer meshRenderer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            meshRenderer.material.SetFloat("Vector1_64b39fc03e0c4484add516ebc45180ce", Time.time);
        }
    }
}
