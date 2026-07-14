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

    // マウスの位置
    public Vector2 mousePosition = default;

    private float timer = 0f;
    private int scrollCount = 0;
    private float fireTimer = 0f;

    // 前フレームでスクロールしていたか
    private bool wasScrolling = false;

    private void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel") * scrollSensitivity;

        mousePosition = Input.mousePosition;

        bool isScrolling = Mathf.Abs(scroll) > deadZone;

        // スクロール開始時だけカウント
        if (isScrolling && !wasScrolling)
        {
            scrollCount++;
            timer = 0f;

            Debug.Log($"スクロール回数 : {scrollCount}");
        }

        wasScrolling = isScrolling;

        // 入力が止まっている間だけ時間を進める
        if (!isScrolling)
        {
            timer += Time.deltaTime;
        }

        // 発火中
        if (FireManager.Instance.isFire)
        {
            fireTimer += Time.deltaTime;

            if (fireTimer >= fireDuration)
            {
                FireManager.Instance.isFire = false;
                fireTimer = 0f;
            }

            return;
        }

        // 一定時間スクロールが止まったら判定
        if (timer >= windowTime && scrollCount > 0)
        {
            if (scrollCount >= minCount && scrollCount <= maxCount)
            {
                Debug.Log("成功！");
                OnFire();
            }
            else
            {
                Debug.Log($"失敗 ({scrollCount}回)");
            }

            // リセット
            scrollCount = 0;
            timer = 0f;
        }
    }

    /// <summary>
    /// 発火判定した時の処理
    /// </summary>
    public void OnFire()
    {
        Debug.Log("🔥 発火！");
        FireManager.Instance.isFire = true;
    }
}