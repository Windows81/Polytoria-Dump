namespace System.Linq.Expressions;

[Token(Token = "0x2000085")]
internal sealed class FullExpression : ExpressionN<TDelegate>
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000136")]
	private readonly string <NameCore>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000137")]
	private readonly bool <TailCallCore>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x1700008C")]
	internal virtual string NameCore
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000385")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700008D")]
	internal virtual bool TailCallCore
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000386")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0xC42200", Offset = "0xC41400", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000384")]
	public FullExpression`1(Expression body, string name, bool tailCall, IReadOnlyList<ParameterExpression> parameters) { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000385")]
	internal virtual string get_NameCore() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000386")]
	internal virtual bool get_TailCallCore() { }

}

