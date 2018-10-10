using UnityEngine;
using System.Collections;

public class DestroyButton : MonoBehaviour {

	public void ButtonClick()
    {
        this.gameObject.SetActive(false);
    }
}
