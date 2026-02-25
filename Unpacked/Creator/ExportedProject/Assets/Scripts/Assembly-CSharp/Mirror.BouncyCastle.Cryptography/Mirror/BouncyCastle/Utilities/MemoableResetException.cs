namespace Mirror.BouncyCastle.Utilities;

[Token(Token = "0x200000A")]
public class MemoableResetException : InvalidCastException
{

	[Address(RVA = "0x10BD510", Offset = "0x10BC710", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000036")]
	public MemoableResetException() { }

	[Address(RVA = "0x10BD520", Offset = "0x10BC720", Length = "0x8")]
	[CalledBy(Type = typeof(Sha512tDigest), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemoable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000037")]
	public MemoableResetException(string message) { }

	[Address(RVA = "0x10BD4F0", Offset = "0x10BC6F0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000038")]
	protected MemoableResetException(SerializationInfo info, StreamingContext context) { }

}

