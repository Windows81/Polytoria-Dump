namespace Mirror;

[AddComponentMenu("Network/Network Manager")]
[DisallowMultipleComponent]
[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-manager")]
[Token(Token = "0x2000056")]
public class NetworkManager : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000057")]
	private sealed class <>c
	{
		[Token(Token = "0x400013F")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000140")]
		public static Func<KeyValuePair`2<Int32, NetworkConnectionToClient>, Boolean> <>9__30_0; //Field offset: 0x8
		[Token(Token = "0x4000141")]
		public static Func<GameObject, Boolean> <>9__62_0; //Field offset: 0x10
		[Token(Token = "0x4000142")]
		public static Func<Transform, Int32> <>9__79_0; //Field offset: 0x18
		[Token(Token = "0x4000143")]
		public static Predicate<Transform> <>9__81_0; //Field offset: 0x20

		[Address(RVA = "0x12A4460", Offset = "0x12A3660", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000281")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000282")]
		public <>c() { }

		[Address(RVA = "0x12A4350", Offset = "0x12A3550", Length = "0x6A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000283")]
		internal bool <get_numPlayers>b__30_0(KeyValuePair<Int32, NetworkConnectionToClient> kv) { }

		[Address(RVA = "0x12A40D0", Offset = "0x12A32D0", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000286")]
		internal bool <GetStartPosition>b__81_0(Transform t) { }

		[Address(RVA = "0x12A4120", Offset = "0x12A3320", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000284")]
		internal bool <RegisterClientMessages>b__62_0(GameObject t) { }

		[Address(RVA = "0x12A4170", Offset = "0x12A3370", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Transform), Member = "GetSiblingIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000285")]
		internal int <RegisterStartPosition>b__79_0(Transform transform) { }

	}

	[Token(Token = "0x4000130")]
	public static List<Transform> startPositions; //Field offset: 0x0
	[Token(Token = "0x4000131")]
	public static int startPositionIndex; //Field offset: 0x8
	[CompilerGenerated]
	[Token(Token = "0x4000137")]
	private static NetworkManager <singleton>k__BackingField; //Field offset: 0x10
	[Token(Token = "0x4000138")]
	internal static NetworkConnection clientReadyConnection; //Field offset: 0x18
	[CompilerGenerated]
	[Token(Token = "0x400013C")]
	private static string <networkSceneName>k__BackingField; //Field offset: 0x20
	[Token(Token = "0x400013D")]
	public static AsyncOperation loadingSceneAsync; //Field offset: 0x28
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("m_DontDestroyOnLoad")]
	[Header("Configuration")]
	[Token(Token = "0x400011E")]
	[Tooltip("Should the Network Manager object be persisted through scene changes?")]
	public bool dontDestroyOnLoad; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[FormerlySerializedAs("m_RunInBackground")]
	[Token(Token = "0x400011F")]
	[Tooltip("Multiplayer games should always run in the background so the network doesn't time out.")]
	public bool runInBackground; //Field offset: 0x21
	[FieldOffset(Offset = "0x24")]
	[Header("Auto-Start Options")]
	[Token(Token = "0x4000120")]
	[Tooltip("Choose whether Server or Client should auto-start in headless builds")]
	public HeadlessStartOptions headlessStartMode; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000121")]
	[Tooltip("Headless Start Mode in Editor\nwhen enabled, headless start mode will be used in editor as well.")]
	public bool editorAutoStart; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[FormerlySerializedAs("serverTickRate")]
	[Token(Token = "0x4000122")]
	[Tooltip("Server / Client send rate per second.\nUse 60-100Hz for fast paced games like Counter-Strike to minimize latency.\nUse around 30Hz for games like WoW to minimize computations.\nUse around 1-10Hz for slow paced games like EVE.")]
	public int sendRate; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_OfflineScene")]
	[Header("Scene Management")]
	[Scene]
	[Token(Token = "0x4000123")]
	[Tooltip("Scene that Mirror will switch to when the client or server is stopped")]
	public string offlineScene; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("m_OnlineScene")]
	[Scene]
	[Token(Token = "0x4000124")]
	[Tooltip("Scene that Mirror will switch to when the server is started. Clients will recieve a Scene Message to load the server's current scene when they connect.")]
	public string onlineScene; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Range(0, 60)]
	[Token(Token = "0x4000125")]
	[Tooltip("Optional delay that can be used after disconnecting to show a 'Connection lost...' message or similar before loading the offline scene, which may take a long time in big projects.")]
	public float offlineSceneLoadDelay; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Header("Network Info")]
	[Token(Token = "0x4000126")]
	[Tooltip("Transport component attached to this object that server and client will use to connect")]
	public Transport transport; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[FormerlySerializedAs("m_NetworkAddress")]
	[Token(Token = "0x4000127")]
	[Tooltip("Network Address where the client should connect to the server. Server does not use this for anything.")]
	public string networkAddress; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[FormerlySerializedAs("m_MaxConnections")]
	[Token(Token = "0x4000128")]
	[Tooltip("Maximum number of concurrent connections.")]
	public int maxConnections; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000129")]
	[Tooltip("When enabled, the server automatically disconnects inactive connections after the configured timeout.")]
	public bool disconnectInactiveConnections; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400012A")]
	[Tooltip("Timeout in seconds for server to automatically disconnect inactive connections if 'disconnectInactiveConnections' is enabled.")]
	public float disconnectInactiveTimeout; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Header("Authentication")]
	[Token(Token = "0x400012B")]
	[Tooltip("Authentication component attached to this object")]
	public NetworkAuthenticator authenticator; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[FormerlySerializedAs("m_PlayerPrefab")]
	[Header("Player Object")]
	[Token(Token = "0x400012C")]
	[Tooltip("Prefab of the player object. Prefab must have a Network Identity component. May be an empty game object or a full avatar.")]
	public GameObject playerPrefab; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[FormerlySerializedAs("m_AutoCreatePlayer")]
	[Token(Token = "0x400012D")]
	[Tooltip("Should Mirror automatically spawn the player after scene change?")]
	public bool autoCreatePlayer; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[FormerlySerializedAs("m_PlayerSpawnMethod")]
	[Token(Token = "0x400012E")]
	[Tooltip("Round Robin or Random order of Start Position selection")]
	public PlayerSpawnMethod playerSpawnMethod; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[FormerlySerializedAs("m_SpawnPrefabs")]
	[HideInInspector]
	[Token(Token = "0x400012F")]
	public List<GameObject> spawnPrefabs; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Header("Security")]
	[Token(Token = "0x4000132")]
	[Tooltip("For security, it is recommended to disconnect a player if a networked action triggers an exception\nThis could prevent components being accessed in an undefined state, which may be an attack vector for exploits.\nHowever, some games may want to allow exceptions in order to not interrupt the player's experience.")]
	public bool exceptionsDisconnect; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Header("Snapshot Interpolation")]
	[Token(Token = "0x4000133")]
	public SnapshotInterpolationSettings snapshotSettings; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Header("Connection Quality")]
	[Token(Token = "0x4000134")]
	[Tooltip("Method to use for connection quality evaluation.\nSimple: based on rtt and jitter.\nPragmatic: based on snapshot interpolation adjustment.")]
	public ConnectionQualityMethod evaluationMethod; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[FormerlySerializedAs("connectionQualityInterval")]
	[Range(0, 60)]
	[Token(Token = "0x4000135")]
	[Tooltip("Interval in seconds to evaluate connection quality.\nSet to 0 to disable connection quality evaluation.")]
	public float evaluationInterval; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Header("Interpolation UI - Requires Editor / Dev Build")]
	[Token(Token = "0x4000136")]
	public bool timeInterpolationGui; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA1")]
	[Token(Token = "0x4000139")]
	protected bool clientLoadedScene; //Field offset: 0xA1
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x400013A")]
	private NetworkManagerMode <mode>k__BackingField; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400013B")]
	private bool finishStartHostPending; //Field offset: 0xA8
	[FieldOffset(Offset = "0xA9")]
	[Token(Token = "0x400013E")]
	private SceneOperation clientSceneOperation; //Field offset: 0xA9

	[Token(Token = "0x17000049")]
	public bool isNetworkActive
	{
		[Address(RVA = "0x126F060", Offset = "0x126E260", Length = "0xAD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
		[Token(Token = "0x6000237")]
		 get { } //Length: 173
	}

	[Token(Token = "0x1700004A")]
	public private NetworkManagerMode mode
	{
		[Address(RVA = "0x126F110", Offset = "0x126E310", Length = "0x7")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000238")]
		 get { } //Length: 7
		[Address(RVA = "0x126F300", Offset = "0x126E500", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000239")]
		private set { } //Length: 7
	}

	[Token(Token = "0x1700004B")]
	public static string networkSceneName
	{
		[Address(RVA = "0x126F120", Offset = "0x126E320", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000253")]
		 get { } //Length: 79
		[Address(RVA = "0x126F310", Offset = "0x126E510", Length = "0x6E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6000254")]
		 set { } //Length: 110
	}

	[Token(Token = "0x17000048")]
	public int numPlayers
	{
		[Address(RVA = "0x126F170", Offset = "0x126E370", Length = "0x140")]
		[CalledBy(Type = "Polytoria.Networking.PTNetworkManager+<HeartbeatLoop>d__33", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Mirror.NetworkRoomManager", Member = "OnServerDisconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000236")]
		 get { } //Length: 320
	}

	[Token(Token = "0x17000047")]
	public internal static NetworkManager singleton
	{
		[Address(RVA = "0x126F2B0", Offset = "0x126E4B0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000234")]
		 get { } //Length: 79
		[Address(RVA = "0x126F380", Offset = "0x126E580", Length = "0x6E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6000235")]
		internal set { } //Length: 110
	}

	[Address(RVA = "0x126EE30", Offset = "0x126E030", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000280")]
	private static NetworkManager() { }

	[Address(RVA = "0x126EF00", Offset = "0x126E100", Length = "0x151")]
	[CalledBy(Type = "Polytoria.Networking.PTNetworkManager", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkLobbyManager", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRoomManager", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SnapshotInterpolationSettings), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600027F")]
	public NetworkManager() { }

	[Address(RVA = "0x12698F0", Offset = "0x1268AF0", Length = "0xF2")]
	[CalledBy(Type = typeof(NetworkManager), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000241")]
	private void ApplyConfiguration() { }

	[Address(RVA = "0x12699F0", Offset = "0x1268BF0", Length = "0xD7")]
	[CalledBy(Type = "Polytoria.Networking.PTNetworkManager", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkManager), Member = "InitializeSingleton", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkManager), Member = "ApplyConfiguration", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18124C820")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityAction`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SceneManager), Member = "add_sceneLoaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Events.UnityAction`2<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>)}, ReturnType = typeof(void))]
	[Token(Token = "0x600023C")]
	public override void Awake() { }

	[Address(RVA = "0x1269AD0", Offset = "0x1268CD0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkManager), Member = "ClientChangeScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SceneOperation), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000267")]
	private void ClientChangeOfflineScene() { }

	[Address(RVA = "0x1269B00", Offset = "0x1268D00", Length = "0x405")]
	[CalledBy(Type = typeof(NetworkManager), Member = "ClientChangeOfflineScene", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "OnClientSceneInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneMessage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Scene), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AsyncOperation))]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LoadSceneMode)}, ReturnType = typeof(AsyncOperation))]
	[Calls(Type = typeof(SceneManager), Member = "UnloadSceneAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UnloadSceneOptions)}, ReturnType = typeof(AsyncOperation))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SceneManager), Member = "GetSceneByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Scene))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SceneManager), Member = "GetSceneByPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Scene))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18124C820")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000256")]
	internal void ClientChangeScene(string newSceneName, SceneOperation sceneOperation = 0, bool customHandling = false) { }

	[Address(RVA = "0x1269F10", Offset = "0x1269110", Length = "0x5C")]
	[CalledBy(Type = "Polytoria.Networking.PTNetworkManager", Member = "ConfigureHeadlessFrameRate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Utils), Member = "IsHeadless", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "set_targetFrameRate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600024D")]
	public override void ConfigureHeadlessFrameRate() { }

	[Address(RVA = "0x126A3D0", Offset = "0x12695D0", Length = "0x299")]
	[CalledBy(Type = typeof(NetworkManager), Member = "UpdateScene", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkServer), Member = "SpawnObjects", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkManager), Member = "FinishLoadSceneHost", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000259")]
	protected void FinishLoadScene() { }

	[Address(RVA = "0x1269F70", Offset = "0x1269170", Length = "0x128")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600025C")]
	private void FinishLoadSceneClientOnly() { }

	[Address(RVA = "0x126A0A0", Offset = "0x12692A0", Length = "0x254")]
	[CalledBy(Type = typeof(NetworkManager), Member = "FinishLoadScene", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkServer), Member = "SpawnObjects", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkManager), Member = "FinishStartHost", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600025A")]
	private void FinishLoadSceneHost() { }

	[Address(RVA = "0x126A300", Offset = "0x1269500", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "SpawnObjects", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600025B")]
	private void FinishLoadSceneServerOnly() { }

	[Address(RVA = "0x126A670", Offset = "0x1269870", Length = "0x325")]
	[CalledBy(Type = typeof(NetworkManager), Member = "StartHost", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "FinishLoadSceneHost", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "CreateLocalConnections", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalConnectionToClient&), typeof(LocalConnectionToServer&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkServer), Member = "SetLocalConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalConnectionToClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkServer), Member = "SpawnObjects", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkManager), Member = "SetupClient", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkManager), Member = "RegisterClientMessages", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkServer), Member = "OnConnected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000248")]
	private void FinishStartHost() { }

	[Address(RVA = "0x126F060", Offset = "0x126E260", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Token(Token = "0x6000237")]
	public bool get_isNetworkActive() { }

	[Address(RVA = "0x126F110", Offset = "0x126E310", Length = "0x7")]
	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000238")]
	public NetworkManagerMode get_mode() { }

	[Address(RVA = "0x126F120", Offset = "0x126E320", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000253")]
	public static string get_networkSceneName() { }

	[Address(RVA = "0x126F170", Offset = "0x126E370", Length = "0x140")]
	[CalledBy(Type = "Polytoria.Networking.PTNetworkManager+<HeartbeatLoop>d__33", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.NetworkRoomManager", Member = "OnServerDisconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000236")]
	public int get_numPlayers() { }

	[Address(RVA = "0x126F2B0", Offset = "0x126E4B0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000234")]
	public static NetworkManager get_singleton() { }

	[Address(RVA = "0x126A9A0", Offset = "0x1269BA0", Length = "0x25D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600025F")]
	public override Transform GetStartPosition() { }

	[Address(RVA = "0x126AC00", Offset = "0x1269E00", Length = "0x427")]
	[CalledBy(Type = typeof(NetworkManager), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "SetupServer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "SetupClient", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "DontDestroyOnLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18124C890")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600024E")]
	private bool InitializeSingleton() { }

	[Address(RVA = "0x126B030", Offset = "0x126A230", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Utils), Member = "IsSceneActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000240")]
	private bool IsServerOnlineSceneChangeNeeded() { }

	[Address(RVA = "0x126B080", Offset = "0x126A280", Length = "0x7")]
	[CalledBy(Type = "Polytoria.Networking.PTNetworkManager", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NetworkManager), Member = "UpdateScene", ReturnType = typeof(void))]
	[Token(Token = "0x600023F")]
	public override void LateUpdate() { }

	[Address(RVA = "0x126B090", Offset = "0x126A290", Length = "0x126")]
	[CalledBy(Type = "Polytoria.Networking.PTNetworkManager", Member = "OnApplicationQuit", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkManager), Member = "StopClient", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkManager), Member = "StopServer", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkManager), Member = "ResetStatics", ReturnType = typeof(void))]
	[Token(Token = "0x600024C")]
	public override void OnApplicationQuit() { }

	[Address(RVA = "0x126B1C0", Offset = "0x126A3C0", Length = "0x16B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Utils), Member = "IsSceneActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180701270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000265")]
	private void OnClientAuthenticated() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000277")]
	public override void OnClientChangeScene(string newSceneName, SceneOperation sceneOperation, bool customHandling) { }

	[Address(RVA = "0x126B510", Offset = "0x126A710", Length = "0x99")]
	[CalledBy(Type = "Polytoria.Networking.PTNetworkManager", Member = "OnClientConnect", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRoomManager", Member = "OnClientConnect", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "Ready", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkClient), Member = "AddPlayer", ReturnType = typeof(bool))]
	[Token(Token = "0x6000272")]
	public override void OnClientConnect() { }

	[Address(RVA = "0x126B330", Offset = "0x126A530", Length = "0x1D6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Utils), Member = "IsSceneActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180701270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000264")]
	private void OnClientConnectInternal() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000273")]
	public override void OnClientDisconnect() { }

	[Address(RVA = "0x126B5B0", Offset = "0x126A7B0", Length = "0x377")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Scene), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF6A0")]
	[Calls(Type = typeof(Utils), Member = "IsSceneActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SceneManager), Member = "MoveGameObjectToScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Scene)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Scene), Member = "get_path", ReturnType = typeof(string))]
	[Calls(Type = typeof(SceneManager), Member = "GetActiveScene", ReturnType = typeof(Scene))]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_scene", ReturnType = typeof(Scene))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(NetworkClient), Member = "Shutdown", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(MonoBehaviour), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18124C820")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000266")]
	private void OnClientDisconnectInternal() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000274")]
	public override void OnClientError(TransportError error, string reason) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000276")]
	public override void OnClientNotReady() { }

	[Address(RVA = "0x126B930", Offset = "0x126AB30", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000268")]
	private void OnClientNotReadyMessageInternal(NotReadyMessage msg) { }

	[Address(RVA = "0x126B9A0", Offset = "0x126ABA0", Length = "0x1B9")]
	[CalledBy(Type = "Polytoria.Networking.PTNetworkManager", Member = "OnClientSceneChanged", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRoomManager", Member = "OnClientSceneChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "Ready", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18124C760")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkClient), Member = "AddPlayer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000278")]
	public override void OnClientSceneChanged() { }

	[Address(RVA = "0x126BB60", Offset = "0x126AD60", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkManager), Member = "ClientChangeScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SceneOperation), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000269")]
	private void OnClientSceneInternal(SceneMessage msg) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000275")]
	public override void OnClientTransportException(Exception exception) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000252")]
	public override void OnDestroy() { }

	[Address(RVA = "0x126BC10", Offset = "0x126AE10", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "SpawnObjects", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkClient), Member = "PrepareToSpawnSceneObjects", ReturnType = typeof(void))]
	[Token(Token = "0x6000257")]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	[Address(RVA = "0x126BEC0", Offset = "0x126B0C0", Length = "0x205")]
	[CalledBy(Type = "Mirror.NetworkRoomManager", Member = "OnRoomServerAddPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Vector3), typeof(Quaternion)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkServer), Member = "AddPlayerForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(GameObject)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600026D")]
	public override void OnServerAddPlayer(NetworkConnectionToClient conn) { }

	[Address(RVA = "0x126BD10", Offset = "0x126AF10", Length = "0x1A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000263")]
	private void OnServerAddPlayerInternal(NetworkConnectionToClient conn, AddPlayerMessage msg) { }

	[Address(RVA = "0x126C0D0", Offset = "0x126B2D0", Length = "0x1E6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkConnection), Member = "Send", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000261")]
	private void OnServerAuthenticated(NetworkConnectionToClient conn) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000270")]
	public override void OnServerChangeScene(string newSceneName) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600026A")]
	public override void OnServerConnect(NetworkConnectionToClient conn) { }

	[Address(RVA = "0x126C2C0", Offset = "0x126B4C0", Length = "0x26E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkConnection), Member = "Send", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000260")]
	private void OnServerConnectInternal(NetworkConnectionToClient conn) { }

	[Address(RVA = "0x126C530", Offset = "0x126B730", Length = "0x49")]
	[CalledBy(Type = "Polytoria.Networking.PTNetworkManager", Member = "OnServerDisconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRoomManager", Member = "OnServerDisconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "DestroyPlayerForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Token(Token = "0x600026B")]
	public override void OnServerDisconnect(NetworkConnectionToClient conn) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600026E")]
	public override void OnServerError(NetworkConnectionToClient conn, TransportError error, string reason) { }

	[Address(RVA = "0x126C5A0", Offset = "0x126B7A0", Length = "0x8F")]
	[CalledBy(Type = "Polytoria.Networking.PTNetworkManager", Member = "OnServerReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRoomManager", Member = "OnServerReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkServer), Member = "SetClientReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600026C")]
	public override void OnServerReady(NetworkConnectionToClient conn) { }

	[Address(RVA = "0x126C580", Offset = "0x126B780", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000262")]
	private void OnServerReadyMessageInternal(NetworkConnectionToClient conn, ReadyMessage msg) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000271")]
	public override void OnServerSceneChanged(string sceneName) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600026F")]
	public override void OnServerTransportException(NetworkConnectionToClient conn, Exception exception) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600027B")]
	public override void OnStartClient() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000279")]
	public override void OnStartHost() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600027A")]
	public override void OnStartServer() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600027D")]
	public override void OnStopClient() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600027E")]
	public override void OnStopHost() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600027C")]
	public override void OnStopServer() { }

	[Address(RVA = "0x126C630", Offset = "0x126B830", Length = "0x1A0")]
	[CalledBy(Type = "Polytoria.Networking.PTNetworkManager", Member = "OnValidate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRoomManager", Member = "OnValidate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600023A")]
	public override void OnValidate() { }

	[Address(RVA = "0x126C7E0", Offset = "0x126B9E0", Length = "0x55C")]
	[CalledBy(Type = typeof(NetworkManager), Member = "StartClient", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "StartClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "FinishStartHost", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Action`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "RegisterPrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkClient), Member = "RegisterHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<T>", typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000250")]
	private void RegisterClientMessages() { }

	[Address(RVA = "0x126CD40", Offset = "0x126BF40", Length = "0x288")]
	[CalledBy(Type = typeof(NetworkManager), Member = "SetupServer", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Action`3<System.Object, System.ByteEnum, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkServer), Member = "RegisterHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`2<NetworkConnectionToClient, T>", typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkServer), Member = "ReplaceHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`2<NetworkConnectionToClient, T>", typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600024F")]
	private void RegisterServerMessages() { }

	[Address(RVA = "0x126CFD0", Offset = "0x126C1D0", Length = "0x22D")]
	[CalledBy(Type = typeof(NetworkStartPosition), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600025D")]
	public static void RegisterStartPosition(Transform start) { }

	[Address(RVA = "0x126D4E0", Offset = "0x126C6E0", Length = "0x1A3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600023B")]
	public override void Reset() { }

	[Address(RVA = "0x126D200", Offset = "0x126C400", Length = "0x2DE")]
	[CalledBy(Type = typeof(NetworkManager), Member = "OnApplicationQuit", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkManager), Member = "StopClient", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkManager), Member = "StopServer", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	[Token(Token = "0x6000251")]
	public static void ResetStatics() { }

	[Address(RVA = "0x126D690", Offset = "0x126C890", Length = "0x3F9")]
	[CalledBy(Type = "Polytoria.Networking.PTNetworkManager", Member = "ServerChangeScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRoomManager", Member = "ServerChangeScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkServer), Member = "SendToAll", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AsyncOperation))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18124C820")]
	[Calls(Type = typeof(NetworkServer), Member = "SetAllClientsNotReady", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000255")]
	public override void ServerChangeScene(string newSceneName) { }

	[Address(RVA = "0x126F300", Offset = "0x126E500", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000239")]
	private void set_mode(NetworkManagerMode value) { }

	[Address(RVA = "0x126F310", Offset = "0x126E510", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6000254")]
	protected static void set_networkSceneName(string value) { }

	[Address(RVA = "0x126F380", Offset = "0x126E580", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6000235")]
	internal static void set_singleton(NetworkManager value) { }

	[Address(RVA = "0x126DA90", Offset = "0x126CC90", Length = "0x15C")]
	[CalledBy(Type = typeof(NetworkManager), Member = "StartClient", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "StartClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "FinishStartHost", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkManager), Member = "InitializeSingleton", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "set_runInBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000244")]
	private void SetupClient() { }

	[Address(RVA = "0x126DBF0", Offset = "0x126CDF0", Length = "0x1DD")]
	[CalledBy(Type = typeof(NetworkManager), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "StartServer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "StartHost", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkManager), Member = "InitializeSingleton", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "set_runInBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkServer), Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkManager), Member = "RegisterServerMessages", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000242")]
	private void SetupServer() { }

	[Address(RVA = "0x126E530", Offset = "0x126D730", Length = "0x1DB")]
	[CalledBy(Type = "Polytoria.Networking.PTNetworkManager", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Utils), Member = "IsHeadless", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkManager), Member = "SetupServer", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Utils), Member = "IsSceneActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkServer), Member = "SpawnObjects", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkManager), Member = "StartClient", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600023D")]
	public override void Start() { }

	[Address(RVA = "0x126E030", Offset = "0x126D230", Length = "0x228")]
	[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryHUD", Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.Discovery.ServerResponse"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NetworkManager), Member = "RegisterClientMessages", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkManager), Member = "SetupClient", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkClient), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "AddTransportHandlers", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NetworkConnection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000246")]
	public void StartClient(Uri uri) { }

	[Address(RVA = "0x126DDD0", Offset = "0x126CFD0", Length = "0x25F")]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NetworkManager), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManagerHUD), Member = "StartButtons", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NetworkManager), Member = "SetupClient", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkConnection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NetworkClient), Member = "AddTransportHandlers", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkManager), Member = "RegisterClientMessages", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000245")]
	public void StartClient() { }

	[Address(RVA = "0x126E260", Offset = "0x126D460", Length = "0x16B")]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<PlaySolo>d__9", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NetworkManagerHUD), Member = "StartButtons", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryHUD", Member = "DrawGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkManager), Member = "SetupServer", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Utils), Member = "IsSceneActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkManager), Member = "FinishStartHost", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000247")]
	public void StartHost() { }

	[Address(RVA = "0x126E3D0", Offset = "0x126D5D0", Length = "0x160")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorStart", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManagerHUD), Member = "StartButtons", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryHUD", Member = "DrawGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkManager), Member = "SetupServer", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Utils), Member = "IsSceneActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkServer), Member = "SpawnObjects", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000243")]
	public void StartServer() { }

	[Address(RVA = "0x126E710", Offset = "0x126D910", Length = "0x1DB")]
	[CalledBy(Type = typeof(NetworkManager), Member = "StopHost", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "OnApplicationQuit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "ResetStatics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManagerHUD), Member = "StartButtons", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManagerHUD), Member = "StopButtons", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryHUD", Member = "StopButtons", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600024B")]
	public void StopClient() { }

	[Address(RVA = "0x126E8F0", Offset = "0x126DAF0", Length = "0x35")]
	[CalledBy(Type = typeof(NetworkManagerHUD), Member = "StopButtons", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryHUD", Member = "StopButtons", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NetworkManager), Member = "StopClient", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000249")]
	public void StopHost() { }

	[Address(RVA = "0x126E930", Offset = "0x126DB30", Length = "0x39F")]
	[CalledBy(Type = typeof(NetworkManager), Member = "OnApplicationQuit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "ResetStatics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManagerHUD), Member = "StopButtons", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRoomManager", Member = "OnServerDisconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryHUD", Member = "StopButtons", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(NetworkServer), Member = "Shutdown", ReturnType = typeof(void))]
	[Calls(Type = typeof(SceneManager), Member = "MoveGameObjectToScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Scene)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Scene), Member = "get_path", ReturnType = typeof(string))]
	[Calls(Type = typeof(SceneManager), Member = "GetActiveScene", ReturnType = typeof(Scene))]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GameObject), Member = "get_scene", ReturnType = typeof(Scene))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Scene), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600024A")]
	public void StopServer() { }

	[Address(RVA = "0x126ECD0", Offset = "0x126DED0", Length = "0x78")]
	[CalledBy(Type = typeof(NetworkStartPosition), Member = "OnDestroy", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600025E")]
	public static void UnRegisterStartPosition(Transform start) { }

	[Address(RVA = "0x126EE20", Offset = "0x126E020", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkManager), Member = "ApplyConfiguration", ReturnType = typeof(void))]
	[Token(Token = "0x600023E")]
	public override void Update() { }

	[Address(RVA = "0x126ED50", Offset = "0x126DF50", Length = "0xC4")]
	[CalledBy(Type = typeof(NetworkManager), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncOperation), Member = "get_isDone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkManager), Member = "FinishLoadScene", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18124C670")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000258")]
	private void UpdateScene() { }

}

