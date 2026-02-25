namespace Unity.Hierarchy;

[IsReadOnly]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyNodeType.h")]
[Token(Token = "0x2000020")]
public struct HierarchyNodeType : IEquatable<HierarchyNodeType>
{
	[Token(Token = "0x4000050")]
	private static readonly HierarchyNodeType s_Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000051")]
	private readonly int m_Id; //Field offset: 0x0

	[Token(Token = "0x1700001C")]
	public int Id
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000BC")]
		 get { } //Length: 3
	}

	[IsReadOnly]
	[Token(Token = "0x1700001B")]
	public static HierarchyNodeType Null
	{
		[Address(RVA = "0x1998980", Offset = "0x1997B80", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60000BB")]
		 get { } //Length: 51
	}

	[Address(RVA = "0x19987F0", Offset = "0x19979F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[ExcludeFromDocs]
	[Token(Token = "0x60000BE")]
	public override bool Equals(HierarchyNodeType other) { }

	[Address(RVA = "0x1998800", Offset = "0x1997A00", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[ExcludeFromDocs]
	[Token(Token = "0x60000C0")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BC")]
	public int get_Id() { }

	[Address(RVA = "0x1998980", Offset = "0x1997B80", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60000BB")]
	public static HierarchyNodeType get_Null() { }

	[Address(RVA = "0x1998890", Offset = "0x1997A90", Length = "0x1B")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[ExcludeFromDocs]
	[Token(Token = "0x60000C1")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x19989C0", Offset = "0x1997BC0", Length = "0x8")]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[ExcludeFromDocs]
	[Token(Token = "0x60000BD")]
	public static bool op_Equality(in HierarchyNodeType lhs, in HierarchyNodeType rhs) { }

	[Address(RVA = "0x19988B0", Offset = "0x1997AB0", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[ExcludeFromDocs]
	[Token(Token = "0x60000BF")]
	public virtual string ToString() { }

}

