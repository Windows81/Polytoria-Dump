namespace UnityEngine.EventSystems;

[Token(Token = "0x200009B")]
public abstract class AbstractEventData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002CE")]
	protected bool m_Used; //Field offset: 0x10

	[Token(Token = "0x1700019E")]
	public override bool used
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000633")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000634")]
	protected AbstractEventData() { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000633")]
	public override bool get_used() { }

	[Address(RVA = "0x1A96F40", Offset = "0x1A96140", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000631")]
	public override void Reset() { }

	[Address(RVA = "0x551C10", Offset = "0x550E10", Length = "0x5")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000632")]
	public override void Use() { }

}

