namespace System.IO;

[Token(Token = "0x20001E3")]
internal class FileData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400072C")]
	public string Directory; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400072D")]
	public FileAttributes Attributes; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400072E")]
	public bool NotExists; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400072F")]
	public DateTime CreationTime; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000730")]
	public DateTime LastWriteTime; //Field offset: 0x28

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C1D")]
	public FileData() { }

}

