//we need the UI library
using UnityEngine.UI;

//we need the SceneManagement library (Step 5)
using UnityEngine.SceneManagement;

using UnityEngine;

public class GameManager : MonoBehaviour
{
   Text scoreText;

   int scoreCount = 0;

   bool gameHasEnded = false;

   void Start () {
       scoreText = FindObjectOfType<Text>();
   }

   public void AddPoint() {
       scoreCount++;
       scoreText.text = scoreCount.ToString();//have to convert to a string
   }

   public void EndGame () {
       if(!gameHasEnded) {
           gameHasEnded = true;

           //Invoke("Restart", 5);

           if(scoreCount >= 6) {
               scoreText.text = "Good Job!";
               Invoke("NextLevel", 2);
           }
           else {
               scoreText.text = "Try again.";
               Invoke("Restart", 2);
           }
       }
   }

   void Restart() {
       //SceneManager.LoadScene("Level01");

       //a better way of doing it
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

   void NextLevel() {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
