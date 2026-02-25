namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Assembly (1), Inherited = False, AllowMultiple = False)]
[Token(Token = "0x2000479")]
public sealed class RuntimeCompatibilityAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001254")]
	private bool <WrapNonExceptionThrows>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170003FD")]
	public bool WrapNonExceptionThrows
	{
		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002034")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002033")]
	public RuntimeCompatibilityAttribute() { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002034")]
	public void set_WrapNonExceptionThrows(bool value) { }

}

