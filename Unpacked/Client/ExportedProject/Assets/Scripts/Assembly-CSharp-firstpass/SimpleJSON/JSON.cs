namespace SimpleJSON;

[Token(Token = "0x2000039")]
public static class JSON
{

	[Address(RVA = "0x300CE0", Offset = "0x2FFEE0", Length = "0x7")]
	[CallerCount(Count = 30)]
	[Calls(Type = typeof(JSONNode), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JSONNode))]
	[Token(Token = "0x600046A")]
	public static JSONNode Parse(string aJSON) { }

}

