using UnityEngine;

public class CandleController : MonoBehaviour
{
    [Header("キャンドルに付ける火")]
    [SerializeField] private GameObject fire = null;

    private void Start()
    {
        if (fire == null)
        {
            Debug.LogError("Fireがnullです！");
        }
        else
        {
            fire.SetActive(false);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Lighter") && FireManager.Instance.isFire)
        {
            fire.SetActive(true);
        }
    }
}
