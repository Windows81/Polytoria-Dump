namespace Mirror;

[Token(Token = "0x2000047")]
public class NetworkConnectionToClient : NetworkConnection
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000D7")]
	private readonly NetworkWriter reliableRpcs; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000D8")]
	private readonly NetworkWriter unreliableRpcs; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000D9")]
	private string <address>k__BackingField; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000DA")]
	public readonly int connectionId; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000DB")]
	public readonly HashSet<NetworkIdentity> observing; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40000DC")]
	public Unbatcher unbatcher; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40000DD")]
	private ExponentialMovingAverage driftEma; //Field offset: 0x78
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40000DE")]
	private ExponentialMovingAverage deliveryTimeEma; //Field offset: 0xA0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40000DF")]
	public double remoteTimeline; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40000E0")]
	public double remoteTimescale; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40000E1")]
	private double bufferTimeMultiplier; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40000E2")]
	private readonly SortedList<Double, TimeSnapshot> snapshots; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40000E3")]
	public int snapshotBufferSizeLimit; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40000E4")]
	private double lastPingTime; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40000E5")]
	internal ExponentialMovingAverage _rtt; //Field offset: 0xF8

	[Token(Token = "0x17000038")]
	public private override string address
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001C7")]
		 get { } //Length: 5
		[Address(RVA = "0x324160", Offset = "0x323360", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60001C8")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000039")]
	private double bufferTime
	{
		[Address(RVA = "0x1265210", Offset = "0x1264410", Length = "0x53")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(NetworkServer), Member = "get_sendInterval", ReturnType = typeof(float))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60001C9")]
		private get { } //Length: 83
	}

	[Token(Token = "0x1700003A")]
	public double rtt
	{
		[Address(RVA = "0x1265270", Offset = "0x1264470", Length = "0x9")]
		[CalledBy(Type = "Mirror.LagCompensator", Member = "Sample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), "Mirror.Capture3D&"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x60001CA")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x1265050", Offset = "0x1264250", Length = "0x1BE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NetworkWriter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unbatcher), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SortedList`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExponentialMovingAverage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkConnection), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60001CB")]
	internal NetworkConnectionToClient() { }

	[Address(RVA = "0x1264C70", Offset = "0x1263E70", Length = "0x3D3")]
	[CalledBy(Type = typeof(LocalConnectionToClient), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "OnTransportConnectedWithAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NetworkWriter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unbatcher), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SortedList`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExponentialMovingAverage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkConnection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001CC")]
	public NetworkConnectionToClient(int networkConnectionId, string clientAddress = "localhost") { }

	[Address(RVA = "0x12640C0", Offset = "0x12632C0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001D7")]
	internal void AddOwnedObject(NetworkIdentity obj) { }

	[Address(RVA = "0x1264120", Offset = "0x1263320", Length = "0x82")]
	[CalledBy(Type = typeof(InterestManagement), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InterestManagementBase), Member = "AddObserver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkIdentity), Member = "AddObserver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "ShowForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001D4")]
	internal void AddToObserving(NetworkIdentity netIdentity) { }

	[Address(RVA = "0x12641B0", Offset = "0x12633B0", Length = "0x216")]
	[CalledBy(Type = typeof(NetworkServer), Member = "OnTransportDisconnected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "DestroyPlayerForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkServer), Member = "RemovePlayerForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(RemovePlayerOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkServer), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60001D9")]
	internal void DestroyOwnedObjects() { }

	[Address(RVA = "0x12643D0", Offset = "0x12635D0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D3")]
	public virtual void Disconnect() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C7")]
	public override string get_address() { }

	[Address(RVA = "0x1265210", Offset = "0x1264410", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "get_sendInterval", ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001C9")]
	private double get_bufferTime() { }

	[Address(RVA = "0x1265270", Offset = "0x1264470", Length = "0x9")]
	[CalledBy(Type = "Mirror.LagCompensator", Member = "Sample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), "Mirror.Capture3D&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x60001CA")]
	public double get_rtt() { }

	[Address(RVA = "0x1264450", Offset = "0x1263650", Length = "0x2E7")]
	[CalledBy(Type = typeof(NetworkServer), Member = "OnTimeSnapshotMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(TimeSnapshotMessage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "get_sendInterval", ReturnType = typeof(float))]
	[Calls(Type = typeof(SnapshotInterpolation), Member = "DynamicAdjustment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(SnapshotInterpolation), Member = "InsertAndAdjust", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedList`2<Double, T>", typeof(int), "T", typeof(Double&), typeof(Double&), typeof(float), typeof(double), typeof(double), typeof(double), typeof(ExponentialMovingAverage&), typeof(float), typeof(float), typeof(ExponentialMovingAverage&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001CE")]
	public void OnTimeSnapshot(TimeSnapshot snapshot) { }

	[Address(RVA = "0x1264740", Offset = "0x1263940", Length = "0x96")]
	[CalledBy(Type = typeof(InterestManagement), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "HideForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001D5")]
	internal void RemoveFromObserving(NetworkIdentity netIdentity, bool isDestroyed) { }

	[Address(RVA = "0x12647E0", Offset = "0x12639E0", Length = "0x179")]
	[CalledBy(Type = typeof(NetworkServer), Member = "SetAllClientsNotReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalConnectionToClient), Member = "DisconnectInternal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalConnectionToClient), Member = "Disconnect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalConnectionToServer), Member = "Disconnect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "OnTransportDisconnected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "DestroyPlayerForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "SetClientNotReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60001D6")]
	internal void RemoveFromObservingsObservers() { }

	[Address(RVA = "0x1264960", Offset = "0x1263B60", Length = "0x53")]
	[CalledBy(Type = typeof(NetworkServer), Member = "UnSpawnInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001D8")]
	internal void RemoveOwnedObject(NetworkIdentity obj) { }

	[Address(RVA = "0x12649C0", Offset = "0x1263BC0", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D0")]
	protected virtual void SendToTransport(ArraySegment<Byte> segment, int channelId = 0) { }

	[Address(RVA = "0x324160", Offset = "0x323360", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C8")]
	private void set_address(string value) { }

	[Address(RVA = "0x1264A50", Offset = "0x1263C50", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x60001CD")]
	public virtual string ToString() { }

	[Address(RVA = "0x1264C40", Offset = "0x1263E40", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkConnection), Member = "Update", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D2")]
	internal virtual void Update() { }

	[Address(RVA = "0x1264AB0", Offset = "0x1263CB0", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(NetworkConnection), Member = "Send", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001D1")]
	protected override void UpdatePing() { }

	[Address(RVA = "0x1264B80", Offset = "0x1263D80", Length = "0xB6")]
	[CalledBy(Type = typeof(NetworkServer), Member = "NetworkEarlyUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Time), Member = "get_unscaledDeltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(SnapshotInterpolation), Member = "StepInterpolation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedList`2<Double, T>", typeof(double), "T&", "T&", typeof(Double&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001CF")]
	public void UpdateTimeInterpolation() { }

}

