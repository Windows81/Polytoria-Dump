namespace GLTFast.Schema;

[Token(Token = "0x200009C")]
public class LightsPunctual
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400025F")]
	public LightPunctual[] lights; //Field offset: 0x10

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E7")]
	public LightsPunctual() { }

	[Address(RVA = "0x5A28B0", Offset = "0x5A1AB0", Length = "0x9")]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E6")]
	public bool JsonUtilityCleanup() { }

}

