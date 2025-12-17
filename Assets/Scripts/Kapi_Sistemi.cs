using UnityEngine;

public class Kapi_Sistemi : MonoBehaviour
{
    public Trigger_Kontrol triggerBox; // Trigger objesine eriþim
    private bool isOpen = false;
    private Quaternion targetRotation;

    private void Start()
    {
        targetRotation = Quaternion.Euler(0, 0, 0);
    }

    void Update()
    {
        if (triggerBox.IsPlayerInside && Input.GetKeyDown(KeyCode.E))
        {
            isOpen = !isOpen;

            if (isOpen)
            {
                targetRotation = Quaternion.Euler(0, -90, 0);
            }

            else
            {
                targetRotation = Quaternion.Euler(0, 0, 0);
            }

        }

        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, Time.deltaTime * 5f);
    }
}
