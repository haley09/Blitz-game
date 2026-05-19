using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

  public Player player;
  public Text scoreText;
  //public GameObject playButton;
  public GameObject quitButton;
  public GameObject gameOver;
  private UpdateScore scoreTracker;

  private void Awake() {
    Application.targetFrameRate = 60;
    scoreTracker = GetComponent<UpdateScore>();
    //Pause();
  }

  public void Play() {
    scoreTracker.ResetScore();
    //playButton.SetActive(false);
    gameOver.SetActive(false);
    Time.timeScale = 1f;
    player.enabled = true;

    Asteroids[] asteroids = FindObjectsOfType<Asteroids>();

    for (int i = 0; i < asteroids.Length; i++) {
      Destroy(asteroids[i].gameObject);
    }
  }

  public void Pause() {
    Time.timeScale = 0f;
    player.enabled = false;
  }

  public void QuitGame () {
      Debug.Log("QUIT!");
      Application.Quit();
  }

  public void GameOver() {
    gameOver.SetActive(true);
    //playButton.SetActive(true);
    //Pause();
    scoreTracker.StopScore();
  }
}
