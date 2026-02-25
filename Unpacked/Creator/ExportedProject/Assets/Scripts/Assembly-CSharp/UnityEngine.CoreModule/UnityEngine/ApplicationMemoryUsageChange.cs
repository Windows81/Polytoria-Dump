namespace UnityEngine;

[Token(Token = "0x2000075")]
public struct ApplicationMemoryUsageChange
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000F3")]
	private ApplicationMemoryUsage <memoryUsage>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x1700003F")]
	private ApplicationMemoryUsage memoryUsage
	{
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600019A")]
		private set { } //Length: 3
	}

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600019B")]
	public ApplicationMemoryUsageChange(ApplicationMemoryUsage usage) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600019A")]
	private void set_memoryUsage(ApplicationMemoryUsage value) { }

}

