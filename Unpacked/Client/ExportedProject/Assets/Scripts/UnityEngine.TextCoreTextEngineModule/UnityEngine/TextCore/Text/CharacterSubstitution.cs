namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000051")]
internal struct CharacterSubstitution
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002F8")]
	public int index; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40002F9")]
	public uint unicode; //Field offset: 0x4

	[Address(RVA = "0x3AFE70", Offset = "0x3AF070", Length = "0x7")]
	[CallerCount(Count = 47)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000204")]
	public CharacterSubstitution(int index, uint unicode) { }

}

