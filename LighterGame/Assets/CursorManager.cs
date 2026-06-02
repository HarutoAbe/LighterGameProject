using UnityEngine;

public class CursorManager : SingletonMonoBehaviour<CursorManager>
{
    [Header("LighterDataを設定")]
    [SerializeField] private LighterData lighterData = null;

    /// <summary>
    /// 設定したカーソルを適用させるmwそっど
    /// </summary>
    /// <param name="cursorType"></param>
    public void SetCursor(CursorEntry.CursorType cursorType)
    {
        // lighterDataのリストから、指定されたカーソルタイプに一致するエントリーを検索
        foreach (var entry in lighterData.lighterImage)
        {
            // 一致するカーソルタイプが見つかった場合、そのカーソルを設定してメソッドを終了
            if (entry.cursorType == cursorType)
            {
                Cursor.SetCursor(
                    entry.cursorTexture,
                    entry.cursorHotspot,
                    CursorMode.Auto
                );
                return;
            }
        }

        Debug.LogWarning("指定されたカーソルが見つかりません: " + cursorType);
    }
}