namespace RLD;

[Token(Token = "0x20002B3")]
public sealed class ObjectSelectionManipSessionBeginHandler : MulticastDelegate
{

	[Address(RVA = "0x38DDA0", Offset = "0x38CFA0", Length = "0xA6")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001999")]
	public ObjectSelectionManipSessionBeginHandler(object object, IntPtr method) { }

	[Address(RVA = "0x3EABB0", Offset = "0x3E9DB0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
	[Token(Token = "0x600199B")]
	public override IAsyncResult BeginInvoke(ObjectSelectionManipSession session, AsyncCallback callback, object object) { }

	[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
	[DeduplicatedMethod]
	[Token(Token = "0x600199C")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600199A")]
	public override void Invoke(ObjectSelectionManipSession session) { }

}

