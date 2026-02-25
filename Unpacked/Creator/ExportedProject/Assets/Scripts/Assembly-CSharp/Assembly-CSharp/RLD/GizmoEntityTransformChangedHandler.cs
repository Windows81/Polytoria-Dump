namespace RLD;

[Token(Token = "0x2000039")]
public sealed class GizmoEntityTransformChangedHandler : MulticastDelegate
{

	[Address(RVA = "0x3B92A0", Offset = "0x3B84A0", Length = "0x125")]
	[CallerCount(Count = 50)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000184")]
	public GizmoEntityTransformChangedHandler(object object, IntPtr method) { }

	[Address(RVA = "0x3B9210", Offset = "0x3B8410", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
	[Token(Token = "0x6000186")]
	public override IAsyncResult BeginInvoke(GizmoTransform transform, ChangeData changeData, AsyncCallback callback, object object) { }

	[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000187")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000185")]
	public override void Invoke(GizmoTransform transform, ChangeData changeData) { }

}

