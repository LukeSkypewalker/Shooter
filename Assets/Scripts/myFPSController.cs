using UnityEngine;

public class myFPSController : MonoBehaviour {

    public float moveSpeed = 10f;
    public Gun gun;
    public string playerNumber;
    public float sensitivity = 5.0f;

    void Start () {
	    Cursor.lockState = CursorLockMode.Locked;
	}

    void Update()
    {
        float forwardMove = Input.GetAxis("Vertical" + playerNumber) * moveSpeed * Time.deltaTime;
        float strafe = Input.GetAxis("Horizontal" + playerNumber) * moveSpeed * Time.deltaTime;

        transform.Translate(strafe, 0, forwardMove);

        float isFired = Input.GetAxis("Fire1" + playerNumber);
        if (isFired > 0 && gun.isReadyToShoot())
            gun.Fire();

        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        Camera.main.transform.Rotate(-mouseY,0,0);
        this.transform.Rotate(0, mouseX, 0);
    }
}

