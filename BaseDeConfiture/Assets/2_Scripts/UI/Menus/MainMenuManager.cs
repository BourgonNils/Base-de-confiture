using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public static MainMenuManager Instance { get; private set; }


    private GameManager gameManager;

    [SerializeField]
    private Button startButton;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }




    void Start()
    {
        gameManager = GameManager.Instance;
        startButton.onClick.AddListener(onClickStartButton);
        
    }

    public void onClickStartButton()
    {
        Debug.Log("onClickStartButton");
        gameManager.NextLevel();
    }
  
}
