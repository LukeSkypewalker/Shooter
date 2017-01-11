using UnityEngine;
using System.Collections;
using System.Net;
using UnityEngine.Networking;

public class PlayerController : MonoBehaviour{

    public float moveSpeed = 10f;
    public float turnSpeed = 150f;
    public Gun gun;

	void Update ()
	{       
        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float forwardMove = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

	    transform.Rotate(0, turn, 0);
	    transform.Translate(0, 0, forwardMove);

	    float isFired = Input.GetAxis("Fire1");
        Debug.Log(isFired);
        if (isFired>0 && gun.isReadyToShoot())
            gun.Fire();
    }
}
