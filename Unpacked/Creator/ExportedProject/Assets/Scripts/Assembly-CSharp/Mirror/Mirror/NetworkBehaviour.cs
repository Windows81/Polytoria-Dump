namespace Mirror;

[AddComponentMenu(null)]
[HelpURL("https://mirror-networking.gitbook.io/docs/guides/networkbehaviour")]
[Token(Token = "0x2000038")]
public abstract class NetworkBehaviour : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000039")]
	private sealed class <>c__DisplayClass45_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400008B")]
		public NetworkBehaviour <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400008C")]
		public ulong nthBit; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000121")]
		public <>c__DisplayClass45_0() { }

		[Address(RVA = "0x126F420", Offset = "0x126E620", Length = "0x23")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000122")]
		internal void <InitSyncObject>b__0() { }

		[Address(RVA = "0x126F450", Offset = "0x126E650", Length = "0x1EF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000123")]
		internal bool <InitSyncObject>b__1() { }

		[Address(RVA = "0x126F640", Offset = "0x126E840", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000124")]
		internal bool <InitSyncObject>b__2() { }

	}

	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[Token(Token = "0x4000081")]
	[Tooltip("Server Authority calls OnSerialize on the server and syncs it to clients.\n\nClient Authority calls OnSerialize on the owning client, syncs it to server, which then broadcasts it to all other clients.\n\nUse server authority for cheat safety.")]
	public SyncDirection syncDirection; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[HideInInspector]
	[Token(Token = "0x4000082")]
	[Tooltip("By default synced data is sent from the server to all Observers of the object.\nChange this to Owner to only have the server update the client that has ownership authority for this object")]
	public SyncMode syncMode; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	[Range(0, 2)]
	[Token(Token = "0x4000083")]
	[Tooltip("Time in seconds until next change is synchronized to the client. '0' means send immediately if changed. '0.5' means only send changes every 500ms.\n(This is for state synchronization like SyncVars, SyncLists, OnSerialize. Not for Cmds, Rpcs, etc.)")]
	public float syncInterval; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000084")]
	internal double lastSyncTime; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000085")]
	protected readonly List<SyncObject> syncObjects; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000086")]
	private NetworkIdentity <netIdentity>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000087")]
	private byte <ComponentIndex>k__BackingField; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000088")]
	protected ulong syncVarDirtyBits; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000089")]
	internal ulong syncObjectDirtyBits; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400008A")]
	private ulong syncVarHookGuard; //Field offset: 0x60

	[Token(Token = "0x17000021")]
	public bool authority
	{
		[Address(RVA = "0x1258930", Offset = "0x1257B30", Length = "0x53")]
		[CalledBy(Type = "Mirror.NetworkTransformBase", Member = "get_IsClientWithAuthority", ReturnType = typeof(bool))]
		[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = "UpdateClient", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = "OnServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Vector3>", "System.Nullable`1<Quaternion>", "System.Nullable`1<Vector3>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60000E1")]
		 get { } //Length: 83
	}

	[Token(Token = "0x17000026")]
	public internal byte ComponentIndex
	{
		[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E8")]
		 get { } //Length: 5
		[Address(RVA = "0x347A50", Offset = "0x346C50", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E9")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000024")]
	public NetworkConnectionToClient connectionToClient
	{
		[Address(RVA = "0x1258990", Offset = "0x1257B90", Length = "0x1B")]
		[CalledBy(Type = "Mirror.NetworkTransformUnreliable", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "AddPlrExplosionForce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Player", typeof(Vector3), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.NetworkEvent", Member = "InvokeClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.NetMessage", "Polytoria.Datamodel.Player"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player+<DelayedDisconnect>d__237", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Mirror.NetworkTransformHybrid", Member = "OnClientToServerDeltaSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Vector3>", "System.Nullable`1<Quaternion>", "System.Nullable`1<Vector3>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkTransformHybrid", Member = "UpdateServerInterpolation", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkTransformHybrid", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkTransformUnreliable", Member = "UpdateServerInterpolation", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkTransformUnreliable", Member = "OnClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SyncData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = "UpdateServer", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = "OnClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Vector3>", "System.Nullable`1<Quaternion>", "System.Nullable`1<Vector3>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.RemoteStatistics", Member = "UserCode_CmdAuthenticate__String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.RemoteStatistics", Member = "InvokeUserCode_CmdAuthenticate__String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000E4")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000023")]
	public NetworkConnection connectionToServer
	{
		[Address(RVA = "0x3E4DD0", Offset = "0x3E3FD0", Length = "0x1B")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E3")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700001C")]
	public bool isClient
	{
		[Address(RVA = "0x12589E0", Offset = "0x1257BE0", Length = "0x1B")]
		[CallerCount(Count = 34)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000DC")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700001F")]
	public bool isClientOnly
	{
		[Address(RVA = "0x12589B0", Offset = "0x1257BB0", Length = "0x2B")]
		[CalledBy(Type = "Mirror.PredictedRigidbody", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.PredictedRigidbody", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.PredictedRigidbody", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60000DF")]
		 get { } //Length: 43
	}

	[Token(Token = "0x1700001D")]
	public bool isLocalPlayer
	{
		[Address(RVA = "0x1258A00", Offset = "0x1257C00", Length = "0x1B")]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "OnTriggerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Collider"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkRoomPlayer", Member = "DrawPlayerReadyButton", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkRoomPlayer", Member = "OnGUI", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Seat", Member = "OnTriggerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Collider"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Seat", Member = "OnCollisionEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Collision"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "InvokeUserCode_RpcJumpSound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "UserCode_RpcJumpSound", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "OnTriggerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Collider"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "OnCollisionEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Collision"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "OnCollisionExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Collision"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "set_Health", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "get_IsLocalPlayer", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "AddPlrExplosionForce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Player", typeof(Vector3), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.RemoteStatistics", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.RemoteStatistics", Member = "OnGUI", ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000DD")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000020")]
	public bool isOwned
	{
		[Address(RVA = "0x1258A20", Offset = "0x1257C20", Length = "0x1B")]
		[CallerCount(Count = 45)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000E0")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700001B")]
	public bool isServer
	{
		[Address(RVA = "0x1258A70", Offset = "0x1257C70", Length = "0x1B")]
		[CallerCount(Count = 476)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000DB")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700001E")]
	public bool isServerOnly
	{
		[Address(RVA = "0x1258A40", Offset = "0x1257C40", Length = "0x2B")]
		[CalledBy(Type = "Mirror.NetworkRoomPlayer", Member = "DrawPlayerReadyState", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60000DE")]
		 get { } //Length: 43
	}

	[Token(Token = "0x17000022")]
	public uint netId
	{
		[Address(RVA = "0x1258A90", Offset = "0x1257C90", Length = "0x1A")]
		[CalledBy(Type = "Polytoria.Datamodel.Instance", Member = "OnHide", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Instance", Member = "OnShow", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.ClipboardController", Member = "PasteInstancesFromClipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarSetter_NetworkBehaviour", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong), "System.Action`2<T, T>", typeof(NetworkBehaviourSyncVar&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkBehaviour), Member = "SyncVarNetworkBehaviourEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(NetworkBehaviourSyncVar)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(NetworkBehaviour), Member = "SetSyncVarNetworkBehaviour", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong), typeof(NetworkBehaviourSyncVar&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkWriterExtensions), Member = "WriteNetworkBehaviour", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(NetworkBehaviour)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000E2")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000025")]
	public internal NetworkIdentity netIdentity
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E6")]
		 get { } //Length: 5
		[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E7")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x12588B0", Offset = "0x1257AB0", Length = "0x77")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000120")]
	protected NetworkBehaviour() { }

	[Address(RVA = "0x1254E10", Offset = "0x1254010", Length = "0xCE")]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "SerializeServer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NetworkWriter), typeof(NetworkWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "SerializeClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "AddObserver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000F1")]
	public void ClearAllDirtyBits() { }

	[Address(RVA = "0x12551F0", Offset = "0x12543F0", Length = "0x6B8")]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "DeserializeServer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "DeserializeClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(NetworkReader), Member = "ReadByte", ReturnType = typeof(byte))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000115")]
	internal bool Deserialize(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x1254EE0", Offset = "0x12540E0", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000111")]
	internal void DeserializeObjectsAll(NetworkReader reader) { }

	[Address(RVA = "0x1254F90", Offset = "0x1254190", Length = "0xD2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000112")]
	internal void DeserializeObjectsDelta(NetworkReader reader) { }

	[Address(RVA = "0x1255070", Offset = "0x1254270", Length = "0x174")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600010C")]
	private void DeserializeSyncObjects(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600010E")]
	protected override void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x12558B0", Offset = "0x1254AB0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000114")]
	internal static int ErrorCorrection(int size, byte safety) { }

	[Address(RVA = "0x708B20", Offset = "0x707D20", Length = "0x8C")]
	[CallerCount(Count = 93)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000FE")]
	public void GeneratedSyncVarDeserialize(ref T field, Action<T, T> OnChanged, T value) { }

	[Address(RVA = "0x12558C0", Offset = "0x1254AC0", Length = "0x1B5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000FF")]
	public void GeneratedSyncVarDeserialize_GameObject(ref GameObject field, Action<GameObject, GameObject> OnChanged, NetworkReader reader, ref uint netIdField) { }

	[Address(RVA = "0x708A40", Offset = "0x707C40", Length = "0xD7")]
	[CalledBy(Type = "Polytoria.Datamodel.InstanceValue", Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Seat", Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadNetworkBehaviourSyncVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(NetworkBehaviourSyncVar))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GetSyncVarNetworkBehaviour", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviourSyncVar), "T&"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviourSyncVar)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviourSyncVar), typeof(NetworkBehaviourSyncVar&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000101")]
	public void GeneratedSyncVarDeserialize_NetworkBehaviour(ref T field, Action<T, T> OnChanged, NetworkReader reader, ref NetworkBehaviourSyncVar netIdField) { }

	[Address(RVA = "0x1255A80", Offset = "0x1254C80", Length = "0x142")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000100")]
	public void GeneratedSyncVarDeserialize_NetworkIdentity(ref NetworkIdentity field, Action<NetworkIdentity, NetworkIdentity> OnChanged, NetworkReader reader, ref uint netIdField) { }

	[Address(RVA = "0x709680", Offset = "0x708880", Length = "0xFE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "get_activeHost", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F6")]
	public void GeneratedSyncVarSetter(T value, ref T field, ulong dirtyBit, Action<T, T> OnChanged) { }

	[Address(RVA = "0x1255BD0", Offset = "0x1254DD0", Length = "0x2A0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkServer), Member = "get_activeHost", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000F7")]
	public void GeneratedSyncVarSetter_GameObject(GameObject value, ref GameObject field, ulong dirtyBit, Action<GameObject, GameObject> OnChanged, ref uint netIdField) { }

	[Address(RVA = "0x709390", Offset = "0x708590", Length = "0x2EC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetworkBehaviourSyncVar), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviourSyncVar), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_netId", ReturnType = typeof(uint))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkServer), Member = "get_activeHost", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F9")]
	public void GeneratedSyncVarSetter_NetworkBehaviour(T value, ref T field, ulong dirtyBit, Action<T, T> OnChanged, ref NetworkBehaviourSyncVar netIdField) { }

	[Address(RVA = "0x1255E80", Offset = "0x1255080", Length = "0x22A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkServer), Member = "get_activeHost", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000F8")]
	public void GeneratedSyncVarSetter_NetworkIdentity(NetworkIdentity value, ref NetworkIdentity field, ulong dirtyBit, Action<NetworkIdentity, NetworkIdentity> OnChanged, ref uint netIdField) { }

	[Address(RVA = "0x1258930", Offset = "0x1257B30", Length = "0x53")]
	[CalledBy(Type = "Mirror.NetworkTransformBase", Member = "get_IsClientWithAuthority", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = "UpdateClient", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = "OnServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Vector3>", "System.Nullable`1<Quaternion>", "System.Nullable`1<Vector3>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000E1")]
	public bool get_authority() { }

	[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E8")]
	public byte get_ComponentIndex() { }

	[Address(RVA = "0x1258990", Offset = "0x1257B90", Length = "0x1B")]
	[CalledBy(Type = "Mirror.RemoteStatistics", Member = "InvokeUserCode_CmdAuthenticate__String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.RemoteStatistics", Member = "UserCode_CmdAuthenticate__String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = "OnClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Vector3>", "System.Nullable`1<Quaternion>", "System.Nullable`1<Vector3>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = "UpdateServer", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformUnreliable", Member = "OnClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SyncData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformHybrid", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformUnreliable", Member = "UpdateServerInterpolation", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformHybrid", Member = "OnClientToServerDeltaSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Vector3>", "System.Nullable`1<Quaternion>", "System.Nullable`1<Vector3>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player+<DelayedDisconnect>d__237", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.NetworkEvent", Member = "InvokeClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.NetMessage", "Polytoria.Datamodel.Player"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "AddPlrExplosionForce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Player", typeof(Vector3), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformUnreliable", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformHybrid", Member = "UpdateServerInterpolation", ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000E4")]
	public NetworkConnectionToClient get_connectionToClient() { }

	[Address(RVA = "0x3E4DD0", Offset = "0x3E3FD0", Length = "0x1B")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E3")]
	public NetworkConnection get_connectionToServer() { }

	[Address(RVA = "0x12589E0", Offset = "0x1257BE0", Length = "0x1B")]
	[CallerCount(Count = 34)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000DC")]
	public bool get_isClient() { }

	[Address(RVA = "0x12589B0", Offset = "0x1257BB0", Length = "0x2B")]
	[CalledBy(Type = "Mirror.PredictedRigidbody", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.PredictedRigidbody", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.PredictedRigidbody", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000DF")]
	public bool get_isClientOnly() { }

	[Address(RVA = "0x1258A00", Offset = "0x1257C00", Length = "0x1B")]
	[CalledBy(Type = "Mirror.RemoteStatistics", Member = "OnGUI", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.RemoteStatistics", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "AddPlrExplosionForce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Player", typeof(Vector3), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "get_IsLocalPlayer", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "set_Health", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "OnCollisionExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Collision"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "OnTriggerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Collider"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "UserCode_RpcJumpSound", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "InvokeUserCode_RpcJumpSound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkBehaviour), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Seat", Member = "OnCollisionEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Collision"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Seat", Member = "OnTriggerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Collider"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRoomPlayer", Member = "OnGUI", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRoomPlayer", Member = "DrawPlayerReadyButton", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "OnTriggerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Collider"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "OnCollisionEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Collision"}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000DD")]
	public bool get_isLocalPlayer() { }

	[Address(RVA = "0x1258A20", Offset = "0x1257C20", Length = "0x1B")]
	[CallerCount(Count = 45)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000E0")]
	public bool get_isOwned() { }

	[Address(RVA = "0x1258A70", Offset = "0x1257C70", Length = "0x1B")]
	[CallerCount(Count = 476)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000DB")]
	public bool get_isServer() { }

	[Address(RVA = "0x1258A40", Offset = "0x1257C40", Length = "0x2B")]
	[CalledBy(Type = "Mirror.NetworkRoomPlayer", Member = "DrawPlayerReadyState", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000DE")]
	public bool get_isServerOnly() { }

	[Address(RVA = "0x1258A90", Offset = "0x1257C90", Length = "0x1A")]
	[CalledBy(Type = "Polytoria.Datamodel.Instance", Member = "OnHide", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Instance", Member = "OnShow", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.ClipboardController", Member = "PasteInstancesFromClipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarSetter_NetworkBehaviour", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong), "System.Action`2<T, T>", typeof(NetworkBehaviourSyncVar&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkBehaviour), Member = "SyncVarNetworkBehaviourEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(NetworkBehaviourSyncVar)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NetworkBehaviour), Member = "SetSyncVarNetworkBehaviour", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong), typeof(NetworkBehaviourSyncVar&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkWriterExtensions), Member = "WriteNetworkBehaviour", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(NetworkBehaviour)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000E2")]
	public uint get_netId() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E6")]
	public NetworkIdentity get_netIdentity() { }

	[Address(RVA = "0x12560B0", Offset = "0x12552B0", Length = "0x149")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000FC")]
	protected GameObject GetSyncVarGameObject(uint netId, ref GameObject gameObjectField) { }

	[Address(RVA = "0x1256200", Offset = "0x1255400", Length = "0x8")]
	[CalledBy(Type = "Polytoria.Controllers.AppearanceLoaderBase", Member = "ApplyAppearance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Controllers.AppearanceData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "set_NetworkanimatorSpeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkBehaviour), Member = "SetSyncVarNetworkBehaviour", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong), typeof(NetworkBehaviourSyncVar&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarSetter_NetworkBehaviour", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong), "System.Action`2<T, T>", typeof(NetworkBehaviourSyncVar&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarSetter", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong), "System.Action`2<T, T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Bounds), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.AppearanceLoaderBase", Member = "set_NetworktorsoUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "set_Networkvelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Vector3Value", Member = "set_Networkval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Vector3Value", Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Networkcolor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.ColorRange"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.ColorRange"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.InstanceValue", Member = "set_Networkval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.InstanceValue", Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Decal", Member = "set_NetworkimageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Controllers.ImageType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Decal", Member = "set_ImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Controllers.ImageType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRoomPlayer", Member = "set_Networkindex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRoomManager", Member = "RecalculateRoomPlayerIndices", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRoomPlayer", Member = "set_NetworkreadyToBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000EB")]
	protected bool GetSyncVarHookGuard(ulong dirtyBit) { }

	[Address(RVA = "0x70A4D0", Offset = "0x7096D0", Length = "0x478")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isClient", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000106")]
	protected T GetSyncVarNetworkBehaviour(NetworkBehaviourSyncVar syncNetBehaviour, ref T behaviourField) { }

	[Address(RVA = "0x1256210", Offset = "0x1255410", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000103")]
	protected NetworkIdentity GetSyncVarNetworkIdentity(uint netId, ref NetworkIdentity identityField) { }

	[Address(RVA = "0x12562C0", Offset = "0x12554C0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000E5")]
	internal bool HasSyncObjects() { }

	[Address(RVA = "0x1256310", Offset = "0x1255510", Length = "0x243")]
	[CalledBy(Type = "Polytoria.Controllers.AppearanceLoaderBase", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60000F2")]
	protected void InitSyncObject(SyncObject syncObject) { }

	[Address(RVA = "0x1256560", Offset = "0x1255760", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000F0")]
	public bool IsDirty() { }

	[Address(RVA = "0x12565D0", Offset = "0x12557D0", Length = "0x19B")]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "OnDeserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600010A")]
	public override void OnDeserialize(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x1256770", Offset = "0x1255970", Length = "0x192")]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "OnSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000109")]
	public override void OnSerialize(NetworkWriter writer, bool initialState) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011D")]
	public override void OnStartAuthority() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000119")]
	public override void OnStartClient() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011B")]
	public override void OnStartLocalPlayer() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000117")]
	public override void OnStartServer() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011E")]
	public override void OnStopAuthority() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011A")]
	public override void OnStopClient() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011C")]
	public override void OnStopLocalPlayer() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000118")]
	public override void OnStopServer() { }

	[Address(RVA = "0x1256910", Offset = "0x1255B10", Length = "0x17D")]
	[CalledBy(Type = "Mirror.NetworkTransformHybrid", Member = "OnValidate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformBase", Member = "OnValidate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.PredictedRigidbody", Member = "OnValidate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.RemoteStatistics", Member = "OnValidate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkLerpRigidbody", Member = "OnValidate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody", Member = "OnValidate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "OnValidate", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Token(Token = "0x60000EA")]
	protected override void OnValidate() { }

	[Address(RVA = "0x1256A90", Offset = "0x1255C90", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000116")]
	internal void ResetSyncObjects() { }

	[Address(RVA = "0x1256BA0", Offset = "0x1255DA0", Length = "0x6CD")]
	[CallerCount(Count = 102)]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetworkConnection), Member = "Send", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180701270")]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000F3")]
	protected void SendCommandInternal(string functionFullName, int functionHashCode, NetworkWriter writer, int channelId, bool requiresAuthority = true) { }

	[Address(RVA = "0x1257270", Offset = "0x1256470", Length = "0x5E8")]
	[CallerCount(Count = 204)]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(NetworkConnection), Member = "Send", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NetworkWriter), Member = "Write", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000F4")]
	protected void SendRPCInternal(string functionFullName, int functionHashCode, NetworkWriter writer, int channelId, bool includeOwner) { }

	[Address(RVA = "0x1257860", Offset = "0x1256A60", Length = "0x640")]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(NetworkConnection), Member = "Send", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000F5")]
	protected void SendTargetRPCInternal(NetworkConnection conn, string functionFullName, int functionHashCode, NetworkWriter writer, int channelId) { }

	[Address(RVA = "0x12581B0", Offset = "0x12573B0", Length = "0x292")]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "SerializeServer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NetworkWriter), typeof(NetworkWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "SerializeClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000113")]
	internal void Serialize(NetworkWriter writer, bool initialState) { }

	[Address(RVA = "0x1257EB0", Offset = "0x12570B0", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600010F")]
	public void SerializeObjectsAll(NetworkWriter writer) { }

	[Address(RVA = "0x1257F60", Offset = "0x1257160", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000110")]
	public void SerializeObjectsDelta(NetworkWriter writer) { }

	[Address(RVA = "0x1258040", Offset = "0x1257240", Length = "0x165")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600010B")]
	private void SerializeSyncObjects(NetworkWriter writer, bool initialState) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600010D")]
	protected override void SerializeSyncVars(NetworkWriter writer, bool initialState) { }

	[Address(RVA = "0x347A50", Offset = "0x346C50", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E9")]
	internal void set_ComponentIndex(byte value) { }

	[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E7")]
	internal void set_netIdentity(NetworkIdentity value) { }

	[Address(RVA = "0x1258450", Offset = "0x1257650", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000EF")]
	public void SetDirty() { }

	[Address(RVA = "0x1258460", Offset = "0x1257660", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000ED")]
	private void SetSyncObjectDirtyBit(ulong dirtyBit) { }

	[Address(RVA = "0x70AAB0", Offset = "0x709CB0", Length = "0x8")]
	[CallerCount(Count = 36)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000108")]
	protected void SetSyncVar(T value, ref T fieldValue, ulong dirtyBit) { }

	[Address(RVA = "0x1258470", Offset = "0x1257670", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000EE")]
	public void SetSyncVarDirtyBit(ulong dirtyBit) { }

	[Address(RVA = "0x1258480", Offset = "0x1257680", Length = "0x136")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000FB")]
	protected void SetSyncVarGameObject(GameObject newGameObject, ref GameObject gameObjectField, ulong dirtyBit, ref uint netIdField) { }

	[Address(RVA = "0x12585C0", Offset = "0x12577C0", Length = "0x1C")]
	[CalledBy(Type = "Polytoria.Controllers.AppearanceLoaderBase", Member = "ApplyAppearance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Controllers.AppearanceData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRoomManager", Member = "RecalculateRoomPlayerIndices", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "set_NetworkanimatorSpeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarSetter_NetworkBehaviour", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong), "System.Action`2<T, T>", typeof(NetworkBehaviourSyncVar&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarSetter", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong), "System.Action`2<T, T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Bounds), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.AppearanceLoaderBase", Member = "set_NetworktorsoUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "set_Networkvelocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Vector3Value", Member = "set_Networkval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Vector3Value", Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Networkcolor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.ColorRange"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.ColorRange"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.InstanceValue", Member = "set_Networkval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.InstanceValue", Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Decal", Member = "set_NetworkimageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Controllers.ImageType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Decal", Member = "set_ImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Controllers.ImageType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRoomPlayer", Member = "set_NetworkreadyToBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRoomPlayer", Member = "set_Networkindex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 36)]
	[Token(Token = "0x60000EC")]
	protected void SetSyncVarHookGuard(ulong dirtyBit, bool value) { }

	[Address(RVA = "0x70A950", Offset = "0x709B50", Length = "0x157")]
	[CalledBy(Type = "Polytoria.Datamodel.InstanceValue", Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.InstanceValue", Member = "set_Networkval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "SetSittingIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Seat"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "set_NetworksittingIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Seat"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Seat", Member = "SetOccupant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Player"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Seat", Member = "set_Networkoccupant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Player"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(NetworkBehaviourSyncVar), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_netId", ReturnType = typeof(uint))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000105")]
	protected void SetSyncVarNetworkBehaviour(T newBehaviour, ref T behaviourField, ulong dirtyBit, ref NetworkBehaviourSyncVar syncField) { }

	[Address(RVA = "0x12585E0", Offset = "0x12577E0", Length = "0xFD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000102")]
	protected void SetSyncVarNetworkIdentity(NetworkIdentity newIdentity, ref NetworkIdentity identityField, ulong dirtyBit, ref uint netIdField) { }

	[Address(RVA = "0x70AC40", Offset = "0x709E40", Length = "0x161")]
	[CallerCount(Count = 38)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Boolean>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Boolean>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000107")]
	protected static bool SyncVarEqual(T value, ref T fieldValue) { }

	[Address(RVA = "0x12586E0", Offset = "0x12578E0", Length = "0xFD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x60000FA")]
	public static bool SyncVarGameObjectEqual(GameObject newGameObject, uint netIdField) { }

	[Address(RVA = "0x70BED0", Offset = "0x70B0D0", Length = "0xE9")]
	[CalledBy(Type = "Polytoria.Datamodel.Seat", Member = "set_Networkoccupant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Player"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.InstanceValue", Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.InstanceValue", Member = "set_Networkval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "SetSittingIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Seat"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "set_NetworksittingIn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Seat"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Seat", Member = "SetOccupant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Player"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_netId", ReturnType = typeof(uint))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviourSyncVar), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000104")]
	protected static bool SyncVarNetworkBehaviourEqual(T newBehaviour, NetworkBehaviourSyncVar syncField) { }

	[Address(RVA = "0x12587E0", Offset = "0x12579E0", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x60000FD")]
	public static bool SyncVarNetworkIdentityEqual(NetworkIdentity newIdentity, uint netIdField) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x600011F")]
	public override bool Weaved() { }

}

