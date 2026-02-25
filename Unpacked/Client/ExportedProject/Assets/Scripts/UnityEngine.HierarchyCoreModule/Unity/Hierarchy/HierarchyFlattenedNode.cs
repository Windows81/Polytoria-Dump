namespace Unity.Hierarchy;

[IsReadOnly]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyFlattenedNode.h")]
[Token(Token = "0x200001D")]
public struct HierarchyFlattenedNode : IEquatable<HierarchyFlattenedNode>
{
	[Token(Token = "0x4000040")]
	private static readonly HierarchyFlattenedNode s_Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000041")]
	private readonly HierarchyNode m_Node; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000042")]
	private readonly HierarchyNodeType m_Type; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000043")]
	private readonly int m_ParentOffset; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000044")]
	private readonly int m_NextSiblingOffset; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000045")]
	private readonly int m_ChildrenCount; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000046")]
	private readonly int m_Depth; //Field offset: 0x18

	[Token(Token = "0x17000017")]
	public int ChildrenCount
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AA")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000016")]
	public int NextSiblingOffset
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A9")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000015")]
	public HierarchyNode Node
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A8")]
		 get { } //Length: 4
	}

	[IsReadOnly]
	[Token(Token = "0x17000014")]
	public static HierarchyFlattenedNode Null
	{
		[Address(RVA = "0x1996B40", Offset = "0x1995D40", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60000A7")]
		 get { } //Length: 51
	}

	[Address(RVA = "0x19968F0", Offset = "0x1995AF0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[ExcludeFromDocs]
	[Token(Token = "0x60000AC")]
	public override bool Equals(HierarchyFlattenedNode other) { }

	[Address(RVA = "0x1996910", Offset = "0x1995B10", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[ExcludeFromDocs]
	[Token(Token = "0x60000AE")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AA")]
	public int get_ChildrenCount() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A9")]
	public int get_NextSiblingOffset() { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A8")]
	public HierarchyNode get_Node() { }

	[Address(RVA = "0x1996B40", Offset = "0x1995D40", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60000A7")]
	public static HierarchyFlattenedNode get_Null() { }

	[Address(RVA = "0x19969B0", Offset = "0x1995BB0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, ReturnType = typeof(int))]
	[ExcludeFromDocs]
	[Token(Token = "0x60000AF")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B0")]
	internal static HierarchyNode GetNodeByRef(in HierarchyFlattenedNode hierarchyFlattenedNode) { }

	[Address(RVA = "0x1996B80", Offset = "0x1995D80", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[ExcludeFromDocs]
	[Token(Token = "0x60000AB")]
	public static bool op_Equality(in HierarchyFlattenedNode lhs, in HierarchyFlattenedNode rhs) { }

	[Address(RVA = "0x1996A20", Offset = "0x1995C20", Length = "0x119")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[ExcludeFromDocs]
	[Token(Token = "0x60000AD")]
	public virtual string ToString() { }

}

