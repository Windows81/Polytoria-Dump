namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True, Inherited = False)]
[Token(Token = "0x200049B")]
public sealed class InternalsVisibleToAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001289")]
	private string _assemblyName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400128A")]
	private bool _allInternalsVisible; //Field offset: 0x18

	[Token(Token = "0x1700040D")]
	public bool AllInternalsVisible
	{
		[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60020A6")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x13BA720", Offset = "0x13B9920", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020A5")]
	public InternalsVisibleToAttribute(string assemblyName) { }

	[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020A6")]
	public void set_AllInternalsVisible(bool value) { }

}

