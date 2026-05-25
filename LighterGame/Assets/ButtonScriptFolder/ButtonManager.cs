using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public void OnClickTitleButton()
    {
        Debug.Log("ゲームを開始します");
        SceneInstance.Instance.LoadTitleScene();
    }

    public void OnClickMenuButton()
    {
        Debug.Log("メニューに戻ります");
        SceneInstance.Instance.LoadMenuScene();
    }

    public void OnClickStageSelectButton()
    {
        Debug.Log("ステージ選択に移動します");
        SceneInstance.Instance.LoadStageSelectScene();
    }

    public void OnClickStageScene1Button()
    {
        Debug.Log("ステージ1に移動します");
        SceneInstance.Instance.LoadStageScene1();
    }

    public void OnClickExitButton()
    {
        Debug.Log("ゲームを終了します");
        Application.Quit();
    }
}
