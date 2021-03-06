using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Slider slide;
    [SerializeField] private Vector3[] spawnPos;
    [SerializeField] private Scene activeScene;
    private static List<string> scenesAffectSlider = new List<string>(new string[]{"Opções"});

    void Start()
    {
        activeScene = SceneManager.GetActiveScene();
        if(scenesAffectSlider.Contains(activeScene.name))
        {
            slide.value = AudioListener.volume;
        }
    }

    #region Controle_Opções

    public void SetVolume(Slider slide)
    {
        AudioListener.volume = slide.value;
    } 
    public void DisplayVolume(Text volume)
    {
        volume.text = (int)(AudioListener.volume * 100) + "%";
    }

    #endregion Controle_Opções
	#region Controle_Cenas
    public void LoadScene(string name)
    {
        Time.timeScale = 1f;
        Collectables.TurnZero();
        SceneManager.LoadScene(name);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Pause(GameObject menuPause)
    {
        Time.timeScale = 0f;
        menuPause.SetActive(true);
    }

    public void UnPause(GameObject menuPause)
    {
        Time.timeScale = 1f;
        menuPause.SetActive(false);
    }
    #endregion Controle_Cenas
}
