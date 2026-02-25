namespace Polytoria.Datamodel;

[Instantiatable]
[Token(Token = "0x200036A")]
public class UIImage : UIField
{
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000EAD")]
	private Image image; //Field offset: 0x198
	[FieldOffset(Offset = "0x1A0")]
	[SyncVar(hook = "SyncSetColor")]
	[Token(Token = "0x4000EAE")]
	private Color color; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1B0")]
	[SyncVar(hook = "SetImage")]
	[Token(Token = "0x4000EAF")]
	private string imageID; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[SyncVar(hook = "SetImageType")]
	[Token(Token = "0x4000EB0")]
	private ImageType imageType; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1BC")]
	[SyncVar(hook = "SyncSetClickable")]
	[Token(Token = "0x4000EB1")]
	private bool clickable; //Field offset: 0x1BC
	[FieldOffset(Offset = "0x1BD")]
	[Token(Token = "0x4000EB2")]
	private bool loading; //Field offset: 0x1BD
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000EB3")]
	private Texture2D texture; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000EB4")]
	private ImageCacheKey lastCacheKey; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000EB5")]
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_color; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000EB6")]
	public Action<String, String> _Mirror_SyncVarHookDelegate_imageID; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000EB7")]
	public Action<ImageType, ImageType> _Mirror_SyncVarHookDelegate_imageType; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000EB8")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_clickable; //Field offset: 0x1F8

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AF1")]
	public bool Clickable
	{
		[Address(RVA = "0x497970", Offset = "0x496B70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600248C")]
		 get { } //Length: 8
		[Address(RVA = "0x4979B0", Offset = "0x496BB0", Length = "0x93")]
		[CalledBy(Type = typeof(UIImage), Member = "SyncSetClickable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIImage), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIImageProxy), Member = "set_Clickable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600248D")]
		 set { } //Length: 147
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AED")]
	public Color Color
	{
		[Address(RVA = "0x497980", Offset = "0x496B80", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002485")]
		 get { } //Length: 14
		[Address(RVA = "0x497A50", Offset = "0x496C50", Length = "0xA6")]
		[CalledBy(Type = typeof(UIImageProxy), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002486")]
		 set { } //Length: 166
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AEF")]
	public string ImageID
	{
		[Address(RVA = "0x497990", Offset = "0x496B90", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002488")]
		 get { } //Length: 8
		[Address(RVA = "0x497B00", Offset = "0x496D00", Length = "0x70")]
		[CalledBy(Type = typeof(UIImage), Member = "SetImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIImage), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIImageProxy), Member = "set_ImageID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
		[Calls(Type = typeof(UIImage), Member = "GetImage", ReturnType = typeof(void))]
		[Token(Token = "0x6002489")]
		 set { } //Length: 112
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AF0")]
	public ImageType ImageType
	{
		[Address(RVA = "0x495D20", Offset = "0x494F20", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600248A")]
		 get { } //Length: 7
		[Address(RVA = "0x497B70", Offset = "0x496D70", Length = "0x6E")]
		[CalledBy(Type = typeof(UIImage), Member = "SetImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType), typeof(ImageType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIImageProxy), Member = "set_ImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[Calls(Type = typeof(UIImage), Member = "GetImage", ReturnType = typeof(void))]
		[Token(Token = "0x600248B")]
		 set { } //Length: 110
	}

	[Token(Token = "0x17000AEE")]
	public bool Loading
	{
		[Address(RVA = "0x4979A0", Offset = "0x496BA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002487")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000AF5")]
	public bool Networkclickable
	{
		[Address(RVA = "0x497970", Offset = "0x496B70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024A2")]
		 get { } //Length: 8
		[Address(RVA = "0x497BE0", Offset = "0x496DE0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x60024A3")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000AF2")]
	public Color Networkcolor
	{
		[Address(RVA = "0x497980", Offset = "0x496B80", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600249C")]
		 get { } //Length: 14
		[Address(RVA = "0x497C50", Offset = "0x496E50", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Token(Token = "0x600249D")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000AF3")]
	public string NetworkimageID
	{
		[Address(RVA = "0x497990", Offset = "0x496B90", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600249E")]
		 get { } //Length: 8
		[Address(RVA = "0x497CD0", Offset = "0x496ED0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
		[Token(Token = "0x600249F")]
		 set { } //Length: 103
	}

	[Token(Token = "0x17000AF4")]
	public ImageType NetworkimageType
	{
		[Address(RVA = "0x495D20", Offset = "0x494F20", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024A0")]
		 get { } //Length: 7
		[Address(RVA = "0x497D40", Offset = "0x496F40", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[Token(Token = "0x60024A1")]
		 set { } //Length: 101
	}

	[Address(RVA = "0x4977B0", Offset = "0x4969B0", Length = "0x1BC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIField), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002499")]
	public UIImage() { }

	[Address(RVA = "0x497610", Offset = "0x496810", Length = "0x198")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ImageCacheKey), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2)}, ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[Token(Token = "0x600249A")]
	private void <GetImage>b__29_0(ImageCacheKey key, ImageCacheEntry entry) { }

	[Address(RVA = "0x496BC0", Offset = "0x495DC0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIField), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002492")]
	protected virtual void Awake() { }

	[Address(RVA = "0x496C60", Offset = "0x495E60", Length = "0x1A9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIField), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(UIImage), Member = "set_ImageID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Calls(Type = typeof(UIImage), Member = "GetImage", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIImage), Member = "set_Clickable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002498")]
	protected virtual void CopyProperties(Instance clone) { }

	[Address(RVA = "0x496E10", Offset = "0x496010", Length = "0x23E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIField), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color&), typeof(System.Action`2<UnityEngine.Color, UnityEngine.Color>), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(System.Action`2<System.Object, System.Object>), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), typeof(System.Action`2<System.Int32Enum, System.Int32Enum>), "System.Int32Enum"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Action`2<T, T>", "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60024A5")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x497970", Offset = "0x496B70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600248C")]
	public bool get_Clickable() { }

	[Address(RVA = "0x497980", Offset = "0x496B80", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002485")]
	public Color get_Color() { }

	[Address(RVA = "0x497990", Offset = "0x496B90", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002488")]
	public string get_ImageID() { }

	[Address(RVA = "0x495D20", Offset = "0x494F20", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600248A")]
	public ImageType get_ImageType() { }

	[Address(RVA = "0x4979A0", Offset = "0x496BA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002487")]
	public bool get_Loading() { }

	[Address(RVA = "0x497970", Offset = "0x496B70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024A2")]
	public bool get_Networkclickable() { }

	[Address(RVA = "0x497980", Offset = "0x496B80", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600249C")]
	public Color get_Networkcolor() { }

	[Address(RVA = "0x497990", Offset = "0x496B90", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600249E")]
	public string get_NetworkimageID() { }

	[Address(RVA = "0x495D20", Offset = "0x494F20", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024A0")]
	public ImageType get_NetworkimageType() { }

	[Address(RVA = "0x497050", Offset = "0x496250", Length = "0x240")]
	[CalledBy(Type = typeof(UIImage), Member = "set_ImageID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIImage), Member = "set_ImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIImage), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Action`2<Polytoria.Controllers.ImageCacheKey, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ImageCacheController), Member = "GetImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageCacheKey), typeof(System.Action`2<Polytoria.Controllers.ImageCacheKey, Polytoria.Controllers.ImageCacheEntry>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002495")]
	private void GetImage() { }

	[Address(RVA = "0x4972A0", Offset = "0x4964A0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002494")]
	private void LoadFallback() { }

	[Address(RVA = "0x497310", Offset = "0x496510", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "OnHide", ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002496")]
	protected virtual void OnHide() { }

	[Address(RVA = "0x497350", Offset = "0x496550", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIField), Member = "OnShow", ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002497")]
	protected virtual void OnShow() { }

	[Address(RVA = "0x497390", Offset = "0x496590", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIField), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60024A4")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x4979B0", Offset = "0x496BB0", Length = "0x93")]
	[CalledBy(Type = typeof(UIImage), Member = "SyncSetClickable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIImage), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIImageProxy), Member = "set_Clickable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600248D")]
	public void set_Clickable(bool value) { }

	[Address(RVA = "0x497A50", Offset = "0x496C50", Length = "0xA6")]
	[CalledBy(Type = typeof(UIImageProxy), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002486")]
	public void set_Color(Color value) { }

	[Address(RVA = "0x497B00", Offset = "0x496D00", Length = "0x70")]
	[CalledBy(Type = typeof(UIImage), Member = "SetImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIImage), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIImageProxy), Member = "set_ImageID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
	[Calls(Type = typeof(UIImage), Member = "GetImage", ReturnType = typeof(void))]
	[Token(Token = "0x6002489")]
	public void set_ImageID(string value) { }

	[Address(RVA = "0x497B70", Offset = "0x496D70", Length = "0x6E")]
	[CalledBy(Type = typeof(UIImage), Member = "SetImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType), typeof(ImageType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIImageProxy), Member = "set_ImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Calls(Type = typeof(UIImage), Member = "GetImage", ReturnType = typeof(void))]
	[Token(Token = "0x600248B")]
	public void set_ImageType(ImageType value) { }

	[Address(RVA = "0x497BE0", Offset = "0x496DE0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x60024A3")]
	public void set_Networkclickable(in bool value) { }

	[Address(RVA = "0x497C50", Offset = "0x496E50", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Token(Token = "0x600249D")]
	public void set_Networkcolor(in Color value) { }

	[Address(RVA = "0x497CD0", Offset = "0x496ED0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
	[Token(Token = "0x600249F")]
	public void set_NetworkimageID(in string value) { }

	[Address(RVA = "0x497D40", Offset = "0x496F40", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Token(Token = "0x60024A1")]
	public void set_NetworkimageType(in ImageType value) { }

	[Address(RVA = "0x4974D0", Offset = "0x4966D0", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIImage), Member = "set_ImageID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600248F")]
	private void SetImage(string oldValue, string newValue) { }

	[Address(RVA = "0x497490", Offset = "0x496690", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIImage), Member = "set_ImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002490")]
	private void SetImageType(ImageType oldValue, ImageType newValue) { }

	[Address(RVA = "0x493BF0", Offset = "0x492DF0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIField), Member = "set_Visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002493")]
	protected virtual void Start() { }

	[Address(RVA = "0x497510", Offset = "0x496710", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIImage), Member = "set_Clickable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002491")]
	private void SyncSetClickable(bool oldValue, bool newValue) { }

	[Address(RVA = "0x497550", Offset = "0x496750", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600248E")]
	private void SyncSetColor(Color oldValue, Color newValue) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600249B")]
	public virtual bool Weaved() { }

}

