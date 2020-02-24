/****************************************************
    文件：Test.cs
	作者：AnLian
    邮箱: 157083536@qq.com
    日期：#CreateTime#
	功能：Nothing
*****************************************************/

using UnityEngine;

public class Test : MonoBehaviour 
{
	private void Update()
	{
		this.gameObject.transform.Rotate(Vector3.up,Time.deltaTime*2f);
	}
}