using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
   public void Change(string sceneName){
       SceneManager.LoadScene(sceneName);
   }
   public void LoadMainGame(int level){
       int row, col;
       switch (level) {
           case 1:
                row = 2;
                col = 3;
                break;
           case 2:
                row = 3;
                col = 4;
                 break;
           default:
                row = 4;
                col = 5;
                break;
       }
       PlayerPrefs.SetInt("row", row);
       PlayerPrefs.SetInt("col", col);
       SceneManager.LoadScene("MainScene");
   }
   public void TimeScore(int score){
       
   }
   public void Exit(){
       Application.Quit();
   }
   
}
