namespace UnityEngine;

[AssetFileNameExtension("guiskin", new IL2CPP_TYPE_STRING[] {})]
[ExecuteInEditMode]
[RequiredByNativeCode]
[Token(Token = "0x2000016")]
public sealed class GUISkin : ScriptableObject
{
	[Token(Token = "0x2000017")]
	public sealed class SkinChangedDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2D8810", Offset = "0x2D7A10", Length = "0xA5")]
		[CallerCount(Count = 285)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000169")]
		public SkinChangedDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x2BC000", Offset = "0x2BB200", Length = "0x16A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288CC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600016A")]
		public override void Invoke() { }

	}

	[Token(Token = "0x400009D")]
	internal static GUIStyle ms_Error; //Field offset: 0x0
	[Token(Token = "0x400009F")]
	internal static SkinChangedDelegate m_SkinChanged; //Field offset: 0x8
	[Token(Token = "0x40000A0")]
	internal static GUISkin current; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000083")]
	private Font m_Font; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000084")]
	private GUIStyle m_box; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000085")]
	private GUIStyle m_button; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000086")]
	private GUIStyle m_toggle; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000087")]
	private GUIStyle m_label; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000088")]
	private GUIStyle m_textField; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000089")]
	private GUIStyle m_textArea; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400008A")]
	private GUIStyle m_window; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x400008B")]
	private GUIStyle m_horizontalSlider; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x400008C")]
	private GUIStyle m_horizontalSliderThumb; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400008D")]
	private GUIStyle m_horizontalSliderThumbExtent; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x400008E")]
	private GUIStyle m_verticalSlider; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x400008F")]
	private GUIStyle m_verticalSliderThumb; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000090")]
	private GUIStyle m_verticalSliderThumbExtent; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000091")]
	private GUIStyle m_SliderMixed; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x4000092")]
	private GUIStyle m_horizontalScrollbar; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x4000093")]
	private GUIStyle m_horizontalScrollbarThumb; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x4000094")]
	private GUIStyle m_horizontalScrollbarLeftButton; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x4000095")]
	private GUIStyle m_horizontalScrollbarRightButton; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[Token(Token = "0x4000096")]
	private GUIStyle m_verticalScrollbar; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[Token(Token = "0x4000097")]
	private GUIStyle m_verticalScrollbarThumb; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[Token(Token = "0x4000098")]
	private GUIStyle m_verticalScrollbarUpButton; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[Token(Token = "0x4000099")]
	private GUIStyle m_verticalScrollbarDownButton; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	[Token(Token = "0x400009A")]
	private GUIStyle m_ScrollView; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	[Token(Token = "0x400009B")]
	internal GUIStyle[] m_CustomStyles; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Token(Token = "0x400009C")]
	private GUISettings m_Settings; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400009E")]
	private Dictionary<String, GUIStyle> m_Styles; //Field offset: 0xE8

	[Token(Token = "0x1700003E")]
	public GUIStyle box
	{
		[Address(RVA = "0x19865C0", Offset = "0x19857C0", Length = "0x7")]
		[CallerCount(Count = 69)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000131")]
		 get { } //Length: 7
		[Address(RVA = "0x19AA920", Offset = "0x19A9B20", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x6000132")]
		 set { } //Length: 122
	}

	[Token(Token = "0x17000042")]
	public GUIStyle button
	{
		[Address(RVA = "0x1979DB0", Offset = "0x1978FB0", Length = "0x7")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000139")]
		 get { } //Length: 7
		[Address(RVA = "0x19AA9A0", Offset = "0x19A9BA0", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x600013A")]
		 set { } //Length: 122
	}

	[Token(Token = "0x17000055")]
	public GUIStyle[] customStyles
	{
		[Address(RVA = "0x19AA6C0", Offset = "0x19A98C0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600015F")]
		 get { } //Length: 10
		[Address(RVA = "0x19AAA20", Offset = "0x19A9C20", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x6000160")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000057")]
	internal static GUIStyle error
	{
		[Address(RVA = "0x19AA6D0", Offset = "0x19A98D0", Length = "0xFA")]
		[CalledBy(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUISkin), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIStyle))]
		[CalledBy(Type = typeof(GUIStyle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIStyle))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(GUIStyle), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(GUIStyle), Member = "set_rawName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000162")]
		internal get { } //Length: 250
	}

	[Token(Token = "0x1700003D")]
	public Font font
	{
		[Address(RVA = "0xB081E0", Offset = "0xB073E0", Length = "0x7")]
		[CallerCount(Count = 73)]
		[DeduplicatedMethod]
		[Token(Token = "0x600012F")]
		 get { } //Length: 7
		[Address(RVA = "0x19AAAA0", Offset = "0x19A9CA0", Length = "0x190")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000130")]
		 set { } //Length: 400
	}

	[Token(Token = "0x1700004C")]
	public GUIStyle horizontalScrollbar
	{
		[Address(RVA = "0x19AA800", Offset = "0x19A9A00", Length = "0xA")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x600014D")]
		 get { } //Length: 10
		[Address(RVA = "0x19AADB0", Offset = "0x19A9FB0", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x600014E")]
		 set { } //Length: 128
	}

	[Token(Token = "0x1700004E")]
	public GUIStyle horizontalScrollbarLeftButton
	{
		[Address(RVA = "0x19AA7D0", Offset = "0x19A99D0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000151")]
		 get { } //Length: 10
		[Address(RVA = "0x19AAC30", Offset = "0x19A9E30", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x6000152")]
		 set { } //Length: 128
	}

	[Token(Token = "0x1700004F")]
	public GUIStyle horizontalScrollbarRightButton
	{
		[Address(RVA = "0x19AA7E0", Offset = "0x19A99E0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000153")]
		 get { } //Length: 10
		[Address(RVA = "0x19AACB0", Offset = "0x19A9EB0", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x6000154")]
		 set { } //Length: 128
	}

	[Token(Token = "0x1700004D")]
	public GUIStyle horizontalScrollbarThumb
	{
		[Address(RVA = "0x19AA7F0", Offset = "0x19A99F0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600014F")]
		 get { } //Length: 10
		[Address(RVA = "0x19AAD30", Offset = "0x19A9F30", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x6000150")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000045")]
	public GUIStyle horizontalSlider
	{
		[Address(RVA = "0x19AA830", Offset = "0x19A9A30", Length = "0x7")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600013F")]
		 get { } //Length: 7
		[Address(RVA = "0x19AAF30", Offset = "0x19AA130", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x6000140")]
		 set { } //Length: 122
	}

	[Token(Token = "0x17000046")]
	public GUIStyle horizontalSliderThumb
	{
		[Address(RVA = "0x19AA820", Offset = "0x19A9A20", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000141")]
		 get { } //Length: 7
		[Address(RVA = "0x19AAEB0", Offset = "0x19AA0B0", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x6000142")]
		 set { } //Length: 122
	}

	[Token(Token = "0x17000047")]
	internal GUIStyle horizontalSliderThumbExtent
	{
		[Address(RVA = "0x19AA810", Offset = "0x19A9A10", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000143")]
		internal get { } //Length: 7
		[Address(RVA = "0x19AAE30", Offset = "0x19AA030", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x6000144")]
		internal set { } //Length: 122
	}

	[Token(Token = "0x1700003F")]
	public GUIStyle label
	{
		[Address(RVA = "0x19AA840", Offset = "0x19A9A40", Length = "0x7")]
		[CallerCount(Count = 36)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000133")]
		 get { } //Length: 7
		[Address(RVA = "0x19AAFB0", Offset = "0x19AA1B0", Length = "0x7A")]
		[CalledBy(Type = "LTGUI", Member = "update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x6000134")]
		 set { } //Length: 122
	}

	[Token(Token = "0x17000054")]
	public GUIStyle scrollView
	{
		[Address(RVA = "0x19AA850", Offset = "0x19A9A50", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600015D")]
		 get { } //Length: 10
		[Address(RVA = "0x19AB030", Offset = "0x19AA230", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x600015E")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000056")]
	public GUISettings settings
	{
		[Address(RVA = "0x19AA860", Offset = "0x19A9A60", Length = "0xA")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000161")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000048")]
	internal GUIStyle sliderMixed
	{
		[Address(RVA = "0x19AA870", Offset = "0x19A9A70", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000145")]
		internal get { } //Length: 10
		[Address(RVA = "0x19AB0B0", Offset = "0x19AA2B0", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x6000146")]
		internal set { } //Length: 128
	}

	[Token(Token = "0x17000041")]
	public GUIStyle textArea
	{
		[Address(RVA = "0x19AA880", Offset = "0x19A9A80", Length = "0x7")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000137")]
		 get { } //Length: 7
		[Address(RVA = "0x19AB130", Offset = "0x19AA330", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x6000138")]
		 set { } //Length: 122
	}

	[Token(Token = "0x17000040")]
	public GUIStyle textField
	{
		[Address(RVA = "0x19AA890", Offset = "0x19A9A90", Length = "0x7")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000135")]
		 get { } //Length: 7
		[Address(RVA = "0x19AB1B0", Offset = "0x19AA3B0", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x6000136")]
		 set { } //Length: 122
	}

	[Token(Token = "0x17000043")]
	public GUIStyle toggle
	{
		[Address(RVA = "0x19865B0", Offset = "0x19857B0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600013B")]
		 get { } //Length: 7
		[Address(RVA = "0x19AB230", Offset = "0x19AA430", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x600013C")]
		 set { } //Length: 122
	}

	[Token(Token = "0x17000050")]
	public GUIStyle verticalScrollbar
	{
		[Address(RVA = "0x19AA8D0", Offset = "0x19A9AD0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000155")]
		 get { } //Length: 10
		[Address(RVA = "0x19AB430", Offset = "0x19AA630", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x6000156")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000053")]
	public GUIStyle verticalScrollbarDownButton
	{
		[Address(RVA = "0x19AA8A0", Offset = "0x19A9AA0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600015B")]
		 get { } //Length: 10
		[Address(RVA = "0x19AB2B0", Offset = "0x19AA4B0", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x600015C")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000051")]
	public GUIStyle verticalScrollbarThumb
	{
		[Address(RVA = "0x19AA8B0", Offset = "0x19A9AB0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000157")]
		 get { } //Length: 10
		[Address(RVA = "0x19AB330", Offset = "0x19AA530", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x6000158")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000052")]
	public GUIStyle verticalScrollbarUpButton
	{
		[Address(RVA = "0x19AA8C0", Offset = "0x19A9AC0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000159")]
		 get { } //Length: 10
		[Address(RVA = "0x19AB3B0", Offset = "0x19AA5B0", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x600015A")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000049")]
	public GUIStyle verticalSlider
	{
		[Address(RVA = "0x19AA900", Offset = "0x19A9B00", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000147")]
		 get { } //Length: 7
		[Address(RVA = "0x19AB5B0", Offset = "0x19AA7B0", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x6000148")]
		 set { } //Length: 122
	}

	[Token(Token = "0x1700004A")]
	public GUIStyle verticalSliderThumb
	{
		[Address(RVA = "0x19AA8F0", Offset = "0x19A9AF0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000149")]
		 get { } //Length: 7
		[Address(RVA = "0x19AB530", Offset = "0x19AA730", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x600014A")]
		 set { } //Length: 122
	}

	[Token(Token = "0x1700004B")]
	internal GUIStyle verticalSliderThumbExtent
	{
		[Address(RVA = "0x19AA8E0", Offset = "0x19A9AE0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600014B")]
		internal get { } //Length: 10
		[Address(RVA = "0x19AB4B0", Offset = "0x19AA6B0", Length = "0x7D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x600014C")]
		internal set { } //Length: 125
	}

	[Token(Token = "0x17000044")]
	public GUIStyle window
	{
		[Address(RVA = "0x19AA910", Offset = "0x19A9B10", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600013D")]
		 get { } //Length: 7
		[Address(RVA = "0x19AB630", Offset = "0x19AA830", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[Token(Token = "0x600013E")]
		 set { } //Length: 122
	}

	[Address(RVA = "0x19AA5E0", Offset = "0x19A97E0", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600012C")]
	public GUISkin() { }

	[Address(RVA = "0x19A8CB0", Offset = "0x19A7EB0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000163")]
	internal void Apply() { }

	[Address(RVA = "0x19A8D20", Offset = "0x19A7F20", Length = "0x1338")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "get_error", ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUIStyle), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(GUIStyle), Member = "set_rawName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000164")]
	private void BuildStyleCache() { }

	[Address(RVA = "0x19AA060", Offset = "0x19A9260", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600012E")]
	internal static void CleanupRoots() { }

	[Address(RVA = "0x19AA0E0", Offset = "0x19A92E0", Length = "0x8E")]
	[CalledBy(Type = typeof(GUILayout), Member = "BeginScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(GUISkin), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIStyle))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000166")]
	public GUIStyle FindStyle(string styleName) { }

	[Address(RVA = "0x19865C0", Offset = "0x19857C0", Length = "0x7")]
	[CallerCount(Count = 69)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000131")]
	public GUIStyle get_box() { }

	[Address(RVA = "0x1979DB0", Offset = "0x1978FB0", Length = "0x7")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000139")]
	public GUIStyle get_button() { }

	[Address(RVA = "0x19AA6C0", Offset = "0x19A98C0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600015F")]
	public GUIStyle[] get_customStyles() { }

	[Address(RVA = "0x19AA6D0", Offset = "0x19A98D0", Length = "0xFA")]
	[CalledBy(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUISkin), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIStyle))]
	[CalledBy(Type = typeof(GUIStyle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIStyle))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GUIStyle), Member = "set_rawName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000162")]
	internal static GUIStyle get_error() { }

	[Address(RVA = "0xB081E0", Offset = "0xB073E0", Length = "0x7")]
	[CallerCount(Count = 73)]
	[DeduplicatedMethod]
	[Token(Token = "0x600012F")]
	public Font get_font() { }

	[Address(RVA = "0x19AA800", Offset = "0x19A9A00", Length = "0xA")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600014D")]
	public GUIStyle get_horizontalScrollbar() { }

	[Address(RVA = "0x19AA7D0", Offset = "0x19A99D0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000151")]
	public GUIStyle get_horizontalScrollbarLeftButton() { }

	[Address(RVA = "0x19AA7E0", Offset = "0x19A99E0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000153")]
	public GUIStyle get_horizontalScrollbarRightButton() { }

	[Address(RVA = "0x19AA7F0", Offset = "0x19A99F0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600014F")]
	public GUIStyle get_horizontalScrollbarThumb() { }

	[Address(RVA = "0x19AA830", Offset = "0x19A9A30", Length = "0x7")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600013F")]
	public GUIStyle get_horizontalSlider() { }

	[Address(RVA = "0x19AA820", Offset = "0x19A9A20", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000141")]
	public GUIStyle get_horizontalSliderThumb() { }

	[Address(RVA = "0x19AA810", Offset = "0x19A9A10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000143")]
	internal GUIStyle get_horizontalSliderThumbExtent() { }

	[Address(RVA = "0x19AA840", Offset = "0x19A9A40", Length = "0x7")]
	[CallerCount(Count = 36)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000133")]
	public GUIStyle get_label() { }

	[Address(RVA = "0x19AA850", Offset = "0x19A9A50", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600015D")]
	public GUIStyle get_scrollView() { }

	[Address(RVA = "0x19AA860", Offset = "0x19A9A60", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000161")]
	public GUISettings get_settings() { }

	[Address(RVA = "0x19AA870", Offset = "0x19A9A70", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000145")]
	internal GUIStyle get_sliderMixed() { }

	[Address(RVA = "0x19AA880", Offset = "0x19A9A80", Length = "0x7")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000137")]
	public GUIStyle get_textArea() { }

	[Address(RVA = "0x19AA890", Offset = "0x19A9A90", Length = "0x7")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000135")]
	public GUIStyle get_textField() { }

	[Address(RVA = "0x19865B0", Offset = "0x19857B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600013B")]
	public GUIStyle get_toggle() { }

	[Address(RVA = "0x19AA8D0", Offset = "0x19A9AD0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000155")]
	public GUIStyle get_verticalScrollbar() { }

	[Address(RVA = "0x19AA8A0", Offset = "0x19A9AA0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015B")]
	public GUIStyle get_verticalScrollbarDownButton() { }

	[Address(RVA = "0x19AA8B0", Offset = "0x19A9AB0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000157")]
	public GUIStyle get_verticalScrollbarThumb() { }

	[Address(RVA = "0x19AA8C0", Offset = "0x19A9AC0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000159")]
	public GUIStyle get_verticalScrollbarUpButton() { }

	[Address(RVA = "0x19AA900", Offset = "0x19A9B00", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000147")]
	public GUIStyle get_verticalSlider() { }

	[Address(RVA = "0x19AA8F0", Offset = "0x19A9AF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000149")]
	public GUIStyle get_verticalSliderThumb() { }

	[Address(RVA = "0x19AA8E0", Offset = "0x19A9AE0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600014B")]
	internal GUIStyle get_verticalSliderThumbExtent() { }

	[Address(RVA = "0x19AA910", Offset = "0x19A9B10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600013D")]
	public GUIStyle get_window() { }

	[Address(RVA = "0x19AA170", Offset = "0x19A9370", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000168")]
	public IEnumerator GetEnumerator() { }

	[Address(RVA = "0x19AA230", Offset = "0x19A9430", Length = "0x27B")]
	[CalledBy(Type = "Mirror.NetworkPingDisplay", Member = "OnGUI", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "HorizontalScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GUI), Member = "VerticalScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GUIStyle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIStyle))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(GUISkin), Member = "get_error", ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(GUISkin), Member = "FindStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000165")]
	public GUIStyle GetStyle(string styleName) { }

	[Address(RVA = "0x19AA4B0", Offset = "0x19A96B0", Length = "0x126")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000167")]
	internal void MakeCurrent() { }

	[Address(RVA = "0x19A8CB0", Offset = "0x19A7EB0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600012D")]
	internal void OnEnable() { }

	[Address(RVA = "0x19AA920", Offset = "0x19A9B20", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x6000132")]
	public void set_box(GUIStyle value) { }

	[Address(RVA = "0x19AA9A0", Offset = "0x19A9BA0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x600013A")]
	public void set_button(GUIStyle value) { }

	[Address(RVA = "0x19AAA20", Offset = "0x19A9C20", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x6000160")]
	public void set_customStyles(GUIStyle[] value) { }

	[Address(RVA = "0x19AAAA0", Offset = "0x19A9CA0", Length = "0x190")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000130")]
	public void set_font(Font value) { }

	[Address(RVA = "0x19AADB0", Offset = "0x19A9FB0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x600014E")]
	public void set_horizontalScrollbar(GUIStyle value) { }

	[Address(RVA = "0x19AAC30", Offset = "0x19A9E30", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x6000152")]
	public void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	[Address(RVA = "0x19AACB0", Offset = "0x19A9EB0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x6000154")]
	public void set_horizontalScrollbarRightButton(GUIStyle value) { }

	[Address(RVA = "0x19AAD30", Offset = "0x19A9F30", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x6000150")]
	public void set_horizontalScrollbarThumb(GUIStyle value) { }

	[Address(RVA = "0x19AAF30", Offset = "0x19AA130", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x6000140")]
	public void set_horizontalSlider(GUIStyle value) { }

	[Address(RVA = "0x19AAEB0", Offset = "0x19AA0B0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x6000142")]
	public void set_horizontalSliderThumb(GUIStyle value) { }

	[Address(RVA = "0x19AAE30", Offset = "0x19AA030", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x6000144")]
	internal void set_horizontalSliderThumbExtent(GUIStyle value) { }

	[Address(RVA = "0x19AAFB0", Offset = "0x19AA1B0", Length = "0x7A")]
	[CalledBy(Type = "LTGUI", Member = "update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x6000134")]
	public void set_label(GUIStyle value) { }

	[Address(RVA = "0x19AB030", Offset = "0x19AA230", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x600015E")]
	public void set_scrollView(GUIStyle value) { }

	[Address(RVA = "0x19AB0B0", Offset = "0x19AA2B0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x6000146")]
	internal void set_sliderMixed(GUIStyle value) { }

	[Address(RVA = "0x19AB130", Offset = "0x19AA330", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x6000138")]
	public void set_textArea(GUIStyle value) { }

	[Address(RVA = "0x19AB1B0", Offset = "0x19AA3B0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x6000136")]
	public void set_textField(GUIStyle value) { }

	[Address(RVA = "0x19AB230", Offset = "0x19AA430", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x600013C")]
	public void set_toggle(GUIStyle value) { }

	[Address(RVA = "0x19AB430", Offset = "0x19AA630", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x6000156")]
	public void set_verticalScrollbar(GUIStyle value) { }

	[Address(RVA = "0x19AB2B0", Offset = "0x19AA4B0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x600015C")]
	public void set_verticalScrollbarDownButton(GUIStyle value) { }

	[Address(RVA = "0x19AB330", Offset = "0x19AA530", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x6000158")]
	public void set_verticalScrollbarThumb(GUIStyle value) { }

	[Address(RVA = "0x19AB3B0", Offset = "0x19AA5B0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x600015A")]
	public void set_verticalScrollbarUpButton(GUIStyle value) { }

	[Address(RVA = "0x19AB5B0", Offset = "0x19AA7B0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x6000148")]
	public void set_verticalSlider(GUIStyle value) { }

	[Address(RVA = "0x19AB530", Offset = "0x19AA730", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x600014A")]
	public void set_verticalSliderThumb(GUIStyle value) { }

	[Address(RVA = "0x19AB4B0", Offset = "0x19AA6B0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x600014C")]
	internal void set_verticalSliderThumbExtent(GUIStyle value) { }

	[Address(RVA = "0x19AB630", Offset = "0x19AA830", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
	[Token(Token = "0x600013E")]
	public void set_window(GUIStyle value) { }

}

