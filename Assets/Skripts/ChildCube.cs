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

    public void OnMouseOver()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (hit.collider.TryGetComponent(out ChildCube _clickable))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    string name = gameObject.name;
                }
            }
        }
        clickable.Hit(transform.position);
        clickable.Hit(transform.position);
        clickable.Hit(transform.position);
        GameObject.Find(name).SetActive(false);
    }
}
