namespace RLD;

[Token(Token = "0x20001E3")]
public class RTActiveLibDropDown : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000766")]
	private Dropdown _dropDown; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000767")]
	private List<UnityAction`1<Int32>> _valueChangedListeners; //Field offset: 0x28

	[Token(Token = "0x170005E3")]
	public int ActiveLibIndex
	{
		[Address(RVA = "0x580ED0", Offset = "0x5800D0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60012B1")]
		 get { } //Length: 29
	}

	[Address(RVA = "0x580E50", Offset = "0x580050", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60012B7")]
	public RTActiveLibDropDown() { }

	[Address(RVA = "0x580A50", Offset = "0x57FC50", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60012B2")]
	public void AddValueChangedListener(UnityAction<Int32> listener) { }

	[Address(RVA = "0x580B40", Offset = "0x57FD40", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012B6")]
	private void Awake() { }

	[Address(RVA = "0x580BA0", Offset = "0x57FDA0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dropdown), Member = "ClearOptions", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012B4")]
	public void ClearLibs() { }

	[Address(RVA = "0x580ED0", Offset = "0x5800D0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012B1")]
	public int get_ActiveLibIndex() { }

	[Address(RVA = "0x580BC0", Offset = "0x57FDC0", Length = "0x16B")]
	[CalledBy(Type = typeof(RTActiveLibDropDown), Member = "SyncWithLibDb", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "SetActiveLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEventBase), Member = "RemoveAllListeners", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dropdown), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60012B3")]
	public void SetActiveLibIndex(int activeLibIndex) { }

	[Address(RVA = "0x580D30", Offset = "0x57FF30", Length = "0x115")]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "CreateLib", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RTPrefabLib))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "SetLibName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTPrefabLib), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTPrefabLibDb), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dropdown), Member = "ClearOptions", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTPrefabLibDb), Member = "GetAllLibNames", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[Calls(Type = typeof(Dropdown), Member = "AddOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTActiveLibDropDown), Member = "SetActiveLibIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012B5")]
	public void SyncWithLibDb() { }

}

