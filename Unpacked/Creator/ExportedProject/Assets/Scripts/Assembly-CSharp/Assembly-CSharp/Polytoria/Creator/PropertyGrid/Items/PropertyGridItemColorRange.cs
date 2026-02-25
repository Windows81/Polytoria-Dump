namespace Polytoria.Creator.PropertyGrid.Items;

[Token(Token = "0x20003E2")]
public class PropertyGridItemColorRange : PropertyGridItem
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001036")]
	private ProceduralImage colorDisplayerMin; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001037")]
	private ProceduralImage colorDisplayerMax; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001038")]
	private Button colorDisplayerBtnMin; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001039")]
	private Button colorDisplayerBtnMax; //Field offset: 0x58

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A08")]
	public PropertyGridItemColorRange() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60029FF")]
	private void Awake() { }

	[Address(RVA = "0x4A88F0", Offset = "0x4A7AF0", Length = "0x229")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEventBase), Member = "RemoveAllListeners", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(ColorPicker), Member = "set_R", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorPicker), Member = "set_G", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorPicker), Member = "set_B", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorPicker), Member = "set_A", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002A02")]
	private void OnColorDisplayerBtnClickMax() { }

	[Address(RVA = "0x4A8B20", Offset = "0x4A7D20", Length = "0x228")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEventBase), Member = "RemoveAllListeners", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(ColorPicker), Member = "set_R", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorPicker), Member = "set_G", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorPicker), Member = "set_B", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorPicker), Member = "set_A", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002A01")]
	private void OnColorDisplayerBtnClickMin() { }

	[Address(RVA = "0x4A8D50", Offset = "0x4A7F50", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002A05")]
	private void OnDestroy() { }

	[Address(RVA = "0x4A85A0", Offset = "0x4A77A0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A07")]
	private void OnValueChanged(bool value) { }

	[Address(RVA = "0x4A8DD0", Offset = "0x4A7FD0", Length = "0x1D4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(ColorRange), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A04")]
	private void OnValueChangeMax(Color color) { }

	[Address(RVA = "0x4A8FB0", Offset = "0x4A81B0", Length = "0x1D4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(ColorRange), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A03")]
	private void OnValueChangeMin(Color color) { }

	[Address(RVA = "0x4A9190", Offset = "0x4A8390", Length = "0x26C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertyGridItem), Member = "SetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002A00")]
	public virtual void SetProperty(PropertyInfo property) { }

	[Address(RVA = "0x4A9400", Offset = "0x4A8600", Length = "0x145")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6002A06")]
	public virtual void SetValue(object value) { }

}

