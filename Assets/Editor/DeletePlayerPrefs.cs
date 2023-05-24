using UnityEngine;
using UnityEditor;
  
 public class DeletePlayerPrefs : EditorWindow
 {
     [MenuItem("Tools/Delete PlayerPrefs (All)")]
     static void DeleteAllPlayerPrefs()
     {
         PlayerPrefs.DeleteAll();
         Debug.Log("Deleting PlayerPrefs.");
     }
 }