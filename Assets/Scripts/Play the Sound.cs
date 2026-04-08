using UnityEngine;

public class PlaytheSound : MonoBehaviour
{
    //plays sound
    public AudioSource source;
    
    public void PlaySound()
    {
        source.Play();
    }
}
