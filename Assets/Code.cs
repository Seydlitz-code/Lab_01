using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.ObjectModel;

public class Code : MonoBehaviour
{
	private void Awake()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(10);
		PrintArrayList(arrayList);
		arrayList.Insert(1, 10);
		PrintArrayList(arrayList);
		List<int> data = new List<int>();
		data.Add(1);
		data.Add(3);
		data.Add(2);
		arrayList.AddRange(data);
		PrintArrayList(arrayList);
		arrayList.Sort();
		PrintArrayList(arrayList);
		arrayList.Remove(10);
		PrintArrayList(arrayList);
		arrayList.RemoveAt(0);
		PrintArrayList(arrayList);
		arrayList.RemoveRange(0, 2);
		PrintArrayList(arrayList);
		arrayList.Clear();
		Debug.Log(arrayList.Count);
	}

	public void PrintArrayList(ArrayList list)
	{
		Debug.Log("====================");
		for (int i = 0; i < list.Count; i++)
		{
			Debug.Log($"list[{i}] = {list[i]}");
		}
	}
}