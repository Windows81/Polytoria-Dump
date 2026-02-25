namespace MoonSharp.Interpreter.Execution;

[Token(Token = "0x2000142")]
internal class LoopTracker
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004DD")]
	public FastStack<ILoop> Loops; //Field offset: 0x10

	[Address(RVA = "0x358370", Offset = "0x357570", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FastStack`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BE0")]
	public LoopTracker() { }

}

