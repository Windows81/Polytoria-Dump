namespace UnityEngine.TerrainUtils;

[IsReadOnly]
[Token(Token = "0x2000009")]
public struct TerrainTileCoord
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001A")]
	public readonly int tileX; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400001B")]
	public readonly int tileZ; //Field offset: 0x4

	[Address(RVA = "0x3AFE70", Offset = "0x3AF070", Length = "0x7")]
	[CallerCount(Count = 47)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001D")]
	public TerrainTileCoord(int tileX, int tileZ) { }

}

