namespace System.Threading.Tasks;

[Token(Token = "0x2000280")]
public class UnobservedTaskExceptionEventArgs : EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B48")]
	private AggregateException m_exception; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B49")]
	internal bool m_observed; //Field offset: 0x18

	[Address(RVA = "0x153AB40", Offset = "0x1539D40", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001485")]
	public UnobservedTaskExceptionEventArgs(AggregateException exception) { }

}

