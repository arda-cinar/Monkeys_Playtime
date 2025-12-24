using UnityEngine;

public class Kamera_Hareketi : MonoBehaviour
{
    [Header("Atama")]
    public Transform Player;

    [Header("Ayar")]
    public float mouseHassasiyeti = 100f;

    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseHassasiyeti * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseHassasiyeti * Time.deltaTime;

        xRotation -= mouseY; //Sol El (Ters)
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); //sýnýrlama
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // Çeviri / Yerel Eksen

        if (Player != null)
        {
            Player.Rotate(Vector3.up * mouseX); //Eksenel Dönüþ
        }
    }
}