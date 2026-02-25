namespace RLD;

[Token(Token = "0x20002B6")]
public sealed class ObjectSelectionCanMultiSelectDeselectHandler : MulticastDelegate
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
	[Token(Token = "0x60019A5")]
	public ObjectSelectionCanMultiSelectDeselectHandler(object object, IntPtr method) { }

	[Address(RVA = "0x309230", Offset = "0x308430", Length = "0x21")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60019A7")]
	public override IAsyncResult BeginInvoke(YesNoAnswer answer, AsyncCallback callback, object object) { }

	[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
	[DeduplicatedMethod]
	[Token(Token = "0x60019A8")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019A6")]
	public override void Invoke(YesNoAnswer answer) { }

}

