using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMouseController : MonoBehaviour
{
    [Header("スクロール感度")]
    [SerializeField] private float scrollSensitivity = 1.0f;

    [Header("ノイズ除去")]
    [SerializeField] private float deadZone = 0.01f;

    [Header("判定時間（短いほどシビア）")]
    [SerializeField] private float windowTime = 0.2f;

    [Header("発火条件（回数）")]
    [SerializeField] private int minCount = 2;
    [SerializeField] private int maxCount = 5;

    [Header("発火時間")]
    [SerializeField] private float fireDuration = 3f;

    [Header("ライターのデータ")]
    [SerializeField] private LighterData lighterData = null;


    public Vector2 mousePosition = default;
    private Mouse mouse = null;

    private float timer = 0f;
    private int scrollCount = 0;

    private bool isFired = false;
    private float fireTimer = 0f;


    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel") * scrollSensitivity;

        mousePosition = Input.mousePosition;

        // スクロール検出
        if (Mathf.Abs(scroll) > deadZone)
        {
            scrollCount++;
            timer = 0f; // 入力あったらリセット
        }

        // 時間経過
        timer += Time.deltaTime;

        // 一定時間でリセット
        if (timer > windowTime)
        {
            scrollCount = 0;
        }

        Debug.Log($"Count: {scrollCount}");

        //  発火中
        if (isFired)
        {
            fireTimer += Time.deltaTime;

            if (fireTimer >= fireDuration)
            {
                isFired = false;
                fireTimer = 0f;
            }
            return;
        }

        // 発火判定
        if (scrollCount >= minCount && scrollCount <= maxCount)
        {
            OnFire();
            scrollCount = 0;
        }
    }

    void OnFire()
    {
        Debug.Log("発火！");
        isFired = true;
    }
}