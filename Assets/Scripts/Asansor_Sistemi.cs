using UnityEngine;

public class Asansor_Sistemi : MonoBehaviour
{
    [Header("Referanslar")]

    public Camera playerCamera;
    public GameObject ButtonUpObj;
    public GameObject ButtonDownObj;

    [Header("Ayarlar")]

    public float InteractionDistance = 2f;
    public float MovementDistance = 20f;
    public float Speed = 3f;

    private Vector3 bottomFloor, topFloor, targetPosition; //Katlarýn pozisyon verileri
    private bool isAtTopFloor = false;

    void Start()
    {
        bottomFloor = transform.position; //Zemin konumu kaydý
        topFloor = bottomFloor + new Vector3(0, MovementDistance, 0);
        targetPosition = bottomFloor;
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Speed * Time.fixedDeltaTime);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            InteractiveControl();
        }
    }

    void InteractiveControl()
    {
        RaycastHit hit; //Temas verisi deposu

        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, InteractionDistance))
        {
            if (hit.transform.gameObject == ButtonUpObj && !isAtTopFloor)
            {
                targetPosition = topFloor;
                isAtTopFloor = true;
            }
            else if (hit.transform.gameObject == ButtonDownObj && isAtTopFloor)
            {
                targetPosition = bottomFloor;
                isAtTopFloor = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.SetParent(transform);

            Player_Hareketi player = other.GetComponent<Player_Hareketi>(); //Oyuncu scriptini çeker

            if (player != null) // Güvenlik kontrolü
            {
                player.value = -100f;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.SetParent(null);

            Player_Hareketi player = other.GetComponent<Player_Hareketi>();

            if (player != null)
            {
                player.value = -2f;
            }
        }
    }
}