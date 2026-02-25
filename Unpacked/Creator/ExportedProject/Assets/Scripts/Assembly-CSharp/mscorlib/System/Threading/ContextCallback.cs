namespace System.Threading;

[ComVisible(True)]
[Token(Token = "0x200021C")]
public sealed class ContextCallback : MulticastDelegate
{

	[Address(RVA = "0x3CD330", Offset = "0x3CC530", Length = "0x124")]
	[CallerCount(Count = 83)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60011D0")]
	public ContextCallback(object object, IntPtr method) { }

	[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011D1")]
	public override void Invoke(object state) { }

}

