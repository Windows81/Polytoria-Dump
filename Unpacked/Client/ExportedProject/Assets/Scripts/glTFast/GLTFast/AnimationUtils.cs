namespace GLTFast;

[Token(Token = "0x2000007")]
internal static class AnimationUtils
{

	[Address(RVA = "0x105A330", Offset = "0x1059530", Length = "0x11F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(AnimationUtils), Member = "AddScalarCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationClip), typeof(string), typeof(string), typeof(int), typeof(int), typeof(Unity.Collections.NativeArray`1<System.Single>), typeof(Unity.Collections.NativeArray`1<System.Single>), typeof(InterpolationType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600000E")]
	public static void AddMorphTargetWeightCurves(AnimationClip clip, string animationPath, NativeArray<Single> times, NativeArray<Single> values, InterpolationType interpolationType, String[] morphTargetNames = null) { }

	[Address(RVA = "0x105A450", Offset = "0x1059650", Length = "0xCCE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Reinterpret", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"U"}, ReturnType = "Unity.Collections.NativeArray`1<U>")]
	[Calls(Type = typeof(Keyframe), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Keyframe)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(AnimationClip), Member = "SetCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(string), typeof(AnimationCurve)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Keyframe), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600000C")]
	public static void AddRotationCurves(AnimationClip clip, string animationPath, NativeArray<Single> times, NativeArray<Quaternion> quaternions, InterpolationType interpolationType) { }

	[Address(RVA = "0x105B120", Offset = "0x105A320", Length = "0x4FC")]
	[CalledBy(Type = typeof(AnimationUtils), Member = "AddMorphTargetWeightCurves", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationClip), typeof(string), typeof(Unity.Collections.NativeArray`1<System.Single>), typeof(Unity.Collections.NativeArray`1<System.Single>), typeof(InterpolationType), typeof(String[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Keyframe), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Keyframe)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Keyframe), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AnimationClip), Member = "SetCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(string), typeof(AnimationCurve)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000010")]
	private static void AddScalarCurve(AnimationClip clip, string animationPath, string propertyPrefix, int curveIndex, int valueStride, NativeArray<Single> times, NativeArray<Single> values, InterpolationType interpolationType) { }

	[Address(RVA = "0x105B620", Offset = "0x105A820", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArray`1), Member = "Reinterpret", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"U"}, ReturnType = "Unity.Collections.NativeArray`1<U>")]
	[Calls(Type = typeof(AnimationUtils), Member = "AddVec3Curves", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationClip), typeof(string), typeof(string), typeof(Unity.Collections.NativeArray`1<System.Single>), typeof(Unity.Collections.NativeArray`1<Unity.Mathematics.float3>), typeof(InterpolationType)}, ReturnType = typeof(void))]
	[Token(Token = "0x600000B")]
	public static void AddScaleCurves(AnimationClip clip, string animationPath, NativeArray<Single> times, NativeArray<Vector3> translations, InterpolationType interpolationType) { }

	[Address(RVA = "0x105B6E0", Offset = "0x105A8E0", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArray`1), Member = "Reinterpret", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"U"}, ReturnType = "Unity.Collections.NativeArray`1<U>")]
	[Calls(Type = typeof(AnimationUtils), Member = "AddVec3Curves", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationClip), typeof(string), typeof(string), typeof(Unity.Collections.NativeArray`1<System.Single>), typeof(Unity.Collections.NativeArray`1<Unity.Mathematics.float3>), typeof(InterpolationType)}, ReturnType = typeof(void))]
	[Token(Token = "0x600000A")]
	public static void AddTranslationCurves(AnimationClip clip, string animationPath, NativeArray<Single> times, NativeArray<Vector3> translations, InterpolationType interpolationType) { }

	[Address(RVA = "0x105B7A0", Offset = "0x105A9A0", Length = "0xA23")]
	[CalledBy(Type = typeof(AnimationUtils), Member = "AddTranslationCurves", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationClip), typeof(string), typeof(Unity.Collections.NativeArray`1<System.Single>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector3>), typeof(InterpolationType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnimationUtils), Member = "AddScaleCurves", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationClip), typeof(string), typeof(Unity.Collections.NativeArray`1<System.Single>), typeof(Unity.Collections.NativeArray`1<UnityEngine.Vector3>), typeof(InterpolationType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Keyframe), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Keyframe)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(AnimationClip), Member = "SetCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(string), typeof(AnimationCurve)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Keyframe), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600000F")]
	private static void AddVec3Curves(AnimationClip clip, string animationPath, string propertyPrefix, NativeArray<Single> times, NativeArray<float3> values, InterpolationType interpolationType) { }

	[Address(RVA = "0x105C1D0", Offset = "0x105B3D0", Length = "0xEB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000D")]
	public static string CreateAnimationPath(int nodeIndex, String[] nodeNames, Int32[] parentIndex) { }

}

