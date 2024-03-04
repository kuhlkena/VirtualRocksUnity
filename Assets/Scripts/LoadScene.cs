using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void loadSceneFromIndex(int index){
        if(index == 1){
            SceneManager.LoadScene("Mojave");
        }
        if(index == 2){
            SceneManager.LoadScene("WestonElginHw");
        }
    }

    public void baclToMenu(){
        SceneManager.LoadScene("Menu");
    }
}
