namespace Unity.Hierarchy;

[IsReadOnly]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyPropertyId.h")]
[Token(Token = "0x2000022")]
internal struct HierarchyPropertyId : IEquatable<HierarchyPropertyId>
{
	[Token(Token = "0x4000054")]
	private static readonly HierarchyPropertyId s_Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000055")]
	private readonly int m_Id; //Field offset: 0x0

	[Token(Token = "0x17000020")]
	public int Id
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C5")]
		 get { } //Length: 3
	}

	[IsReadOnly]
	[Token(Token = "0x1700001F")]
	public static HierarchyPropertyId Null
	{
		[Address(RVA = "0x1998DF0", Offset = "0x1997FF0", Length = "0x33")]
		[CalledBy(Type = typeof(HierarchyPropertyUnmanaged`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy), typeof(HierarchyPropertyId&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60000C4")]
		 get { } //Length: 51
	}

	[Address(RVA = "0x1308BB0", Offset = "0x1307DB0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C6")]
	public HierarchyPropertyId() { }

	[Address(RVA = "0x19987F0", Offset = "0x19979F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C8")]
	public override bool Equals(HierarchyPropertyId other) { }

	[Address(RVA = "0x1998C90", Offset = "0x1997E90", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000CA")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C5")]
	public int get_Id() { }

	[Address(RVA = "0x1998DF0", Offset = "0x1997FF0", Length = "0x33")]
	[CalledBy(Type = typeof(HierarchyPropertyUnmanaged`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy), typeof(HierarchyPropertyId&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60000C4")]
	public static HierarchyPropertyId get_Null() { }

	[Address(RVA = "0x1998890", Offset = "0x1997A90", Length = "0x1B")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000CB")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x19989C0", Offset = "0x1997BC0", Length = "0x8")]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C7")]
	public static bool op_Equality(in HierarchyPropertyId lhs, in HierarchyPropertyId rhs) { }

	[Address(RVA = "0x1998D20", Offset = "0x1997F20", Length = "0xC5")]
	[CalledBy(Type = typeof(HierarchyPropertyUnmanaged`1), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x60000C9")]
	public virtual string ToString() { }

}

