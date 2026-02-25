namespace GLTFast;

[DefaultExecutionOrder(-1)]
[Token(Token = "0x2000055")]
internal class UninterruptedDefaultDeferAgent : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001A9")]
	private UninterruptedDeferAgent m_DeferAgent; //Field offset: 0x20

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015F")]
	public UninterruptedDefaultDeferAgent() { }

	[Address(RVA = "0x10848A0", Offset = "0x1083AA0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GltfImportBase), Member = "UnsetDefaultDeferAgent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDeferAgent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600015E")]
	private void OnDisable() { }

	[Address(RVA = "0x1084910", Offset = "0x1083B10", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600015D")]
	private void OnEnable() { }

}

