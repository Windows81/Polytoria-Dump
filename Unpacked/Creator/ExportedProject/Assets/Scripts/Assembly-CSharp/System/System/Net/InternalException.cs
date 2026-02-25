namespace System.Net;

[Token(Token = "0x200022F")]
internal class InternalException : SystemException
{

	[Address(RVA = "0x1337610", Offset = "0x1336810", Length = "0x7")]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E0B")]
	internal InternalException() { }

}

