using System;
using UnityEngine;
using UnityEngine.UI;

public class UICursor : MonoBehaviour
{
    [Header("‰æ‘œ‚Æƒ}ƒEƒX‚Ì‚¸‚ê–hŽ~")]
    [SerializeField] private Vector2 offset = new Vector2(0, 0);
    private void Start()
    {
        VisibleCursor(AllGameManager.GameState.InGame);


    }

    private void Update()
    {
        transform.position = (Vector2)Input.mousePosition + offset;
    }

    public void VisibleCursor(AllGameManager.GameState gameState)
    {
        if (gameState == AllGameManager.GameState.InGame)
        {
            Cursor.visible = false;
        }
        else
        {
            Cursor.visible = true;
        }
    }
}