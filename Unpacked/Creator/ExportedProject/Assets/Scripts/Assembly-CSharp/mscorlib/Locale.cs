//Type is in global namespace

[Token(Token = "0x200002A")]
internal sealed class Locale
{

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000042")]
	public static string GetText(string msg) { }

	[Address(RVA = "0x12AD9E0", Offset = "0x12ACBE0", Length = "0x8")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000043")]
	public static string GetText(string fmt, Object[] args) { }

}

