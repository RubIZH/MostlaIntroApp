using UnityEngine;
using System.Collections;

public class RotateCamera : MonoBehaviour {

    public Vector3 rotation;
	// Use this for initialization
	void Start ()
    {
        
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + rotation);
        transform.position = transform.position + transform.forward * Input.GetAxis("Vertical") * 10f * Time.fixedDeltaTime;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + (transform.up * Input.GetAxis("Horizontal")));
            }
}
