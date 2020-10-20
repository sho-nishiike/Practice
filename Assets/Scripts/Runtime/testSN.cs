using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testSN : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		Debug.Log("Start test");
    }

	private float _updateTime = 0f;
    // Update is called once per frame
    void Update()
    {
		_updateTime += Time.deltaTime;
		if (_updateTime >= 1.0f)
		{
			_updateTime -= 1.0f;
			Debug.Log("Update");
		}
    }

	private float _lateUpdateTime = 0f;
	private void LateUpdate()
	{
		_lateUpdateTime += Time.deltaTime;
		if (_lateUpdateTime >= 1.0f)
		{
			_lateUpdateTime -= 1.0f;
			Debug.Log("LateUpdate");
		}
	}
}
