namespace namudev;

[Token(Token = "0x20002E1")]
public class PropertyGridVector3 : PropertyGridItem<Vector3>
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B22")]
	private GameObject caption; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B23")]
	private GameObject inputFieldX; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B24")]
	private GameObject inputFieldY; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B25")]
	private GameObject inputFieldZ; //Field offset: 0x48

	[Address(RVA = "0x416F70", Offset = "0x416170", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001B02")]
	public PropertyGridVector3() { }

	[Address(RVA = "0x416520", Offset = "0x415720", Length = "0x17E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(namudev.PropertyGridItem`1<UnityEngine.Vector3>), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001AFA")]
	protected virtual void Awake() { }

	[Address(RVA = "0x4166A0", Offset = "0x4158A0", Length = "0x134")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(namudev.PropertyGridItem`1<UnityEngine.Vector3>), Member = "get_Value", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(namudev.PropertyGridItem`1<UnityEngine.Vector3>), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001AFD")]
	private void OnEndEditX(string str) { }

	[Address(RVA = "0x4167E0", Offset = "0x4159E0", Length = "0x134")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(namudev.PropertyGridItem`1<UnityEngine.Vector3>), Member = "get_Value", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(namudev.PropertyGridItem`1<UnityEngine.Vector3>), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001AFF")]
	private void OnEndEditY(string str) { }

	[Address(RVA = "0x416920", Offset = "0x415B20", Length = "0x134")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(namudev.PropertyGridItem`1<UnityEngine.Vector3>), Member = "get_Value", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(namudev.PropertyGridItem`1<UnityEngine.Vector3>), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B01")]
	private void OnEndEditZ(string str) { }

	[Address(RVA = "0x416A60", Offset = "0x415C60", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(namudev.PropertyGridItem`1<UnityEngine.Vector3>), Member = "get_Value", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(namudev.PropertyGridItem`1<UnityEngine.Vector3>), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001AFC")]
	private void OnValueChangeX(string str) { }

	[Address(RVA = "0x416B10", Offset = "0x415D10", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(namudev.PropertyGridItem`1<UnityEngine.Vector3>), Member = "get_Value", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(namudev.PropertyGridItem`1<UnityEngine.Vector3>), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001AFE")]
	private void OnValueChangeY(string str) { }

	[Address(RVA = "0x416BC0", Offset = "0x415DC0", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(namudev.PropertyGridItem`1<UnityEngine.Vector3>), Member = "get_Value", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(namudev.PropertyGridItem`1<UnityEngine.Vector3>), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001B00")]
	private void OnValueChangeZ(string str) { }

	[Address(RVA = "0x416C70", Offset = "0x415E70", Length = "0x2F1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(PropertyGridItem`1), Member = "get_Caption", ReturnType = typeof(string))]
	[Calls(Type = typeof(namudev.PropertyGridItem`1<UnityEngine.Vector3>), Member = "get_Value", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001AFB")]
	private void Start() { }

}

