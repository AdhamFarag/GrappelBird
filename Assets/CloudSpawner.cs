using UnityEngine;
using System.Collections;

public class CloudSpawner : MonoBehaviour {

	public GameObject cloud;
	public float MaxObjectCount = 0;

	// Use this for initialization
	void Start () {
		StartCoroutine (TheSpawn ());
		cloud.SetActive (true);
		iconcollect.iconcolect.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {

	}

	IEnumerator TheSpawn()
	{
		while (true) {
		
			yield return new WaitForSeconds(Random.Range(1f,5f));

			cloud.transform.position = new Vector2(Random.Range(-7f,5f),Random.Range(0f,4f));
		GameObject clone = (GameObject) Instantiate(cloud , cloud.transform.position , Quaternion.identity);
			Destroy(clone,3f);
		}
	

	}

}
