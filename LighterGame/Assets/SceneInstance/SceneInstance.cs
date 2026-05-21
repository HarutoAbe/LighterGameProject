using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// シーンの設定、ロードを管理するクラス
/// シーンを設定した際は必ず設定すること
/// </summary>
public class SceneInstance : SingletonMonoBehaviour<SceneInstance>
{
    [Header("タイトルシーンを設定")]
    [SerializeField] private static readonly string TITLE_SCENE = "TitleScene";

    [Header("メニューシーンを設定")]
    [SerializeField] private static readonly string MENU_SCENE = "MenuScene";

    [Header("ステージ選択シーンを設定")]
    [SerializeField] private static readonly string STAGE_SELECT_SCENE = "StageSelectScene";

    [Header("ゲームシーンを設定")]
    [SerializeField] private static readonly string MAIN_STAGE_SCENE_1 = "StageScene1";

    /// <summary>
    /// タイトルシーンをロードする
    /// </summary>
    public void LoadTitleScene()
    {
        SceneManager.LoadScene(TITLE_SCENE);
    }

    /// <summary>
    /// メニューシーンをロードする
    /// </summary>
    public void LoadMenuScene()
    {
        SceneManager.LoadScene(MENU_SCENE);
    }

    /// <summary>
    /// ステージ選択シーンをロードする
    /// </summary>
    public void LoadStageSelectScene()
    {
        SceneManager.LoadScene(STAGE_SELECT_SCENE);
    }

    public void LoadStageScene1()
    {
        SceneManager.LoadScene(MAIN_STAGE_SCENE_1);
    }

}
