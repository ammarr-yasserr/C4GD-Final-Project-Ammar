using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   public void LoadScene(string MoreLevelsSoon)
   {
      SceneManager.LoadScene(MoreLevelsSoon);
   }
   public void quitApp(){
      Application.Quit();
   }


}
