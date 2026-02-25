namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Method (64), Inherited = False)]
[ComVisible(True)]
[Token(Token = "0x2000441")]
public sealed class PreserveSigAttribute : Attribute
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F79")]
	public PreserveSigAttribute() { }

}

