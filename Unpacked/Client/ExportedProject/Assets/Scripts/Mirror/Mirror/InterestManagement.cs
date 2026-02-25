namespace Mirror;

[DisallowMultipleComponent]
[HelpURL("https://mirror-networking.gitbook.io/docs/guides/interest-management")]
[Token(Token = "0x2000019")]
public abstract class InterestManagement : InterestManagementBase
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000041")]
	private readonly HashSet<NetworkConnectionToClient> newObservers; //Field offset: 0x20

	[Address(RVA = "0x1250A00", Offset = "0x124FC00", Length = "0x77")]
	[CalledBy(Type = "Mirror.SpatialHashing3DInterestManagement", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.DistanceInterestManagement", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.MatchInterestManagement", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SceneInterestManagement", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SceneDistanceInterestManagement", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.HexSpatialHash2DInterestManagement", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.HexSpatialHash3DInterestManagement", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SpatialHashingInterestManagement", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.TeamInterestManagement", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000093")]
	protected InterestManagement() { }

	[Token(Token = "0x6000090")]
	public abstract void OnRebuildObservers(NetworkIdentity identity, HashSet<NetworkConnectionToClient> newObservers) { }

	[Address(RVA = "0x12504B0", Offset = "0x124F6B0", Length = "0x549")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkConnectionToClient), Member = "RemoveFromObserving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkConnectionToClient), Member = "AddToObserving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000092")]
	public virtual void Rebuild(NetworkIdentity identity, bool initialize) { }

	[Address(RVA = "0x12502E0", Offset = "0x124F4E0", Length = "0x1C2")]
	[CalledBy(Type = "Mirror.SpatialHashingInterestManagement", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.DistanceInterestManagement", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SceneDistanceInterestManagement", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.HexSpatialHash2DInterestManagement", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.HexSpatialHash3DInterestManagement", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SpatialHashing3DInterestManagement", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkServer), Member = "RebuildObservers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ServerCallback]
	[Token(Token = "0x6000091")]
	protected void RebuildAll() { }

}

