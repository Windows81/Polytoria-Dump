namespace Polytoria.Datamodel;

[RequireComponent(typeof(Light))]
[Token(Token = "0x2000362")]
public class SunLight : DynamicInstance
{
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4000E5C")]
	private Light light; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[SyncVar(hook = "OnBrightnessChanged")]
	[Token(Token = "0x4000E5D")]
	private float brightness; //Field offset: 0x218
	[FieldOffset(Offset = "0x21C")]
	[SyncVar(hook = "OnColorChanged")]
	[Token(Token = "0x4000E5E")]
	private Color color; //Field offset: 0x21C
	[FieldOffset(Offset = "0x22C")]
	[SyncVar(hook = "OnShadowsChanged")]
	[Token(Token = "0x4000E5F")]
	private bool shadows; //Field offset: 0x22C
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000E60")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_brightness; //Field offset: 0x230
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000E61")]
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_color; //Field offset: 0x238
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000E62")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_shadows; //Field offset: 0x240

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AA8")]
	public float Brightness
	{
		[Address(RVA = "0x4761D0", Offset = "0x4753D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002363")]
		 get { } //Length: 9
		[Address(RVA = "0x4761F0", Offset = "0x4753F0", Length = "0x83")]
		[CalledBy(Type = typeof(Lighting), Member = "set_SunBrightness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SunLightProxy), Member = "set_Brightness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(Light), Member = "set_intensity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002364")]
		 set { } //Length: 131
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AA9")]
	public Color Color
	{
		[Address(RVA = "0x4761E0", Offset = "0x4753E0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002365")]
		 get { } //Length: 14
		[Address(RVA = "0x476280", Offset = "0x475480", Length = "0x97")]
		[CalledBy(Type = typeof(Lighting), Member = "set_SunColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SunLightProxy), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Calls(Type = typeof(Light), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002366")]
		 set { } //Length: 151
	}

	[Token(Token = "0x17000AAB")]
	public float Networkbrightness
	{
		[Address(RVA = "0x4761D0", Offset = "0x4753D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600236F")]
		 get { } //Length: 9
		[Address(RVA = "0x476320", Offset = "0x475520", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x6002370")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000AAC")]
	public Color Networkcolor
	{
		[Address(RVA = "0x4761E0", Offset = "0x4753E0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002371")]
		 get { } //Length: 14
		[Address(RVA = "0x476390", Offset = "0x475590", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Token(Token = "0x6002372")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000AAD")]
	public bool Networkshadows
	{
		[Address(RVA = "0x474670", Offset = "0x473870", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002373")]
		 get { } //Length: 8
		[Address(RVA = "0x476410", Offset = "0x475610", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x6002374")]
		 set { } //Length: 104
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AAA")]
	public bool Shadows
	{
		[Address(RVA = "0x474670", Offset = "0x473870", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002367")]
		 get { } //Length: 8
		[Address(RVA = "0x476480", Offset = "0x475680", Length = "0x84")]
		[CalledBy(Type = typeof(Lighting), Member = "set_Shadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SunLightProxy), Member = "set_Shadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Calls(Type = typeof(Light), Member = "set_shadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightShadows)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002368")]
		 set { } //Length: 132
	}

	[Address(RVA = "0x476040", Offset = "0x475240", Length = "0x183")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LuaColor3), Member = "FromHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynamicInstance), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600236D")]
	public SunLight() { }

	[Address(RVA = "0x475B70", Offset = "0x474D70", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DynamicInstance), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002369")]
	protected virtual void Awake() { }

	[Address(RVA = "0x475BD0", Offset = "0x474DD0", Length = "0x1BC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DynamicInstance), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(System.Action`2<System.Single, System.Single>), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color&), typeof(System.Action`2<UnityEngine.Color, UnityEngine.Color>), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Action`2<T, T>", "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002376")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x4761D0", Offset = "0x4753D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002363")]
	public float get_Brightness() { }

	[Address(RVA = "0x4761E0", Offset = "0x4753E0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002365")]
	public Color get_Color() { }

	[Address(RVA = "0x4761D0", Offset = "0x4753D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600236F")]
	public float get_Networkbrightness() { }

	[Address(RVA = "0x4761E0", Offset = "0x4753E0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002371")]
	public Color get_Networkcolor() { }

	[Address(RVA = "0x474670", Offset = "0x473870", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002373")]
	public bool get_Networkshadows() { }

	[Address(RVA = "0x474670", Offset = "0x473870", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002367")]
	public bool get_Shadows() { }

	[Address(RVA = "0x475D90", Offset = "0x474F90", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(Light), Member = "set_intensity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600236A")]
	private void OnBrightnessChanged(float oldValue, float newValue) { }

	[Address(RVA = "0x475E20", Offset = "0x475020", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(Light), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600236B")]
	private void OnColorChanged(Color oldValue, Color newValue) { }

	[Address(RVA = "0x475ED0", Offset = "0x4750D0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Calls(Type = typeof(Light), Member = "set_shadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightShadows)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600236C")]
	private void OnShadowsChanged(bool oldValue, bool newValue) { }

	[Address(RVA = "0x475F70", Offset = "0x475170", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicInstance), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002375")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x4761F0", Offset = "0x4753F0", Length = "0x83")]
	[CalledBy(Type = typeof(Lighting), Member = "set_SunBrightness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SunLightProxy), Member = "set_Brightness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(Light), Member = "set_intensity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002364")]
	public void set_Brightness(float value) { }

	[Address(RVA = "0x476280", Offset = "0x475480", Length = "0x97")]
	[CalledBy(Type = typeof(Lighting), Member = "set_SunColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SunLightProxy), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(Light), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002366")]
	public void set_Color(Color value) { }

	[Address(RVA = "0x476320", Offset = "0x475520", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x6002370")]
	public void set_Networkbrightness(in float value) { }

	[Address(RVA = "0x476390", Offset = "0x475590", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Token(Token = "0x6002372")]
	public void set_Networkcolor(in Color value) { }

	[Address(RVA = "0x476410", Offset = "0x475610", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x6002374")]
	public void set_Networkshadows(in bool value) { }

	[Address(RVA = "0x476480", Offset = "0x475680", Length = "0x84")]
	[CalledBy(Type = typeof(Lighting), Member = "set_Shadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SunLightProxy), Member = "set_Shadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Calls(Type = typeof(Light), Member = "set_shadows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightShadows)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002368")]
	public void set_Shadows(bool value) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600236E")]
	public virtual bool Weaved() { }

}

