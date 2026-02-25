namespace GLTFast;

[Flags]
[Token(Token = "0x2000008")]
public enum ComponentType
{
	None = 0,
	Mesh = 2,
	Animation = 4,
	Camera = 8,
	Light = 16,
	All = -1,
}

