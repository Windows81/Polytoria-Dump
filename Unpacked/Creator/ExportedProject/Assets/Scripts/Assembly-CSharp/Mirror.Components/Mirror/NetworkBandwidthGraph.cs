namespace Mirror;

[Token(Token = "0x2000043")]
public class NetworkBandwidthGraph : BaseUIGraph
{
	[Token(Token = "0x4000183")]
	private static readonly String[] Units; //Field offset: 0x0
	[Token(Token = "0x4000184")]
	private const float UnitScale = 1024; //Field offset: 0x0
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000181")]
	private int dataIn; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000182")]
	private int dataOut; //Field offset: 0x8C

	[Address(RVA = "0x122C4E0", Offset = "0x122B6E0", Length = "0xF0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000249")]
	private static NetworkBandwidthGraph() { }

	[Address(RVA = "0x122C5E0", Offset = "0x122B7E0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseUIGraph), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000248")]
	public NetworkBandwidthGraph() { }

	[Address(RVA = "0x122C090", Offset = "0x122B290", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000245")]
	protected virtual void CollectData(int category, out float value, out GraphAggregationMode mode) { }

	[Address(RVA = "0x122C170", Offset = "0x122B370", Length = "0x142")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000246")]
	protected virtual string FormatValue(float value) { }

	[Address(RVA = "0x122C2C0", Offset = "0x122B4C0", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NetworkDiagnostics), Member = "remove_InMessageEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<Mirror.NetworkDiagnostics+MessageInfo>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkDiagnostics), Member = "remove_OutMessageEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<Mirror.NetworkDiagnostics+MessageInfo>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000242")]
	private void OnDestroy() { }

	[Address(RVA = "0xF0D3D0", Offset = "0xF0C5D0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000241")]
	private void OnEnable() { }

	[Address(RVA = "0x122C370", Offset = "0x122B570", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000244")]
	private void OnReceive(MessageInfo obj) { }

	[Address(RVA = "0x122C380", Offset = "0x122B580", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000243")]
	private void OnSend(MessageInfo obj) { }

	[Address(RVA = "0x122C390", Offset = "0x122B590", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseUIGraph), Member = "OnValidate", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000247")]
	protected virtual void OnValidate() { }

	[Address(RVA = "0x122C430", Offset = "0x122B630", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NetworkDiagnostics), Member = "add_InMessageEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<Mirror.NetworkDiagnostics+MessageInfo>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkDiagnostics), Member = "add_OutMessageEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<Mirror.NetworkDiagnostics+MessageInfo>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000240")]
	private void Start() { }

}

