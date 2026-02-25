namespace Mirror;

[Flags]
[Token(Token = "0x2000031")]
public enum Changed
{
	None = 0,
	PosX = 1,
	PosY = 2,
	PosZ = 4,
	CompressRot = 8,
	RotX = 16,
	RotY = 32,
	RotZ = 64,
	Scale = 128,
	Pos = 7,
	Rot = 112,
}

