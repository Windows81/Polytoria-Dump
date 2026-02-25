namespace GLTFast;

[Flags]
[Token(Token = "0x200005F")]
internal enum MainBufferType
{
	None = 0,
	Position = 1,
	Normal = 2,
	Tangent = 4,
	PosNorm = 3,
	PosNormTan = 7,
}

