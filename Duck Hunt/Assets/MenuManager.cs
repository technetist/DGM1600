using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {
    public void LoadLevel(string _name)
    {
        Application.LoadLevel(_name);
    }
}
