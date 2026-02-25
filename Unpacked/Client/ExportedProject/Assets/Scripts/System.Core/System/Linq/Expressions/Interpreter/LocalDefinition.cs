namespace System.Linq.Expressions.Interpreter;

[IsReadOnly]
[Token(Token = "0x20001A3")]
internal struct LocalDefinition
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000325")]
	private readonly int <Index>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000326")]
	private readonly ParameterExpression <Parameter>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x170001C8")]
	public int Index
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60008BA")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001C9")]
	public ParameterExpression Parameter
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60008BB")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x880C00", Offset = "0x87FE00", Length = "0x12")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60008B9")]
	internal LocalDefinition(int localIndex, ParameterExpression parameter) { }

	[Address(RVA = "0x15D71C0", Offset = "0x15D63C0", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60008BC")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60008BA")]
	public int get_Index() { }

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60008BB")]
	public ParameterExpression get_Parameter() { }

	[Address(RVA = "0x15D7260", Offset = "0x15D6460", Length = "0x55")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008BD")]
	public virtual int GetHashCode() { }

}

