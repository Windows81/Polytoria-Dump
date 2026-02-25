namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
[NativeHeader("IMGUIScriptingClasses.h")]
[RequiredByNativeCode]
[Token(Token = "0x200001B")]
public sealed class GUIStyle
{
	[Token(Token = "0x200001C")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001E5")]
		public static IntPtr ConvertToNative(GUIStyle guiStyle) { }

	}

	[Token(Token = "0x40000B2")]
	internal static bool showKeyboardFocus; //Field offset: 0x0
	[Token(Token = "0x40000B3")]
	private static GUIStyle s_None; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000A4")]
	internal IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A5")]
	private GUIStyleState m_Normal; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000A6")]
	private GUIStyleState m_Hover; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000A7")]
	private GUIStyleState m_Active; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000A8")]
	private GUIStyleState m_Focused; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000A9")]
	private GUIStyleState m_OnNormal; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000AA")]
	private GUIStyleState m_OnHover; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000AB")]
	private GUIStyleState m_OnActive; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000AC")]
	private GUIStyleState m_OnFocused; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000AD")]
	private RectOffset m_Border; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000AE")]
	private RectOffset m_Padding; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000AF")]
	private RectOffset m_Margin; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40000B0")]
	private RectOffset m_Overflow; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40000B1")]
	private string m_Name; //Field offset: 0x78

