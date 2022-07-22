using UnityEngine;
using UnityEngine.SceneManagement;

public class MoreSoon : MonoBehaviour
{
 void OnTriggerEnter(Collider other)
 {
   Cursor.lockState = CursorLockMode.None;
   Cursor.visible = true;
   SceneManager.LoadScene(3);
 }

}
