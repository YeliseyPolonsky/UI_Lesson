using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialManager : MonoBehaviour
{

    public Renderer Renderer;

    public void SetMaterial(Material material) {
        Renderer.material = material;
    }

}
