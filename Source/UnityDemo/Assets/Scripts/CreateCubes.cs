﻿/**CreateCubes.cs
 * Author: Caleb Whitman
 * October 29, 2016
 * 
 * Creates cubes and sets them up around the area.
 */

using UnityEngine;
using System.Collections;
using System.Diagnostics;
using System.IO;

public class CreateCubes : MonoBehaviour {

	//Will hold our cubes
	public GameObject cubePrefab; 


	// Use this for initialization
	void Start () {
	

		for (int x = 0; x < 20; x++) {
			for (int y = 0; y < 20; y++) {
				//Creates a new cube prefab
				GameObject cube = Instantiate (cubePrefab);
				//sets the cubes position
				cube.transform.position = new Vector3 (x * 10, 0, y*10);
			}
		}


	}


	//Makes a call to an external python function and prints out anything printed in standard out to the debugger.
	/**
	private void run_cmd()
	{
		ProcessStartInfo start = new ProcessStartInfo();
		start.FileName = "Path of Python executable";
		start.Arguments = "Path of python file";
		start.UseShellExecute = false;
		start.RedirectStandardOutput = true;

		//The using statments automatically close the reader and process after they are done. 
		using(Process process = Process.Start(start))
		{
			using(StreamReader reader = process.StandardOutput)
			{
				string result = reader.ReadToEnd();
				UnityEngine.Debug.Log (result);
			}
		}
	}
	*/

}

