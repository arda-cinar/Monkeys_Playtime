using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    private bool isFwd;
    private bool isBack;
    private bool isRight;
    private bool isLeft;
    public float speed;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            isFwd = true;
        }
        else { isFwd = false;}

        if (Input.GetKey(KeyCode.S))
        {
            isBack = true;
        }
        else { isBack = false; }

        if (Input.GetKey(KeyCode.D))
        {
            isRight = true;
        }
        else { isRight = false; }

        if (Input.GetKey(KeyCode.A))
        {
            isLeft = true;
        }
        else { isLeft = false; }
    }

    private void FixedUpdate()
    {
        var direction = Vector3.zero;

        if (isFwd)
        { 
            direction += Vector3.forward;
        }

        if (isBack)
        {
            direction += Vector3.back;
        }

        if (isRight)
        {
            direction += Vector3.right;
        }

        if (isLeft)
        {
            direction += Vector3.left;
        }

        rb.linearVelocity = direction.normalized * speed * Time.fixedDeltaTime;
    }
}
