using UnityEngine;

public class Trigger_Kontrol : MonoBehaviour
{
    public bool IsPlayerInside = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            IsPlayerInside = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            IsPlayerInside = false;
        }
    }
}
