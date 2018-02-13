using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitOnClick : MonoBehaviour
{
    public void Quit()
    {
#if Unity_Editor
        Unity_Editor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
