using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Slider slide;
    public static List<string> scenesAffectSlider = new List<string>(new string[]{"Opções"});

    void Start()
    {
        if(scenesAffectSlider.Contains(SceneManager.GetActiveScene().name))
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
        SceneManager.LoadScene(name);
    }

    public void Quit()
    {
        Application.Quit ();
    }
	#endregion Controle_Cenas
}
