namespace Polytoria.Controllers;

[Token(Token = "0x2000405")]
public class ImageCacheEntry
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010DC")]
	public Texture2D texture; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40010DD")]
	public bool loaded; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x40010DE")]
	public bool hasTransparency; //Field offset: 0x19

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B1B")]
	public ImageCacheEntry() { }

}

