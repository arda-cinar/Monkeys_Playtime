using UnityEngine;

public class Player_Hareketi : MonoBehaviour
{
    private CharacterController controller;

    public float speed = 8f;
    public float gravity = -9.81f * 3;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;  //küre yarýçapý
    public LayerMask groundMask;        //atanan Layer'larýn kimliði

    Vector3 velocity;

    bool isGrounded;
    
    bool isMoving;
    private Vector3 lastPosition = new Vector3(0f, 0f, 0f); //Hareket hafýzasý

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); //küre hacminde tarama

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // Düþüþü Sýfýrla
        }



        float x = Input.GetAxis("Horizontal"); //A-D
        float z = Input.GetAxis("Vertical");  //W-S

        Vector3 move = transform.right * x + transform.forward * z; // Yerel Yön



        if (move.magnitude > 1)
        {
            move.Normalize(); //Çapraz Hýzlanma
        }



        controller.Move(move * speed * Time.deltaTime); // Hareketi Uygulama



        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity); // Zýplama Hýzý
        }



        velocity.y += gravity * Time.deltaTime; // Yerçekimi Ývmesi

        controller.Move(velocity * Time.deltaTime); // Yerçekimini Uygulama



        if (lastPosition != gameObject.transform.position && isGrounded == true) //ses/animasyon
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        lastPosition = gameObject.transform.position; //Hafýzayý güncelle
    }

}
