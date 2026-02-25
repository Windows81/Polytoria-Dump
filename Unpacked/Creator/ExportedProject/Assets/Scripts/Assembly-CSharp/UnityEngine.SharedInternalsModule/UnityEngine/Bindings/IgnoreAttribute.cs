namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets::Field (256))]
[Token(Token = "0x2000019")]
[VisibleToOtherModules]
internal class IgnoreAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000021")]
	private bool <DoesNotContributeToSize>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000013")]
	public bool DoesNotContributeToSize
	{
		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000034")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000035")]
	public IgnoreAttribute() { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000034")]
	public void set_DoesNotContributeToSize(bool value) { }

}

