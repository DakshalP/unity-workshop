//we need the UI library
using UnityEngine.UI;

//we need the SceneManagement library (Step 5)
using UnityEngine.SceneManagement;

using UnityEngine;

public class GameManager : MonoBehaviour
{
   public Text scoreText;

   int scoreCount = 0;

   bool gameHasEnded = false;

   public void AddPoint() {
       scoreCount++;
       scoreText.text = scoreCount.ToString();//have to convert to a string
   }

   public void EndGame () {
       if(!gameHasEnded) {
           gameHasEnded = true;

           Invoke("Restart", 5);
       }
   }

   void Restart() {
       //SceneManager.LoadScene("Level01");

       //a better way of doing it
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
