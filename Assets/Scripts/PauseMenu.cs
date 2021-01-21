using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	public static bool GameIsPaused = false;
    
	public GameObject menuPause;
	void Update() // Appuyer sur la touche Echap pour : 
	{
		if (Input.GetKeyDown(KeyCode.Escape)) 
		{
			if (GameIsPaused)
			{
				Resume();
			}
			else
			{
				Pause();
			}
		}
	}

	public void Resume() // Remet le jeu 
	{
		menuPause.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}

	void Pause() // Freeze le temps et le jeu
	{
		menuPause.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}

	public void Menu() // Retourne au début
	{
		SceneManager.LoadScene(0);
		Time.timeScale = 1f;
	}

	public void QuitGame() // Quitte le jeu
	{
		Debug.Log("Quitting game...");
		Application.Quit();
	}
}