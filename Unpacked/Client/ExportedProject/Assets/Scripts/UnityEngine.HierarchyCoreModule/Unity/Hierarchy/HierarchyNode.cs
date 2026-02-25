namespace Unity.Hierarchy;

[IsReadOnly]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyNode.h")]
[Token(Token = "0x200001E")]
public struct HierarchyNode : IEquatable<HierarchyNode>
{
	[Token(Token = "0x4000047")]
	private static readonly HierarchyNode s_Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000048")]
	private readonly int m_Id; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000049")]
	private readonly int m_Version; //Field offset: 0x4

	[Token(Token = "0x17000019")]
	public int Id
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B2")]
		 get { } //Length: 3
	}

	[IsReadOnly]
	[Token(Token = "0x17000018")]
	public static HierarchyNode Null
	{
		[Address(RVA = "0x1998C10", Offset = "0x1997E10", Length = "0x33")]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIds>d__25", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetParentId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerUpEvent"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetChildIndexForId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "CreateNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNode))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetHierarchyNodeById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetHierarchyNodeByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
		[CalledBy(Type = "UnityEngine.UIElements.TreeDataController`1", Member = "ConvertTreeViewItemDataToHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TreeViewItemData`1<T>>", "System.Func`2<HierarchyNode, HierarchyNode>", "System.Action`2<Int32, HierarchyNode>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60000B1")]
		 get { } //Length: 51
	}

	[Token(Token = "0x1700001A")]
	public int Version
	{
		[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B3")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1998C00", Offset = "0x1997E00", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B4")]
	public HierarchyNode() { }

	[Address(RVA = "0x1998A60", Offset = "0x1997C60", Length = "0x12")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[ExcludeFromDocs]
	[Token(Token = "0x60000B7")]
	public override bool Equals(HierarchyNode other) { }

	[Address(RVA = "0x19989D0", Offset = "0x1997BD0", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[ExcludeFromDocs]
	[Token(Token = "0x60000B9")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B2")]
	public int get_Id() { }

	[Address(RVA = "0x1998C10", Offset = "0x1997E10", Length = "0x33")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIds>d__25", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetParentId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "OnItemPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerUpEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetChildIndexForId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "CreateNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNode))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetHierarchyNodeById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetHierarchyNodeByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
	[CalledBy(Type = "UnityEngine.UIElements.TreeDataController`1", Member = "ConvertTreeViewItemDataToHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TreeViewItemData`1<T>>", "System.Func`2<HierarchyNode, HierarchyNode>", "System.Action`2<Int32, HierarchyNode>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60000B1")]
	public static HierarchyNode get_Null() { }

	[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B3")]
	public int get_Version() { }

	[Address(RVA = "0x1998A80", Offset = "0x1997C80", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, ReturnType = typeof(int))]
	[ExcludeFromDocs]
	[Token(Token = "0x60000BA")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1998C50", Offset = "0x1997E50", Length = "0x1A")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetAllItemIds>d__23", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetChildrenIds>d__25", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetParentId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "GetChildIndexForId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "IsChildOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "CreateNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNode))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[ContainsUnimplementedInstructions]
	[ExcludeFromDocs]
	[Token(Token = "0x60000B5")]
	public static bool op_Equality(in HierarchyNode lhs, in HierarchyNode rhs) { }

	[Address(RVA = "0x1998C70", Offset = "0x1997E70", Length = "0x1A")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "IsChildOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[ExcludeFromDocs]
	[Token(Token = "0x60000B6")]
	public static bool op_Inequality(in HierarchyNode lhs, in HierarchyNode rhs) { }

	[Address(RVA = "0x1998AF0", Offset = "0x1997CF0", Length = "0x10D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[ExcludeFromDocs]
	[Token(Token = "0x60000B8")]
	public virtual string ToString() { }

}

