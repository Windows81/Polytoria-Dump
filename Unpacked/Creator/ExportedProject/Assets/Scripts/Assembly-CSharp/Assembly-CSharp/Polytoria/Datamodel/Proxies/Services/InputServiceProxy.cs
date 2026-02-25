namespace Polytoria.Datamodel.Proxies.Services;

[Token(Token = "0x20003D9")]
public class InputServiceProxy
{
	[Token(Token = "0x4001024")]
	public static LuaEvent KeyUp; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001023")]
	private readonly InputService inputService; //Field offset: 0x10

	[Token(Token = "0x17000CAF")]
	public static bool AnyKey
	{
		[Address(RVA = "0x4A5160", Offset = "0x4A4360", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60029BA")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000CB0")]
	public static bool AnyKeyDown
	{
		[Address(RVA = "0x4A5120", Offset = "0x4A4320", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60029BB")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000CAB")]
	public static bool CursorLocked
	{
		[Address(RVA = "0x4A51A0", Offset = "0x4A43A0", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(InputService), Member = "get_CursorLocked", ReturnType = typeof(bool))]
		[Token(Token = "0x60029B4")]
		 get { } //Length: 64
		[Address(RVA = "0x4A5390", Offset = "0x4A4590", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(InputService), Member = "set_CursorLocked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x60029B5")]
		 set { } //Length: 73
	}

	[Token(Token = "0x17000CAC")]
	public static bool CursorVisible
	{
		[Address(RVA = "0x4A51E0", Offset = "0x4A43E0", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(InputService), Member = "get_CursorVisible", ReturnType = typeof(bool))]
		[Token(Token = "0x60029B6")]
		 get { } //Length: 64
		[Address(RVA = "0x4A53E0", Offset = "0x4A45E0", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(InputService), Member = "set_CursorVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x60029B7")]
		 set { } //Length: 73
	}

	[Token(Token = "0x17000CB1")]
	public static bool IsInputFocused
	{
		[Address(RVA = "0x4A5220", Offset = "0x4A4420", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(InputService), Member = "get_IsInputFocused", ReturnType = typeof(bool))]
		[Token(Token = "0x60029BC")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000CA9")]
	public static LuaEvent KeyDown
	{
		[Address(RVA = "0x4A5260", Offset = "0x4A4460", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60029B2")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000CAA")]
	public static Vector3 MousePosition
	{
		[Address(RVA = "0x4A52B0", Offset = "0x4A44B0", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60029B3")]
		 get { } //Length: 93
	}

	[Token(Token = "0x17000CAE")]
	public static int ScreenHeight
	{
		[Address(RVA = "0x4A5310", Offset = "0x4A4510", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(InputService), Member = "get_ScreenHeight", ReturnType = typeof(int))]
		[Token(Token = "0x60029B9")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000CAD")]
	public static int ScreenWidth
	{
		[Address(RVA = "0x4A5350", Offset = "0x4A4550", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(InputService), Member = "get_ScreenWidth", ReturnType = typeof(int))]
		[Token(Token = "0x60029B8")]
		 get { } //Length: 64
	}

	[Address(RVA = "0x4A50A0", Offset = "0x4A42A0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60029D2")]
	private static InputServiceProxy() { }

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60029B1")]
	public InputServiceProxy(InputService target) { }

	[Address(RVA = "0x4A5160", Offset = "0x4A4360", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60029BA")]
	public static bool get_AnyKey() { }

	[Address(RVA = "0x4A5120", Offset = "0x4A4320", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60029BB")]
	public static bool get_AnyKeyDown() { }

	[Address(RVA = "0x4A51A0", Offset = "0x4A43A0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "get_CursorLocked", ReturnType = typeof(bool))]
	[Token(Token = "0x60029B4")]
	public static bool get_CursorLocked() { }

	[Address(RVA = "0x4A51E0", Offset = "0x4A43E0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "get_CursorVisible", ReturnType = typeof(bool))]
	[Token(Token = "0x60029B6")]
	public static bool get_CursorVisible() { }

	[Address(RVA = "0x4A5220", Offset = "0x4A4420", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "get_IsInputFocused", ReturnType = typeof(bool))]
	[Token(Token = "0x60029BC")]
	public static bool get_IsInputFocused() { }

	[Address(RVA = "0x4A5260", Offset = "0x4A4460", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60029B2")]
	public static LuaEvent get_KeyDown() { }

	[Address(RVA = "0x4A52B0", Offset = "0x4A44B0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60029B3")]
	public static Vector3 get_MousePosition() { }

	[Address(RVA = "0x4A5310", Offset = "0x4A4510", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "get_ScreenHeight", ReturnType = typeof(int))]
	[Token(Token = "0x60029B9")]
	public static int get_ScreenHeight() { }

	[Address(RVA = "0x4A5350", Offset = "0x4A4550", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "get_ScreenWidth", ReturnType = typeof(int))]
	[Token(Token = "0x60029B8")]
	public static int get_ScreenWidth() { }

	[Address(RVA = "0x4A4840", Offset = "0x4A3A40", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "GetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Token(Token = "0x60029CA")]
	public static float GetAxis(string axisName) { }

	[Address(RVA = "0x4A47F0", Offset = "0x4A39F0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "GetAxisRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Token(Token = "0x60029CB")]
	public static float GetAxisRaw(string axisName) { }

	[Address(RVA = "0x4A4930", Offset = "0x4A3B30", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "GetButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60029C7")]
	public static bool GetButton(string buttonName) { }

	[Address(RVA = "0x4A4890", Offset = "0x4A3A90", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "GetButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60029C8")]
	public static bool GetButtonDown(string buttonName) { }

	[Address(RVA = "0x4A48E0", Offset = "0x4A3AE0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "GetButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60029C9")]
	public static bool GetButtonUp(string buttonName) { }

	[Address(RVA = "0x4A4A20", Offset = "0x4A3C20", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "GetKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyCode)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60029CC")]
	public static bool GetKey(KeyCode key) { }

	[Address(RVA = "0x4A4980", Offset = "0x4A3B80", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "GetKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyCode)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60029CD")]
	public static bool GetKeyDown(KeyCode key) { }

	[Address(RVA = "0x4A49D0", Offset = "0x4A3BD0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "GetKeyUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyCode)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60029CE")]
	public static bool GetKeyUp(KeyCode key) { }

	[Address(RVA = "0x4A4B10", Offset = "0x4A3D10", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "GetMouseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60029CF")]
	public static bool GetMouseButton(int button) { }

	[Address(RVA = "0x4A4A70", Offset = "0x4A3C70", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "GetMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60029D0")]
	public static bool GetMouseButtonDown(int button) { }

	[Address(RVA = "0x4A4AC0", Offset = "0x4A3CC0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "GetMouseButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60029D1")]
	public static bool GetMouseButtonUp(int button) { }

	[Address(RVA = "0x4A4B60", Offset = "0x4A3D60", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "GetMouseWorldPoint", ReturnType = typeof(Vector3))]
	[Token(Token = "0x60029BE")]
	public static Vector3 GetMouseWorldPoint() { }

	[Address(RVA = "0x4A4BC0", Offset = "0x4A3DC0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "GetMouseWorldPosition", ReturnType = typeof(Vector3))]
	[Token(Token = "0x60029BD")]
	public static Vector3 GetMouseWorldPosition() { }

	[Address(RVA = "0x4A4C20", Offset = "0x4A3E20", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>)}, ReturnType = typeof(System.Nullable`1<Polytoria.Datamodel.RayResult>))]
	[Token(Token = "0x60029C5")]
	public static Nullable<RayResult> ScreenPointToRay(Vector3 pos, List<Instance> ignoreList = null) { }

	[Address(RVA = "0x4A4CE0", Offset = "0x4A3EE0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "ScreenToViewportPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60029C0")]
	public static Vector3 ScreenToViewportPoint(Vector3 pos) { }

	[Address(RVA = "0x4A4D60", Offset = "0x4A3F60", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "ScreenToWorldPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60029BF")]
	public static Vector3 ScreenToWorldPoint(Vector3 pos) { }

	[Address(RVA = "0x4A5390", Offset = "0x4A4590", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "set_CursorLocked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60029B5")]
	public static void set_CursorLocked(bool value) { }

	[Address(RVA = "0x4A53E0", Offset = "0x4A45E0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "set_CursorVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60029B7")]
	public static void set_CursorVisible(bool value) { }

	[Address(RVA = "0x4A4DE0", Offset = "0x4A3FE0", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "ViewportPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>)}, ReturnType = typeof(System.Nullable`1<Polytoria.Datamodel.RayResult>))]
	[Token(Token = "0x60029C6")]
	public static Nullable<RayResult> ViewportPointToRay(Vector3 pos, List<Instance> ignoreList = null) { }

	[Address(RVA = "0x4A4EA0", Offset = "0x4A40A0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "ViewportToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60029C4")]
	public static Vector3 ViewportToScreenPoint(Vector3 pos) { }

	[Address(RVA = "0x4A4F20", Offset = "0x4A4120", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "ViewportToWorldPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60029C3")]
	public static Vector3 ViewportToWorldPoint(Vector3 pos) { }

	[Address(RVA = "0x4A4FA0", Offset = "0x4A41A0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60029C1")]
	public static Vector3 WorldToScreenPoint(Vector3 pos) { }

	[Address(RVA = "0x4A5020", Offset = "0x4A4220", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputService), Member = "WorldToViewportPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60029C2")]
	public static Vector3 WorldToViewportPoint(Vector3 pos) { }

}

