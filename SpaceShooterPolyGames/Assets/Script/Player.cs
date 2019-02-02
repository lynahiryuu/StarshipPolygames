using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    float shipSpeed = 5.0f;
    [SerializeField]
    float turnSpeed = 3.0f;
    Rigidbody rigidBodyPlayer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ForwardMovement();
        RotationMovement();
        //transform.Translate(-transform.position.x * Input.GetAxis("Horizontal")* Time.deltaTime * shipSpeed, 0.0f, 0.0f);
	}

    void ForwardMovement()
    {
        //Forward est le pointeur qui pointe devant le vaisseau, c'est l'axe rouge dans l'editeur, permet de faire avancer le vaisseau
        transform.position += transform.forward * Input.GetAxis("Vertical") * Time.deltaTime * shipSpeed;
    }

    void RotationMovement()
    {
        float yaw = Input.GetAxis("Yaw") * shipSpeed * Time.deltaTime * turnSpeed;
        float pitch = Input.GetAxis("Pitch") * shipSpeed * Time.deltaTime * turnSpeed;
        float roll = Input.GetAxis("Roll") * shipSpeed * Time.deltaTime * turnSpeed;

        transform.Rotate(-pitch, yaw, -roll);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Asteroid" && collision.collider.enabled)
        {
            collision.collider.enabled = false;
            Destroy(collision.gameObject);
        }
    }
}
