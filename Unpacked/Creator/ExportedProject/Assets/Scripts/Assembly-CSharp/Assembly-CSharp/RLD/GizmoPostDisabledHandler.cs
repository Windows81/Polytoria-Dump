namespace RLD;

[Token(Token = "0x200005C")]
public sealed class GizmoPostDisabledHandler : MulticastDelegate
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
	[Token(Token = "0x60002C9")]
	public GizmoPostDisabledHandler(object object, IntPtr method) { }

	[Address(RVA = "0x309230", Offset = "0x308430", Length = "0x21")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002CB")]
	public override IAsyncResult BeginInvoke(Gizmo gizmo, AsyncCallback callback, object object) { }

	[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
	[DeduplicatedMethod]
	[Token(Token = "0x60002CC")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002CA")]
	public override void Invoke(Gizmo gizmo) { }

}

