namespace UnityEngine.Networking;

[Token(Token = "0x2000003")]
public struct DownloadedTextureParams
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000006")]
	public DownloadedTextureFlags flags; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000007")]
	public int mipmapCount; //Field offset: 0x4

	[Token(Token = "0x17000001")]
	public static DownloadedTextureParams Default
	{
		[Address(RVA = "0x1CFFA50", Offset = "0x1CFEC50", Length = "0x16")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000001")]
		 get { } //Length: 22
	}

	[Token(Token = "0x17000002")]
	public bool readable
	{
		[Address(RVA = "0x1CFFA70", Offset = "0x1CFEC70", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000002")]
		 set { } //Length: 23
	}

	[Address(RVA = "0x1CFFA50", Offset = "0x1CFEC50", Length = "0x16")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000001")]
	public static DownloadedTextureParams get_Default() { }

	[Address(RVA = "0x1CFFA70", Offset = "0x1CFEC70", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000002")]
	public void set_readable(bool value) { }

	[Address(RVA = "0x19CFB90", Offset = "0x19CED90", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000003")]
	private void SetFlags(DownloadedTextureFlags flgs, bool add) { }

}

