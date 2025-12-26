using UnityEngine;

public class Envanter_Yoneticisi : MonoBehaviour
{
    public static Envanter_Yoneticisi Instance;

    [Header("UI Objeleri")]
    public GameObject inventoryPanel;
    public GameObject flashlightIcon;
    public GameObject keyIcon;

    [Header("Drop Ayarlarý")]
    public GameObject keyPrefab;
    public GameObject flashlightPrefab;
    public Transform dropPoint;

    [Header("Etkileþim Ayarlarý")]
    public Camera playerCamera;
    public float interactionDistance = 5f;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        inventoryPanel.SetActive(false);
        keyIcon.SetActive(false);
        flashlightIcon.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            bool isOpen = !inventoryPanel.activeSelf;
            inventoryPanel.SetActive(isOpen);

            Cursor.lockState = isOpen ? CursorLockMode.None : CursorLockMode.Locked;
            Cursor.visible = isOpen;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, interactionDistance))
            {
                if (hit.transform.CompareTag("Key"))
                {
                    keyIcon.SetActive(true);
                    Destroy(hit.transform.gameObject);
                }
                else if (hit.transform.CompareTag("Flashlight"))
                {
                    flashlightIcon.SetActive(true);
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }

    // UI Buton Tetikleyicileri

    public void DropKey()
    {
        keyIcon.SetActive(false);
        Instantiate(keyPrefab, dropPoint.position, Quaternion.identity);
    }

    public void DropFlashlight()
    {
        flashlightIcon.SetActive(false);
        Instantiate(flashlightPrefab, dropPoint.position, Quaternion.identity);
    }
}