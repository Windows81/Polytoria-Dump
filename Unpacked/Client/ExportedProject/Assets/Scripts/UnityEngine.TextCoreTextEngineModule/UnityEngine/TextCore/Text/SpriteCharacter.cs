namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000034")]
public class SpriteCharacter : TextElement
{
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000153")]
	private string m_Name; //Field offset: 0x30

	[Token(Token = "0x17000033")]
	public string name
	{
		[Address(RVA = "0x19865B0", Offset = "0x19857B0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600014A")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x18ED000", Offset = "0x18EC200", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600014B")]
	public SpriteCharacter() { }

	[Address(RVA = "0x19865B0", Offset = "0x19857B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600014A")]
	public string get_name() { }

}

