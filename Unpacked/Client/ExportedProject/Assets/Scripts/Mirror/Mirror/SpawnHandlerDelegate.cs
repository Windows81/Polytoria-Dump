namespace Mirror;

[Token(Token = "0x200009A")]
public sealed class SpawnHandlerDelegate : MulticastDelegate
{

	[Address(RVA = "0x12A33A0", Offset = "0x12A25A0", Length = "0xA6")]
	[CalledBy(Type = typeof(NetworkClient), Member = "RegisterPrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(uint), typeof(SpawnDelegate), typeof(UnSpawnDelegate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "RegisterPrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(SpawnDelegate), typeof(UnSpawnDelegate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "RegisterSpawnHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(SpawnDelegate), typeof(UnSpawnDelegate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004CC")]
	public SpawnHandlerDelegate(object object, IntPtr method) { }

	[Address(RVA = "0x12A3310", Offset = "0x12A2510", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
	[Token(Token = "0x60004CE")]
	public override IAsyncResult BeginInvoke(SpawnMessage msg, AsyncCallback callback, object object) { }

	[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004CF")]
	public override GameObject EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x80C170", Offset = "0x80B370", Length = "0x48")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004CD")]
	public override GameObject Invoke(SpawnMessage msg) { }

}

