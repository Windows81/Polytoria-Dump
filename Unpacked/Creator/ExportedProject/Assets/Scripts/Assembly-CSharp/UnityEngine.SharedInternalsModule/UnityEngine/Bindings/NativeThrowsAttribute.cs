namespace UnityEngine.Bindings;

[AttributeUsage(192)]
[Token(Token = "0x2000018")]
[VisibleToOtherModules]
internal class NativeThrowsAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000020")]
	private bool <ThrowsException>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000012")]
	public override bool ThrowsException
	{
		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000032")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1A19880", Offset = "0x1A18A80", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000033")]
	public NativeThrowsAttribute() { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000032")]
	public override void set_ThrowsException(bool value) { }

}

