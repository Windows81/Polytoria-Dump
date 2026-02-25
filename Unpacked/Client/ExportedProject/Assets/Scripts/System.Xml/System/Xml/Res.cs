namespace System.Xml;

[Token(Token = "0x20000BE")]
internal static class Res
{

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000838")]
	public static string GetString(string name) { }

	[Address(RVA = "0x16B0F70", Offset = "0x16B0170", Length = "0x11")]
	[CallerCount(Count = 82)]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Token(Token = "0x6000839")]
	public static string GetString(string name, Object[] args) { }

}

