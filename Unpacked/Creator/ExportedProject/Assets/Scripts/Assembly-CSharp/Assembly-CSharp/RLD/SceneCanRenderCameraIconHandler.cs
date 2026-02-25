namespace RLD;

[Token(Token = "0x200020E")]
public sealed class SceneCanRenderCameraIconHandler : MulticastDelegate
{

	[Address(RVA = "0x53F5F0", Offset = "0x53E7F0", Length = "0xB5")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001407")]
	public SceneCanRenderCameraIconHandler(object object, IntPtr method) { }

	[Address(RVA = "0x335300", Offset = "0x334500", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001409")]
	public override IAsyncResult BeginInvoke(Camera camera, YesNoAnswer answer, AsyncCallback callback, object object) { }

	[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
	[DeduplicatedMethod]
	[Token(Token = "0x600140A")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001408")]
	public override void Invoke(Camera camera, YesNoAnswer answer) { }

}

