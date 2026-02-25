namespace MoonSharp.Interpreter;

[Token(Token = "0x200004F")]
public sealed class ScriptFunctionDelegate : MulticastDelegate
{

	[Address(RVA = "0xC45570", Offset = "0xC44770", Length = "0x10F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000532")]
	public ScriptFunctionDelegate`1(object object, IntPtr method) { }

	[Address(RVA = "0x309230", Offset = "0x308430", Length = "0x21")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000534")]
	public override IAsyncResult BeginInvoke(Object[] args, AsyncCallback callback, object object) { }

	[Address(RVA = "0xF0D520", Offset = "0xF0C720", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_from_il2cpp_type")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EDA30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000535")]
	public override T EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000533")]
	public override T Invoke(Object[] args) { }

}

