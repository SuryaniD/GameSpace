using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlScript : MonoBehaviour
{
	public void NextScene()
	{
		SceneManager.LoadScene("Save1");
	}

	public void Menu(){
		SceneManager.LoadScene ("Scene2");
	}

	public void Quit(){
		Application.Quit ();
	}

	public void Controls(){
		SceneManager.LoadScene ("Controls");
	}
}