//we need the UI library
using UnityEngine.UI;

using UnityEngine;

public class GameManager : MonoBehaviour
{
   public Text scoreText;

   int scoreCount = 0;

   public void AddPoint() {
       scoreCount++;
       scoreText.text = scoreCount.ToString();//have to convert to a string
   }
}
