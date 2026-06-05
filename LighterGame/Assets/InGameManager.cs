using UnityEngine;

public class InGameManager : MonoBehaviour
{
    private void Start()
    {
        // ゲーム開始時に、カーソルを変更する
        // リザルト画面に移った時にカーソルを元に戻す
        CursorManager.Instance.SetCursor(CursorEntry.CursorType.INGAME);
    }
}
