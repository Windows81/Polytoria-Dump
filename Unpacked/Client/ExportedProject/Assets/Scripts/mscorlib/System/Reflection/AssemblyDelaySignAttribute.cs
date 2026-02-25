namespace System.Reflection;

[AttributeUsage(AttributeTargets::Assembly (1), Inherited = False)]
[Token(Token = "0x20004BD")]
public sealed class AssemblyDelaySignAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012E9")]
	private readonly bool <DelaySign>k__BackingField; //Field offset: 0x10

	[Address(RVA = "0x2FE860", Offset = "0x2FDA60", Length = "0x26")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002144")]
	public AssemblyDelaySignAttribute(bool delaySign) { }

}

