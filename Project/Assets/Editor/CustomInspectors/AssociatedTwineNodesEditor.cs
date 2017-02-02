using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

[CustomEditor(typeof(AssociatedTwineNodes))]
public class NextTwineNodeInspector : Editor
{

	public override void OnInspectorGUI()
	{
		AssociatedTwineNodes associatedTwineNodes = (AssociatedTwineNodes)target;
		TwineNode[] nodes = FindObjectsOfType(typeof(TwineNode)) as TwineNode[];

		associatedTwineNodes.selectedTwineNodeIndices = PrairieGUI.drawTwineNodeDropdownList ("Associated Twine Nodes", "Twine Node Object",
															nodes, associatedTwineNodes.selectedTwineNodeIndices);

		associatedTwineNodes.UpdateTwineNodeObjectsFromIndices (nodes);
	}
}