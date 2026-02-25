namespace namudev;

[Token(Token = "0x20002D3")]
public class PropertyGridBool : PropertyGridItem<Boolean>
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000AFE")]
	private GameObject caption; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000AFF")]
	private GameObject controls; //Field offset: 0x38

	[Address(RVA = "0x4119F0", Offset = "0x410BF0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001AAF")]
	public PropertyGridBool() { }

	[Address(RVA = "0x4119A0", Offset = "0x410BA0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CompilerGenerated]
	[Token(Token = "0x6001AB0")]
	private void <Start>b__3_0(bool value) { }

	[Address(RVA = "0x411760", Offset = "0x410960", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001AAD")]
	protected virtual void Awake() { }

	[Address(RVA = "0x411840", Offset = "0x410A40", Length = "0x159")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "get_Caption", ReturnType = typeof(string))]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001AAE")]
	private void Start() { }

}

