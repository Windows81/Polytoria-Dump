namespace RLD;

[Flags]
[Token(Token = "0x20001D7")]
public enum GameObjectType
{
	Mesh = 1,
	Terrain = 2,
	Sprite = 4,
	Camera = 8,
	Light = 16,
	ParticleSystem = 32,
	Empty = 64,
}

