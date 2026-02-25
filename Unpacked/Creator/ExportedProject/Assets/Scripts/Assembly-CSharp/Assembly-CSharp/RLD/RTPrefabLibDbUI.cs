namespace RLD;

[Token(Token = "0x20001F1")]
public class RTPrefabLibDbUI : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000781")]
	private RTActiveLibDropDown _activeLibDropDown; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000782")]
	private RTPrefabScrollView _prefabScrollView; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000783")]
	private RTHoveredPrefabNameLabel _hoveredPrefabNameLabel; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000784")]
	private RTPrefabSearch _prefabSearch; //Field offset: 0x38

	[Token(Token = "0x170005F2")]
	public RTActiveLibDropDown ActiveLibDropDown
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600131B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005F4")]
	public RTHoveredPrefabNameLabel HoveredPrefabNameLabel
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x600131D")]
		 get { } //Length: 95
	}

	[Token(Token = "0x170005F3")]
	public RTPrefabScrollView PrefabScrollView
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600131C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005F5")]
	public RTPrefabSearch PrefabSearch
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600131E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001323")]
	public RTPrefabLibDbUI() { }

	[Address(RVA = "0x5829A0", Offset = "0x581BA0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTPrefabScrollView), Member = "FilterPrefabsByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001324")]
	private void <Awake>b__12_0(string p) { }

	[Address(RVA = "0x582620", Offset = "0x581820", Length = "0x255")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RTPrefabScrollView), Member = "add_PrefabPreviewHoverEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrefabPreviewHoverEnterHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTPrefabScrollView), Member = "add_PrefabPreviewHoverExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrefabPreviewHoverExitHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600131F")]
	private void Awake() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600131B")]
	public RTActiveLibDropDown get_ActiveLibDropDown() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x600131D")]
	public RTHoveredPrefabNameLabel get_HoveredPrefabNameLabel() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600131C")]
	public RTPrefabScrollView get_PrefabScrollView() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600131E")]
	public RTPrefabSearch get_PrefabSearch() { }

	[Address(RVA = "0x582880", Offset = "0x581A80", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001320")]
	private void OnPrefabPreviewHoverEnter(RTPrefab prefab) { }

	[Address(RVA = "0x582950", Offset = "0x581B50", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001321")]
	private void OnPrefabPreviewHoverExit(RTPrefab prefab) { }

	[Address(RVA = "0x5829A0", Offset = "0x581BA0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTPrefabScrollView), Member = "FilterPrefabsByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001322")]
	private void OnPrefabSearchFieldValueChanged(string value) { }

}

