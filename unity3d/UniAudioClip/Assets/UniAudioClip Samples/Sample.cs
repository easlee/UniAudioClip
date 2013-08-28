using UnityEngine;
using System.IO;
using System.Collections;

using BinFoo.UniPlugin.Audio;

public class Sample : MonoBehaviour {
	
	public AudioSource audioSource;
	public string fileMP3;
	// Use this for initialization
	void Start () 
	{
		string pathMP3 = Path.Combine(Application.streamingAssetsPath, fileMP3);
		byte[] data = File.ReadAllBytes(pathMP3);
		ACxAudioClip acx = new ACxAudioClip();
		audioSource.clip = acx.FromMP3(data);
		audioSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
