namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(CatchBlockProxy))]
[Token(Token = "0x2000064")]
public sealed class CatchBlock
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000B0")]
	private readonly ParameterExpression <Variable>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000B1")]
	private readonly Type <Test>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000B2")]
	private readonly Expression <Body>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000B3")]
	private readonly Expression <Filter>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x1700004D")]
	public Expression Body
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000251")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700004E")]
	public Expression Filter
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000252")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700004C")]
	public Type Test
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000250")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700004B")]
	public ParameterExpression Variable
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600024F")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1594650", Offset = "0x1593850", Length = "0x7D")]
	[CalledBy(Type = typeof(Expression), Member = "MakeCatchBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ParameterExpression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(CatchBlock))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600024E")]
	internal CatchBlock(Type test, ParameterExpression variable, Expression body, Expression filter) { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000251")]
	public Expression get_Body() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000252")]
	public Expression get_Filter() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000250")]
	public Type get_Test() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600024F")]
	public ParameterExpression get_Variable() { }

	[Address(RVA = "0x15944D0", Offset = "0x15936D0", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000253")]
	public virtual string ToString() { }

	[Address(RVA = "0x15945B0", Offset = "0x15937B0", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Expression), Member = "MakeCatchBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ParameterExpression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(CatchBlock))]
	[Token(Token = "0x6000254")]
	public CatchBlock Update(ParameterExpression variable, Expression filter, Expression body) { }

}

