using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    [SerializeField] Button startButton=null;
    [SerializeField] AudioSource music=null;
    [SerializeField] AudioSource hereWeGo=null;
    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(HandleStartButtonClicked);
    }
    void OnDestroy(){
        startButton.onClick.RemoveListener(HandleStartButtonClicked);
    }
    void HandleStartButtonClicked(){
        music.Stop();
        hereWeGo.Play();
        Invoke("LoadLevel",1.5f);
    }

    void LoadLevel(){
        SceneManager.LoadScene(Scenes.DANCE);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
