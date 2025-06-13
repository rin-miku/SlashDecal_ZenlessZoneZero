using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

public class Decal : MonoBehaviour
{
    private DecalProjector decalProjector;
    private Material decalMaterial;

    private void Start()
    {
        decalProjector = GetComponent<DecalProjector>();
        decalMaterial = decalProjector.material;
    }  
}
