namespace UnityEngine;

[Il2CppEagerStaticClassConstruction]
[NativeHeader("Runtime/Math/ColorSpaceConversion.h")]
[NativeHeader("Runtime/Math/FloatConversion.h")]
[NativeHeader("Runtime/Math/PerlinNoise.h")]
[Token(Token = "0x20000FE")]
public struct Mathf
{
	[Token(Token = "0x40004BD")]
	public static readonly float Epsilon; //Field offset: 0x0

	[Address(RVA = "0x1947970", Offset = "0x1946B70", Length = "0xBE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x60007E2")]
	private static Mathf() { }

	[Address(RVA = "0x19468E0", Offset = "0x1945AE0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60007BF")]
	public static int Abs(int value) { }

	[Address(RVA = "0x1946880", Offset = "0x1945A80", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60007BE")]
	public static float Abs(float f) { }

	[Address(RVA = "0x1946930", Offset = "0x1945B30", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028B010")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007BA")]
	public static float Acos(float f) { }

	[Address(RVA = "0x1946990", Offset = "0x1945B90", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007D5")]
	public static bool Approximately(float a, float b) { }

	[Address(RVA = "0x1946A20", Offset = "0x1945C20", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028B2D0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007B9")]
	public static float Asin(float f) { }

	[Address(RVA = "0x1946AF0", Offset = "0x1945CF0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028B560")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007BB")]
	public static float Atan(float f) { }

	[Address(RVA = "0x1946A80", Offset = "0x1945C80", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028B7B0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007BC")]
	public static float Atan2(float y, float x) { }

	[Address(RVA = "0x1946BB0", Offset = "0x1945DB0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007C9")]
	public static float Ceil(float f) { }

	[Address(RVA = "0x1946B50", Offset = "0x1945D50", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007CC")]
	public static int CeilToInt(float f) { }

	[Address(RVA = "0x1946CF0", Offset = "0x1945EF0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007D0")]
	public static float Clamp(float value, float min, float max) { }

	[Address(RVA = "0x1946CD0", Offset = "0x1945ED0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007D1")]
	public static int Clamp(int value, int min, int max) { }

	[Address(RVA = "0x1946C10", Offset = "0x1945E10", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007D2")]
	public static float Clamp01(float value) { }

	[Address(RVA = "0x1946C30", Offset = "0x1945E30", Length = "0x5F")]
	[CalledBy(Type = "UnityEngine.UIElements.FloatField+FloatInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Single&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007D9")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static float ClampToFloat(double value) { }

	[Address(RVA = "0x1946C90", Offset = "0x1945E90", Length = "0x1B")]
	[CalledBy(Type = "UnityEngine.UIElements.IntegerField+IntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Int32&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x60007DA")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule"})]
	internal static int ClampToInt(long value) { }

	[Address(RVA = "0x1946CB0", Offset = "0x1945EB0", Length = "0x14")]
	[CalledBy(Type = "UnityEngine.UIElements.UnsignedIntegerField+UnsignedIntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(UInt32&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x60007DB")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static uint ClampToUInt(long value) { }

	[Address(RVA = "0x1946D10", Offset = "0x1945F10", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007E0")]
	public static int ClosestPowerOfTwo(int value) { }

	[Address(RVA = "0x1946DB0", Offset = "0x1945FB0", Length = "0x4C")]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractColorTemperature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light)}, ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DirectionalLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(PointLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(SpotLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(RectangleLight&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(DiscLight&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x60007B2")]
	public static Color CorrelatedColorTemperatureToRGB(float kelvin) { }

	[Address(RVA = "0x1946D60", Offset = "0x1945F60", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007E3")]
	private static void CorrelatedColorTemperatureToRGB_Injected(float kelvin, out Color ret) { }

	[Address(RVA = "0x1946E00", Offset = "0x1946000", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028BE30")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007B7")]
	public static float Cos(float f) { }

	[Address(RVA = "0x1946E60", Offset = "0x1946060", Length = "0xD1")]
	[CalledBy(Type = typeof(Mathf), Member = "RoundBasedOnMinimumDifference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028FCA0")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007DE")]
	internal static double DiscardLeastSignificantDecimal(double v) { }

	[Address(RVA = "0x1946F40", Offset = "0x1946140", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028C7A0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007C5")]
	public static float Exp(float power) { }

	[Address(RVA = "0x1946FA0", Offset = "0x19461A0", Length = "0x3A")]
	[CallerCount(Count = 46)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x60007B3")]
	public static ushort FloatToHalf(float val) { }

	[Address(RVA = "0x1947040", Offset = "0x1946240", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007CA")]
	public static float Floor(float f) { }

	[Address(RVA = "0x1946FE0", Offset = "0x19461E0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007CD")]
	public static int FloorToInt(float f) { }

	[Address(RVA = "0x19470A0", Offset = "0x19462A0", Length = "0x3A")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator", Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator", Member = "SetColorValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.BMPAlloc", typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator", Member = "SetTextCoreSettingValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.BMPAlloc", "UnityEngine.UIElements.UIR.TextCoreSettings"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LinearColor), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(float)}, ReturnType = typeof(LinearColor))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.BloomRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Fog", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x60007B0")]
	public static float GammaToLinearSpace(float value) { }

	[Address(RVA = "0x19470E0", Offset = "0x19462E0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028FCA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Token(Token = "0x60007DC")]
	internal static int GetNumberOfDecimalsForMinimumDifference(double minDifference) { }

	[Address(RVA = "0x1947160", Offset = "0x1946360", Length = "0x33")]
	[CallerCount(Count = 60)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x60007B4")]
	public static float HalfToFloat(ushort val) { }

	[Address(RVA = "0x19471A0", Offset = "0x19463A0", Length = "0x34")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007D8")]
	public static float InverseLerp(float a, float b, float value) { }

	[Address(RVA = "0x19471E0", Offset = "0x19463E0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007E1")]
	public static bool IsPowerOfTwo(int value) { }

	[Address(RVA = "0x2CD990", Offset = "0x2CCB90", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007D3")]
	public static float Lerp(float a, float b, float t) { }

	[Address(RVA = "0x19471F0", Offset = "0x19463F0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007D4")]
	public static float LerpUnclamped(float a, float b, float t) { }

	[Address(RVA = "0x1947210", Offset = "0x1946410", Length = "0x3A")]
	[CalledBy(Type = "GLTFast.LightPunctualExtension", Member = "ToUnityLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Schema.LightPunctual", typeof(Light), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.Materials.BuiltInMaterialGenerator", Member = "GenerateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.Schema.MaterialBase", "GLTFast.IGltfReadable", typeof(bool)}, ReturnType = typeof(Material))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x60007B1")]
	public static float LinearToGammaSpace(float value) { }

	[Address(RVA = "0x19472B0", Offset = "0x19464B0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007C6")]
	public static float Log(float f, float p) { }

	[Address(RVA = "0x1947320", Offset = "0x1946520", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028F4B0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007C7")]
	public static float Log(float f) { }

	[Address(RVA = "0x1947250", Offset = "0x1946450", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028FCA0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007C8")]
	public static float Log10(float f) { }

	[Address(RVA = "0x1947380", Offset = "0x1946580", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007C3")]
	public static int Max(int a, int b) { }

	[Address(RVA = "0x1947390", Offset = "0x1946590", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007C2")]
	public static float Max(float a, float b) { }

	[Address(RVA = "0x19473A0", Offset = "0x19465A0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007C0")]
	public static float Min(float a, float b) { }

	[Address(RVA = "0x19473B0", Offset = "0x19465B0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007C1")]
	public static int Min(int a, int b) { }

	[Address(RVA = "0x19473C0", Offset = "0x19465C0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007DF")]
	public static int NextPowerOfTwo(int value) { }

	[Address(RVA = "0x19473F0", Offset = "0x19465F0", Length = "0x4A")]
	[CalledBy(Type = "LeanAudio", Member = "createAudioFromWave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "LeanAudioOptions"}, ReturnType = "UnityEngine.AudioClip")]
	[CalledBy(Type = "Mirror.LatencySimulation", Member = "Noise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("PerlinNoise::NoiseNormalized", IsThreadSafe = True)]
	[Token(Token = "0x60007B5")]
	public static float PerlinNoise(float x, float y) { }

	[Address(RVA = "0x1947440", Offset = "0x1946640", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007C4")]
	public static float Pow(float f, float p) { }

	[Address(RVA = "0x19474B0", Offset = "0x19466B0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[Token(Token = "0x60007D7")]
	public static float Repeat(float t, float length) { }

	[Address(RVA = "0x1947670", Offset = "0x1946870", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007CB")]
	public static float Round(float f) { }

	[Address(RVA = "0x1947510", Offset = "0x1946710", Length = "0xF7")]
	[CalledBy(Type = "UnityEngine.UIElements.DoubleField+DoubleInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.FloatField+FloatInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mathf), Member = "DiscardLeastSignificantDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028FCA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007DD")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static double RoundBasedOnMinimumDifference(double valueToRound, double minDifference) { }

	[Address(RVA = "0x1947610", Offset = "0x1946810", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007CE")]
	public static int RoundToInt(float f) { }

	[Address(RVA = "0x19476D0", Offset = "0x19468D0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007CF")]
	public static float Sign(float f) { }

	[Address(RVA = "0x19476F0", Offset = "0x19468F0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028CBC0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007B6")]
	public static float Sin(float f) { }

	[Address(RVA = "0x1947750", Offset = "0x1946950", Length = "0x135")]
	[CalledBy(Type = "UnityEngine.UIElements.ScrollView", Member = "SpringBack", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007D6")]
	public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	[Address(RVA = "0x1947890", Offset = "0x1946A90", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007BD")]
	public static float Sqrt(float f) { }

	[Address(RVA = "0x1947910", Offset = "0x1946B10", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028D560")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007B8")]
	public static float Tan(float f) { }

}

