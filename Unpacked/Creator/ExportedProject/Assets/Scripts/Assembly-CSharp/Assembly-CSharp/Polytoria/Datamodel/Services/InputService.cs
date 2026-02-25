namespace Polytoria.Datamodel.Services;

[Token(Token = "0x2000387")]
public class InputService
{
	[Token(Token = "0x4000F6C")]
	public static LuaEvent KeyDown; //Field offset: 0x0
	[Token(Token = "0x4000F6D")]
	public static LuaEvent KeyUp; //Field offset: 0x8

	[Token(Token = "0x17000B4C")]
	public static bool AnyKey
	{
		[Address(RVA = "0x488DC0", Offset = "0x487FC0", Length = "0x7")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Input), Member = "get_anyKey", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x60025EE")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000B4D")]
	public static bool AnyKeyDown
	{
		[Address(RVA = "0x488DB0", Offset = "0x487FB0", Length = "0x7")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Input), Member = "get_anyKeyDown", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x60025EF")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000B48")]
	public static bool CursorLocked
	{
		[Address(RVA = "0x488DD0", Offset = "0x487FD0", Length = "0x16")]
		[CalledBy(Type = typeof(InputServiceProxy), Member = "get_CursorLocked", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Cursor), Member = "get_lockState", ReturnType = typeof(CursorLockMode))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60025E8")]
		 get { } //Length: 22
		[Address(RVA = "0x488FB0", Offset = "0x4881B0", Length = "0xC")]
		[CalledBy(Type = typeof(InputServiceProxy), Member = "set_CursorLocked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Cursor), Member = "set_lockState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CursorLockMode)}, ReturnType = typeof(void))]
		[Token(Token = "0x60025E9")]
		 set { } //Length: 12
	}

	[Token(Token = "0x17000B49")]
	public static bool CursorVisible
	{
		[Address(RVA = "0x488DF0", Offset = "0x487FF0", Length = "0x7")]
		[CalledBy(Type = typeof(InputServiceProxy), Member = "get_CursorVisible", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Cursor), Member = "get_visible", ReturnType = typeof(bool))]
		[Token(Token = "0x60025EA")]
		 get { } //Length: 7
		[Address(RVA = "0x488FC0", Offset = "0x4881C0", Length = "0x7")]
		[CalledBy(Type = typeof(InputServiceProxy), Member = "set_CursorVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Cursor), Member = "set_visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x60025EB")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000B4E")]
	public static bool IsInputFocused
	{
		[Address(RVA = "0x488E00", Offset = "0x488000", Length = "0x150")]
		[CalledBy(Type = typeof(Player), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Camera), Member = "UpdateFollowMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Camera), Member = "HandleLockInput", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Camera), Member = "HandleScrollInput", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(Camera), Member = "UpdateFree", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Player), Member = "get_IsInputFocused", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Player), Member = "get_IsMovementAllowed", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputServiceProxy), Member = "get_IsInputFocused", ReturnType = typeof(bool))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
		[Calls(Type = typeof(ScreenshotController), Member = "get_Focused", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60025F0")]
		 get { } //Length: 336
	}

	[Token(Token = "0x17000B47")]
	public static Vector3 MousePosition
	{
		[Address(RVA = "0x488F60", Offset = "0x488160", Length = "0x2C")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x60025E7")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000B4B")]
	public static int ScreenHeight
	{
		[Address(RVA = "0x488F90", Offset = "0x488190", Length = "0x7")]
		[CalledBy(Type = typeof(InputServiceProxy), Member = "get_ScreenHeight", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
		[Token(Token = "0x60025ED")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000B4A")]
	public static int ScreenWidth
	{
		[Address(RVA = "0x488FA0", Offset = "0x4881A0", Length = "0x7")]
		[CalledBy(Type = typeof(InputServiceProxy), Member = "get_ScreenWidth", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
		[Token(Token = "0x60025EC")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x488CF0", Offset = "0x487EF0", Length = "0xB8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LuaEvent), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002607")]
	private static InputService() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002606")]
	public InputService() { }

	[Address(RVA = "0x488DC0", Offset = "0x487FC0", Length = "0x7")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Input), Member = "get_anyKey", ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x60025EE")]
	public static bool get_AnyKey() { }

	[Address(RVA = "0x488DB0", Offset = "0x487FB0", Length = "0x7")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Input), Member = "get_anyKeyDown", ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x60025EF")]
	public static bool get_AnyKeyDown() { }

	[Address(RVA = "0x488DD0", Offset = "0x487FD0", Length = "0x16")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "get_CursorLocked", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Cursor), Member = "get_lockState", ReturnType = typeof(CursorLockMode))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60025E8")]
	public static bool get_CursorLocked() { }

	[Address(RVA = "0x488DF0", Offset = "0x487FF0", Length = "0x7")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "get_CursorVisible", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Cursor), Member = "get_visible", ReturnType = typeof(bool))]
	[Token(Token = "0x60025EA")]
	public static bool get_CursorVisible() { }

	[Address(RVA = "0x488E00", Offset = "0x488000", Length = "0x150")]
	[CalledBy(Type = typeof(Player), Member = "get_IsMovementAllowed", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Player), Member = "get_IsInputFocused", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Camera), Member = "UpdateFree", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "get_IsInputFocused", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Camera), Member = "HandleLockInput", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Camera), Member = "UpdateFollowMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Camera), Member = "HandleScrollInput", ReturnType = typeof(float))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(ScreenshotController), Member = "get_Focused", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60025F0")]
	public static bool get_IsInputFocused() { }

	[Address(RVA = "0x488F60", Offset = "0x488160", Length = "0x2C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x60025E7")]
	public static Vector3 get_MousePosition() { }

	[Address(RVA = "0x488F90", Offset = "0x488190", Length = "0x7")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "get_ScreenHeight", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Token(Token = "0x60025ED")]
	public static int get_ScreenHeight() { }

	[Address(RVA = "0x488FA0", Offset = "0x4881A0", Length = "0x7")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "get_ScreenWidth", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Token(Token = "0x60025EC")]
	public static int get_ScreenWidth() { }

	[Address(RVA = "0x487C70", Offset = "0x486E70", Length = "0x7")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "GetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Input), Member = "GetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Token(Token = "0x60025FE")]
	public static float GetAxis(string axisName) { }

	[Address(RVA = "0x487C60", Offset = "0x486E60", Length = "0x7")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "GetAxisRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Input), Member = "GetAxisRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Token(Token = "0x60025FF")]
	public static float GetAxisRaw(string axisName) { }

	[Address(RVA = "0x487CA0", Offset = "0x486EA0", Length = "0x7")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "GetButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Input), Member = "GetButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60025FB")]
	public static bool GetButton(string buttonName) { }

	[Address(RVA = "0x487C80", Offset = "0x486E80", Length = "0x7")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "GetButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Input), Member = "GetButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60025FC")]
	public static bool GetButtonDown(string buttonName) { }

	[Address(RVA = "0x487C90", Offset = "0x486E90", Length = "0x7")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "GetButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Input), Member = "GetButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60025FD")]
	public static bool GetButtonUp(string buttonName) { }

	[Address(RVA = "0x487CD0", Offset = "0x486ED0", Length = "0x7")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "GetKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyCode)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002600")]
	public static bool GetKey(KeyCode key) { }

	[Address(RVA = "0x487CB0", Offset = "0x486EB0", Length = "0x7")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "GetKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyCode)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002601")]
	public static bool GetKeyDown(KeyCode key) { }

	[Address(RVA = "0x487CC0", Offset = "0x486EC0", Length = "0x7")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "GetKeyUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyCode)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002602")]
	public static bool GetKeyUp(KeyCode key) { }

	[Address(RVA = "0x487D00", Offset = "0x486F00", Length = "0x7")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "GetMouseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Input), Member = "GetMouseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6002603")]
	public static bool GetMouseButton(int button) { }

	[Address(RVA = "0x487CE0", Offset = "0x486EE0", Length = "0x7")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "GetMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6002604")]
	public static bool GetMouseButtonDown(int button) { }

	[Address(RVA = "0x487CF0", Offset = "0x486EF0", Length = "0x7")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "GetMouseButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6002605")]
	public static bool GetMouseButtonUp(int button) { }

	[Address(RVA = "0x487D10", Offset = "0x486F10", Length = "0x6F")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "GetMouseWorldPoint", ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "ScreenToWorldPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60025F2")]
	public static Vector3 GetMouseWorldPoint() { }

	[Address(RVA = "0x487D80", Offset = "0x486F80", Length = "0x18C")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "GetMouseWorldPosition", ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(RaycastHit&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "ScreenToWorldPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025F1")]
	public static Vector3 GetMouseWorldPosition() { }

	[Address(RVA = "0x487F10", Offset = "0x487110", Length = "0x59E")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>)}, ReturnType = typeof(System.Nullable`1<Polytoria.Datamodel.RayResult>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Nullable`1<Polytoria.Datamodel.RayResult>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayResult)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Nullable`1<Polytoria.Datamodel.RayResult>), Member = "get_Value", ReturnType = typeof(RayResult))]
	[Calls(Type = typeof(Instance), Member = "IsDescendantOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider", ReturnType = typeof(Collider))]
	[Calls(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray)}, ReturnType = typeof(RaycastHit[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x60025F9")]
	public static Nullable<RayResult> ScreenPointToRay(Vector3 pos, List<Instance> ignoreList = null) { }

	[Address(RVA = "0x4884B0", Offset = "0x4876B0", Length = "0x63")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "ScreenToViewportPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Camera), Member = "ScreenToViewportPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60025F4")]
	public static Vector3 ScreenToViewportPoint(Vector3 pos) { }

	[Address(RVA = "0x488520", Offset = "0x487720", Length = "0x63")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "ScreenToWorldPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Camera), Member = "ScreenToWorldPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60025F3")]
	public static Vector3 ScreenToWorldPoint(Vector3 pos) { }

	[Address(RVA = "0x488FB0", Offset = "0x4881B0", Length = "0xC")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "set_CursorLocked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Cursor), Member = "set_lockState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CursorLockMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x60025E9")]
	public static void set_CursorLocked(bool value) { }

	[Address(RVA = "0x488FC0", Offset = "0x4881C0", Length = "0x7")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "set_CursorVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Cursor), Member = "set_visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60025EB")]
	public static void set_CursorVisible(bool value) { }

	[Address(RVA = "0x488590", Offset = "0x487790", Length = "0x59E")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "ViewportPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>)}, ReturnType = typeof(System.Nullable`1<Polytoria.Datamodel.RayResult>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Nullable`1<Polytoria.Datamodel.RayResult>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RayResult)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Nullable`1<Polytoria.Datamodel.RayResult>), Member = "get_Value", ReturnType = typeof(RayResult))]
	[Calls(Type = typeof(Instance), Member = "IsDescendantOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider", ReturnType = typeof(Collider))]
	[Calls(Type = typeof(Physics), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray)}, ReturnType = typeof(RaycastHit[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Camera), Member = "ViewportPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x60025FA")]
	public static Nullable<RayResult> ViewportPointToRay(Vector3 pos, List<Instance> ignoreList = null) { }

	[Address(RVA = "0x488B30", Offset = "0x487D30", Length = "0x63")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "ViewportToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Camera), Member = "ViewportToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60025F8")]
	public static Vector3 ViewportToScreenPoint(Vector3 pos) { }

	[Address(RVA = "0x488BA0", Offset = "0x487DA0", Length = "0x63")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "ViewportToWorldPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Camera), Member = "ViewportToWorldPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60025F7")]
	public static Vector3 ViewportToWorldPoint(Vector3 pos) { }

	[Address(RVA = "0x488C10", Offset = "0x487E10", Length = "0x63")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Camera), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60025F5")]
	public static Vector3 WorldToScreenPoint(Vector3 pos) { }

	[Address(RVA = "0x488C80", Offset = "0x487E80", Length = "0x63")]
	[CalledBy(Type = typeof(InputServiceProxy), Member = "WorldToViewportPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Camera), Member = "WorldToViewportPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60025F6")]
	public static Vector3 WorldToViewportPoint(Vector3 pos) { }

}

