namespace RLD;

[Token(Token = "0x20002BD")]
public sealed class ObjectSelectionPreSelectCustomizeHandler : MulticastDelegate
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
	[Token(Token = "0x60019C1")]
	public ObjectSelectionPreSelectCustomizeHandler(object object, IntPtr method) { }

	[Address(RVA = "0x335300", Offset = "0x334500", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60019C3")]
	public override IAsyncResult BeginInvoke(ObjectPreSelectCustomizeInfo customizeInfo, List<GameObject> toBeSelected, AsyncCallback callback, object object) { }

	[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
	[DeduplicatedMethod]
	[Token(Token = "0x60019C4")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019C2")]
	public override void Invoke(ObjectPreSelectCustomizeInfo customizeInfo, List<GameObject> toBeSelected) { }

}

