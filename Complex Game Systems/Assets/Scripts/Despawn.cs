using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Despawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(Fade());
    }
	
	// Update is called once per frame
	void Update () {
	    if (GetComponent<Image>().color.a <= 0)
        {
            Destroy(gameObject);
        }
	}

    public IEnumerator Fade()
    {
        while (GetComponent<Image>().color.a > 0)
        {
            Color color = GetComponent<Image>().color;
            color.a -= 0.1f;
            GetComponent<Image>().color = color;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
