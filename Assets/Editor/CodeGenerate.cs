using SampleCodeDom;
using UnityEditor;
using System.IO;

[InitializeOnLoad]
public class CodeGenerate
{
	static CodeGenerate()
	{
		Directory.CreateDirectory(  Path.GetDirectoryName(outputFileName ));
		
		Sample sample = new Sample ();
		sample.AddFields ();
		sample.AddProperties ();
		sample.AddMethod ();
		sample.AddConstructor (); 
		sample.AddEntryPoint ();
		sample.GenerateCSharpCode (outputFileName);
	}
	
	static string outputFileName = "Assets/Entity/SampleCode.cs";
}
