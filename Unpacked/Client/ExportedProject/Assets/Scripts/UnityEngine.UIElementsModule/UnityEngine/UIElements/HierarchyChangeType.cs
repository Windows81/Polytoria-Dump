namespace UnityEngine.UIElements;

[Token(Token = "0x200052A")]
internal enum HierarchyChangeType
{
	AddedToParent = 0,
	RemovedFromParent = 1,
	ChildrenReordered = 2,
	AttachedToPanel = 3,
	DetachedFromPanel = 4,
}

