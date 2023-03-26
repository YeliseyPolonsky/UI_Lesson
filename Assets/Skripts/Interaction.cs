using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{

    [SerializeField] private Camera _camera;
    [SerializeField] private GameObject _prefabCube;
    [SerializeField] private float _speed = 10;

    void Update()
    {

        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (hit.collider.TryGetComponent(out Clickable clickable))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        GameObject cub = Instantiate(_prefabCube);
                        cub.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-_speed, _speed), Random.Range(0, _speed), Random.Range(-_speed, _speed));
                    }
                    
                }
            }
        }

    }

}
