namespace System.Runtime.Remoting.Contexts;

[Token(Token = "0x2000365")]
internal class ContextCallbackObject : ContextBoundObject
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B15")]
	public ContextCallbackObject() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B14")]
	public void DoCallBack(CrossContextDelegate deleg) { }

}

