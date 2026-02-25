namespace Mirror;

[DisallowMultipleComponent]
[HelpURL("https://mirror-networking.gitbook.io/docs/guides/interest-management")]
[Token(Token = "0x200001A")]
public abstract class InterestManagementBase : MonoBehaviour
{

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600009D")]
	protected InterestManagementBase() { }

	[Address(RVA = "0x124FCA0", Offset = "0x124EEA0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkConnectionToClient), Member = "AddToObserving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600009B")]
	protected void AddObserver(NetworkConnectionToClient connection, NetworkIdentity identity) { }

	[Token(Token = "0x6000096")]
	public abstract bool OnCheckObserver(NetworkIdentity identity, NetworkConnectionToClient newObserver) { }

	[Address(RVA = "0x124FD10", Offset = "0x124EF10", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ServerCallback]
	[Token(Token = "0x6000099")]
	public override void OnDestroyed(NetworkIdentity identity) { }

	[Address(RVA = "0x124FD80", Offset = "0x124EF80", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000094")]
	protected override void OnEnable() { }

	[Address(RVA = "0x124FE50", Offset = "0x124F050", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ServerCallback]
	[Token(Token = "0x6000098")]
	public override void OnSpawned(NetworkIdentity identity) { }

	[Token(Token = "0x600009A")]
	public abstract void Rebuild(NetworkIdentity identity, bool initialize) { }

	[Address(RVA = "0x124FEC0", Offset = "0x124F0C0", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "HideForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600009C")]
	protected void RemoveObserver(NetworkConnectionToClient connection, NetworkIdentity identity) { }

	[Address(RVA = "0x124FF90", Offset = "0x124F190", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ServerCallback]
	[Token(Token = "0x6000095")]
	public override void ResetState() { }

	[Address(RVA = "0x1250000", Offset = "0x124F200", Length = "0x2D2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Terrain), Member = "set_drawHeightmap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Terrain), Member = "set_drawTreesAndFoliage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EmissionModule), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ServerCallback]
	[Token(Token = "0x6000097")]
	public override void SetHostVisibility(NetworkIdentity identity, bool visible) { }

}

