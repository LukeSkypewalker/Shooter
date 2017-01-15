using UnityEngine;

public class myFPSController : MonoBehaviour {

    public float moveSpeed = 10f;
    public Gun gun;
    public int playerNumber;
    public float sensitivity = 5.0f;

    void Start () {
	    Cursor.lockState = CursorLockMode.Locked;
	}

    void Update()
    {
        float forwardMove = Input.GetAxis("Vertical_p" + playerNumber) * moveSpeed * Time.deltaTime;
        float strafe = Input.GetAxis("Horizontal_p" + playerNumber) * moveSpeed * Time.deltaTime;

        transform.Translate(strafe, 0, forwardMove);

        float isFired = Input.GetAxis("Fire1_p" + playerNumber);
        if (isFired > 0 && gun.isReadyToShoot())
            gun.Fire();

        float mouseH = Input.GetAxis("Mouse X") * sensitivity;
        float mouseV = Input.GetAxis("Mouse Y") * sensitivity;

        Camera.main.transform.Rotate(-mouseV,0,0);
        this.transform.Rotate(0, mouseH, 0);

    }
}

