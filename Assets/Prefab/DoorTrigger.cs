using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator doorAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            doorAnimator.SetBool("PlayerInside", true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            doorAnimator.SetBool("PlayerInside", false);
    }
}