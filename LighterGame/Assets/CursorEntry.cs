using UnityEngine;

[System.Serializable]
public class CursorEntry
{
    public enum CursorType
    {
        NORMAL,
        INGAME
    }

    [Header("カーソルのタイプ")]
    [SerializeField] public CursorType cursorType = CursorType.NORMAL;

    [Header("カーソルの画像")]
    [SerializeField] public Texture2D cursorTexture = null;

    [Header("カーソル位置")]
    [SerializeField] public Vector2 cursorHotspot = new Vector2(0, 0);
}