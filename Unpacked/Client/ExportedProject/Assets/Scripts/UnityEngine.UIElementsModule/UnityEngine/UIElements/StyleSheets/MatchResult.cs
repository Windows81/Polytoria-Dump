namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x200060D")]
internal struct MatchResult
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001690")]
	public MatchResultErrorCode errorCode; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001691")]
	public string errorValue; //Field offset: 0x8

	[Token(Token = "0x17000AE4")]
	public bool success
	{
		[Address(RVA = "0x1BBF6F0", Offset = "0x1BBE8F0", Length = "0x9")]
		[CalledBy(Type = typeof(StyleVariableResolver), Member = "ValidateResolvedValues", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002A83")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x1BBF6F0", Offset = "0x1BBE8F0", Length = "0x9")]
	[CalledBy(Type = typeof(StyleVariableResolver), Member = "ValidateResolvedValues", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A83")]
	public bool get_success() { }

}

