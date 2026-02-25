namespace System.Reflection;

[Flags]
[Token(Token = "0x20004EA")]
public enum ResourceLocation
{
	ContainedInAnotherAssembly = 2,
	ContainedInManifestFile = 4,
	Embedded = 1,
}

