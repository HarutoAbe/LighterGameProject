using System.Security.Cryptography;
using UnityEngine;

public class PlayerMouseController : MonoBehaviour
{
    private static float SCROLL_SENSITIVITY = -0.3f;

    private void Update()
    {
        float mouseScroll = Input.GetAxis("Mouse ScrollWheel");
        float speed = Mathf.Abs(mouseScroll);

        if (mouseScroll > SCROLL_SENSITIVITY)
        {
            
        }
    }
}
