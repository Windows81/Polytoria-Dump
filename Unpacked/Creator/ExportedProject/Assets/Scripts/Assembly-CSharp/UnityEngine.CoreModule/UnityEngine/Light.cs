namespace UnityEngine;

[NativeHeader("Runtime/Camera/Light.h")]
[NativeHeader("Runtime/Export/Graphics/Light.bindings.h")]
[RequireComponent(typeof(Transform))]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x20000BB")]
public sealed class Light : Behaviour
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400020F")]
	private LightShape <shape>k__BackingField; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000210")]
	private int m_BakedIndex; //Field offset: 0x1C

	[Token(Token = "0x170000D4")]
	public LightBakingOutput bakingOutput
	{
		[Address(RVA = "0x192CF00", Offset = "0x192C100", Length = "0x93")]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600049B")]
		 get { } //Length: 147
	}

	[Token(Token = "0x170000D1")]
	public float bounceIntensity
	{
		[Address(RVA = "0x192CFE0", Offset = "0x192C1E0", Length = "0x76")]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(LinearColor))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000497")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170000CD")]
	public Color color
	{
		[Address(RVA = "0x192D170", Offset = "0x192C370", Length = "0x8E")]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(LinearColor))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "get_Color", ReturnType = typeof(Color))]
		[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "get_Color", ReturnType = typeof(Color))]
		[CalledBy(Type = "RLD.RTScene", Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000490")]
		 get { } //Length: 142
		[Address(RVA = "0x192D930", Offset = "0x192CB30", Length = "0x85")]
		[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.SunLight", Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.SunLight", Member = "OnColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.LightPunctualExtension", Member = "ToUnityLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Schema.LightPunctual", typeof(Light), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000491")]
		 set { } //Length: 133
	}

	[Token(Token = "0x170000CE")]
	public float colorTemperature
	{
		[Address(RVA = "0x192D0A0", Offset = "0x192C2A0", Length = "0x76")]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractColorTemperature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(Color))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000492")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170000D7")]
	public Texture cookie
	{
		[Address(RVA = "0x192D300", Offset = "0x192C500", Length = "0x90")]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(Cookie&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600049F")]
		 get { } //Length: 144
	}

	[Token(Token = "0x170000D6")]
	public float cookieSize
	{
		[Address(RVA = "0x192D240", Offset = "0x192C440", Length = "0x76")]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(Cookie&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600049E")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170000D3")]
	public float dilatedRange
	{
		[Address(RVA = "0x192D3E0", Offset = "0x192C5E0", Length = "0x76")]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600049A")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170000CC")]
	public float innerSpotAngle
	{
		[Address(RVA = "0x192DA10", Offset = "0x192CC10", Length = "0x86")]
		[CalledBy(Type = "GLTFast.LightPunctualExtension", Member = "ToUnityLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Schema.LightPunctual", typeof(Light), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600048F")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170000D0")]
	public float intensity
	{
		[Address(RVA = "0x192D4A0", Offset = "0x192C6A0", Length = "0x76")]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "get_Brightness", ReturnType = typeof(float))]
		[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "get_Brightness", ReturnType = typeof(float))]
		[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(LinearColor))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000495")]
		 get { } //Length: 118
		[Address(RVA = "0x192DAF0", Offset = "0x192CCF0", Length = "0x86")]
		[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "BeginGenSession", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.PrefabPreviewLookAndFeel"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "CreatePreviewLight", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "set_Brightness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "set_Brightness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.SunLight", Member = "set_Brightness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.SunLight", Member = "OnBrightnessChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.LightPunctualExtension", Member = "ToUnityLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Schema.LightPunctual", typeof(Light), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.LightPunctualExtension", Member = "LightAssignIntensity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), "GLTFast.Schema.LightPunctual", typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000496")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170000D2")]
	public float range
	{
		[Address(RVA = "0x192D560", Offset = "0x192C760", Length = "0x76")]
		[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "get_Range", ReturnType = typeof(float))]
		[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "get_Range", ReturnType = typeof(float))]
		[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000498")]
		 get { } //Length: 118
		[Address(RVA = "0x192DBD0", Offset = "0x192CDD0", Length = "0x86")]
		[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "set_Range", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "set_Range", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.LightPunctualExtension", Member = "ToUnityLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Schema.LightPunctual", typeof(Light), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000499")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170000D5")]
	public LightShadows shadows
	{
		[Address(RVA = "0x192D620", Offset = "0x192C820", Length = "0x76")]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "get_Shadows", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "get_Shadows", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod("GetShadowType")]
		[Token(Token = "0x600049C")]
		 get { } //Length: 118
		[Address(RVA = "0x192DCA0", Offset = "0x192CEA0", Length = "0x83")]
		[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "set_Shadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "set_Shadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.SunLight", Member = "set_Shadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.SunLight", Member = "OnShadowsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("Light_Bindings::SetShadowType", HasExplicitThis = True, ThrowsException = True)]
		[Token(Token = "0x600049D")]
		 set { } //Length: 131
	}

	[Token(Token = "0x170000CB")]
	public float spotAngle
	{
		[Address(RVA = "0x192D6E0", Offset = "0x192C8E0", Length = "0x76")]
		[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "get_Angle", ReturnType = typeof(float))]
		[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractInnerCone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600048D")]
		 get { } //Length: 118
		[Address(RVA = "0x192DD80", Offset = "0x192CF80", Length = "0x86")]
		[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "set_Angle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.LightPunctualExtension", Member = "ToUnityLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Schema.LightPunctual", typeof(Light), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600048E")]
		 set { } //Length: 134
	}

	[NativeProperty("LightType")]
	[Token(Token = "0x170000CA")]
	public LightType type
	{
		[Address(RVA = "0x192D7A0", Offset = "0x192C9A0", Length = "0x76")]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(Cookie&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Experimental.GlobalIllumination.Lightmapping+<>c", Member = "<.cctor>b__7_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light[]), typeof(Unity.Collections.NativeArray`1<UnityEngine.Experimental.GlobalIllumination.LightDataGI>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600048B")]
		 get { } //Length: 118
		[Address(RVA = "0x192DE50", Offset = "0x192D050", Length = "0x83")]
		[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "BeginGenSession", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.PrefabPreviewLookAndFeel"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "CreatePreviewLight", ReturnType = typeof(bool))]
		[CalledBy(Type = "GLTFast.LightPunctualExtension", Member = "ToUnityLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Schema.LightPunctual", typeof(Light), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600048C")]
		 set { } //Length: 131
	}

	[Token(Token = "0x170000CF")]
	public bool useColorTemperature
	{
		[Address(RVA = "0x192D860", Offset = "0x192CA60", Length = "0x76")]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractColorTemperature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(Color))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000493")]
		 get { } //Length: 118
		[Address(RVA = "0x192DF30", Offset = "0x192D130", Length = "0x86")]
		[CalledBy(Type = "GLTFast.LightPunctualExtension", Member = "ToUnityLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Schema.LightPunctual", typeof(Light), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000494")]
		 set { } //Length: 134
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A0")]
	public Light() { }

	[Address(RVA = "0x192CF00", Offset = "0x192C100", Length = "0x93")]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600049B")]
	public LightBakingOutput get_bakingOutput() { }

	[Address(RVA = "0x192CEB0", Offset = "0x192C0B0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004B1")]
	private static void get_bakingOutput_Injected(IntPtr _unity_self, out LightBakingOutput ret) { }

	[Address(RVA = "0x192CFE0", Offset = "0x192C1E0", Length = "0x76")]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(LinearColor))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000497")]
	public float get_bounceIntensity() { }

	[Address(RVA = "0x192CFA0", Offset = "0x192C1A0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004AD")]
	private static float get_bounceIntensity_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x192D170", Offset = "0x192C370", Length = "0x8E")]
	[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.RTScene", Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "get_Color", ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "get_Color", ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(LinearColor))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000490")]
	public Color get_color() { }

	[Address(RVA = "0x192D120", Offset = "0x192C320", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004A6")]
	private static void get_color_Injected(IntPtr _unity_self, out Color ret) { }

	[Address(RVA = "0x192D0A0", Offset = "0x192C2A0", Length = "0x76")]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractColorTemperature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000492")]
	public float get_colorTemperature() { }

	[Address(RVA = "0x192D060", Offset = "0x192C260", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004A8")]
	private static float get_colorTemperature_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x192D300", Offset = "0x192C500", Length = "0x90")]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(Cookie&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600049F")]
	public Texture get_cookie() { }

	[Address(RVA = "0x192D2C0", Offset = "0x192C4C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004B5")]
	private static IntPtr get_cookie_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x192D240", Offset = "0x192C440", Length = "0x76")]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(Cookie&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600049E")]
	public float get_cookieSize() { }

	[Address(RVA = "0x192D200", Offset = "0x192C400", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004B4")]
	private static float get_cookieSize_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x192D3E0", Offset = "0x192C5E0", Length = "0x76")]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600049A")]
	public float get_dilatedRange() { }

	[Address(RVA = "0x192D3A0", Offset = "0x192C5A0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004B0")]
	private static float get_dilatedRange_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x192D4A0", Offset = "0x192C6A0", Length = "0x76")]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(LinearColor))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "get_Brightness", ReturnType = typeof(float))]
	[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "get_Brightness", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000495")]
	public float get_intensity() { }

	[Address(RVA = "0x192D460", Offset = "0x192C660", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004AB")]
	private static float get_intensity_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x192D560", Offset = "0x192C760", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "get_Range", ReturnType = typeof(float))]
	[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "get_Range", ReturnType = typeof(float))]
	[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000498")]
	public float get_range() { }

	[Address(RVA = "0x192D520", Offset = "0x192C720", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004AE")]
	private static float get_range_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x192D620", Offset = "0x192C820", Length = "0x76")]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "get_Shadows", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "get_Shadows", ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("GetShadowType")]
	[Token(Token = "0x600049C")]
	public LightShadows get_shadows() { }

	[Address(RVA = "0x192D5E0", Offset = "0x192C7E0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004B2")]
	private static LightShadows get_shadows_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x192D6E0", Offset = "0x192C8E0", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "get_Angle", ReturnType = typeof(float))]
	[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractInnerCone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600048D")]
	public float get_spotAngle() { }

	[Address(RVA = "0x192D6A0", Offset = "0x192C8A0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004A3")]
	private static float get_spotAngle_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x192D7A0", Offset = "0x192C9A0", Length = "0x76")]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(Cookie&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.GlobalIllumination.Lightmapping+<>c", Member = "<.cctor>b__7_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light[]), typeof(Unity.Collections.NativeArray`1<UnityEngine.Experimental.GlobalIllumination.LightDataGI>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600048B")]
	public LightType get_type() { }

	[Address(RVA = "0x192D760", Offset = "0x192C960", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004A1")]
	private static LightType get_type_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x192D860", Offset = "0x192CA60", Length = "0x76")]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractColorTemperature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000493")]
	public bool get_useColorTemperature() { }

	[Address(RVA = "0x192D820", Offset = "0x192CA20", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004A9")]
	private static bool get_useColorTemperature_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x192D930", Offset = "0x192CB30", Length = "0x85")]
	[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.SunLight", Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.SunLight", Member = "OnColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.LightPunctualExtension", Member = "ToUnityLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Schema.LightPunctual", typeof(Light), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000491")]
	public void set_color(Color value) { }

	[Address(RVA = "0x192D8E0", Offset = "0x192CAE0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004A7")]
	private static void set_color_Injected(IntPtr _unity_self, in Color value) { }

	[Address(RVA = "0x192DA10", Offset = "0x192CC10", Length = "0x86")]
	[CalledBy(Type = "GLTFast.LightPunctualExtension", Member = "ToUnityLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Schema.LightPunctual", typeof(Light), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600048F")]
	public void set_innerSpotAngle(float value) { }

	[Address(RVA = "0x192D9C0", Offset = "0x192CBC0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004A5")]
	private static void set_innerSpotAngle_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x192DAF0", Offset = "0x192CCF0", Length = "0x86")]
	[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "BeginGenSession", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.PrefabPreviewLookAndFeel"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "CreatePreviewLight", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "set_Brightness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "set_Brightness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.SunLight", Member = "set_Brightness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.SunLight", Member = "OnBrightnessChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.LightPunctualExtension", Member = "ToUnityLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Schema.LightPunctual", typeof(Light), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.LightPunctualExtension", Member = "LightAssignIntensity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), "GLTFast.Schema.LightPunctual", typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000496")]
	public void set_intensity(float value) { }

	[Address(RVA = "0x192DAA0", Offset = "0x192CCA0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004AC")]
	private static void set_intensity_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x192DBD0", Offset = "0x192CDD0", Length = "0x86")]
	[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "set_Range", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "set_Range", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.LightPunctualExtension", Member = "ToUnityLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Schema.LightPunctual", typeof(Light), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000499")]
	public void set_range(float value) { }

	[Address(RVA = "0x192DB80", Offset = "0x192CD80", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004AF")]
	private static void set_range_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x192DCA0", Offset = "0x192CEA0", Length = "0x83")]
	[CalledBy(Type = "Polytoria.Datamodel.PointLight", Member = "set_Shadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "set_Shadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.SunLight", Member = "set_Shadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.SunLight", Member = "OnShadowsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("Light_Bindings::SetShadowType", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600049D")]
	public void set_shadows(LightShadows value) { }

	[Address(RVA = "0x192DC60", Offset = "0x192CE60", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004B3")]
	private static void set_shadows_Injected(IntPtr _unity_self, LightShadows value) { }

	[Address(RVA = "0x192DD80", Offset = "0x192CF80", Length = "0x86")]
	[CalledBy(Type = "Polytoria.Datamodel.Spotlight", Member = "set_Angle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.LightPunctualExtension", Member = "ToUnityLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Schema.LightPunctual", typeof(Light), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600048E")]
	public void set_spotAngle(float value) { }

	[Address(RVA = "0x192DD30", Offset = "0x192CF30", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004A4")]
	private static void set_spotAngle_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x192DE50", Offset = "0x192D050", Length = "0x83")]
	[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "BeginGenSession", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.PrefabPreviewLookAndFeel"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.EditorPrefabPreviewGen", Member = "CreatePreviewLight", ReturnType = typeof(bool))]
	[CalledBy(Type = "GLTFast.LightPunctualExtension", Member = "ToUnityLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Schema.LightPunctual", typeof(Light), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600048C")]
	public void set_type(LightType value) { }

	[Address(RVA = "0x192DE10", Offset = "0x192D010", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004A2")]
	private static void set_type_Injected(IntPtr _unity_self, LightType value) { }

	[Address(RVA = "0x192DF30", Offset = "0x192D130", Length = "0x86")]
	[CalledBy(Type = "GLTFast.LightPunctualExtension", Member = "ToUnityLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Schema.LightPunctual", typeof(Light), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000494")]
	public void set_useColorTemperature(bool value) { }

	[Address(RVA = "0x192DEE0", Offset = "0x192D0E0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004AA")]
	private static void set_useColorTemperature_Injected(IntPtr _unity_self, bool value) { }

}

