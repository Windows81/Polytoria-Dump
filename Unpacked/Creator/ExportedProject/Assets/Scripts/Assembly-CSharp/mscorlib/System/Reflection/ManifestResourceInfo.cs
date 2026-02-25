namespace System.Reflection;

[Token(Token = "0x20004D8")]
public class ManifestResourceInfo
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001340")]
	private readonly Assembly <ReferencedAssembly>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001341")]
	private readonly string <FileName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001342")]
	private readonly ResourceLocation <ResourceLocation>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000430")]
	public override string FileName
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600219D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700042F")]
	public override Assembly ReferencedAssembly
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600219C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000431")]
	public override ResourceLocation ResourceLocation
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600219E")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1139D30", Offset = "0x1138F30", Length = "0x5F")]
	[CallerCount(Count = 46)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600219B")]
	public ManifestResourceInfo(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600219D")]
	public override string get_FileName() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600219C")]
	public override Assembly get_ReferencedAssembly() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600219E")]
	public override ResourceLocation get_ResourceLocation() { }

}

