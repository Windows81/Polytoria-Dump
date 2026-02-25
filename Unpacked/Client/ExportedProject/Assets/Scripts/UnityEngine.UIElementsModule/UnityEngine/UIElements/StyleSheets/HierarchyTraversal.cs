namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x20005F3")]
internal abstract class HierarchyTraversal
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60029AA")]
	protected HierarchyTraversal() { }

	[Address(RVA = "0x1BA4800", Offset = "0x1BA3A00", Length = "0xCF")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyBindingTracker+HierarchicalBindingsSorter", Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker+InvalidateDataSourcesTraversal", Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UQueryMatcher), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60029A9")]
	protected void Recurse(VisualElement element, int depth) { }

	[Address(RVA = "0x1BA48D0", Offset = "0x1BA3AD0", Length = "0x17")]
	[CalledBy(Type = typeof(UQueryMatcher), Member = "Traverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60029A7")]
	public override void Traverse(VisualElement element) { }

	[Token(Token = "0x60029A8")]
	public abstract void TraverseRecursive(VisualElement element, int depth) { }

}