	[NativeProperty("m_Alignment", False, TargetType::Field (1))]
	[Token(Token = "0x1700005C")]
	public TextAnchor alignment
	{
		[Address(RVA = "0x19AEEA0", Offset = "0x19AE0A0", Length = "0x8B")]
		[CalledBy(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600017D")]
		 get { } //Length: 139
		[Address(RVA = "0x19B0280", Offset = "0x19AF480", Length = "0x98")]
		[CalledBy(Type = "Mirror.NetworkPingDisplay", Member = "OnGUI", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600017E")]
		 set { } //Length: 152
	}

	[NativeProperty("m_Clipping", False, TargetType::Field (1))]
	[Token(Token = "0x1700005E")]
	public TextClipping clipping
	{
		[Address(RVA = "0x19AEF70", Offset = "0x19AE170", Length = "0x8B")]
		[CalledBy(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000180")]
		 get { } //Length: 139
	}

	[NativeProperty("m_ContentOffset", False, TargetType::Field (1))]
	[Token(Token = "0x1700005F")]
	public Vector2 contentOffset
	{
		[Address(RVA = "0x19AF050", Offset = "0x19AE250", Length = "0x9C")]
		[CalledBy(Type = typeof(TextEditor), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000181")]
		 get { } //Length: 156
		[Address(RVA = "0x19B0370", Offset = "0x19AF570", Length = "0x95")]
		[CalledBy(Type = typeof(TextEditor), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000182")]
		 set { } //Length: 149
	}

	[NativeProperty("m_FixedHeight", False, TargetType::Field (1))]
	[Token(Token = "0x17000061")]
	public float fixedHeight
	{
		[Address(RVA = "0x19AF130", Offset = "0x19AE330", Length = "0x8B")]
		[CalledBy(Type = typeof(SliderHandler), Member = "ThumbExtRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(GUI), Member = "BeginScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Vector2), typeof(Rect), typeof(bool), typeof(bool), typeof(GUIStyle), typeof(GUIStyle), typeof(GUIStyle)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(GUILayoutEntry), Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcHeight", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIScrollGroup), Member = "CalcHeight", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIScrollGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SliderHandler), Member = "HorizontalThumbRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(SliderHandler), Member = "ThumbSize", ReturnType = typeof(float))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000184")]
		 get { } //Length: 139
	}

	[NativeProperty("m_FixedWidth", False, TargetType::Field (1))]
	[Token(Token = "0x17000060")]
	public float fixedWidth
	{
		[Address(RVA = "0x19AF200", Offset = "0x19AE400", Length = "0x8B")]
		[CalledBy(Type = typeof(SliderHandler), Member = "ThumbExtRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(GUI), Member = "BeginScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Vector2), typeof(Rect), typeof(bool), typeof(bool), typeof(GUIStyle), typeof(GUIStyle), typeof(GUIStyle)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(GUILayoutEntry), Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcWidth", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIScrollGroup), Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIScrollGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SliderHandler), Member = "VerticalThumbRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(SliderHandler), Member = "ThumbSize", ReturnType = typeof(float))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000183")]
		 get { } //Length: 139
	}

	[NativeProperty("Font", False, TargetType::Function (0))]
	[Token(Token = "0x1700005A")]
	public Font font
	{
		[Address(RVA = "0x19AF470", Offset = "0x19AE670", Length = "0xA5")]
		[CalledBy(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600017B")]
		 get { } //Length: 165
	}

	[NativeProperty("m_FontSize", False, TargetType::Field (1))]
	[Token(Token = "0x17000064")]
	public int fontSize
	{
		[Address(RVA = "0x19AF2D0", Offset = "0x19AE4D0", Length = "0x8B")]
		[CalledBy(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000189")]
		 get { } //Length: 139
		[Address(RVA = "0x19B0450", Offset = "0x19AF650", Length = "0x98")]
		[CalledBy(Type = "LTRect", Member = "get_rect", ReturnType = typeof(Rect))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600018A")]
		 set { } //Length: 152
	}

	[NativeProperty("m_FontStyle", False, TargetType::Field (1))]
	[Token(Token = "0x17000065")]
	public FontStyle fontStyle
	{
		[Address(RVA = "0x19AF3A0", Offset = "0x19AE5A0", Length = "0x8B")]
		[CalledBy(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600018B")]
		 get { } //Length: 139
	}

	[NativeProperty("m_ImagePosition", False, TargetType::Field (1))]
	[Token(Token = "0x1700005B")]
	public ImagePosition imagePosition
	{
		[Address(RVA = "0x19AF560", Offset = "0x19AE760", Length = "0x8B")]
		[CalledBy(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600017C")]
		 get { } //Length: 139
	}

	[NativeProperty("m_ClipOffset", False, TargetType::Field (1))]
	[Token(Token = "0x17000067")]
	internal Vector2 Internal_clipOffset
	{
		[Address(RVA = "0x19AEDC0", Offset = "0x19ADFC0", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600018D")]
		internal get { } //Length: 156
		[Address(RVA = "0x19B01A0", Offset = "0x19AF3A0", Length = "0x95")]
		[CalledBy(Type = typeof(TextEditor), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600018E")]
		internal set { } //Length: 149
	}

	[Token(Token = "0x1700006E")]
	public bool isHeightDependantOnWidth
	{
		[Address(RVA = "0x19AF5F0", Offset = "0x19AE7F0", Length = "0x18D")]
		[CalledBy(Type = typeof(GUILayoutUtility), Member = "DoGetRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIContent), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(Rect))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60001B9")]
		 get { } //Length: 397
	}

	[Token(Token = "0x1700006C")]
	public float lineHeight
	{
		[Address(RVA = "0x19AF780", Offset = "0x19AE980", Length = "0x4E")]
		[CalledBy(Type = typeof(TextEditor), Member = "GetLocalCursorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TextEditor), Member = "UpdateScrollOffset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditor), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(IMGUITextHandle), Member = "GetLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
		[Token(Token = "0x60001A8")]
		 get { } //Length: 78
	}

	[Token(Token = "0x1700006A")]
	public RectOffset margin
	{
		[Address(RVA = "0x19AF7D0", Offset = "0x19AE9D0", Length = "0xEE")]
		[CalledBy(Type = typeof(GUIScrollGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SliderHandler), Member = "HorizontalThumbRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(SliderHandler), Member = "VerticalThumbRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(GUIScrollGroup), Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIScrollGroup), Member = "CalcHeight", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutEntry), Member = "get_marginTop", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(GUILayoutEntry), Member = "get_marginRight", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(GUILayoutEntry), Member = "get_marginLeft", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(GUI), Member = "BeginScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Vector2), typeof(Rect), typeof(bool), typeof(bool), typeof(GUIStyle), typeof(GUIStyle), typeof(GUIStyle)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(GUILayoutEntry), Member = "get_marginBottom", ReturnType = typeof(int))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001A6")]
		 get { } //Length: 238
	}

	[Token(Token = "0x17000068")]
	public string name
	{
		[Address(RVA = "0x19AF8C0", Offset = "0x19AEAC0", Length = "0x3F")]
		[CalledBy(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutEntry), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(GUIStyle), Member = "get_rawName", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60001A3")]
		 get { } //Length: 63
		[Address(RVA = "0x19B04F0", Offset = "0x19AF6F0", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(GUIStyle), Member = "set_rawName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Token(Token = "0x60001A4")]
		 set { } //Length: 53
	}

	[Token(Token = "0x1700006D")]
	public static GUIStyle none
	{
		[Address(RVA = "0x19AF900", Offset = "0x19AEB00", Length = "0xB1")]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditor), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIScrollGroup), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcHeight", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcWidth", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayout), Member = "BeginArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayout), Member = "BeginVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIContent), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayout), Member = "BeginVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayout), Member = "BeginHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIContent), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayout), Member = "BeginHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUI), Member = "CallWindowDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WindowFunction), typeof(int), typeof(int), typeof(GUISkin), typeof(int), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUI), Member = "BeginScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Vector2), typeof(Rect), typeof(bool), typeof(bool), typeof(GUIStyle), typeof(GUIStyle), typeof(GUIStyle)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(GUI), Member = "BeginGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle), typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 25)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(GUIStyle), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60001B4")]
		 get { } //Length: 177
	}

	[Token(Token = "0x17000069")]
	public GUIStyleState normal
	{
		[Address(RVA = "0x19AF9C0", Offset = "0x19AEBC0", Length = "0xF8")]
		[CalledBy(Type = "LTGUI", Member = "element", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"LTRect", typeof(int)}, ReturnType = "LTRect")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001A5")]
		 get { } //Length: 248
	}

	[Token(Token = "0x1700006B")]
	public RectOffset padding
	{
		[Address(RVA = "0x19AFAC0", Offset = "0x19AECC0", Length = "0xEE")]
		[CalledBy(Type = typeof(SliderHandler), Member = "ValuesPerPixel", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(TextEditor), Member = "UpdateScrollOffset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditor), Member = "UpdateTextHandle", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SliderHandler), Member = "ThumbSize", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(SliderHandler), Member = "VerticalThumbRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SliderHandler), Member = "HorizontalThumbRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcWidth", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIStyle), Member = "GetDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect), typeof(Vector2&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIStyle), Member = "GetPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Rect)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(GUIStyle), Member = "GetCursorPixelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcHeight", ReturnType = typeof(void))]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001A7")]
		 get { } //Length: 238
	}

	[NativeProperty("Name", False, TargetType::Function (0))]
	[Token(Token = "0x17000059")]
	internal string rawName
	{
		[Address(RVA = "0x19AFC00", Offset = "0x19AEE00", Length = "0x11B")]
		[CalledBy(Type = typeof(GUI), Member = "HorizontalScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(GUI), Member = "VerticalScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(GUILayout), Member = "BeginScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(GUIStyle), Member = "get_name", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(GUIStyle), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000179")]
		internal get { } //Length: 283
		[Address(RVA = "0x19B0580", Offset = "0x19AF780", Length = "0x1CA")]
		[CalledBy(Type = typeof(GUISkin), Member = "get_error", ReturnType = typeof(GUIStyle))]
		[CalledBy(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIStyle), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 25)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600017A")]
		internal set { } //Length: 458
	}

	[NativeProperty("m_RichText", False, TargetType::Field (1))]
	[Token(Token = "0x17000066")]
	public bool richText
	{
		[Address(RVA = "0x19AFD60", Offset = "0x19AEF60", Length = "0x8B")]
		[CalledBy(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600018C")]
		 get { } //Length: 139
	}

	[NativeProperty("m_StretchHeight", False, TargetType::Field (1))]
	[Token(Token = "0x17000063")]
	public bool stretchHeight
	{
		[Address(RVA = "0x19AFE30", Offset = "0x19AF030", Length = "0x8B")]
		[CalledBy(Type = typeof(GUILayoutEntry), Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcHeight", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000187")]
		 get { } //Length: 139
		[Address(RVA = "0x19B07A0", Offset = "0x19AF9A0", Length = "0x9B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000188")]
		 set { } //Length: 155
	}

	[NativeProperty("m_StretchWidth", False, TargetType::Field (1))]
	[Token(Token = "0x17000062")]
	public bool stretchWidth
	{
		[Address(RVA = "0x19AFF00", Offset = "0x19AF100", Length = "0x8B")]
		[CalledBy(Type = typeof(GUILayoutEntry), Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcWidth", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000185")]
		 get { } //Length: 139
		[Address(RVA = "0x19B0890", Offset = "0x19AFA90", Length = "0x9B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000186")]
		 set { } //Length: 155
	}

	[NativeProperty("m_WordWrap", False, TargetType::Field (1))]
	[Token(Token = "0x1700005D")]
	public bool wordWrap
	{
		[Address(RVA = "0x19AFFD0", Offset = "0x19AF1D0", Length = "0x8B")]
		[CalledBy(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600017F")]
		 get { } //Length: 139
	}

	[Address(RVA = "0x19AECB0", Offset = "0x19ADEB0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60001C0")]
	private static GUIStyle() { }

	[Address(RVA = "0x19AECF0", Offset = "0x19ADEF0", Length = "0x72")]
	[CalledBy(Type = typeof(GUILayout), Member = "FlexibleSpace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "get_spaceStyle", ReturnType = typeof(GUIStyle))]
	[CalledBy(Type = typeof(GUISkin), Member = "get_error", ReturnType = typeof(GUIStyle))]
	[CalledBy(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A1")]
	public GUIStyle() { }

	[Address(RVA = "0x19ABC30", Offset = "0x19AAE30", Length = "0xAA")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001B7")]
	public float CalcHeight(GUIContent content, float width) { }

	[Address(RVA = "0x19ABCE0", Offset = "0x19AAEE0", Length = "0xCB")]
	[CalledBy(Type = typeof(GUIWordWrapSizer), Member = "CalcWidth", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001BA")]
	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	[Address(RVA = "0x19ABDB0", Offset = "0x19AAFB0", Length = "0xE7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001B6")]
	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	[Address(RVA = "0x19ACD10", Offset = "0x19ABF10", Length = "0x130")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A9")]
	public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[Address(RVA = "0x19ACC20", Offset = "0x19ABE20", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001AA")]
	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[Address(RVA = "0x19ACE50", Offset = "0x19AC050", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001AB")]
	public void Draw(Rect position, GUIContent content, int controlID) { }

	[Address(RVA = "0x19ACA50", Offset = "0x19ABC50", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001AC")]
	public void Draw(Rect position, GUIContent content, int controlID, bool on) { }

	[Address(RVA = "0x19ACE90", Offset = "0x19AC090", Length = "0xCE")]
	[CalledBy(Type = typeof(GUI), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "DoRepeatButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle), typeof(FocusType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GUI), Member = "DoControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(bool), typeof(bool), typeof(GUIContent), typeof(GUIStyle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SliderHandler), Member = "OnRepaint", ReturnType = typeof(float))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIUtility), Member = "get_hotControl", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUIUtility), Member = "HasKeyFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUIStyle), Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001AD")]
	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	[Address(RVA = "0x19ACA90", Offset = "0x19ABC90", Length = "0x182")]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForTouchscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(string), typeof(char), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "BeginGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIStyle), Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIStyle), Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIStyle), Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001AE")]
	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[Address(RVA = "0x19ABEA0", Offset = "0x19AB0A0", Length = "0x361")]
	[CalledBy(Type = typeof(TextEditor), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUI), Member = "get_skin", ReturnType = typeof(GUISkin))]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E040")]
	[Calls(Type = typeof(GUIStyle), Member = "GetCursorPixelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001AF")]
	public void DrawCursor(Rect position, GUIContent content, int controlID, int character) { }

	[Address(RVA = "0x19AC210", Offset = "0x19AB410", Length = "0x50E")]
	[CalledBy(Type = typeof(GUIStyle), Member = "DrawWithTextSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIStyle), Member = "DrawWithTextSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GUIStyle), Member = "GetCursorPixelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUI), Member = "get_skin", ReturnType = typeof(GUISkin))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E040")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001B0")]
	internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor) { }

	[Address(RVA = "0x19AC8B0", Offset = "0x19ABAB0", Length = "0x19A")]
	[CalledBy(Type = typeof(TextEditor), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIUtility), Member = "get_hotControl", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUIUtility), Member = "get_keyboardControl", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUI), Member = "get_skin", ReturnType = typeof(GUISkin))]
	[Calls(Type = typeof(GUIStyle), Member = "DrawWithTextSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(bool), typeof(bool), typeof(int), typeof(int), typeof(bool), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001B1")]
	internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition) { }

	[Address(RVA = "0x19AC720", Offset = "0x19AB920", Length = "0x18B")]
	[CalledBy(Type = typeof(TextEditor), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIUtility), Member = "get_hotControl", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUIUtility), Member = "get_keyboardControl", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUI), Member = "get_skin", ReturnType = typeof(GUISkin))]
	[Calls(Type = typeof(GUIStyle), Member = "DrawWithTextSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(bool), typeof(bool), typeof(int), typeof(int), typeof(bool), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001B2")]
	public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) { }

	[Address(RVA = "0x19ACF60", Offset = "0x19AC160", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(IMGUITextHandle), Member = "EmptyManagedCache", ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x60001BF")]
	internal static void EmptyManagedCache() { }

	[Address(RVA = "0x19ACFA0", Offset = "0x19AC1A0", Length = "0xBE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A2")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x19AEEA0", Offset = "0x19AE0A0", Length = "0x8B")]
	[CalledBy(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600017D")]
	public TextAnchor get_alignment() { }

	[Address(RVA = "0x19AEE60", Offset = "0x19AE060", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C5")]
	private static TextAnchor get_alignment_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19AEF70", Offset = "0x19AE170", Length = "0x8B")]
	[CalledBy(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000180")]
	public TextClipping get_clipping() { }

	[Address(RVA = "0x19AEF30", Offset = "0x19AE130", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C8")]
	private static TextClipping get_clipping_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19AF050", Offset = "0x19AE250", Length = "0x9C")]
	[CalledBy(Type = typeof(TextEditor), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000181")]
	public Vector2 get_contentOffset() { }

	[Address(RVA = "0x19AF000", Offset = "0x19AE200", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C9")]
	private static void get_contentOffset_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x19AF130", Offset = "0x19AE330", Length = "0x8B")]
	[CalledBy(Type = typeof(SliderHandler), Member = "ThumbSize", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GUIScrollGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIScrollGroup), Member = "CalcHeight", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcHeight", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SliderHandler), Member = "HorizontalThumbRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(GUILayoutEntry), Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "BeginScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Vector2), typeof(Rect), typeof(bool), typeof(bool), typeof(GUIStyle), typeof(GUIStyle), typeof(GUIStyle)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(SliderHandler), Member = "ThumbExtRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000184")]
	public float get_fixedHeight() { }

	[Address(RVA = "0x19AF0F0", Offset = "0x19AE2F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001CC")]
	private static float get_fixedHeight_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19AF200", Offset = "0x19AE400", Length = "0x8B")]
	[CalledBy(Type = typeof(SliderHandler), Member = "ThumbSize", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GUIScrollGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIScrollGroup), Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcWidth", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SliderHandler), Member = "VerticalThumbRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(GUILayoutEntry), Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "BeginScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Vector2), typeof(Rect), typeof(bool), typeof(bool), typeof(GUIStyle), typeof(GUIStyle), typeof(GUIStyle)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(SliderHandler), Member = "ThumbExtRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000183")]
	public float get_fixedWidth() { }

	[Address(RVA = "0x19AF1C0", Offset = "0x19AE3C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001CB")]
	private static float get_fixedWidth_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19AF470", Offset = "0x19AE670", Length = "0xA5")]
	[CalledBy(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600017B")]
	public Font get_font() { }

	[Address(RVA = "0x19AF430", Offset = "0x19AE630", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C3")]
	private static IntPtr get_font_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19AF2D0", Offset = "0x19AE4D0", Length = "0x8B")]
	[CalledBy(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000189")]
	public int get_fontSize() { }

	[Address(RVA = "0x19AF290", Offset = "0x19AE490", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D1")]
	private static int get_fontSize_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19AF3A0", Offset = "0x19AE5A0", Length = "0x8B")]
	[CalledBy(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600018B")]
	public FontStyle get_fontStyle() { }

	[Address(RVA = "0x19AF360", Offset = "0x19AE560", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D3")]
	private static FontStyle get_fontStyle_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19AF560", Offset = "0x19AE760", Length = "0x8B")]
	[CalledBy(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600017C")]
	public ImagePosition get_imagePosition() { }

	[Address(RVA = "0x19AF520", Offset = "0x19AE720", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C4")]
	private static ImagePosition get_imagePosition_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19AEDC0", Offset = "0x19ADFC0", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600018D")]
	internal Vector2 get_Internal_clipOffset() { }

	[Address(RVA = "0x19AED70", Offset = "0x19ADF70", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D5")]
	private static void get_Internal_clipOffset_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x19AF5F0", Offset = "0x19AE7F0", Length = "0x18D")]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "DoGetRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIContent), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(Rect))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001B9")]
	public bool get_isHeightDependantOnWidth() { }

	[Address(RVA = "0x19AF780", Offset = "0x19AE980", Length = "0x4E")]
	[CalledBy(Type = typeof(TextEditor), Member = "GetLocalCursorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextEditor), Member = "UpdateScrollOffset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(IMGUITextHandle), Member = "GetLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Token(Token = "0x60001A8")]
	public float get_lineHeight() { }

	[Address(RVA = "0x19AF7D0", Offset = "0x19AE9D0", Length = "0xEE")]
	[CalledBy(Type = typeof(GUILayoutEntry), Member = "get_marginBottom", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GUILayoutEntry), Member = "get_marginLeft", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GUILayoutEntry), Member = "get_marginRight", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GUILayoutEntry), Member = "get_marginTop", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GUIScrollGroup), Member = "CalcHeight", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "BeginScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Vector2), typeof(Rect), typeof(bool), typeof(bool), typeof(GUIStyle), typeof(GUIStyle), typeof(GUIStyle)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(GUIScrollGroup), Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SliderHandler), Member = "VerticalThumbRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(SliderHandler), Member = "HorizontalThumbRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(GUIScrollGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A6")]
	public RectOffset get_margin() { }

	[Address(RVA = "0x19AF8C0", Offset = "0x19AEAC0", Length = "0x3F")]
	[CalledBy(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutEntry), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GUIStyle), Member = "get_rawName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001A3")]
	public string get_name() { }

	[Address(RVA = "0x19AF900", Offset = "0x19AEB00", Length = "0xB1")]
	[CalledBy(Type = typeof(GUI), Member = "BeginGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "BeginScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Vector2), typeof(Rect), typeof(bool), typeof(bool), typeof(GUIStyle), typeof(GUIStyle), typeof(GUIStyle)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(GUI), Member = "CallWindowDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WindowFunction), typeof(int), typeof(int), typeof(GUISkin), typeof(int), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayout), Member = "BeginHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayout), Member = "BeginHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIContent), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayout), Member = "BeginVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayout), Member = "BeginArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayout), Member = "BeginVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIContent), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcWidth", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcHeight", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIScrollGroup), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60001B4")]
	public static GUIStyle get_none() { }

	[Address(RVA = "0x19AF9C0", Offset = "0x19AEBC0", Length = "0xF8")]
	[CalledBy(Type = "LTGUI", Member = "element", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"LTRect", typeof(int)}, ReturnType = "LTRect")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A5")]
	public GUIStyleState get_normal() { }

	[Address(RVA = "0x19AFAC0", Offset = "0x19AECC0", Length = "0xEE")]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcHeight", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIStyle), Member = "GetCursorPixelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(GUIStyle), Member = "GetDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect), typeof(Vector2&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcWidth", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SliderHandler), Member = "HorizontalThumbRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(GUIStyle), Member = "GetPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(SliderHandler), Member = "VerticalThumbRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(SliderHandler), Member = "ThumbSize", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TextEditor), Member = "UpdateTextHandle", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "UpdateScrollOffset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SliderHandler), Member = "ValuesPerPixel", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "SetVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001A7")]
	public RectOffset get_padding() { }

	[Address(RVA = "0x19AFC00", Offset = "0x19AEE00", Length = "0x11B")]
	[CalledBy(Type = typeof(GUI), Member = "HorizontalScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GUI), Member = "VerticalScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GUILayout), Member = "BeginScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(GUIStyle), Member = "get_name", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(GUIStyle), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000179")]
	internal string get_rawName() { }

	[Address(RVA = "0x19AFBB0", Offset = "0x19AEDB0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C1")]
	private static void get_rawName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x19AFD60", Offset = "0x19AEF60", Length = "0x8B")]
	[CalledBy(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600018C")]
	public bool get_richText() { }

	[Address(RVA = "0x19AFD20", Offset = "0x19AEF20", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D4")]
	private static bool get_richText_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19AFE30", Offset = "0x19AF030", Length = "0x8B")]
	[CalledBy(Type = typeof(GUILayoutEntry), Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcHeight", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000187")]
	public bool get_stretchHeight() { }

	[Address(RVA = "0x19AFDF0", Offset = "0x19AEFF0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001CF")]
	private static bool get_stretchHeight_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19AFF00", Offset = "0x19AF100", Length = "0x8B")]
	[CalledBy(Type = typeof(GUILayoutEntry), Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "ApplyStyleSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcWidth", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000185")]
	public bool get_stretchWidth() { }

	[Address(RVA = "0x19AFEC0", Offset = "0x19AF0C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001CD")]
	private static bool get_stretchWidth_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19AFFD0", Offset = "0x19AF1D0", Length = "0x8B")]
	[CalledBy(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600017F")]
	public bool get_wordWrap() { }

	[Address(RVA = "0x19AFF90", Offset = "0x19AF190", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C7")]
	private static bool get_wordWrap_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19AD060", Offset = "0x19AC260", Length = "0x3E8")]
	[CalledBy(Type = typeof(GUIStyle), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIStyle), Member = "DrawWithTextSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(bool), typeof(bool), typeof(int), typeof(int), typeof(bool), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "UpdateScrollOffset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(IMGUITextHandle), Member = "GetLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(float))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_preferredSize", ReturnType = typeof(Vector2))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetCursorPositionFromStringIndexUsingLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Rect), typeof(string), typeof(Color32)}, ReturnType = typeof(IMGUITextHandle))]
	[Calls(Type = typeof(RectOffset), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIStyle), Member = "get_padding", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001B5")]
	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	[Address(RVA = "0x19AD480", Offset = "0x19AC680", Length = "0x75")]
	[CalledBy(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "GUIStyle::GetDefaultFont")]
	[Token(Token = "0x600019F")]
	internal static Font GetDefaultFont() { }

	[Address(RVA = "0x19AD450", Offset = "0x19AC650", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001E4")]
	private static IntPtr GetDefaultFont_Injected() { }

	[Address(RVA = "0x19AD500", Offset = "0x19AC700", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GUIStyle), Member = "get_padding", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Rect), typeof(string), typeof(Color32)}, ReturnType = typeof(IMGUITextHandle))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_preferredSize", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[RequiredByNativeCode]
	[Token(Token = "0x60001BD")]
	internal static void GetDimensions(GUIStyle style, Color color, string content, Rect rect, ref Vector2 dimensions) { }

	[Address(RVA = "0x19AD620", Offset = "0x19AC820", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(IMGUITextHandle), Member = "GetLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[RequiredByNativeCode]
	[Token(Token = "0x60001BE")]
	internal static void GetLineHeight(GUIStyle style, ref float lineHeight) { }

	[Address(RVA = "0x19AD690", Offset = "0x19AC890", Length = "0x3B3")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_settings", ReturnType = "UnityEngine.TextCore.Text.TextGenerationSettings")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Rect), typeof(string), typeof(Color32), typeof(Boolean&)}, ReturnType = typeof(IMGUITextHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(GUIUtility), Member = "get_pixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_preferredSize", ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x60001BC")]
	internal static void GetMeshInfo(GUIStyle style, Color color, string content, Rect rect, ref MeshInfoBindings[] meshInfos, ref Vector2 dimensions, ref int generationId) { }

	[Address(RVA = "0x19ADA50", Offset = "0x19ACC50", Length = "0xE7")]
	[CalledBy(Type = typeof(TextEditor), Member = "UpdateScrollOffset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GUIStyle), Member = "get_padding", ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(RectOffset), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Rect), typeof(string), typeof(Color32)}, ReturnType = typeof(IMGUITextHandle))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_preferredSize", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001B8")]
	internal Vector2 GetPreferredSize(string content, Rect rect) { }

	[Address(RVA = "0x19ADB80", Offset = "0x19ACD80", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "GUIStyle_Bindings::GetRectOffsetPtr", HasExplicitThis = True)]
	[Token(Token = "0x6000192")]
	private IntPtr GetRectOffsetPtr(int idx) { }

	[Address(RVA = "0x19ADB40", Offset = "0x19ACD40", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D8")]
	private static IntPtr GetRectOffsetPtr_Injected(IntPtr _unity_self, int idx) { }

	[Address(RVA = "0x19ADC60", Offset = "0x19ACE60", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "GUIStyle_Bindings::GetStyleStatePtr", IsThreadSafe = True, HasExplicitThis = True)]
	[Token(Token = "0x6000191")]
	private IntPtr GetStyleStatePtr(int idx) { }

	[Address(RVA = "0x19ADC20", Offset = "0x19ACE20", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D7")]
	private static IntPtr GetStyleStatePtr_Injected(IntPtr _unity_self, int idx) { }

	[Address(RVA = "0x19ABC30", Offset = "0x19AAE30", Length = "0xAA")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcHeight", HasExplicitThis = True)]
	[Token(Token = "0x6000198")]
	private float Internal_CalcHeight(GUIContent content, float width) { }

	[Address(RVA = "0x19ADD00", Offset = "0x19ACF00", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001DE")]
	private static float Internal_CalcHeight_Injected(IntPtr _unity_self, GUIContent content, float width) { }

	[Address(RVA = "0x19ADDC0", Offset = "0x19ACFC0", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcMinMaxWidth", HasExplicitThis = True)]
	[Token(Token = "0x6000199")]
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	[Address(RVA = "0x19ADD60", Offset = "0x19ACF60", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001DF")]
	private static void Internal_CalcMinMaxWidth_Injected(IntPtr _unity_self, GUIContent content, out Vector2 ret) { }

	[Address(RVA = "0x19ADEE0", Offset = "0x19AD0E0", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSizeWithConstraints", HasExplicitThis = True)]
	[Token(Token = "0x6000197")]
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	[Address(RVA = "0x19ADE70", Offset = "0x19AD070", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001DD")]
	private static void Internal_CalcSizeWithConstraints_Injected(IntPtr _unity_self, GUIContent content, in Vector2 maxSize, out Vector2 ret) { }

	[Address(RVA = "0x19ADFA0", Offset = "0x19AD1A0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Create", IsThreadSafe = True)]
	[Token(Token = "0x600018F")]
	private static IntPtr Internal_Create(GUIStyle self) { }

	[Address(RVA = "0x19AE020", Offset = "0x19AD220", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Destroy", IsThreadSafe = True)]
	[Token(Token = "0x6000190")]
	private static void Internal_Destroy(IntPtr self) { }

	[Address(RVA = "0x19ADFE0", Offset = "0x19AD1E0", Length = "0x31")]
	[CalledBy(Type = typeof(IMGUITextHandle), Member = "ClearUnusedTextHandles", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_DestroyTextGenerator")]
	[Token(Token = "0x60001A0")]
	internal static void Internal_DestroyTextGenerator(int meshInfoId) { }

	[Address(RVA = "0x19AE540", Offset = "0x19AD740", Length = "0xE0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw", HasExplicitThis = True)]
	[Token(Token = "0x6000193")]
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[Address(RVA = "0x19AE4B0", Offset = "0x19AD6B0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D9")]
	private static void Internal_Draw_Injected(IntPtr _unity_self, in Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[Address(RVA = "0x19AE0D0", Offset = "0x19AD2D0", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw2", HasExplicitThis = True)]
	[Token(Token = "0x6000194")]
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	[Address(RVA = "0x19AE060", Offset = "0x19AD260", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001DA")]
	private static void Internal_Draw2_Injected(IntPtr _unity_self, in Rect position, GUIContent content, int controlID, bool on) { }

	[Address(RVA = "0x19AE210", Offset = "0x19AD410", Length = "0xBE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_DrawCursor", HasExplicitThis = True)]
	[Token(Token = "0x6000195")]
	private void Internal_DrawCursor(Rect position, GUIContent content, Vector2 pos, Color cursorColor) { }

	[Address(RVA = "0x19AE1A0", Offset = "0x19AD3A0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001DB")]
	private static void Internal_DrawCursor_Injected(IntPtr _unity_self, in Rect position, GUIContent content, in Vector2 pos, in Color cursorColor) { }

	[Address(RVA = "0x19AE380", Offset = "0x19AD580", Length = "0x12B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_DrawWithTextSelection", HasExplicitThis = True)]
	[Token(Token = "0x6000196")]
	private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, Vector2 cursorFirstPosition, Vector2 cursorLastPosition, Color cursorColor, Color selectionColor) { }

	[Address(RVA = "0x19AE2D0", Offset = "0x19AD4D0", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001DC")]
	private static void Internal_DrawWithTextSelection_Injected(IntPtr _unity_self, in Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, in Vector2 cursorFirstPosition, in Vector2 cursorLastPosition, in Color cursorColor, in Color selectionColor) { }

	[Address(RVA = "0x19AE630", Offset = "0x19AD830", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorFlashOffset")]
	[Token(Token = "0x600019D")]
	private static float Internal_GetCursorFlashOffset() { }

	[Address(RVA = "0x19AE6D0", Offset = "0x19AD8D0", Length = "0xBB")]
	[CalledBy(Type = typeof(TextEditor), Member = "GetLocalCursorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetTextRectOffset", HasExplicitThis = True)]
	[Token(Token = "0x600019A")]
	internal Vector2 Internal_GetTextRectOffset(Rect screenRect, GUIContent content, Vector2 textSize) { }

	[Address(RVA = "0x19AE660", Offset = "0x19AD860", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001E0")]
	private static void Internal_GetTextRectOffset_Injected(IntPtr _unity_self, in Rect screenRect, GUIContent content, in Vector2 textSize, out Vector2 ret) { }

	[Address(RVA = "0x19AE7D0", Offset = "0x19AD9D0", Length = "0x1A1")]
	[CalledBy(Type = typeof(GUI), Member = "DoLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "GUIStyle_Bindings::IsTooltipActive")]
	[Token(Token = "0x600019C")]
	internal static bool IsTooltipActive(string tooltip) { }

	[Address(RVA = "0x19AE790", Offset = "0x19AD990", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001E2")]
	private static bool IsTooltipActive_Injected(ref ManagedSpanWrapper tooltip) { }

	[Address(RVA = "0x19B0060", Offset = "0x19AF260", Length = "0xEB")]
	[CalledBy(Type = "Mirror.RemoteStatistics", Member = "GUI_Cpu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(double), typeof(double), typeof(double), typeof(double), typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkClient", Member = "OnGUI", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.GUIConsole", Member = "OnGUI", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkStatistics", Member = "OnGUI", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkStatistics", Member = "OnClientGUI", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkStatistics", Member = "OnServerGUI", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.RemoteStatistics", Member = "GUI_Authenticate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.RemoteStatistics", Member = "GUI_General", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(double), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.RemoteStatistics", Member = "GUI_Traffic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.RemoteStatistics", Member = "OnWindow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnGUIStatistics", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GUISkin), Member = "get_error", ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60001B3")]
	public static GUIStyle op_Implicit(string str) { }

	[Address(RVA = "0x19B0280", Offset = "0x19AF480", Length = "0x98")]
	[CalledBy(Type = "Mirror.NetworkPingDisplay", Member = "OnGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600017E")]
	public void set_alignment(TextAnchor value) { }

	[Address(RVA = "0x19B0240", Offset = "0x19AF440", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C6")]
	private static void set_alignment_Injected(IntPtr _unity_self, TextAnchor value) { }

	[Address(RVA = "0x19B0370", Offset = "0x19AF570", Length = "0x95")]
	[CalledBy(Type = typeof(TextEditor), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000182")]
	public void set_contentOffset(Vector2 value) { }

	[Address(RVA = "0x19B0320", Offset = "0x19AF520", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001CA")]
	private static void set_contentOffset_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x19B0450", Offset = "0x19AF650", Length = "0x98")]
	[CalledBy(Type = "LTRect", Member = "get_rect", ReturnType = typeof(Rect))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600018A")]
	public void set_fontSize(int value) { }

	[Address(RVA = "0x19B0410", Offset = "0x19AF610", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D2")]
	private static void set_fontSize_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x19B01A0", Offset = "0x19AF3A0", Length = "0x95")]
	[CalledBy(Type = typeof(TextEditor), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600018E")]
	internal void set_Internal_clipOffset(Vector2 value) { }

	[Address(RVA = "0x19B0150", Offset = "0x19AF350", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D6")]
	private static void set_Internal_clipOffset_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x19B04F0", Offset = "0x19AF6F0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GUIStyle), Member = "set_rawName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001A4")]
	public void set_name(string value) { }

	[Address(RVA = "0x19B0580", Offset = "0x19AF780", Length = "0x1CA")]
	[CalledBy(Type = typeof(GUISkin), Member = "get_error", ReturnType = typeof(GUIStyle))]
	[CalledBy(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIStyle), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600017A")]
	internal void set_rawName(string value) { }

	[Address(RVA = "0x19B0530", Offset = "0x19AF730", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C2")]
	private static void set_rawName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[Address(RVA = "0x19B07A0", Offset = "0x19AF9A0", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000188")]
	public void set_stretchHeight(bool value) { }

	[Address(RVA = "0x19B0750", Offset = "0x19AF950", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001D0")]
	private static void set_stretchHeight_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x19B0890", Offset = "0x19AFA90", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000186")]
	public void set_stretchWidth(bool value) { }

	[Address(RVA = "0x19B0840", Offset = "0x19AFA40", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001CE")]
	private static void set_stretchWidth_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x19AE9C0", Offset = "0x19ADBC0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "GUIStyle::SetDefaultFont")]
	[Token(Token = "0x600019E")]
	internal static void SetDefaultFont(Font font) { }

	[Address(RVA = "0x19AE980", Offset = "0x19ADB80", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001E3")]
	private static void SetDefaultFont_Injected(IntPtr font) { }

	[Address(RVA = "0x19AEAA0", Offset = "0x19ADCA0", Length = "0x19D")]
	[CalledBy(Type = typeof(GUI), Member = "DoLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "GUIStyle_Bindings::SetMouseTooltip")]
	[Token(Token = "0x600019B")]
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	[Address(RVA = "0x19AEA50", Offset = "0x19ADC50", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001E1")]
	private static void SetMouseTooltip_Injected(ref ManagedSpanWrapper tooltip, in Rect screenRect) { }

	[Address(RVA = "0x19AEC40", Offset = "0x19ADE40", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GUIStyle), Member = "get_rawName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x60001BB")]
	public virtual string ToString() { }

}

