namespace System.Diagnostics;

[AttributeUsage(3, AllowMultiple = False)]
[ComVisible(True)]
[Token(Token = "0x2000578")]
public sealed class DebuggableAttribute : Attribute
{
	[ComVisible(True)]
	[Flags]
	[Token(Token = "0x2000579")]
	internal enum DebuggingModes
	{
		None = 0,
		Default = 1,
		DisableOptimizations = 256,
		IgnoreSymbolStoreSequencePoints = 2,
		EnableEditAndContinue = 4,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001755")]
	private DebuggingModes m_debuggingModes; //Field offset: 0x10

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600282D")]
	public DebuggableAttribute(DebuggingModes modes) { }

}

