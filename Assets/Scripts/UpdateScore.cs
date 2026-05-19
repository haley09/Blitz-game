using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour {
  public Text scoreText;
  public float score;
  public float increasedPerSecond = 1f;
  private bool isPaused;

  public void Start() {
    ResetScore();
  }

  public void Update() {
    if (!isPaused) {
      score += Time.deltaTime * increasedPerSecond;
      UpdateScoreText();
    }
  }

  public void ResetScore() {
    score = 0;
    isPaused = false;
    UpdateScoreText();
  }

  public void StopScore() {
    isPaused = true;
  }

  private void UpdateScoreText() {
    scoreText.text = Mathf.FloorToInt(score).ToString();
  }

}
