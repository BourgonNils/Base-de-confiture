using UnityEngine;
using UnityEngine.UI;

public class MenuPause : MonoBehaviour
{

  

    [SerializeField]
    private Button reprendreButton;

    [SerializeField]
    private Button recommencerButton;


    [SerializeField]
    private Button mainMenuButton;

    void Start()
    {
        if(mainMenuButton       == null ||
            recommencerButton   == null ||
            reprendreButton     == null)
        {
            Debug.LogWarning("OULA IL FAUT METTRE LES BOUTONS");
        } 


        reprendreButton.onClick.AddListener(OnClickResumeBtn);
        recommencerButton.onClick.AddListener(onClickRestartBtn);
        mainMenuButton.onClick.AddListener(onClickMenuBtn);

        GameManager.Instance.SetMenuPause(this.gameObject);
        this.gameObject.SetActive(false);
    }

     void OnClickResumeBtn()
    {
        GameManager.Instance.ResumeGame();
    }

     void onClickRestartBtn()
    {
        GameManager.Instance.ReloadGame();
    }

 

    public void onClickMenuBtn()
    {
        SceneManager.Instance.LoadScene(0);
    }
}
