namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Delegate (4096), AllowMultiple = False, Inherited = False)]
[ComVisible(True)]
[Token(Token = "0x2000436")]
public sealed class UnmanagedFunctionPointerAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400119B")]
	private CallingConvention m_callingConvention; //Field offset: 0x10

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F72")]
	public UnmanagedFunctionPointerAttribute(CallingConvention callingConvention) { }

}

