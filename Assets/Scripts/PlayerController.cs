using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float thrustMultiplier = 2000f;
    public float torqueMultiplier = 2000f;

    Rigidbody rb;
    Vector3 torque;
    float thrust;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        torque = new Vector3(Input.GetAxis("Vertical"), 0, -Input.GetAxis("Horizontal"));
    }

    void FixedUpdate()
    {
        // pitch and roll
        rb.AddRelativeTorque(torque * torqueMultiplier);

        // thrust
        thrust = thrustMultiplier * Time.fixedDeltaTime;
        thrust -= transform.forward.y * 3f;
        rb.AddRelativeForce(new Vector3(0, 0, thrust));
    }
}
