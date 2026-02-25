namespace Unity.IO.Archive;

[NativeHeader("Runtime/VirtualFileSystem/ArchiveFileSystem/ArchiveFileHandle.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000031")]
public struct ArchiveFileInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000099")]
	public string Filename; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400009A")]
	public ulong FileSize; //Field offset: 0x8

}

