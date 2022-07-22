using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
 void OnTriggerEnter(Collider other)
 {
   SceneManager.LoadScene(2);
 }

}
