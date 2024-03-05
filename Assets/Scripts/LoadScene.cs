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
        if(index == 3){
            SceneManager.LoadScene("MtCarmelJunction");
        }
        if(index == 4){
            SceneManager.LoadScene("TwinSisters");
        }
    }

    public void baclToMenu(){
        SceneManager.LoadScene("Menu");
    }
}
