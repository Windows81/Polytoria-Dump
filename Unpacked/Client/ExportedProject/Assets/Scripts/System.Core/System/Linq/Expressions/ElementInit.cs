namespace System.Linq.Expressions;

[Token(Token = "0x200006F")]
public sealed class ElementInit : IArgumentProvider
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000C1")]
	private readonly MethodInfo <AddMethod>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000C2")]
	private readonly ReadOnlyCollection<Expression> <Arguments>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700005F")]
	public MethodInfo AddMethod
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000275")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000061")]
	public override int ArgumentCount
	{
		[Address(RVA = "0x1596AE0", Offset = "0x1595CE0", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000278")]
		 get { } //Length: 68
	}

	[Token(Token = "0x17000060")]
	public ReadOnlyCollection<Expression> Arguments
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000276")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000275")]
	public MethodInfo get_AddMethod() { }

	[Address(RVA = "0x1596AE0", Offset = "0x1595CE0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000278")]
	public override int get_ArgumentCount() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000276")]
	public ReadOnlyCollection<Expression> get_Arguments() { }

	[Address(RVA = "0x1596A80", Offset = "0x1595C80", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000277")]
	public override Expression GetArgument(int index) { }

}

