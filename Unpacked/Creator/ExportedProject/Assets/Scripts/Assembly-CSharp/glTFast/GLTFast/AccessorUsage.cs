namespace GLTFast;

[Flags]
[Token(Token = "0x2000002")]
internal enum AccessorUsage
{
	Unknown = 0,
	Ignore = 1,
	Index = 2,
	IndexFlipped = 4,
	Position = 8,
	Normal = 16,
	Tangent = 32,
	UV = 64,
	Color = 128,
	InverseBindMatrix = 256,
	AnimationTimes = 512,
	Translation = 1024,
	Rotation = 2048,
	Scale = 4096,
	Weight = 8192,
	RequiredForInstantiation = 16384,
}

