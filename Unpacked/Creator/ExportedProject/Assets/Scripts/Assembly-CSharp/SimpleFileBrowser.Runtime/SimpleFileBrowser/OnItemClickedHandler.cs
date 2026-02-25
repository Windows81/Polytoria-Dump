namespace SimpleFileBrowser;

[Token(Token = "0x200001F")]
public sealed class OnItemClickedHandler : MulticastDelegate
{

	[Address(RVA = "0x3351D0", Offset = "0x3343D0", Length = "0x124")]
	[CallerCount(Count = 654)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x600010D")]
	public OnItemClickedHandler(object object, IntPtr method) { }

	[Address(RVA = "0x309230", Offset = "0x308430", Length = "0x21")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
	[DeduplicatedMethod]
	[Token(Token = "0x600010F")]
	public override IAsyncResult BeginInvoke(ListItem item, AsyncCallback callback, object object) { }

	[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000110")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600010E")]
	public override void Invoke(ListItem item) { }

}

