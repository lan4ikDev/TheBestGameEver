using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenedeCaster : MonoBehaviour
{
    public Rigidbody grenadePrefab;
    public Transform grenedeSourceTransform;

    public float force = 500;
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            var grenede = Instantiate(grenadePrefab);
            grenede.transform.position = grenedeSourceTransform.position;
            grenede.GetComponent<Rigidbody>().AddForce(grenedeSourceTransform.forward * force);

        }
    }
}
