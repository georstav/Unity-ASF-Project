using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuToFlyer_3D_Models : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    public void FromMenuToFlyer()
    {
        Debug.Log("Hello from the script From MENU to  3D MODELS ");
        SceneManager.LoadScene("Flyer_3D_Models");
        //Goes from  Menu scene to Flyer_3D_Models scene
        
    }
}
