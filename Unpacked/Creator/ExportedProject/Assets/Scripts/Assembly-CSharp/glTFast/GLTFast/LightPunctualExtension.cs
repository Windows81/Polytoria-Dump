namespace GLTFast;

[Extension]
[Token(Token = "0x2000042")]
public static class LightPunctualExtension
{

	[Address(RVA = "0x1075AA0", Offset = "0x1074CA0", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Light), Member = "set_intensity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000129")]
	private static void LightAssignIntensity(Light lightDestination, LightPunctual lightSource, float lightIntensityFactor) { }

	[Address(RVA = "0x1075B40", Offset = "0x1074D40", Length = "0x2A4")]
	[CalledBy(Type = typeof(GameObjectInstantiator), Member = "AddLightPunctual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Light), Member = "set_innerSpotAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Light), Member = "set_spotAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Light), Member = "set_range", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Light), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mathf), Member = "LinearToGammaSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Light), Member = "set_useColorTemperature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Light), Member = "set_type", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LightPunctual), Member = "GetLightType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Light), Member = "set_intensity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Extension]
	[Token(Token = "0x6000128")]
	public static void ToUnityLight(LightPunctual lightSource, Light lightDestination, float lightIntensityFactor) { }

}

