using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCube : MonoBehaviour
{
    private Clickable clickable;
    private Camera _camera;
    

    private void Start()
    {
        clickable = GameObject.FindAnyObjectByType<Clickable>();
        _camera = GameObject.FindAnyObjectByType<Camera>();
    }

    public void LateUpdate()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (hit.collider.TryGetComponent(out ChildCube _clickable))
            {
                clickable.Hit(_clickable.gameObject.transform.position);
                Destroy(_clickable.gameObject);
            }
        }
    }
}
