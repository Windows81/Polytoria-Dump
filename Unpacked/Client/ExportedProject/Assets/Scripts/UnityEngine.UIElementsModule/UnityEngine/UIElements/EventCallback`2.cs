namespace UnityEngine.UIElements;

[Token(Token = "0x20001C0")]
public sealed class EventCallback : MulticastDelegate
{

	[Address(RVA = "0x3EACB0", Offset = "0x3E9EB0", Length = "0x125")]
	[CallerCount(Count = 71)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CC6")]
	public EventCallback`2(object object, IntPtr method) { }

	[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CC7")]
	public override void Invoke(TEventType evt, TCallbackArgs userArgs) { }

}

