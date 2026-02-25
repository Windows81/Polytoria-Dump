namespace UnityEngine.TerrainUtils;

[Token(Token = "0x2000008")]
internal enum TerrainMapStatusCode
{
	OK = 0,
	Overlapping = 1,
	SizeMismatch = 4,
	EdgeAlignmentMismatch = 8,
}

