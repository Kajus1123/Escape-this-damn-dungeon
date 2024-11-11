using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kooperativ : MonoBehaviour
{
    public void OpenURL()
    {
        //Copy your portfolio website URL and past here

        Application.OpenURL("https://open.spotify.com/artist/4RXWP0S1lEyi6gMjYIh7br");
        Debug.Log("is this working");
    }
}
