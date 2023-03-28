using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialManager : MonoBehaviour
{

    public Renderer RendererCube;
    public Renderer RendererShere;
    public Renderer RendererCilinder;

    public void SetMaterial(Material material) {
        RendererCube.material = material;
        RendererCilinder.material = material;
        RendererShere.material = material;
    }

}
