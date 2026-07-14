using UnityEngine;
using UnityEngine.UI;

public class FireManager : SingletonMonoBehaviour<FireManager>
{
    [Header("‰Î‚Ì‰æ‘œ")]
    [SerializeField] private GameObject fireImage = null;

    [Header("”­‰Î‚Ì”»’è")]
    [SerializeField] public bool isFire = false;

    private void Start()
    {
        if (fireImage == null)
        {
            Debug.LogError("FireImage‚ªnull‚Å‚·I");
        }
        else
        {
            fireImage.SetActive(false);
        }
    }

    private void Update()
    {
        if (isFire)
        {
            fireImage.SetActive(true);
        }
        else
        {
            fireImage.SetActive(false);
        }
    }
}