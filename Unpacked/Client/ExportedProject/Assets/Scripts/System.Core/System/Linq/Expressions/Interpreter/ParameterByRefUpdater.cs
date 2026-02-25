namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000183")]
internal sealed class ParameterByRefUpdater : ByRefUpdater
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000305")]
	private readonly LocalVariable _parameter; //Field offset: 0x18

	[Address(RVA = "0x15E0710", Offset = "0x15DF910", Length = "0x41")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007F8")]
	public ParameterByRefUpdater(LocalVariable parameter, int argumentIndex) { }

	[Address(RVA = "0x15E0560", Offset = "0x15DF760", Length = "0x1A2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60007F9")]
	public virtual void Update(InterpretedFrame frame, object value) { }

}

