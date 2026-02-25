namespace Polytoria.Datamodel;

[Instantiatable]
[Token(Token = "0x2000354")]
public class ProceduralSky : SkyBase
{
	[FieldOffset(Offset = "0x100")]
	[SyncVar(hook = "OnSunSizeChanged")]
	[Token(Token = "0x4000E20")]
	private float sunSize; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[SyncVar(hook = "OnSunSizeConvergenceChanged")]
	[Token(Token = "0x4000E21")]
	private float sunSizeConvergence; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[SyncVar(hook = "OnAtmosphereThicknessChanged")]
	[Token(Token = "0x4000E22")]
	private float atmosphereThickness; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[SyncVar(hook = "OnSkyTintChanged")]
	[Token(Token = "0x4000E23")]
	private Color skyTint; //Field offset: 0x10C
	[FieldOffset(Offset = "0x11C")]
	[SyncVar(hook = "OnGroundColorChanged")]
	[Token(Token = "0x4000E24")]
	private Color groundColor; //Field offset: 0x11C
	[FieldOffset(Offset = "0x12C")]
	[SyncVar(hook = "OnExposureChanged")]
	[Token(Token = "0x4000E25")]
	private float exposure; //Field offset: 0x12C
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000E26")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_sunSize; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000E27")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_sunSizeConvergence; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000E28")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_atmosphereThickness; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000E29")]
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_skyTint; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000E2A")]
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_groundColor; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000E2B")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_exposure; //Field offset: 0x158

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000A76")]
	public float AtmosphereThickness
	{
		[Address(RVA = "0x402160", Offset = "0x401360", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002269")]
		 get { } //Length: 9
		[Address(RVA = "0x46A610", Offset = "0x469810", Length = "0xA6")]
		[CalledBy(Type = typeof(ProceduralSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ProceduralSky), Member = "OnAtmosphereThicknessChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ProceduralSkyProxy), Member = "set_AtmosphereThickness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600226A")]
		 set { } //Length: 166
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000A79")]
	public float Exposure
	{
		[Address(RVA = "0x424BE0", Offset = "0x423DE0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600226F")]
		 get { } //Length: 9
		[Address(RVA = "0x46A6C0", Offset = "0x4698C0", Length = "0xA6")]
		[CalledBy(Type = typeof(ProceduralSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ProceduralSky), Member = "OnExposureChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ProceduralSkyProxy), Member = "set_Exposure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002270")]
		 set { } //Length: 166
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000A78")]
	public Color GroundColor
	{
		[Address(RVA = "0x465020", Offset = "0x464220", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600226D")]
		 get { } //Length: 14
		[Address(RVA = "0x46A770", Offset = "0x469970", Length = "0xBA")]
		[CalledBy(Type = typeof(ProceduralSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ProceduralSky), Member = "OnGroundColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ProceduralSkyProxy), Member = "set_GroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600226E")]
		 set { } //Length: 186
	}

	[Token(Token = "0x17000A7C")]
	public float NetworkatmosphereThickness
	{
		[Address(RVA = "0x402160", Offset = "0x401360", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002281")]
		 get { } //Length: 9
		[Address(RVA = "0x46A830", Offset = "0x469A30", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x6002282")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000A7F")]
	public float Networkexposure
	{
		[Address(RVA = "0x424BE0", Offset = "0x423DE0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002287")]
		 get { } //Length: 9
		[Address(RVA = "0x46A8A0", Offset = "0x469AA0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x6002288")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000A7E")]
	public Color NetworkgroundColor
	{
		[Address(RVA = "0x465020", Offset = "0x464220", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002285")]
		 get { } //Length: 14
		[Address(RVA = "0x46A910", Offset = "0x469B10", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Token(Token = "0x6002286")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000A7D")]
	public Color NetworkskyTint
	{
		[Address(RVA = "0x46A600", Offset = "0x469800", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002283")]
		 get { } //Length: 14
		[Address(RVA = "0x46A990", Offset = "0x469B90", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Token(Token = "0x6002284")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000A7A")]
	public float NetworksunSize
	{
		[Address(RVA = "0x43D500", Offset = "0x43C700", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600227D")]
		 get { } //Length: 9
		[Address(RVA = "0x46AA80", Offset = "0x469C80", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x600227E")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000A7B")]
	public float NetworksunSizeConvergence
	{
		[Address(RVA = "0x402150", Offset = "0x401350", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600227F")]
		 get { } //Length: 9
		[Address(RVA = "0x46AA10", Offset = "0x469C10", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x6002280")]
		 set { } //Length: 104
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000A77")]
	public Color SkyTint
	{
		[Address(RVA = "0x46A600", Offset = "0x469800", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600226B")]
		 get { } //Length: 14
		[Address(RVA = "0x46AAF0", Offset = "0x469CF0", Length = "0xBA")]
		[CalledBy(Type = typeof(ProceduralSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ProceduralSky), Member = "OnSkyTintChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ProceduralSkyProxy), Member = "set_SkyTint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600226C")]
		 set { } //Length: 186
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000A74")]
	public float SunSize
	{
		[Address(RVA = "0x43D500", Offset = "0x43C700", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002265")]
		 get { } //Length: 9
		[Address(RVA = "0x46AC60", Offset = "0x469E60", Length = "0xA6")]
		[CalledBy(Type = typeof(ProceduralSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ProceduralSky), Member = "OnSunSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ProceduralSkyProxy), Member = "set_SunSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002266")]
		 set { } //Length: 166
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000A75")]
	public float SunSizeConvergence
	{
		[Address(RVA = "0x402150", Offset = "0x401350", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002267")]
		 get { } //Length: 9
		[Address(RVA = "0x46ABB0", Offset = "0x469DB0", Length = "0xA6")]
		[CalledBy(Type = typeof(ProceduralSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ProceduralSky), Member = "OnSunSizeConvergenceChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ProceduralSkyProxy), Member = "set_SunSizeConvergence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002268")]
		 set { } //Length: 166
	}

	[Address(RVA = "0x46A390", Offset = "0x469590", Length = "0x264")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Instance), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x600227B")]
	public ProceduralSky() { }

	[Address(RVA = "0x4699F0", Offset = "0x468BF0", Length = "0x170")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RenderSettings), Member = "set_skybox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002273")]
	protected virtual void Apply() { }

	[Address(RVA = "0x469B60", Offset = "0x468D60", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002271")]
	protected virtual void Awake() { }

	[Address(RVA = "0x469C40", Offset = "0x468E40", Length = "0x112")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProceduralSky), Member = "set_SunSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProceduralSky), Member = "set_SunSizeConvergence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProceduralSky), Member = "set_AtmosphereThickness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProceduralSky), Member = "set_SkyTint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProceduralSky), Member = "set_GroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProceduralSky), Member = "set_Exposure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6002274")]
	protected virtual void CopyProperties(Instance clone) { }

	[Address(RVA = "0x469D60", Offset = "0x468F60", Length = "0x30E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(System.Action`2<System.Single, System.Single>), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color&), typeof(System.Action`2<UnityEngine.Color, UnityEngine.Color>), typeof(Color)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600228A")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x402160", Offset = "0x401360", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002269")]
	public float get_AtmosphereThickness() { }

	[Address(RVA = "0x424BE0", Offset = "0x423DE0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600226F")]
	public float get_Exposure() { }

	[Address(RVA = "0x465020", Offset = "0x464220", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600226D")]
	public Color get_GroundColor() { }

	[Address(RVA = "0x402160", Offset = "0x401360", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002281")]
	public float get_NetworkatmosphereThickness() { }

	[Address(RVA = "0x424BE0", Offset = "0x423DE0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002287")]
	public float get_Networkexposure() { }

	[Address(RVA = "0x465020", Offset = "0x464220", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002285")]
	public Color get_NetworkgroundColor() { }

	[Address(RVA = "0x46A600", Offset = "0x469800", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002283")]
	public Color get_NetworkskyTint() { }

	[Address(RVA = "0x43D500", Offset = "0x43C700", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600227D")]
	public float get_NetworksunSize() { }

	[Address(RVA = "0x402150", Offset = "0x401350", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600227F")]
	public float get_NetworksunSizeConvergence() { }

	[Address(RVA = "0x46A600", Offset = "0x469800", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600226B")]
	public Color get_SkyTint() { }

	[Address(RVA = "0x43D500", Offset = "0x43C700", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002265")]
	public float get_SunSize() { }

	[Address(RVA = "0x402150", Offset = "0x401350", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002267")]
	public float get_SunSizeConvergence() { }

	[Address(RVA = "0x46A070", Offset = "0x469270", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProceduralSky), Member = "set_AtmosphereThickness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002277")]
	private void OnAtmosphereThicknessChanged(float oldValue, float newValue) { }

	[Address(RVA = "0x46A0B0", Offset = "0x4692B0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProceduralSky), Member = "set_Exposure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x600227A")]
	private void OnExposureChanged(float oldValue, float newValue) { }

	[Address(RVA = "0x46A0F0", Offset = "0x4692F0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProceduralSky), Member = "set_GroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002279")]
	private void OnGroundColorChanged(Color oldValue, Color newValue) { }

	[Address(RVA = "0x46A130", Offset = "0x469330", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProceduralSky), Member = "set_SkyTint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002278")]
	private void OnSkyTintChanged(Color oldValue, Color newValue) { }

	[Address(RVA = "0x46A170", Offset = "0x469370", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProceduralSky), Member = "set_SunSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002275")]
	private void OnSunSizeChanged(float oldValue, float newValue) { }

	[Address(RVA = "0x46A1B0", Offset = "0x4693B0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProceduralSky), Member = "set_SunSizeConvergence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002276")]
	private void OnSunSizeConvergenceChanged(float oldValue, float newValue) { }

	[Address(RVA = "0x46A1F0", Offset = "0x4693F0", Length = "0x161")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Color)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002289")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x46A610", Offset = "0x469810", Length = "0xA6")]
	[CalledBy(Type = typeof(ProceduralSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProceduralSky), Member = "OnAtmosphereThicknessChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProceduralSkyProxy), Member = "set_AtmosphereThickness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600226A")]
	public void set_AtmosphereThickness(float value) { }

	[Address(RVA = "0x46A6C0", Offset = "0x4698C0", Length = "0xA6")]
	[CalledBy(Type = typeof(ProceduralSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProceduralSky), Member = "OnExposureChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProceduralSkyProxy), Member = "set_Exposure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002270")]
	public void set_Exposure(float value) { }

	[Address(RVA = "0x46A770", Offset = "0x469970", Length = "0xBA")]
	[CalledBy(Type = typeof(ProceduralSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProceduralSky), Member = "OnGroundColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProceduralSkyProxy), Member = "set_GroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600226E")]
	public void set_GroundColor(Color value) { }

	[Address(RVA = "0x46A830", Offset = "0x469A30", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x6002282")]
	public void set_NetworkatmosphereThickness(in float value) { }

	[Address(RVA = "0x46A8A0", Offset = "0x469AA0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x6002288")]
	public void set_Networkexposure(in float value) { }

	[Address(RVA = "0x46A910", Offset = "0x469B10", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Token(Token = "0x6002286")]
	public void set_NetworkgroundColor(in Color value) { }

	[Address(RVA = "0x46A990", Offset = "0x469B90", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Token(Token = "0x6002284")]
	public void set_NetworkskyTint(in Color value) { }

	[Address(RVA = "0x46AA80", Offset = "0x469C80", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x600227E")]
	public void set_NetworksunSize(in float value) { }

	[Address(RVA = "0x46AA10", Offset = "0x469C10", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x6002280")]
	public void set_NetworksunSizeConvergence(in float value) { }

	[Address(RVA = "0x46AAF0", Offset = "0x469CF0", Length = "0xBA")]
	[CalledBy(Type = typeof(ProceduralSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProceduralSky), Member = "OnSkyTintChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProceduralSkyProxy), Member = "set_SkyTint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600226C")]
	public void set_SkyTint(Color value) { }

	[Address(RVA = "0x46AC60", Offset = "0x469E60", Length = "0xA6")]
	[CalledBy(Type = typeof(ProceduralSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProceduralSky), Member = "OnSunSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProceduralSkyProxy), Member = "set_SunSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002266")]
	public void set_SunSize(float value) { }

	[Address(RVA = "0x46ABB0", Offset = "0x469DB0", Length = "0xA6")]
	[CalledBy(Type = typeof(ProceduralSky), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProceduralSky), Member = "OnSunSizeConvergenceChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProceduralSkyProxy), Member = "set_SunSizeConvergence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002268")]
	public void set_SunSizeConvergence(float value) { }

	[Address(RVA = "0x46A360", Offset = "0x469560", Length = "0x2C")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002272")]
	protected virtual void Start() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600227C")]
	public virtual bool Weaved() { }

}

