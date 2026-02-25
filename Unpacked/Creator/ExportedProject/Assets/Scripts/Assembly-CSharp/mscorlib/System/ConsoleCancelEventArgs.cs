namespace System;

[Token(Token = "0x200015D")]
public sealed class ConsoleCancelEventArgs : EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004BE")]
	private readonly ConsoleSpecialKey _type; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40004BF")]
	private bool <Cancel>k__BackingField; //Field offset: 0x14

	[Token(Token = "0x17000105")]
	public bool Cancel
	{
		[Address(RVA = "0x59B000", Offset = "0x59A200", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BF8")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x14B9900", Offset = "0x14B8B00", Length = "0x58")]
	[CalledBy(Type = typeof(Console), Member = "DoConsoleCancelEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BF7")]
	internal ConsoleCancelEventArgs(ConsoleSpecialKey type) { }

	[Address(RVA = "0x14B9960", Offset = "0x14B8B60", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x6000BF9")]
	internal ConsoleCancelEventArgs() { }

	[Address(RVA = "0x59B000", Offset = "0x59A200", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BF8")]
	public bool get_Cancel() { }

}

