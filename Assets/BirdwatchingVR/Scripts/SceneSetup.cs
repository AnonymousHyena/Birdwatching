using UnityEngine;
using System.Collections;

public class SceneSetup : MonoBehaviour
{
	public Material ocean_material;
    public lb_BirdController birdControl;
    //public GameObject seagulls;

    //void Awake ()
    //{
    //	Instantiate (seagulls);
    //}

    void Start ()
	{
		Ocean.gameObject.SetActive(true);
		Ocean.gameObject.transform.position 					= new Vector3(0.0f, -2.7f, 0.0f);
		Ocean.gameObject.transform.localScale 					= Vector3.one * 64.0f;

		Ocean.gameObject.GetComponent<MeshRenderer>().material 	= ocean_material;

		Ocean.audio_source.volume 								= 0.125f;
		Ocean.audio_source.Play();

        birdControl = GameObject.Find("_livingBirdsController").GetComponent<lb_BirdController>();
        birdControl.SendMessage("SpawnAmount", 10);
    }


	void Update ()
	{
		Ocean.AdjustPitch();
		Ocean.SetSoundPositionRelativeToViewer();
	}
}
