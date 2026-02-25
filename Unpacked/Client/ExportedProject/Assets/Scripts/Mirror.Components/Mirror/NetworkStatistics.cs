namespace Mirror;

[AddComponentMenu("Network/Network Statistics")]
[DisallowMultipleComponent]
[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-statistics")]
[Token(Token = "0x200002D")]
public class NetworkStatistics : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000BF")]
	private double intervalStartTime; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	[Token(Token = "0x40000C0")]
	public int clientIntervalReceivedPackets; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	[Token(Token = "0x40000C1")]
	public long clientIntervalReceivedBytes; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	[Token(Token = "0x40000C2")]
	public int clientIntervalSentPackets; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	[Token(Token = "0x40000C3")]
	public long clientIntervalSentBytes; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[HideInInspector]
	[Token(Token = "0x40000C4")]
	public int clientReceivedPacketsPerSecond; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[HideInInspector]
	[Token(Token = "0x40000C5")]
	public long clientReceivedBytesPerSecond; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[HideInInspector]
	[Token(Token = "0x40000C6")]
	public int clientSentPacketsPerSecond; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[HideInInspector]
	[Token(Token = "0x40000C7")]
	public long clientSentBytesPerSecond; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[HideInInspector]
	[Token(Token = "0x40000C8")]
	public int serverIntervalReceivedPackets; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[HideInInspector]
	[Token(Token = "0x40000C9")]
	public long serverIntervalReceivedBytes; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[HideInInspector]
	[Token(Token = "0x40000CA")]
	public int serverIntervalSentPackets; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[HideInInspector]
	[Token(Token = "0x40000CB")]
	public long serverIntervalSentBytes; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[HideInInspector]
	[Token(Token = "0x40000CC")]
	public int serverReceivedPacketsPerSecond; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[HideInInspector]
	[Token(Token = "0x40000CD")]
	public long serverReceivedBytesPerSecond; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[HideInInspector]
	[Token(Token = "0x40000CE")]
	public int serverSentPacketsPerSecond; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	[Token(Token = "0x40000CF")]
	public long serverSentBytesPerSecond; //Field offset: 0xA0

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000159")]
	public NetworkStatistics() { }

	[Address(RVA = "0x121DB20", Offset = "0x121CD20", Length = "0x185")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(GUILayout), Member = "BeginVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayout), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Utils), Member = "PrettyBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GUILayout), Member = "EndVertical", ReturnType = typeof(void))]
	[Token(Token = "0x6000157")]
	private void OnClientGUI() { }

	[Address(RVA = "0x121DCB0", Offset = "0x121CEB0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600014F")]
	private void OnClientReceive(ArraySegment<Byte> data, int channelId) { }

	[Address(RVA = "0x121DD30", Offset = "0x121CF30", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000150")]
	private void OnClientSend(ArraySegment<Byte> data, int channelId) { }

	[Address(RVA = "0x121DDB0", Offset = "0x121CFB0", Length = "0x372")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Action`2<System.ArraySegment`1<System.Byte>, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Action`3<System.Int32, System.ArraySegment`1<System.Byte>, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600014E")]
	private void OnDestroy() { }

	[Address(RVA = "0x121E130", Offset = "0x121D330", Length = "0x447")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUILayout), Member = "BeginArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(GUILayout), Member = "BeginVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayout), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Utils), Member = "PrettyBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GUILayout), Member = "EndVertical", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayout), Member = "EndArea", ReturnType = typeof(void))]
	[Token(Token = "0x6000156")]
	private void OnGUI() { }

	[Address(RVA = "0x121E580", Offset = "0x121D780", Length = "0x191")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(GUILayout), Member = "BeginVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayout), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Utils), Member = "PrettyBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GUILayout), Member = "EndVertical", ReturnType = typeof(void))]
	[Token(Token = "0x6000158")]
	private void OnServerGUI() { }

	[Address(RVA = "0x121E720", Offset = "0x121D920", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000151")]
	private void OnServerReceive(int connectionId, ArraySegment<Byte> data, int channelId) { }

	[Address(RVA = "0x121E7A0", Offset = "0x121D9A0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000152")]
	private void OnServerSend(int connectionId, ArraySegment<Byte> data, int channelId) { }

	[Address(RVA = "0x121E820", Offset = "0x121DA20", Length = "0x40C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Action`3<System.Int32, System.ArraySegment`1<System.Byte>, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(System.Action`2<System.ArraySegment`1<System.Byte>, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x600014D")]
	private void Start() { }

	[Address(RVA = "0x121ECA0", Offset = "0x121DEA0", Length = "0x181")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000153")]
	private void Update() { }

	[Address(RVA = "0x121EC30", Offset = "0x121DE30", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000154")]
	private void UpdateClient() { }

	[Address(RVA = "0x121EC60", Offset = "0x121DE60", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000155")]
	private void UpdateServer() { }

}

