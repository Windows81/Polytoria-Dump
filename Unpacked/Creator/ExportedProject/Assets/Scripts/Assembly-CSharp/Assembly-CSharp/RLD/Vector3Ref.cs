namespace RLD;

[Token(Token = "0x20001C2")]
public class Vector3Ref
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000720")]
	private Vector3 _value; //Field offset: 0x10

	[Token(Token = "0x170005BA")]
	public Vector3 Value
	{
		[Address(RVA = "0x53F270", Offset = "0x53E470", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001213")]
		 get { } //Length: 19
		[Address(RVA = "0x58D8B0", Offset = "0x58CAB0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001214")]
		 set { } //Length: 16
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001215")]
	public Vector3Ref() { }

	[Address(RVA = "0x58D870", Offset = "0x58CA70", Length = "0x31")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001216")]
	public Vector3Ref(Vector3 vec) { }

	[Address(RVA = "0x53F270", Offset = "0x53E470", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001213")]
	public Vector3 get_Value() { }

	[Address(RVA = "0x58D8B0", Offset = "0x58CAB0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001214")]
	public void set_Value(Vector3 value) { }

}

