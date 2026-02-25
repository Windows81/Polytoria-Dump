namespace Polytoria.Datamodel;

[Instantiatable]
[Token(Token = "0x2000371")]
public class UIView : UIField
{
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000F02")]
	private Image border; //Field offset: 0x198
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000F03")]
	private RectTransform borderRect; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000F04")]
	private Image fill; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1B0")]
	[SyncVar(hook = "SyncSetColor")]
	[Token(Token = "0x4000F05")]
	private Color color; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1C0")]
	[SyncVar(hook = "SyncSetBorderWidth")]
	[Token(Token = "0x4000F06")]
	private float borderWidth; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C4")]
	[SyncVar(hook = "SyncSetBorderColor")]
	[Token(Token = "0x4000F07")]
	private Color borderColor; //Field offset: 0x1C4
	[FieldOffset(Offset = "0x1D4")]
	[SyncVar(hook = "SyncSetCornerRadius")]
	[Token(Token = "0x4000F08")]
	private float cornerRadius; //Field offset: 0x1D4
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000F09")]
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_color; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000F0A")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_borderWidth; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000F0B")]
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_borderColor; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000F0C")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_cornerRadius; //Field offset: 0x1F0

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000B23")]
	public Color BorderColor
	{
		[Address(RVA = "0x49D9E0", Offset = "0x49CBE0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002530")]
		 get { } //Length: 14
		[Address(RVA = "0x49DA20", Offset = "0x49CC20", Length = "0xA2")]
		[CalledBy(Type = typeof(UIViewProxy), Member = "set_BorderColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002531")]
		 set { } //Length: 162
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000B25")]
	public float BorderWidth
	{
		[Address(RVA = "0x49D9F0", Offset = "0x49CBF0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002534")]
		 get { } //Length: 9
		[Address(RVA = "0x49DAD0", Offset = "0x49CCD0", Length = "0x8E")]
		[CalledBy(Type = typeof(UIView), Member = "SyncSetBorderWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIView), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIView), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIViewProxy), Member = "set_BorderWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(UIView), Member = "UpdateBorder", ReturnType = typeof(void))]
		[Token(Token = "0x6002535")]
		 set { } //Length: 142
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000B24")]
	public Color Color
	{
		[Address(RVA = "0x49DA00", Offset = "0x49CC00", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002532")]
		 get { } //Length: 14
		[Address(RVA = "0x49DB60", Offset = "0x49CD60", Length = "0xA2")]
		[CalledBy(Type = typeof(UIViewProxy), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002533")]
		 set { } //Length: 162
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000B26")]
	public float CornerRadius
	{
		[Address(RVA = "0x49DA10", Offset = "0x49CC10", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002536")]
		 get { } //Length: 9
		[Address(RVA = "0x49DC10", Offset = "0x49CE10", Length = "0xB0")]
		[CalledBy(Type = typeof(UIView), Member = "SyncSetCornerRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIView), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIView), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIViewProxy), Member = "set_CornerRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(UIView), Member = "UpdateBorder", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002537")]
		 set { } //Length: 176
	}

	[Token(Token = "0x17000B29")]
	public Color NetworkborderColor
	{
		[Address(RVA = "0x49D9E0", Offset = "0x49CBE0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002548")]
		 get { } //Length: 14
		[Address(RVA = "0x49DCD0", Offset = "0x49CED0", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Token(Token = "0x6002549")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000B28")]
	public float NetworkborderWidth
	{
		[Address(RVA = "0x49D9F0", Offset = "0x49CBF0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002546")]
		 get { } //Length: 9
		[Address(RVA = "0x49DD50", Offset = "0x49CF50", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x6002547")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000B27")]
	public Color Networkcolor
	{
		[Address(RVA = "0x49DA00", Offset = "0x49CC00", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002544")]
		 get { } //Length: 14
		[Address(RVA = "0x49DDC0", Offset = "0x49CFC0", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Token(Token = "0x6002545")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000B2A")]
	public float NetworkcornerRadius
	{
		[Address(RVA = "0x49DA10", Offset = "0x49CC10", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600254A")]
		 get { } //Length: 9
		[Address(RVA = "0x49DE40", Offset = "0x49D040", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x600254B")]
		 set { } //Length: 104
	}

	[Address(RVA = "0x49D850", Offset = "0x49CA50", Length = "0x189")]
	[CalledBy(Type = typeof(UILabel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIField), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6002542")]
	public UIView() { }

	[Address(RVA = "0x49CCD0", Offset = "0x49BED0", Length = "0x129")]
	[CalledBy(Type = typeof(UIButton), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIField), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600253D")]
	protected virtual void Awake() { }

	[Address(RVA = "0x49CE00", Offset = "0x49C000", Length = "0x1D6")]
	[CalledBy(Type = typeof(UIButton), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIField), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(UIView), Member = "set_BorderWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIView), Member = "set_CornerRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002541")]
	protected virtual void CopyProperties(Instance clone) { }

	[Address(RVA = "0x49CFE0", Offset = "0x49C1E0", Length = "0x245")]
	[CalledBy(Type = typeof(UILabel), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIField), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color&), typeof(System.Action`2<UnityEngine.Color, UnityEngine.Color>), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(System.Action`2<System.Single, System.Single>), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600254D")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x49D9E0", Offset = "0x49CBE0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002530")]
	public Color get_BorderColor() { }

	[Address(RVA = "0x49D9F0", Offset = "0x49CBF0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002534")]
	public float get_BorderWidth() { }

	[Address(RVA = "0x49DA00", Offset = "0x49CC00", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002532")]
	public Color get_Color() { }

	[Address(RVA = "0x49DA10", Offset = "0x49CC10", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002536")]
	public float get_CornerRadius() { }

	[Address(RVA = "0x49D9E0", Offset = "0x49CBE0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002548")]
	public Color get_NetworkborderColor() { }

	[Address(RVA = "0x49D9F0", Offset = "0x49CBF0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002546")]
	public float get_NetworkborderWidth() { }

	[Address(RVA = "0x49DA00", Offset = "0x49CC00", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002544")]
	public Color get_Networkcolor() { }

	[Address(RVA = "0x49DA10", Offset = "0x49CC10", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600254A")]
	public float get_NetworkcornerRadius() { }

	[Address(RVA = "0x49D230", Offset = "0x49C430", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "OnHide", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600253F")]
	protected virtual void OnHide() { }

	[Address(RVA = "0x49D2A0", Offset = "0x49C4A0", Length = "0x73")]
	[CalledBy(Type = typeof(UILabel), Member = "OnShow", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "OnShow", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIField), Member = "OnShow", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002540")]
	protected virtual void OnShow() { }

	[Address(RVA = "0x49D320", Offset = "0x49C520", Length = "0x111")]
	[CalledBy(Type = typeof(UILabel), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIField), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600254C")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x49DA20", Offset = "0x49CC20", Length = "0xA2")]
	[CalledBy(Type = typeof(UIViewProxy), Member = "set_BorderColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002531")]
	public void set_BorderColor(Color value) { }

	[Address(RVA = "0x49DAD0", Offset = "0x49CCD0", Length = "0x8E")]
	[CalledBy(Type = typeof(UIView), Member = "SyncSetBorderWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIView), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIView), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIViewProxy), Member = "set_BorderWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(UIView), Member = "UpdateBorder", ReturnType = typeof(void))]
	[Token(Token = "0x6002535")]
	public void set_BorderWidth(float value) { }

	[Address(RVA = "0x49DB60", Offset = "0x49CD60", Length = "0xA2")]
	[CalledBy(Type = typeof(UIViewProxy), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002533")]
	public void set_Color(Color value) { }

	[Address(RVA = "0x49DC10", Offset = "0x49CE10", Length = "0xB0")]
	[CalledBy(Type = typeof(UIView), Member = "SyncSetCornerRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIView), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIView), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIViewProxy), Member = "set_CornerRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(UIView), Member = "UpdateBorder", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002537")]
	public void set_CornerRadius(float value) { }

	[Address(RVA = "0x49DCD0", Offset = "0x49CED0", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Token(Token = "0x6002549")]
	public void set_NetworkborderColor(in Color value) { }

	[Address(RVA = "0x49DD50", Offset = "0x49CF50", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x6002547")]
	public void set_NetworkborderWidth(in float value) { }

	[Address(RVA = "0x49DDC0", Offset = "0x49CFC0", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Token(Token = "0x6002545")]
	public void set_Networkcolor(in Color value) { }

	[Address(RVA = "0x49DE40", Offset = "0x49D040", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x600254B")]
	public void set_NetworkcornerRadius(in float value) { }

	[Address(RVA = "0x49D440", Offset = "0x49C640", Length = "0x174")]
	[CalledBy(Type = typeof(UIButton), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIField), Member = "set_Visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(UIView), Member = "set_BorderWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIView), Member = "set_CornerRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600253E")]
	protected virtual void Start() { }

	[Address(RVA = "0x49D5C0", Offset = "0x49C7C0", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600253A")]
	private void SyncSetBorderColor(Color oldValue, Color newValue) { }

	[Address(RVA = "0x49D670", Offset = "0x49C870", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIView), Member = "set_BorderWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002539")]
	private void SyncSetBorderWidth(float oldValue, float newValue) { }

	[Address(RVA = "0x49D680", Offset = "0x49C880", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600253C")]
	private void SyncSetColor(Color oldValue, Color newValue) { }

	[Address(RVA = "0x49D730", Offset = "0x49C930", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIView), Member = "set_CornerRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x600253B")]
	private void SyncSetCornerRadius(float oldValue, float newValue) { }

	[Address(RVA = "0x49D740", Offset = "0x49C940", Length = "0x103")]
	[CalledBy(Type = typeof(UIView), Member = "set_BorderWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIView), Member = "set_CornerRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Image), Member = "set_pixelsPerUnitMultiplier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002538")]
	private void UpdateBorder() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002543")]
	public virtual bool Weaved() { }

}

