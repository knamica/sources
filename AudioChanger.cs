using UnityEngine;
using System.Collections;

public class AudioChanger : MonoBehaviour {
	const int numoftracks = 15;
	public AudioClip[] main;
	public AudioClip[] intro;
	public float[] delaytime = new float[numoftracks];
	struct tracks{
		public float delaytime;
		public AudioClip intro;
		public AudioClip main;
	}
	private int t=0; //曲の選択
	private AudioSource audioSource;
	private bool nowPlaying = false;
	tracks[] track;

	//track name//
	private string[] trackname= new string[numoftracks] {
		"track1","track2","track3","track4",
		"track5","track6","track_7","track_8",
		"track9","track10","track11","track12",
		"track13","track14","track15"
		};

	void Start () {
		track = new tracks[numoftracks];

		for (int i=0; i<numoftracks; i++) {
			track[i].delaytime=delaytime[i];
			track[i].intro=intro[i];
			track[i].main=main[i];
		}
	}

	void OnGUI ()
	{
		GUI.Box (new Rect (350, 200, 300, 70), "Change Music");
		if(GUI.Button (new Rect (370, 225, 70,30), "Back")){
			t--;
			t=LoopNum(t);
			PlayWithDelay(t,nowPlaying);
		}
		if(GUI.Button (new Rect (460, 225, 80,30), "Play/Stop")){
			nowPlaying=!nowPlaying;
			PlayWithDelay(t,nowPlaying);
		}
		if(GUI.Button (new Rect (560, 225, 70,30), "Next")){
			t++;
			t=LoopNum (t);
			PlayWithDelay(t,nowPlaying);
		}

		int	p = GUI.SelectionGrid(new Rect(25, 25, 120,400), t, trackname, 1);
		if (p != t) {
			t = p;
			nowPlaying=true;
			PlayWithDelay(t,nowPlaying);
		}
	}

	void PlayWithDelay(int t,bool nowPlaying) {
		AudioSource[] audioSources = gameObject.GetComponents<AudioSource>();
		if (nowPlaying) {
			if (track [t].delaytime == 0) {
				audioSources[0].Stop();
				audioSources[1].clip = main[t];
				audioSources[1].Play();
			} else {
				audioSources[0].clip = intro[t];
				audioSources[0].Play();
				audioSources[1].clip = main[t];
				audioSources[1].PlayDelayed(track[t].delaytime);
			}
		} else {
			audioSources[0].Stop();
			audioSources[1].Stop();
		}
	}

	int LoopNum(int a) {
		if(a < 0)
			a = trackname.Length-1;
		if (a > (trackname.Length-1) )
			a = 0;
		return a;
	}

}
