using UnityEngine;
using System.Collections;

public class ShootingController : MonoBehaviour {

    public Gun gun;

    // Update is called once per frame
    void Update () {
        float isFired = Input.GetAxis("Fire1");
        if (isFired > 0 && gun.isReadyToShoot())
            gun.Fire();
    }
}
