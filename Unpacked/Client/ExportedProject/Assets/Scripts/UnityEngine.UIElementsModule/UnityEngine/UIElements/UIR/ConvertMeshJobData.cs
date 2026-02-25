namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200056F")]
internal struct ConvertMeshJobData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40012B4")]
	public IntPtr vertSrc; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40012B5")]
	public IntPtr vertDst; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012B6")]
	public int vertCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40012B7")]
	public Matrix4x4 transform; //Field offset: 0x14
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40012B8")]
	public Color32 xformClipPages; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40012B9")]
	public Color32 ids; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40012BA")]
	public Color32 addFlags; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40012BB")]
	public Color32 opacityPage; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40012BC")]
	public Color32 textCoreSettingsPage; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40012BD")]
	public int usesTextCoreSettings; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40012BE")]
	public float textureId; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40012BF")]
	public int gradientSettingsIndexOffset; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40012C0")]
	public IntPtr indexSrc; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40012C1")]
	public IntPtr indexDst; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40012C2")]
	public int indexCount; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x40012C3")]
	public int indexOffset; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40012C4")]
	public int flipIndices; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x40012C5")]
	public int forceZ; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40012C6")]
	public float positionZ; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40012C7")]
	public int remapUVs; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40012C8")]
	public Rect atlasRect; //Field offset: 0xA0

}

