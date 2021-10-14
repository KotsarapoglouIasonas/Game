using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    private SceneState [] scenestates;
    public SceneState[] Scenestates
    {
        get
        {
            return scenestates;
        }
    }

    public void SaveScene(SceneState scene)
    {
        if (scenestates.Length==0)
        {
            scenestates = new SceneState[scenestates.Length+1];
            scenestates[scenestates.Length] = scene;
        }
        else
        {
            scenestates[scenestates.Length] = scene;
        }
    }
}
