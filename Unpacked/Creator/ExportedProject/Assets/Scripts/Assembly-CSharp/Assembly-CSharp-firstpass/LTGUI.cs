//Type is in global namespace

[Token(Token = "0x200001A")]
public class LTGUI
{
	[Token(Token = "0x200001B")]
	internal enum Element_Type
	{
		Texture = 0,
		Label = 1,
	}

	[Token(Token = "0x40000EC")]
	public static int RECT_LEVELS; //Field offset: 0x0
	[Token(Token = "0x40000ED")]
	public static int RECTS_PER_LEVEL; //Field offset: 0x4
	[Token(Token = "0x40000EE")]
	public static int BUTTONS_MAX; //Field offset: 0x8
	[Token(Token = "0x40000EF")]
	private static LTRect[] levels; //Field offset: 0x10
	[Token(Token = "0x40000F0")]
	private static Int32[] levelDepths; //Field offset: 0x18
	[Token(Token = "0x40000F1")]
	private static Rect[] buttons; //Field offset: 0x20
	[Token(Token = "0x40000F2")]
	private static Int32[] buttonLevels; //Field offset: 0x28
	[Token(Token = "0x40000F3")]
	private static Int32[] buttonLastFrame; //Field offset: 0x30
	[Token(Token = "0x40000F4")]
	private static LTRect r; //Field offset: 0x38
	[Token(Token = "0x40000F5")]
	private static Color color; //Field offset: 0x40
	[Token(Token = "0x40000F6")]
	private static bool isGUIEnabled; //Field offset: 0x50
	[Token(Token = "0x40000F7")]
	private static int global_counter; //Field offset: 0x54

	[Address(RVA = "0x2BE130", Offset = "0x2BD330", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600017C")]
	private static LTGUI() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017B")]
	public LTGUI() { }

	[Address(RVA = "0x2BE1E0", Offset = "0x2BD3E0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600016F")]
	public static bool checkOnScreen(Rect rect) { }

	[Address(RVA = "0x2BE270", Offset = "0x2BD470", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000179")]
	public static bool checkWithinRect(Vector2 vec2, Rect rect) { }

	[Address(RVA = "0x2BE400", Offset = "0x2BD600", Length = "0x164")]
	[CalledBy(Type = typeof(LeanTween), Member = "removeTween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTGUI), Member = "element", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LTRect), typeof(int)}, ReturnType = typeof(LTRect))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000170")]
	public static void destroy(int id) { }

	[Address(RVA = "0x2BE2D0", Offset = "0x2BD4D0", Length = "0x125")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000171")]
	public static void destroyAll(int depth) { }

	[Address(RVA = "0x2BE570", Offset = "0x2BD770", Length = "0x452")]
	[CalledBy(Type = typeof(LTGUI), Member = "label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(string), typeof(int)}, ReturnType = typeof(LTRect))]
	[CalledBy(Type = typeof(LTGUI), Member = "label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LTRect), typeof(string), typeof(int)}, ReturnType = typeof(LTRect))]
	[CalledBy(Type = typeof(LTGUI), Member = "texture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Texture), typeof(int)}, ReturnType = typeof(LTRect))]
	[CalledBy(Type = typeof(LTGUI), Member = "texture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LTRect), typeof(Texture), typeof(int)}, ReturnType = typeof(LTRect))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(LTGUI), Member = "destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(GUIStyleState), Member = "get_textColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GUIStyle), Member = "get_normal", ReturnType = typeof(GUIStyleState))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(LTGUI), Member = "init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000176")]
	public static LTRect element(LTRect rect, int depth) { }

	[Address(RVA = "0x2BE9D0", Offset = "0x2BDBD0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Input), Member = "GetMouseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Input), Member = "get_touches", ReturnType = typeof(Touch[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600017A")]
	public static Vector2 firstTouch() { }

	[Address(RVA = "0x2BEA60", Offset = "0x2BDC60", Length = "0x4F8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(LTGUI), Member = "pressedWithinRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000177")]
	public static bool hasNoOverlap(Rect rect, int depth) { }

	[Address(RVA = "0x2BF160", Offset = "0x2BE360", Length = "0x119")]
	[CalledBy(Type = typeof(LTGUI), Member = "update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTGUI), Member = "element", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LTRect), typeof(int)}, ReturnType = typeof(LTRect))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600016B")]
	public static void init() { }

	[Address(RVA = "0x2BEF60", Offset = "0x2BE160", Length = "0x1FA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600016C")]
	public static void initRectCheck() { }

	[Address(RVA = "0x2BF310", Offset = "0x2BE510", Length = "0x162")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LTGUI), Member = "element", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LTRect), typeof(int)}, ReturnType = typeof(LTRect))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000172")]
	public static LTRect label(Rect rect, string label, int depth) { }

	[Address(RVA = "0x2BF280", Offset = "0x2BE480", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LTGUI), Member = "element", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LTRect), typeof(int)}, ReturnType = typeof(LTRect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000173")]
	public static LTRect label(LTRect rect, string label, int depth) { }

	[Address(RVA = "0x2BF480", Offset = "0x2BE680", Length = "0x123")]
	[CalledBy(Type = typeof(LTGUI), Member = "hasNoOverlap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Input), Member = "GetMouseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Input), Member = "get_touches", ReturnType = typeof(Touch[]))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000178")]
	public static bool pressedWithinRect(Rect rect) { }

	[Address(RVA = "0x2BF5B0", Offset = "0x2BE7B0", Length = "0x1AE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600016D")]
	public static void reset() { }

	[Address(RVA = "0x2BF760", Offset = "0x2BE960", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LTGUI), Member = "element", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LTRect), typeof(int)}, ReturnType = typeof(LTRect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000175")]
	public static LTRect texture(LTRect rect, Texture texture, int depth) { }

	[Address(RVA = "0x2BF7F0", Offset = "0x2BE9F0", Length = "0x164")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LTGUI), Member = "element", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LTRect), typeof(int)}, ReturnType = typeof(LTRect))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000174")]
	public static LTRect texture(Rect rect, Texture texture, int depth) { }

	[Address(RVA = "0x2BF960", Offset = "0x2BEB60", Length = "0xC00")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUI), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LTGUI), Member = "init", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "get_color", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LTRect), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(GUI), Member = "DrawTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "get_skin", ReturnType = typeof(GUISkin))]
	[Calls(Type = typeof(GUISkin), Member = "set_label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600016E")]
	public static void update(int updateLevel) { }

}

