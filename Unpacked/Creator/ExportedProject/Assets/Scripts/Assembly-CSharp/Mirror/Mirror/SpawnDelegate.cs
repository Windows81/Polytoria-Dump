namespace Mirror;

[Token(Token = "0x2000099")]
public sealed class SpawnDelegate : MulticastDelegate
{

	[Address(RVA = "0x12A3260", Offset = "0x12A2460", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004C8")]
	public SpawnDelegate(object object, IntPtr method) { }

	[Address(RVA = "0x12A31C0", Offset = "0x12A23C0", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
	[Token(Token = "0x60004CA")]
	public override IAsyncResult BeginInvoke(Vector3 position, uint assetId, AsyncCallback callback, object object) { }

	[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004CB")]
	public override GameObject EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0xA30CB0", Offset = "0xA2FEB0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004C9")]
	public override GameObject Invoke(Vector3 position, uint assetId) { }

}

