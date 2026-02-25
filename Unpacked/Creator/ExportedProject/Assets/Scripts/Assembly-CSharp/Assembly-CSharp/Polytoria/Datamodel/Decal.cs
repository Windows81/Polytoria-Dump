namespace Polytoria.Datamodel;

[Instantiatable]
[RequireComponent(typeof(MeshRenderer))]
[Token(Token = "0x2000315")]
public class Decal : DynamicInstance
{
	[FieldOffset(Offset = "0x210")]
	[SyncVar(hook = "SetImage")]
	[Token(Token = "0x4000BE8")]
	private string imageID; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[SyncVar(hook = "SetImageType")]
	[Token(Token = "0x4000BE9")]
	private ImageType imageType; //Field offset: 0x218
	[FieldOffset(Offset = "0x21C")]
	[SyncVar(hook = "SetTextureScale")]
	[Token(Token = "0x4000BEA")]
	private Vector2 textureScale; //Field offset: 0x21C
	[FieldOffset(Offset = "0x224")]
	[SyncVar(hook = "SetTextureOffset")]
	[Token(Token = "0x4000BEB")]
	private Vector2 textureOffset; //Field offset: 0x224
	[FieldOffset(Offset = "0x22C")]
	[SyncVar(hook = "SetColor")]
	[Token(Token = "0x4000BEC")]
	private Color color; //Field offset: 0x22C
	[FieldOffset(Offset = "0x23C")]
	[SyncVar(hook = "SetCastShadows")]
	[Token(Token = "0x4000BED")]
	private bool castShadows; //Field offset: 0x23C
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000BEE")]
	private ImageCacheKey lastCacheKey; //Field offset: 0x240
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4000BEF")]
	private BoxCollider col; //Field offset: 0x258
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4000BF0")]
	private MeshRenderer meshRenderer; //Field offset: 0x260
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4000BF1")]
	private ImageCacheEntry currentEntry; //Field offset: 0x268
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000BF2")]
	private Material transparentMaterial; //Field offset: 0x270
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4000BF3")]
	private Material cutoutMaterial; //Field offset: 0x278
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4000BF4")]
	public Action<String, String> _Mirror_SyncVarHookDelegate_imageID; //Field offset: 0x280
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4000BF5")]
	public Action<ImageType, ImageType> _Mirror_SyncVarHookDelegate_imageType; //Field offset: 0x288
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4000BF6")]
	public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_textureScale; //Field offset: 0x290
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4000BF7")]
	public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_textureOffset; //Field offset: 0x298
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x4000BF8")]
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_color; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x4000BF9")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_castShadows; //Field offset: 0x2A8

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x1700090C")]
	public bool CastShadows
	{
		[Address(RVA = "0x408960", Offset = "0x407B60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CB1")]
		 get { } //Length: 8
		[Address(RVA = "0x4089E0", Offset = "0x407BE0", Length = "0x82")]
		[CalledBy(Type = typeof(Decal), Member = "SetCastShadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Decal), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DecalProxy), Member = "set_CastShadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Calls(Type = typeof(Renderer), Member = "set_shadowCastingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowCastingMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CB2")]
		 set { } //Length: 130
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x1700090B")]
	public Color Color
	{
		[Address(RVA = "0x408970", Offset = "0x407B70", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CAF")]
		 get { } //Length: 14
		[Address(RVA = "0x408A70", Offset = "0x407C70", Length = "0x205")]
		[CalledBy(Type = typeof(Decal), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Decal), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Decal), Member = "<GetImage>b__41_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageCacheKey), typeof(ImageCacheEntry)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DecalProxy), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
		[Calls(Type = typeof(Material), Member = "set_mainTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "set_mainTextureScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "set_mainTextureOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 5)]
		[Token(Token = "0x6001CB0")]
		 set { } //Length: 517
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000907")]
	public string ImageID
	{
		[Address(RVA = "0x408980", Offset = "0x407B80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CA7")]
		 get { } //Length: 8
		[Address(RVA = "0x408C80", Offset = "0x407E80", Length = "0x70")]
		[CalledBy(Type = typeof(Decal), Member = "SetImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Decal), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DecalProxy), Member = "set_ImageID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
		[Calls(Type = typeof(Decal), Member = "GetImage", ReturnType = typeof(void))]
		[Token(Token = "0x6001CA8")]
		 set { } //Length: 112
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000908")]
	public ImageType ImageType
	{
		[Address(RVA = "0x408990", Offset = "0x407B90", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CA9")]
		 get { } //Length: 7
		[Address(RVA = "0x408CF0", Offset = "0x407EF0", Length = "0x145")]
		[CalledBy(Type = typeof(Decal), Member = "SetImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType), typeof(ImageType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Decal), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DecalProxy), Member = "set_ImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Int32Enum&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(NetworkServer), Member = "get_activeHost", ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "GetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Decal), Member = "GetImage", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001CAA")]
		 set { } //Length: 325
	}

	[Token(Token = "0x17000912")]
	public bool NetworkcastShadows
	{
		[Address(RVA = "0x408960", Offset = "0x407B60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CCD")]
		 get { } //Length: 8
		[Address(RVA = "0x408E40", Offset = "0x408040", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x6001CCE")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000911")]
	public Color Networkcolor
	{
		[Address(RVA = "0x408970", Offset = "0x407B70", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CCB")]
		 get { } //Length: 14
		[Address(RVA = "0x408EB0", Offset = "0x4080B0", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Token(Token = "0x6001CCC")]
		 set { } //Length: 113
	}

	[Token(Token = "0x1700090D")]
	public string NetworkimageID
	{
		[Address(RVA = "0x408980", Offset = "0x407B80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CC3")]
		 get { } //Length: 8
		[Address(RVA = "0x408F30", Offset = "0x408130", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
		[Token(Token = "0x6001CC4")]
		 set { } //Length: 103
	}

	[Token(Token = "0x1700090E")]
	public ImageType NetworkimageType
	{
		[Address(RVA = "0x408990", Offset = "0x407B90", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CC5")]
		 get { } //Length: 7
		[Address(RVA = "0x408FA0", Offset = "0x4081A0", Length = "0x13C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Int32Enum&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(NetworkServer), Member = "get_activeHost", ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "GetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001CC6")]
		 set { } //Length: 316
	}

	[Token(Token = "0x17000910")]
	public Vector2 NetworktextureOffset
	{
		[Address(RVA = "0x4089A0", Offset = "0x407BA0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CC9")]
		 get { } //Length: 25
		[Address(RVA = "0x4090E0", Offset = "0x4082E0", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
		[Token(Token = "0x6001CCA")]
		 set { } //Length: 108
	}

	[Token(Token = "0x1700090F")]
	public Vector2 NetworktextureScale
	{
		[Address(RVA = "0x4089C0", Offset = "0x407BC0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CC7")]
		 get { } //Length: 25
		[Address(RVA = "0x409150", Offset = "0x408350", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
		[Token(Token = "0x6001CC8")]
		 set { } //Length: 108
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x1700090A")]
	public Vector2 TextureOffset
	{
		[Address(RVA = "0x4089A0", Offset = "0x407BA0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CAD")]
		 get { } //Length: 25
		[Address(RVA = "0x4091C0", Offset = "0x4083C0", Length = "0x98")]
		[CalledBy(Type = typeof(Decal), Member = "SetTextureOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Decal), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DecalProxy), Member = "set_TextureOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
		[Calls(Type = typeof(Material), Member = "set_mainTextureOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001CAE")]
		 set { } //Length: 152
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000909")]
	public Vector2 TextureScale
	{
		[Address(RVA = "0x4089C0", Offset = "0x407BC0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CAB")]
		 get { } //Length: 25
		[Address(RVA = "0x409260", Offset = "0x408460", Length = "0x98")]
		[CalledBy(Type = typeof(Decal), Member = "SetTextureScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Decal), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DecalProxy), Member = "set_TextureScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
		[Calls(Type = typeof(Material), Member = "set_mainTextureScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001CAC")]
		 set { } //Length: 152
	}

	[Address(RVA = "0x408660", Offset = "0x407860", Length = "0x300")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynamicInstance), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001CC0")]
	public Decal() { }

	[Address(RVA = "0x408590", Offset = "0x407790", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ImageCacheKey), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Decal), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	[Token(Token = "0x6001CC1")]
	private void <GetImage>b__41_0(ImageCacheKey key, ImageCacheEntry entry) { }

	[Address(RVA = "0x407790", Offset = "0x406990", Length = "0x100")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DynamicInstance), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Token(Token = "0x6001CBB")]
	protected virtual void Awake() { }

	[Address(RVA = "0x407890", Offset = "0x406A90", Length = "0x26B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Decal), Member = "set_ImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decal), Member = "set_ImageID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decal), Member = "set_CastShadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decal), Member = "set_TextureOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decal), Member = "set_TextureScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decal), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Instance), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001CBF")]
	protected virtual void CopyProperties(Instance clone) { }

	[Address(RVA = "0x407B00", Offset = "0x406D00", Length = "0x334")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DynamicInstance), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(System.Action`2<System.Object, System.Object>), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), typeof(System.Action`2<System.Int32Enum, System.Int32Enum>), "System.Int32Enum"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2&), typeof(System.Action`2<UnityEngine.Vector2, UnityEngine.Vector2>), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color&), typeof(System.Action`2<UnityEngine.Color, UnityEngine.Color>), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Action`2<T, T>", "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001CD0")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x408960", Offset = "0x407B60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CB1")]
	public bool get_CastShadows() { }

	[Address(RVA = "0x408970", Offset = "0x407B70", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CAF")]
	public Color get_Color() { }

	[Address(RVA = "0x408980", Offset = "0x407B80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CA7")]
	public string get_ImageID() { }

	[Address(RVA = "0x408990", Offset = "0x407B90", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CA9")]
	public ImageType get_ImageType() { }

	[Address(RVA = "0x408960", Offset = "0x407B60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CCD")]
	public bool get_NetworkcastShadows() { }

	[Address(RVA = "0x408970", Offset = "0x407B70", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CCB")]
	public Color get_Networkcolor() { }

	[Address(RVA = "0x408980", Offset = "0x407B80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CC3")]
	public string get_NetworkimageID() { }

	[Address(RVA = "0x408990", Offset = "0x407B90", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CC5")]
	public ImageType get_NetworkimageType() { }

	[Address(RVA = "0x4089A0", Offset = "0x407BA0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CC9")]
	public Vector2 get_NetworktextureOffset() { }

	[Address(RVA = "0x4089C0", Offset = "0x407BC0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CC7")]
	public Vector2 get_NetworktextureScale() { }

	[Address(RVA = "0x4089A0", Offset = "0x407BA0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CAD")]
	public Vector2 get_TextureOffset() { }

	[Address(RVA = "0x4089C0", Offset = "0x407BC0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CAB")]
	public Vector2 get_TextureScale() { }

	[Address(RVA = "0x407E40", Offset = "0x407040", Length = "0x175")]
	[CalledBy(Type = typeof(Decal), Member = "set_ImageID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Decal), Member = "set_ImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Action`2<Polytoria.Controllers.ImageCacheKey, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ImageCacheController), Member = "GetImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageCacheKey), typeof(System.Action`2<Polytoria.Controllers.ImageCacheKey, Polytoria.Controllers.ImageCacheEntry>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CBE")]
	private void GetImage() { }

	[Address(RVA = "0x407FC0", Offset = "0x4071C0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "OnHide", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CB6")]
	protected virtual void OnHide() { }

	[Address(RVA = "0x408020", Offset = "0x407220", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "OnShow", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CB7")]
	protected virtual void OnShow() { }

	[Address(RVA = "0x408080", Offset = "0x407280", Length = "0x306")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Color)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001CCF")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x4089E0", Offset = "0x407BE0", Length = "0x82")]
	[CalledBy(Type = typeof(Decal), Member = "SetCastShadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Decal), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalProxy), Member = "set_CastShadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Calls(Type = typeof(Renderer), Member = "set_shadowCastingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShadowCastingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001CB2")]
	public void set_CastShadows(bool value) { }

	[Address(RVA = "0x408A70", Offset = "0x407C70", Length = "0x205")]
	[CalledBy(Type = typeof(Decal), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Decal), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Decal), Member = "<GetImage>b__41_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageCacheKey), typeof(ImageCacheEntry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalProxy), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Material), Member = "set_mainTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "set_mainTextureScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "set_mainTextureOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6001CB0")]
	public void set_Color(Color value) { }

	[Address(RVA = "0x408C80", Offset = "0x407E80", Length = "0x70")]
	[CalledBy(Type = typeof(Decal), Member = "SetImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Decal), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalProxy), Member = "set_ImageID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
	[Calls(Type = typeof(Decal), Member = "GetImage", ReturnType = typeof(void))]
	[Token(Token = "0x6001CA8")]
	public void set_ImageID(string value) { }

	[Address(RVA = "0x408CF0", Offset = "0x407EF0", Length = "0x145")]
	[CalledBy(Type = typeof(Decal), Member = "SetImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType), typeof(ImageType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Decal), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalProxy), Member = "set_ImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Int32Enum&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "get_activeHost", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decal), Member = "GetImage", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001CAA")]
	public void set_ImageType(ImageType value) { }

	[Address(RVA = "0x408E40", Offset = "0x408040", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x6001CCE")]
	public void set_NetworkcastShadows(in bool value) { }

	[Address(RVA = "0x408EB0", Offset = "0x4080B0", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Token(Token = "0x6001CCC")]
	public void set_Networkcolor(in Color value) { }

	[Address(RVA = "0x408F30", Offset = "0x408130", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
	[Token(Token = "0x6001CC4")]
	public void set_NetworkimageID(in string value) { }

	[Address(RVA = "0x408FA0", Offset = "0x4081A0", Length = "0x13C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Int32Enum&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "get_activeHost", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001CC6")]
	public void set_NetworkimageType(in ImageType value) { }

	[Address(RVA = "0x4090E0", Offset = "0x4082E0", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
	[Token(Token = "0x6001CCA")]
	public void set_NetworktextureOffset(in Vector2 value) { }

	[Address(RVA = "0x409150", Offset = "0x408350", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
	[Token(Token = "0x6001CC8")]
	public void set_NetworktextureScale(in Vector2 value) { }

	[Address(RVA = "0x4091C0", Offset = "0x4083C0", Length = "0x98")]
	[CalledBy(Type = typeof(Decal), Member = "SetTextureOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Decal), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalProxy), Member = "set_TextureOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
	[Calls(Type = typeof(Material), Member = "set_mainTextureOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001CAE")]
	public void set_TextureOffset(Vector2 value) { }

	[Address(RVA = "0x409260", Offset = "0x408460", Length = "0x98")]
	[CalledBy(Type = typeof(Decal), Member = "SetTextureScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Decal), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DecalProxy), Member = "set_TextureScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
	[Calls(Type = typeof(Material), Member = "set_mainTextureScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001CAC")]
	public void set_TextureScale(Vector2 value) { }

	[Address(RVA = "0x408390", Offset = "0x407590", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decal), Member = "set_CastShadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001CB5")]
	private void SetCastShadows(bool oldShadows, bool newShadows) { }

	[Address(RVA = "0x4083D0", Offset = "0x4075D0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decal), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001CBA")]
	private void SetColor(Color oldColor, Color newColor) { }

	[Address(RVA = "0x408450", Offset = "0x407650", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decal), Member = "set_ImageID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001CB8")]
	private void SetImage(string oldId, string newId) { }

	[Address(RVA = "0x408410", Offset = "0x407610", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decal), Member = "set_ImageType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageType)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001CB9")]
	private void SetImageType(ImageType oldType, ImageType newType) { }

	[Address(RVA = "0x408490", Offset = "0x407690", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decal), Member = "set_TextureOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001CB4")]
	private void SetTextureOffset(Vector2 oldOffset, Vector2 newOffset) { }

	[Address(RVA = "0x4084D0", Offset = "0x4076D0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decal), Member = "set_TextureScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001CB3")]
	private void SetTextureScale(Vector2 oldScale, Vector2 newScale) { }

	[Address(RVA = "0x408510", Offset = "0x407710", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Collider), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001CBC")]
	protected virtual void Start() { }

	[Address(RVA = "0x408650", Offset = "0x407850", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "Update", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CBD")]
	protected virtual void Update() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CC2")]
	public virtual bool Weaved() { }

}

