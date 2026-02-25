namespace Unity.Jobs.LowLevel.Unsafe;

[AttributeUsage(AttributeTargets::Interface (1024))]
[Token(Token = "0x2000012")]
public sealed class JobProducerTypeAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000E")]
	private readonly Type <ProducerType>k__BackingField; //Field offset: 0x10

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000028")]
	public JobProducerTypeAttribute(Type producerType) { }

}

