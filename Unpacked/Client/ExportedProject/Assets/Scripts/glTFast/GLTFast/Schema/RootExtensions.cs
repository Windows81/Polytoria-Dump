namespace GLTFast.Schema;

[Token(Token = "0x20000C9")]
public class RootExtensions
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002CC")]
	public LightsPunctual KHR_lights_punctual; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002CD")]
	public MaterialsVariantsRootExtension KHR_materials_variants; //Field offset: 0x18

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000262")]
	public RootExtensions() { }

	[Address(RVA = "0x107A000", Offset = "0x1079200", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000261")]
	public override bool JsonUtilityCleanup() { }

}

