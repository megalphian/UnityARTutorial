using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour {

    Renderer renderer;
    public Texture2D[] textures;

	// Use this for initialization
	void Start () {
        renderer = GetComponent<Renderer>();
        StartCoroutine(ChangeColoursEvery5Seconds());
	}
	
	// Update is called once per frame
	void Update () 
    {
        
	}

    IEnumerator ChangeColoursEvery5Seconds()
    {
        while(true)
        {
            yield return new WaitForSeconds(5);
            var rendererIndex = Mathf.RoundToInt(Random.Range(0, textures.Length));
            renderer.material.mainTexture = textures[rendererIndex];
        }
    }
}
