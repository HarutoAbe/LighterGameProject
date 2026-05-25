using UnityEngine;
using System;

/// <summary>
/// SingletonクラスをMonoBehaviourで実装するためのクラス
/// </summary>
/// <typeparam name="T"></typeparam>
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    // インスタンス
    private static T instance;

    // インスタンスを取得
    public static T Instance
    {
        get
        {
            // インスタンスが存在しない場合は、シーン内から探す
            if (instance == null)
            {
                // ジェネリック型からTypeを取得
                Type t = typeof(T);

                // シーン内からジェネリック型のコンポーネントを探す
                instance = (T)FindFirstObjectByType(t);

                // 見つからない場合はエラーを出す
                if (instance == null)
                {
                    Debug.LogError(t + "をアタッチしているGameObjectはありません");
                }
            }

            return instance;
        }
    }

    /// <summary>
    /// CheckInstanceを呼び出すためのAwake
    /// </summary>
    virtual protected void Awake()
    {
        //CheckInstance();

        if (!CheckInstance())
        {
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    /// <summary>
    /// インスタンスが存在しない場合は、インスタンスを設定し、存在する場合は自身を破棄する
    /// </summary>
    /// <returns></returns>
    protected bool CheckInstance()
    {
        Debug.Log("CheckInstanceだよ");

        if (instance == null)
        {
            instance = this as T;
            return true;
        }

        if (Instance == null)
        {
            return true;
        }

        Destroy(gameObject);
        return false;
    }
}
