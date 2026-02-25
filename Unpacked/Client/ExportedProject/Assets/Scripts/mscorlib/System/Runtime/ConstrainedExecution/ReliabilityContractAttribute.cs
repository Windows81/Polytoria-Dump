namespace System.Runtime.ConstrainedExecution;

[AttributeUsage(1133, Inherited = False)]
[Token(Token = "0x200045D")]
public sealed class ReliabilityContractAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001240")]
	private readonly Consistency <ConsistencyGuarantee>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001241")]
	private readonly Cer <Cer>k__BackingField; //Field offset: 0x14

	[Address(RVA = "0x13C1770", Offset = "0x13C0970", Length = "0x34")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002000")]
	public ReliabilityContractAttribute(Consistency consistencyGuarantee, Cer cer) { }

}

