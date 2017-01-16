using UnityEngine;
using System.Collections;
using System.Net;
using UnityEngine.Networking;

public class MultiPlayerController : MonoBehaviour{

    public float moveSpeed = 10f;
    public float turnSpeed = 150f;
    public Gun gun;
    public string playerNumber;

	void Update ()
	{       
        float turn = Input.GetAxis("Horizontal" + playerNumber) * turnSpeed * Time.deltaTime;
        float forwardMove = Input.GetAxis("Vertical" + playerNumber) * moveSpeed * Time.deltaTime;

	    transform.Rotate(0, turn, 0);
	    transform.Translate(0, 0, forwardMove);

	    float isFired = Input.GetAxis("Fire1" + playerNumber);
        if (isFired>0 && gun.isReadyToShoot())
            gun.Fire();
    }
}
