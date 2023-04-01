using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Fungsi yang akan dipanggil saat tombol ditekan
    public void Menu()
    {
        SceneManager.LoadScene("UTS");
    }

    public void QuitGame()
    {
        Debug.Log("quitting game...");
        Application.Quit();
    }

}