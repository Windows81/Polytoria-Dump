namespace UnityEngine;

[Token(Token = "0x200000B")]
internal class SendMouseEvents
{
	[Token(Token = "0x200000C")]
	private struct HitInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000038")]
		public GameObject target; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000039")]
		public Camera camera; //Field offset: 0x8

		[Address(RVA = "0x19D9180", Offset = "0x19D8380", Length = "0x8E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000046")]
		public static bool Compare(HitInfo lhs, HitInfo rhs) { }

		[Address(RVA = "0x19D9240", Offset = "0x19D8440", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000045")]
		public static bool op_Implicit(HitInfo exists) { }

		[Address(RVA = "0x19D9210", Offset = "0x19D8410", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GameObject), Member = "SendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(SendMessageOptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000044")]
		public void SendMessage(string name) { }

	}

	[Token(Token = "0x400002F")]
	private static bool s_MouseUsed; //Field offset: 0x0
	[Token(Token = "0x4000030")]
	private static readonly HitInfo[] m_LastHit; //Field offset: 0x8
	[Token(Token = "0x4000031")]
	private static readonly HitInfo[] m_MouseDownHit; //Field offset: 0x10
	[Token(Token = "0x4000032")]
	private static readonly HitInfo[] m_CurrentHit; //Field offset: 0x18
	[Token(Token = "0x4000033")]
	private static Camera[] m_Cameras; //Field offset: 0x20
	[Token(Token = "0x4000034")]
	public static Func<KeyValuePair`2<Int32, Vector2>> s_GetMouseState; //Field offset: 0x28
	[Token(Token = "0x4000035")]
	private static Vector2 s_MousePosition; //Field offset: 0x30
	[Token(Token = "0x4000036")]
	private static bool s_MouseButtonPressedThisFrame; //Field offset: 0x38
	[Token(Token = "0x4000037")]
	private static bool s_MouseButtonIsPressed; //Field offset: 0x39

	[Address(RVA = "0x19DC010", Offset = "0x19DB210", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000043")]
	private static SendMouseEvents() { }

	[Address(RVA = "0x19DA7F0", Offset = "0x19D99F0", Length = "0xBBF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801BC7B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Camera), Member = "get_cullingMask", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(Camera), Member = "get_eventMask", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_pixelRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Display), Member = "get_systemHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Display), Member = "get_systemWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Display), Member = "RelativeMouseAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "get_targetDisplay", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_targetTexture", ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "GetAllCameras", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(SendMouseEvents), Member = "UpdateMouse", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Camera), Member = "get_clearFlags", ReturnType = typeof(CameraClearFlags))]
	[Calls(Type = typeof(SendMouseEvents), Member = "SendEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(HitInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	[Token(Token = "0x6000041")]
	private static void DoSendMouseEvents(int skipRTCameras) { }

	[Address(RVA = "0x19DB3B0", Offset = "0x19DA5B0", Length = "0x994")]
	[CalledBy(Type = typeof(SendMouseEvents), Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(SendMessageOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000042")]
	private static void SendEvents(int i, HitInfo hit) { }

	[Address(RVA = "0x19DBD50", Offset = "0x19DAF50", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000040")]
	private static void SetMouseMoved() { }

	[Address(RVA = "0x19DBDA0", Offset = "0x19DAFA0", Length = "0x264")]
	[CalledBy(Type = typeof(SendMouseEvents), Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600003F")]
	private static void UpdateMouse() { }

}

