namespace RLD;

[Token(Token = "0x20002BE")]
public sealed class ObjectSelectionPreDeselectCustomizeHandler : MulticastDelegate
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
	[Token(Token = "0x60019C5")]
	public ObjectSelectionPreDeselectCustomizeHandler(object object, IntPtr method) { }

	[Address(RVA = "0x335300", Offset = "0x334500", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60019C7")]
	public override IAsyncResult BeginInvoke(ObjectPreDeselectCustomizeInfo customizeInfo, List<GameObject> toBeDeselected, AsyncCallback callback, object object) { }

	[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
	[DeduplicatedMethod]
	[Token(Token = "0x60019C8")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019C6")]
	public override void Invoke(ObjectPreDeselectCustomizeInfo customizeInfo, List<GameObject> toBeDeselected) { }

}

