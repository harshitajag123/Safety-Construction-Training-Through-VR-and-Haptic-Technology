// using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    public Text Passage;
    public Button module1Button;
    public Button module2Button;
    public Button module3Button;

    
    // Start is called before the first frame update
    void Start()
    {
        module1Button = transform.Find("module1Button").GetComponent<Button>();
        module2Button = transform.Find("module2Button").GetComponent<Button>();
        module3Button = transform.Find("module3Button").GetComponent<Button>();
    }

    

    public void Module1ButtonClicked(){
    // Load Module 1 interface (see next step)
}
    public void Module2ButtonClicked(){
        // Implement Module 2 logic here
    }

    public void Module3ButtonClicked(){

    }




}
