using UnityEngine;

public class CandleController : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Lighter"))
        {
            // if‚ÅisFire‚ð
        }
    }
}
