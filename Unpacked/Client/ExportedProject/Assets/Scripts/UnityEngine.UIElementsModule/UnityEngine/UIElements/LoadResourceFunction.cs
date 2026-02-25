namespace UnityEngine.UIElements;

[Token(Token = "0x20002AD")]
internal sealed class LoadResourceFunction : MulticastDelegate
{

	[Address(RVA = "0x1C870D0", Offset = "0x1C862D0", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001287")]
	public LoadResourceFunction(object object, IntPtr method) { }

	[Address(RVA = "0xC48500", Offset = "0xC47700", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001288")]
	public override object Invoke(string pathName, Type type, float dpiScaling) { }

}

