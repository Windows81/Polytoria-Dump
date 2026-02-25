namespace namudev;

[Token(Token = "0x20002D4")]
public class PropertyGridColor : PropertyGridItem<Color>
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B00")]
	private GameObject caption; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B01")]
	private GameObject inputFieldR; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B02")]
	private GameObject inputFieldG; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B03")]
	private GameObject inputFieldB; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B04")]
	private GameObject inputFieldA; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B05")]
	private GameObject inputFieldHex; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000B06")]
	private Image colorDisplayer; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000B07")]
	private Button colorDisplayerBtn; //Field offset: 0x68

	[Address(RVA = "0x412E60", Offset = "0x412060", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001AC0")]
	public PropertyGridColor() { }

	[Address(RVA = "0x411A30", Offset = "0x410C30", Length = "0x174")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(namudev.PropertyGridItem`1<UnityEngine.Color>), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001AB1")]
	protected virtual void Awake() { }

	[Address(RVA = "0x411BB0", Offset = "0x410DB0", Length = "0x1EA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEventBase), Member = "RemoveAllListeners", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ColorPicker), Member = "set_R", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorPicker), Member = "set_G", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorPicker), Member = "set_B", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorPicker), Member = "set_A", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001AB4")]
	private void OnColorBtnClick() { }

	[Address(RVA = "0x411DA0", Offset = "0x410FA0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001AB2")]
	private void OnDestroy() { }

	[Address(RVA = "0x411E20", Offset = "0x411020", Length = "0x16F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001ABF")]
	private void OnEndEditA(string str) { }

	[Address(RVA = "0x411F90", Offset = "0x411190", Length = "0x16F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001ABD")]
	private void OnEndEditB(string str) { }

	[Address(RVA = "0x412100", Offset = "0x411300", Length = "0x16F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001ABB")]
	private void OnEndEditG(string str) { }

	[Address(RVA = "0x412270", Offset = "0x411470", Length = "0x18D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(ColorUtility), Member = "ToHtmlStringRGBA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001AB7")]
	private void OnEndEditHex(string str) { }

	[Address(RVA = "0x412400", Offset = "0x411600", Length = "0x16F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001AB9")]
	private void OnEndEditR(string str) { }

	[Address(RVA = "0x412920", Offset = "0x411B20", Length = "0x292")]
	[CalledBy(Type = typeof(PropertyGridColor), Member = "OnValueChangeHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ColorUtility), Member = "ToHtmlStringRGBA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001AB5")]
	private void OnValueChange(Color color) { }

	[Address(RVA = "0x412570", Offset = "0x411770", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Token(Token = "0x6001ABE")]
	private void OnValueChangeA(string str) { }

	[Address(RVA = "0x412630", Offset = "0x411830", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Token(Token = "0x6001ABC")]
	private void OnValueChangeB(string str) { }

	[Address(RVA = "0x4126F0", Offset = "0x4118F0", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Token(Token = "0x6001ABA")]
	private void OnValueChangeG(string str) { }

	[Address(RVA = "0x4127B0", Offset = "0x4119B0", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ColorUtility), Member = "TryParseHtmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(PropertyGridColor), Member = "OnValueChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001AB6")]
	private void OnValueChangeHex(string hexColor) { }

	[Address(RVA = "0x412860", Offset = "0x411A60", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Token(Token = "0x6001AB8")]
	private void OnValueChangeR(string str) { }

	[Address(RVA = "0x412BC0", Offset = "0x411DC0", Length = "0x29D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorUtility), Member = "ToHtmlStringRGBA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "get_Caption", ReturnType = typeof(string))]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001AB3")]
	private void Start() { }

}

