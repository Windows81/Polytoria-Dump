namespace System.Linq.Expressions;

[Token(Token = "0x20000A4")]
internal sealed class ByRefParameterExpression : TypedParameterExpression
{

	[Address(RVA = "0x1593B10", Offset = "0x1592D10", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypedParameterExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000400")]
	internal ByRefParameterExpression(Type type, string name) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000401")]
	internal virtual bool GetIsByRef() { }

}

