using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	public void Change(int x)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(x);
    }
}
