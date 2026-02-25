namespace RLD;

[Token(Token = "0x2000155")]
public class YesNoAnswer
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000627")]
	private bool _hasYes; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4000628")]
	private bool _hasNo; //Field offset: 0x11

	[Token(Token = "0x17000542")]
	public bool HasNo
	{
		[Address(RVA = "0x3CE370", Offset = "0x3CD570", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F83")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000543")]
	public bool HasOnlyYes
	{
		[Address(RVA = "0x551C20", Offset = "0x550E20", Length = "0x11")]
		[CalledBy(Type = typeof(RTObjectSelection), Member = "OnInputDevicePickButtonDown", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTObjectSelection), Member = "OnInputDevicePickButtonUp", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000F84")]
		 get { } //Length: 17
	}

	[Token(Token = "0x17000541")]
	public bool HasYes
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F82")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F87")]
	public YesNoAnswer() { }

	[Address(RVA = "0x3CE370", Offset = "0x3CD570", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F83")]
	public bool get_HasNo() { }

	[Address(RVA = "0x551C20", Offset = "0x550E20", Length = "0x11")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "OnInputDevicePickButtonDown", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "OnInputDevicePickButtonUp", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F84")]
	public bool get_HasOnlyYes() { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F82")]
	public bool get_HasYes() { }

	[Address(RVA = "0x551C00", Offset = "0x550E00", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F86")]
	public void No() { }

	[Address(RVA = "0x551C10", Offset = "0x550E10", Length = "0x5")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F85")]
	public void Yes() { }

}

