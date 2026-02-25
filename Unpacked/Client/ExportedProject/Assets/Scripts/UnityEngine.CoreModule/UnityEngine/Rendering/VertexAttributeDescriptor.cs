namespace UnityEngine.Rendering;

[Token(Token = "0x20002B9")]
[UsedByNativeCode]
public struct VertexAttributeDescriptor : IEquatable<VertexAttributeDescriptor>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007AF")]
	private VertexAttribute <attribute>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40007B0")]
	private VertexAttributeFormat <format>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40007B1")]
	private int <dimension>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40007B2")]
	private int <stream>k__BackingField; //Field offset: 0xC

	[Token(Token = "0x17000223")]
	public VertexAttribute attribute
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000D89")]
		 get { } //Length: 3
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D8A")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000225")]
	public int dimension
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000D8D")]
		 get { } //Length: 4
		[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D8E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000224")]
	public VertexAttributeFormat format
	{
		[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000D8B")]
		 get { } //Length: 4
		[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D8C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000226")]
	public int stream
	{
		[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000D8F")]
		 get { } //Length: 4
		[Address(RVA = "0x143E130", Offset = "0x143D330", Length = "0x4")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D90")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1828760", Offset = "0x1827960", Length = "0x12")]
	[CallerCount(Count = 24)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D91")]
	public VertexAttributeDescriptor(VertexAttribute attribute = 0, VertexAttributeFormat format = 0, int dimension = 3, int stream = 0) { }

	[Address(RVA = "0x1993920", Offset = "0x1992B20", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D94")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x193A780", Offset = "0x1939980", Length = "0x27")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D95")]
	public override bool Equals(VertexAttributeDescriptor other) { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000D89")]
	public VertexAttribute get_attribute() { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000D8D")]
	public int get_dimension() { }

	[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000D8B")]
	public VertexAttributeFormat get_format() { }

	[Address(RVA = "0xAFA3A0", Offset = "0xAF95A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000D8F")]
	public int get_stream() { }

	[Address(RVA = "0x19939E0", Offset = "0x1992BE0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000D93")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D8A")]
	public void set_attribute(VertexAttribute value) { }

	[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D8E")]
	public void set_dimension(int value) { }

	[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D8C")]
	public void set_format(VertexAttributeFormat value) { }

	[Address(RVA = "0x143E130", Offset = "0x143D330", Length = "0x4")]
	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D90")]
	public void set_stream(int value) { }

	[Address(RVA = "0x1993A00", Offset = "0x1992C00", Length = "0x20C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D92")]
	public virtual string ToString() { }

}

