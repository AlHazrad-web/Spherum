using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameController : MonoBehaviour {

    public Transform cube1;
    public Transform cube2;

    public Text distText;

    public GameObject spheres;

    bool check = true;
  
    void Start() {
        DontDestroyOnLoad(gameObject);
    }

    void Update() {
        if (check) {
            float distance = Vector3.Distance(cube1.position, cube2.position);
            distText.text = ((int)distance).ToString() + "m";
            if (distance < 2.0f) {
                spheres.SetActive(true);
            } else  {               
                spheres.SetActive(false);
            }
            if (distance < 1.0f) {
                check = false;
                SceneManager.LoadSceneAsync("Scene2", LoadSceneMode.Single);
            }
        }       
    }

    public void ClickButtonExit() {
        Application.Quit();
    }

}
