using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }


    [SerializeField]
    private Button pauseButton;




    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }



    public void Start()
    {
        pauseButton.onClick.AddListener(onCLickPauseBtn);
    }


    public void onCLickPauseBtn()
    {
        Debug.Log("onCLickPauseBtn ");
        GameManager.Instance.PauseGame();
    }

}
