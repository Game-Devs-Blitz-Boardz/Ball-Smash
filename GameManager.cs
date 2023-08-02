using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
  
    [SerializeField] GameObject[] balls;
    [SerializeField] GameObject panel;
    int numBalls;
    public int ballsDestroyed;

    void Awake() {
        instance = this;
    }

    void Start() {
        ballsDestroyed = 0;
        numBalls = balls.Length;
        panel.SetActive(false);
        for (int i = 0; i<numBalls; i++) {
            balls[i].SetActive(true);
        }
    }

    void Update() {
        if (ballsDestroyed == numBalls) {
            panel.SetActive(true);
        }
    }

    public void PlayAgain() {
        SceneManager.LoadScene("Game");
    }


}
