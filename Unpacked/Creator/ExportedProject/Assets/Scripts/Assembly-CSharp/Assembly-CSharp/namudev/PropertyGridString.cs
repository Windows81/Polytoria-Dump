namespace namudev;

[Token(Token = "0x20002DE")]
public class PropertyGridString : PropertyGridItem<String>
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B1C")]
	private GameObject caption; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B1D")]
	private GameObject controls; //Field offset: 0x38

	[Address(RVA = "0x415DF0", Offset = "0x414FF0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001AEF")]
	public PropertyGridString() { }

	[Address(RVA = "0x415DA0", Offset = "0x414FA0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(namudev.PropertyGridItem`1<System.Object>), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	[Token(Token = "0x6001AF0")]
	private void <Start>b__3_0(string value) { }

	[Address(RVA = "0x415B60", Offset = "0x414D60", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(namudev.PropertyGridItem`1<System.Object>), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001AED")]
	protected virtual void Awake() { }

	[Address(RVA = "0x415C40", Offset = "0x414E40", Length = "0x159")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "get_Caption", ReturnType = typeof(string))]
	[Calls(Type = typeof(namudev.PropertyGridItem`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001AEE")]
	private void Start() { }

}

