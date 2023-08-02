using UnityEngine;

public class Ball : MonoBehaviour
{
    void OnMouseDown() {
        gameObject.SetActive(false);    
        GameManager.instance.ballsDestroyed++;
    }
}
