using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckpointManager : MonoBehaviour 
{
    public static Vector3 respawnPos{get; private set; }
    [SerializeField] PlayerData myPlayerData;
    [SerializeField] HealthController myPlayerHealth;
    [SerializeField] private string nextScene;
    [SerializeField] private Transform player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(this.gameObject.tag == "Checkpoint")
        {
            respawnPos = player.position;
        }
        else if(this.gameObject.tag == "EndScene")
        {
            myPlayerData.SetValues(current: myPlayerHealth.GetCurrent(), parts:Collectables.partsCollecteds, shoots: BulletMovement.bulletsShooted, time: Time.timeSinceLevelLoad);
            StopAllCoroutines();
            SceneManager.LoadScene("Gameplay2");
        }

    }

}