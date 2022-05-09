using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstLore : MonoBehaviour
{
    public void Onplay()
    {
        SceneManager.LoadScene("Second Lore");
    }
}



