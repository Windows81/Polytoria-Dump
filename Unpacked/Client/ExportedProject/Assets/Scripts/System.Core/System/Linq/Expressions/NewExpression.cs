namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(NewExpressionProxy))]
[Token(Token = "0x20000A2")]
public class NewExpression : Expression
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000166")]
	private IReadOnlyList<Expression> _arguments; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000167")]
	private readonly ConstructorInfo <Constructor>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170000B5")]
	public ConstructorInfo Constructor
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60003F6")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60003F6")]
	public ConstructorInfo get_Constructor() { }

	[Address(RVA = "0x15A7470", Offset = "0x15A6670", Length = "0x54")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileNewExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003F7")]
	public override Expression GetArgument(int index) { }

}

