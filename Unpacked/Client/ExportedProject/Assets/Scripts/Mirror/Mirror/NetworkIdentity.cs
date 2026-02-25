namespace Mirror;

[AddComponentMenu("Network/Network Identity")]
[DefaultExecutionOrder(-1)]
[DisallowMultipleComponent]
[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-identity")]
[Token(Token = "0x200004D")]
public sealed class NetworkIdentity : MonoBehaviour
{
	[Token(Token = "0x200004E")]
	internal sealed class ClientAuthorityCallback : MulticastDelegate
	{

		[Address(RVA = "0x124D350", Offset = "0x124C550", Length = "0x125")]
		[CalledBy(Type = "Mirror.NetworkTransformBase", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkTransformBase", Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000226")]
		public ClientAuthorityCallback(object object, IntPtr method) { }

		[Address(RVA = "0x124D2F0", Offset = "0x124C4F0", Length = "0x53")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x6000228")]
		public override IAsyncResult BeginInvoke(NetworkConnectionToClient conn, NetworkIdentity identity, bool authorityState, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000229")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000227")]
		public override void Invoke(NetworkConnectionToClient conn, NetworkIdentity identity, bool authorityState) { }

	}

	[Token(Token = "0x4000101")]
	private const int MaxNetworkBehaviours = 64; //Field offset: 0x0
	[Token(Token = "0x4000104")]
	private static readonly Dictionary<UInt64, NetworkIdentity> sceneIds; //Field offset: 0x0
	[Token(Token = "0x4000105")]
	private static uint nextNetworkId; //Field offset: 0x8
	[CompilerGenerated]
	[Token(Token = "0x4000106")]
	private static ClientAuthorityCallback clientAuthorityCallback; //Field offset: 0x10
	[Token(Token = "0x4000109")]
	internal static NetworkIdentity previousLocalPlayer; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000F3")]
	private bool <isClient>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x40000F4")]
	private bool <isServer>k__BackingField; //Field offset: 0x21
	[CompilerGenerated]
	[FieldOffset(Offset = "0x22")]
	[Token(Token = "0x40000F5")]
	private bool <isLocalPlayer>k__BackingField; //Field offset: 0x22
	[CompilerGenerated]
	[FieldOffset(Offset = "0x23")]
	[Token(Token = "0x40000F6")]
	private bool <isOwned>k__BackingField; //Field offset: 0x23
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000F7")]
	internal bool clientStarted; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000F8")]
	public readonly Dictionary<Int32, NetworkConnectionToClient> observers; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000F9")]
	private uint <netId>k__BackingField; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("m_SceneId")]
	[HideInInspector]
	[Token(Token = "0x40000FA")]
	public ulong sceneId; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000FB")]
	private uint _assetId; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[FormerlySerializedAs("m_ServerOnly")]
	[Token(Token = "0x40000FC")]
	[Tooltip("Prevents this object from being spawned / enabled on clients")]
	public bool serverOnly; //Field offset: 0x44
	[FieldOffset(Offset = "0x45")]
	[Token(Token = "0x40000FD")]
	internal bool destroyCalled; //Field offset: 0x45
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000FE")]
	private NetworkConnection <connectionToServer>k__BackingField; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000FF")]
	private NetworkConnectionToClient _connectionToClient; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000100")]
	private NetworkBehaviour[] <NetworkBehaviours>k__BackingField; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[FormerlySerializedAs("visible")]
	[Token(Token = "0x4000102")]
	[Tooltip("Visibility can overwrite interest management. ForceHidden can be useful to hide monsters while they respawn. ForceShown can be useful for score NetworkIdentities that should always broadcast to everyone in the world.")]
	public Visibility visibility; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000103")]
	private NetworkIdentitySerialization lastSerialization; //Field offset: 0x68
	[FieldOffset(Offset = "0x80")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000107")]
	private bool hasSpawned; //Field offset: 0x80
	[CompilerGenerated]
	[FieldOffset(Offset = "0x81")]
	[Token(Token = "0x4000108")]
	private bool <SpawnedFromInstantiate>k__BackingField; //Field offset: 0x81
	[FieldOffset(Offset = "0x82")]
	[Token(Token = "0x400010A")]
	private bool hadAuthority; //Field offset: 0x82

	[Token(Token = "0x14000004")]
	public static event ClientAuthorityCallback clientAuthorityCallback
	{
		[Address(RVA = "0x1268BA0", Offset = "0x1267DA0", Length = "0xF2")]
		[CalledBy(Type = "Mirror.NetworkTransformBase", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000201")]
		 add { } //Length: 242
		[Address(RVA = "0x1268D10", Offset = "0x1267F10", Length = "0xF2")]
		[CalledBy(Type = "Mirror.NetworkTransformBase", Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000202")]
		 remove { } //Length: 242
	}

	[Token(Token = "0x17000042")]
	public internal uint assetId
	{
		[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001F2")]
		 get { } //Length: 4
		[Address(RVA = "0x1268E20", Offset = "0x1268020", Length = "0xB0")]
		[CalledBy(Type = typeof(NetworkClient), Member = "RegisterPrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkClient), Member = "RegisterPrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(uint), typeof(SpawnHandlerDelegate), typeof(UnSpawnDelegate)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkClient), Member = "ApplySpawnPayload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(SpawnMessage)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkServer), Member = "AddPlayerForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(GameObject), typeof(uint)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(NetworkServer), Member = "ReplacePlayerForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(GameObject), typeof(uint), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(NetworkServer), Member = "ReplacePlayerForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(GameObject), typeof(uint), typeof(ReplacePlayerOptions)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(NetworkServer), Member = "Spawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(uint), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Token(Token = "0x60001F3")]
		internal set { } //Length: 176
	}

	[Token(Token = "0x17000044")]
	public internal NetworkConnectionToClient connectionToClient
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001F6")]
		 get { } //Length: 5
		[Address(RVA = "0x1268ED0", Offset = "0x12680D0", Length = "0xB4")]
		[CalledBy(Type = typeof(NetworkIdentity), Member = "AssignClientAuthority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(NetworkIdentity), Member = "SetClientOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkIdentity), Member = "RemoveClientAuthority", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkIdentity), Member = "ResetState", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkServer), Member = "RemovePlayerForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(RemovePlayerOptions)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkServer), Member = "SpawnObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001F7")]
		internal set { } //Length: 180
	}

	[Token(Token = "0x17000043")]
	public internal NetworkConnection connectionToServer
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001F4")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001F5")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700003B")]
	public internal bool isClient
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001E6")]
		 get { } //Length: 5
		[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001E7")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700003F")]
	public bool isClientOnly
	{
		[Address(RVA = "0x1268CB0", Offset = "0x1267EB0", Length = "0x11")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60001ED")]
		 get { } //Length: 17
	}

	[Token(Token = "0x1700003D")]
	public internal bool isLocalPlayer
	{
		[Address(RVA = "0x1268CD0", Offset = "0x1267ED0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60001EA")]
		 get { } //Length: 5
		[Address(RVA = "0x1268F90", Offset = "0x1268190", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001EB")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000040")]
	public internal bool isOwned
	{
		[Address(RVA = "0x1268CE0", Offset = "0x1267EE0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60001EE")]
		 get { } //Length: 5
		[Address(RVA = "0x1268FA0", Offset = "0x12681A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60001EF")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700003C")]
	public internal bool isServer
	{
		[Address(RVA = "0x3292C0", Offset = "0x3284C0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001E8")]
		 get { } //Length: 5
		[Address(RVA = "0x3292F0", Offset = "0x3284F0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001E9")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700003E")]
	public bool isServerOnly
	{
		[Address(RVA = "0x1268CF0", Offset = "0x1267EF0", Length = "0x11")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60001EC")]
		 get { } //Length: 17
	}

	[Token(Token = "0x17000041")]
	public internal uint netId
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001F0")]
		 get { } //Length: 174
		[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001F1")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000045")]
	public private NetworkBehaviour[] NetworkBehaviours
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001F8")]
		 get { } //Length: 5
		[Address(RVA = "0x324160", Offset = "0x323360", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001F9")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000046")]
	public private bool SpawnedFromInstantiate
	{
		[Address(RVA = "0x1268CA0", Offset = "0x1267EA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000203")]
		 get { } //Length: 8
		[Address(RVA = "0x1268E10", Offset = "0x1268010", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000204")]
		private set { } //Length: 7
	}

	[Address(RVA = "0x12689C0", Offset = "0x1267BC0", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000225")]
	private static NetworkIdentity() { }

	[Address(RVA = "0x1268A90", Offset = "0x1267C90", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkWriter), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000224")]
	public NetworkIdentity() { }

	[Address(RVA = "0x1268BA0", Offset = "0x1267DA0", Length = "0xF2")]
	[CalledBy(Type = "Mirror.NetworkTransformBase", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000201")]
	public static void add_clientAuthorityCallback(ClientAuthorityCallback value) { }

	[Address(RVA = "0x1265F10", Offset = "0x1265110", Length = "0x123")]
	[CalledBy(Type = typeof(NetworkServer), Member = "SpawnObserversForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "SpawnObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "RebuildObserversDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "AddAllReadyServerConnectionsToObservers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "RebuildObservers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "ClearAllDirtyBits", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkConnectionToClient), Member = "AddToObserving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000219")]
	internal void AddObserver(NetworkConnectionToClient conn) { }

	[Address(RVA = "0x1266040", Offset = "0x1265240", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6000209")]
	public static uint AssetGuidToUint(Guid guid) { }

	[Address(RVA = "0x1266050", Offset = "0x1265250", Length = "0x228")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "set_connectionToClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkServer), Member = "SendChangeOwnerMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600021C")]
	public bool AssignClientAuthority(NetworkConnectionToClient conn) { }

	[Address(RVA = "0x1266280", Offset = "0x1265480", Length = "0x18E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkIdentity), Member = "ValidateComponents", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000207")]
	internal void Awake() { }

	[Address(RVA = "0x1266410", Offset = "0x1265610", Length = "0x120")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600021A")]
	internal void ClearAllComponentsDirtyBits() { }

	[Address(RVA = "0x1266540", Offset = "0x1265740", Length = "0x1A5")]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "ResetState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "UnSpawnInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000223")]
	internal void ClearObservers() { }

	[Address(RVA = "0x12666F0", Offset = "0x12658F0", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18124C6F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000212")]
	private ulong ClientDirtyMask() { }

	[Address(RVA = "0x1266790", Offset = "0x1265990", Length = "0xD9")]
	[CalledBy(Type = typeof(NetworkClient), Member = "ApplySpawnPayload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(SpawnMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnEntityStateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityStateMessage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkIdentity), Member = "ValidateComponents", ReturnType = typeof(void))]
	[Calls(Type = typeof(Compression), Member = "DecompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000217")]
	internal void DeserializeClient(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x1266870", Offset = "0x1265A70", Length = "0xF3")]
	[CalledBy(Type = typeof(NetworkServer), Member = "OnEntityStateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(EntityStateMessage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkIdentity), Member = "ValidateComponents", ReturnType = typeof(void))]
	[Calls(Type = typeof(Compression), Member = "DecompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000216")]
	internal bool DeserializeServer(NetworkReader reader) { }

	[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001F2")]
	public uint get_assetId() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001F6")]
	public NetworkConnectionToClient get_connectionToClient() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001F4")]
	public NetworkConnection get_connectionToServer() { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E6")]
	public bool get_isClient() { }

	[Address(RVA = "0x1268CB0", Offset = "0x1267EB0", Length = "0x11")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001ED")]
	public bool get_isClientOnly() { }

	[Address(RVA = "0x1268CD0", Offset = "0x1267ED0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x60001EA")]
	public bool get_isLocalPlayer() { }

	[Address(RVA = "0x1268CE0", Offset = "0x1267EE0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x60001EE")]
	public bool get_isOwned() { }

	[Address(RVA = "0x3292C0", Offset = "0x3284C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E8")]
	public bool get_isServer() { }

	[Address(RVA = "0x1268CF0", Offset = "0x1267EF0", Length = "0x11")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001EC")]
	public bool get_isServerOnly() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001F0")]
	public uint get_netId() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001F8")]
	public NetworkBehaviour[] get_NetworkBehaviours() { }

	[Address(RVA = "0x1268CA0", Offset = "0x1267EA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000203")]
	public bool get_SpawnedFromInstantiate() { }

	[Address(RVA = "0x1266970", Offset = "0x1265B70", Length = "0x58")]
	[CalledBy(Type = typeof(NetworkServer), Member = "SpawnObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60001FF")]
	internal static uint GetNextNetworkId() { }

	[Address(RVA = "0x12669D0", Offset = "0x1265BD0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt64, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001FE")]
	public static NetworkIdentity GetSceneIdentity(ulong id) { }

	[Address(RVA = "0x1266A50", Offset = "0x1265C50", Length = "0x7B")]
	[CalledBy(Type = typeof(NetworkServer), Member = "SerializeForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(NetworkConnectionToClient)}, ReturnType = typeof(NetworkWriter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NetworkIdentity), Member = "SerializeServer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NetworkWriter), typeof(NetworkWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000218")]
	internal NetworkIdentitySerialization GetServerSerializationAtTick(int tick) { }

	[Address(RVA = "0x1266AD0", Offset = "0x1265CD0", Length = "0x3F8")]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnRPCMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RpcMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "OnCommandMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(CommandMessage), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RemoteProcedureCalls), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(RemoteCallType), typeof(NetworkReader), typeof(NetworkBehaviour), typeof(NetworkConnectionToClient)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Token(Token = "0x60001FA")]
	internal void HandleRemoteCall(byte componentIndex, ushort functionHash, RemoteCallType remoteCallType, NetworkReader reader, NetworkConnectionToClient senderConnection = null) { }

	[Address(RVA = "0x1266ED0", Offset = "0x12660D0", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkIdentity), Member = "ValidateComponents", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000205")]
	internal void InitializeNetworkBehaviours() { }

	[Address(RVA = "0x1266FA0", Offset = "0x12661A0", Length = "0x18")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000213")]
	internal static bool IsDirty(ulong mask, int index) { }

	[Address(RVA = "0x1266FC0", Offset = "0x12661C0", Length = "0x48")]
	[CalledBy(Type = typeof(NetworkServer), Member = "UnSpawnInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStartAuthority", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStopAuthority", ReturnType = typeof(void))]
	[Token(Token = "0x6000220")]
	internal void NotifyAuthority() { }

	[Address(RVA = "0x1267010", Offset = "0x1266210", Length = "0x305")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18124C7B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180701270")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600020A")]
	private void OnDestroy() { }

	[Address(RVA = "0x1267320", Offset = "0x1266520", Length = "0xD6")]
	[CalledBy(Type = typeof(NetworkClient), Member = "ApplySpawnPayload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(SpawnMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnHostClientSpawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpawnMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "BootstrapIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "InvokeIdentityCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "ChangeOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(ChangeOwnerMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "NotifyAuthority", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000221")]
	internal void OnStartAuthority() { }

	[Address(RVA = "0x1267400", Offset = "0x1266600", Length = "0xE6")]
	[CalledBy(Type = typeof(NetworkClient), Member = "ApplySpawnPayload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(SpawnMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnHostClientSpawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpawnMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "BootstrapIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "InvokeIdentityCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600020D")]
	internal void OnStartClient() { }

	[Address(RVA = "0x12674F0", Offset = "0x12666F0", Length = "0x19F")]
	[CalledBy(Type = typeof(NetworkClient), Member = "ApplySpawnPayload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(SpawnMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnHostClientSpawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpawnMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "BootstrapIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "InvokeIdentityCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "ChangeOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(ChangeOwnerMessage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600020F")]
	internal void OnStartLocalPlayer() { }

	[Address(RVA = "0x1267690", Offset = "0x1266890", Length = "0xD6")]
	[CalledBy(Type = typeof(NetworkServer), Member = "SpawnObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600020B")]
	internal void OnStartServer() { }

	[Address(RVA = "0x1267770", Offset = "0x1266970", Length = "0xD6")]
	[CalledBy(Type = typeof(NetworkClient), Member = "ApplySpawnPayload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(SpawnMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnHostClientSpawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpawnMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "BootstrapIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "InvokeIdentityCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "ChangeOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(ChangeOwnerMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "ResetState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "NotifyAuthority", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000222")]
	internal void OnStopAuthority() { }

	[Address(RVA = "0x1267850", Offset = "0x1266A50", Length = "0xD8")]
	[CalledBy(Type = typeof(NetworkClient), Member = "DestroyAllClientObjects", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "DestroyObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "UnSpawnInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600020E")]
	internal void OnStopClient() { }

	[Address(RVA = "0x1267930", Offset = "0x1266B30", Length = "0xD6")]
	[CalledBy(Type = typeof(NetworkClient), Member = "ChangeOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(ChangeOwnerMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "DestroyAllClientObjects", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "DestroyObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "UnSpawnInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000210")]
	internal void OnStopLocalPlayer() { }

	[Address(RVA = "0x1267A10", Offset = "0x1266C10", Length = "0xD6")]
	[CalledBy(Type = typeof(NetworkServer), Member = "UnSpawnInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600020C")]
	internal void OnStopServer() { }

	[Address(RVA = "0x1267AF0", Offset = "0x1266CF0", Length = "0x8")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000208")]
	private void OnValidate() { }

	[Address(RVA = "0x1268D10", Offset = "0x1267F10", Length = "0xF2")]
	[CalledBy(Type = "Mirror.NetworkTransformBase", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000202")]
	public static void remove_clientAuthorityCallback(ClientAuthorityCallback value) { }

	[Address(RVA = "0x1267B00", Offset = "0x1266D00", Length = "0x198")]
	[CalledBy(Type = typeof(NetworkServer), Member = "ReplacePlayerForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(GameObject), typeof(ReplacePlayerOptions)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkIdentity), Member = "set_connectionToClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkServer), Member = "SendChangeOwnerMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600021E")]
	public void RemoveClientAuthority() { }

	[Address(RVA = "0x1267CA0", Offset = "0x1266EA0", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600021B")]
	internal void RemoveObserver(NetworkConnectionToClient conn) { }

	[Address(RVA = "0x1267D00", Offset = "0x1266F00", Length = "0x9A")]
	[CalledBy(Type = typeof(NetworkClient), Member = "Shutdown", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "ResetStatics", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001FC")]
	internal static void ResetClientStatics() { }

	[Address(RVA = "0x1267DA0", Offset = "0x1266FA0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000200")]
	public static void ResetNextNetworkId() { }

	[Address(RVA = "0x1267E00", Offset = "0x1267000", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60001FD")]
	internal static void ResetServerStatics() { }

	[Address(RVA = "0x1267E60", Offset = "0x1267060", Length = "0x1A0")]
	[CalledBy(Type = typeof(NetworkClient), Member = "DestroyAllClientObjects", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "DestroyObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "UnSpawnInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStopAuthority", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkIdentity), Member = "set_connectionToClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "ClearObservers", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18124C7B0")]
	[Token(Token = "0x600021F")]
	internal void ResetState() { }

	[Address(RVA = "0x1268000", Offset = "0x1267200", Length = "0x8A")]
	[CalledBy(Type = typeof(NetworkServer), Member = "Shutdown", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkIdentity), Member = "ResetClientStatics", ReturnType = typeof(void))]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	[Token(Token = "0x60001FB")]
	internal static void ResetStatics() { }

	[Address(RVA = "0x1268090", Offset = "0x1267290", Length = "0x148")]
	[CalledBy(Type = typeof(NetworkClient), Member = "BroadcastToServer", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkIdentity), Member = "ValidateComponents", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18124C6F0")]
	[Calls(Type = typeof(Compression), Member = "CompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "ClearAllDirtyBits", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000215")]
	internal void SerializeClient(NetworkWriter writer) { }

	[Address(RVA = "0x12681E0", Offset = "0x12673E0", Length = "0x49E")]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "GetServerSerializationAtTick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NetworkIdentitySerialization))]
	[CalledBy(Type = typeof(NetworkServer), Member = "SendSpawnMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "CreateSpawnMessagePayload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NetworkIdentity), typeof(NetworkWriterPooled), typeof(NetworkWriterPooled)}, ReturnType = typeof(System.ArraySegment`1<System.Byte>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "ClearAllDirtyBits", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "ValidateComponents", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Compression), Member = "CompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000214")]
	internal void SerializeServer(bool initialState, NetworkWriter ownerWriter, NetworkWriter observersWriter) { }

	[Address(RVA = "0x1268680", Offset = "0x1267880", Length = "0x15E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000211")]
	private ValueTuple<UInt64, UInt64> ServerDirtyMasks(bool initialState) { }

	[Address(RVA = "0x1268E20", Offset = "0x1268020", Length = "0xB0")]
	[CalledBy(Type = typeof(NetworkClient), Member = "RegisterPrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "RegisterPrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(uint), typeof(SpawnHandlerDelegate), typeof(UnSpawnDelegate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "ApplySpawnPayload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(SpawnMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "AddPlayerForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(GameObject), typeof(uint)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NetworkServer), Member = "ReplacePlayerForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(GameObject), typeof(uint), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NetworkServer), Member = "ReplacePlayerForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(GameObject), typeof(uint), typeof(ReplacePlayerOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NetworkServer), Member = "Spawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(uint), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001F3")]
	internal void set_assetId(uint value) { }

	[Address(RVA = "0x1268ED0", Offset = "0x12680D0", Length = "0xB4")]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "AssignClientAuthority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "SetClientOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "RemoveClientAuthority", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "ResetState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "RemovePlayerForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(RemovePlayerOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "SpawnObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001F7")]
	internal void set_connectionToClient(NetworkConnectionToClient value) { }

	[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001F5")]
	internal void set_connectionToServer(NetworkConnection value) { }

	[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E7")]
	internal void set_isClient(bool value) { }

	[Address(RVA = "0x1268F90", Offset = "0x1268190", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001EB")]
	internal void set_isLocalPlayer(bool value) { }

	[Address(RVA = "0x1268FA0", Offset = "0x12681A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x60001EF")]
	internal void set_isOwned(bool value) { }

	[Address(RVA = "0x3292F0", Offset = "0x3284F0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E9")]
	internal void set_isServer(bool value) { }

	[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001F1")]
	internal void set_netId(uint value) { }

	[Address(RVA = "0x324160", Offset = "0x323360", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001F9")]
	private void set_NetworkBehaviours(NetworkBehaviour[] value) { }

	[Address(RVA = "0x1268E10", Offset = "0x1268010", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000204")]
	private void set_SpawnedFromInstantiate(bool value) { }

	[Address(RVA = "0x12687E0", Offset = "0x12679E0", Length = "0xBB")]
	[CalledBy(Type = typeof(NetworkServer), Member = "AddPlayerForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(GameObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NetworkServer), Member = "ReplacePlayerForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(GameObject), typeof(ReplacePlayerOptions)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "set_connectionToClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Token(Token = "0x600021D")]
	internal void SetClientOwner(NetworkConnectionToClient conn) { }

	[Address(RVA = "0x12688A0", Offset = "0x1267AA0", Length = "0x114")]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "InitializeNetworkBehaviours", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "SerializeServer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(NetworkWriter), typeof(NetworkWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "SerializeClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "DeserializeServer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "DeserializeClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Token(Token = "0x6000206")]
	private void ValidateComponents() { }

}

