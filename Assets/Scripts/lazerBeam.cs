using UnityEngine;
using System.Collections;

public class lazerBeam : MonoBehaviour
{

	void Update () {
//        RaycastHit hit;

        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * 10f, Color.red, 0.01f);

        //bool result = Physics.Raycast(ray, out hit, 50f);
    }
}
