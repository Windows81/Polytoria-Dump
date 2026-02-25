namespace UnityEngine;

[DefaultMember("Item")]
[NativeHeader("Runtime/Math/AnimationCurve.bindings.h")]
[RequiredByNativeCode]
[Token(Token = "0x200006E")]
public class AnimationCurve : IEquatable<AnimationCurve>
{
	[Token(Token = "0x200006F")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000163")]
		public static IntPtr ConvertToNative(AnimationCurve animationCurve) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000E1")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ParticleSystemModule"})]
	internal IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000E2")]
	private bool m_RequiresNativeCleanup; //Field offset: 0x18

	[Token(Token = "0x17000030")]
	public Keyframe Item
	{
		[Address(RVA = "0x191C660", Offset = "0x191B860", Length = "0xAA")]
		[CalledBy(Type = "LeanAudio", Member = "createAudioWave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve), typeof(AnimationCurve), "LeanAudioOptions"}, ReturnType = typeof(int))]
		[CalledBy(Type = "LeanAudio", Member = "generateAudioFromCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve), typeof(int)}, ReturnType = "UnityEngine.AudioClip")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Spline", Member = "Cache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600014F")]
		 get { } //Length: 170
	}

	[Token(Token = "0x1700002F")]
	public Keyframe[] keys
	{
		[Address(RVA = "0x191C760", Offset = "0x191B960", Length = "0xED")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Spline", Member = "Cache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18191AE40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("AnimationCurveBindings::GetKeysArray", HasExplicitThis = True, IsThreadSafe = True)]
		[Token(Token = "0x600014A")]
		 get { } //Length: 237
		[Address(RVA = "0x191C940", Offset = "0x191BB40", Length = "0xF9")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Spline", Member = "Cache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("AnimationCurveBindings::SetKeysWithSpan", HasExplicitThis = True, IsThreadSafe = True)]
		[Token(Token = "0x600014B")]
		 set { } //Length: 249
	}

	[Token(Token = "0x17000031")]
	public int length
	{
		[Address(RVA = "0x191C890", Offset = "0x191BA90", Length = "0x51")]
		[CalledBy(Type = "LeanAudio", Member = "createAudioWave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve), typeof(AnimationCurve), "LeanAudioOptions"}, ReturnType = typeof(int))]
		[CalledBy(Type = "LeanAudio", Member = "generateAudioFromCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve), typeof(int)}, ReturnType = "UnityEngine.AudioClip")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Spline", Member = "Cache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Spline", Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod("GetKeyCount", IsThreadSafe = True)]
		[Token(Token = "0x6000150")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x191C5E0", Offset = "0x191B7E0", Length = "0x38")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000156")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ParticleSystemModule"})]
	internal AnimationCurve(IntPtr ptr, bool ownMemory) { }

	[Address(RVA = "0x191C5B0", Offset = "0x191B7B0", Length = "0x27")]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_SizeOverLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.AnimationUtils", Member = "AddRotationCurves", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AnimationClip", typeof(string), "Unity.Collections.NativeArray`1<Single>", "Unity.Collections.NativeArray`1<Quaternion>", "GLTFast.Schema.InterpolationType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.AnimationUtils", Member = "AddVec3Curves", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AnimationClip", typeof(string), typeof(string), "Unity.Collections.NativeArray`1<Single>", "Unity.Collections.NativeArray`1<float3>", "GLTFast.Schema.InterpolationType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.AnimationUtils", Member = "AddScalarCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AnimationClip", typeof(string), typeof(string), typeof(int), typeof(int), "Unity.Collections.NativeArray`1<Single>", "Unity.Collections.NativeArray`1<Single>", "GLTFast.Schema.InterpolationType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGrading", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Spline", Member = "Cache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(AnimationCurve), Member = "Internal_Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Keyframe[])}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000155")]
	public AnimationCurve() { }

	[Address(RVA = "0x191C620", Offset = "0x191B820", Length = "0x34")]
	[CalledBy(Type = "LeanAudio", Member = "printOutAudioClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AudioClip", typeof(AnimationCurve&), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGrading", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(AnimationCurve), Member = "Internal_Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Keyframe[])}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000154")]
	public AnimationCurve(Keyframe[] keys) { }

	[Address(RVA = "0x191BBC0", Offset = "0x191ADC0", Length = "0x70")]
	[CalledBy(Type = "GLTFast.AnimationUtils", Member = "AddRotationCurves", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AnimationClip", typeof(string), "Unity.Collections.NativeArray`1<Single>", "Unity.Collections.NativeArray`1<Quaternion>", "GLTFast.Schema.InterpolationType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.AnimationUtils", Member = "AddVec3Curves", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AnimationClip", typeof(string), typeof(string), "Unity.Collections.NativeArray`1<Single>", "Unity.Collections.NativeArray`1<float3>", "GLTFast.Schema.InterpolationType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.AnimationUtils", Member = "AddScalarCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AnimationClip", typeof(string), typeof(string), typeof(int), typeof(int), "Unity.Collections.NativeArray`1<Single>", "Unity.Collections.NativeArray`1<Single>", "GLTFast.Schema.InterpolationType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Spline", Member = "Cache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 34)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600014D")]
	public int AddKey(Keyframe key) { }

	[Address(RVA = "0x191BC40", Offset = "0x191AE40", Length = "0x71")]
	[CalledBy(Type = "Polytoria.Datamodel.Particles", Member = "set_SizeOverLifetime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("AnimationCurveBindings::AddKeySmoothTangents", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x600014C")]
	public int AddKey(float time, float value) { }

	[Address(RVA = "0x191BAB0", Offset = "0x191ACB0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600015E")]
	private static int AddKey_Injected(IntPtr _unity_self, float time, float value) { }

	[Address(RVA = "0x191BB60", Offset = "0x191AD60", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("AddKey", IsThreadSafe = True)]
	[Token(Token = "0x600014E")]
	private int AddKey_Internal(Keyframe key) { }

	[Address(RVA = "0x191BB10", Offset = "0x191AD10", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600015F")]
	private static int AddKey_Internal_Injected(IntPtr _unity_self, in Keyframe key) { }

	[Address(RVA = "0x191BCC0", Offset = "0x191AEC0", Length = "0x1BE")]
	[CalledBy(Type = "RLD.SceneGizmoCamPrjSwitchLabel", Member = "OnGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AnimationCurve), Member = "Internal_Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Keyframe[])}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000153")]
	public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	[Address(RVA = "0x191BF80", Offset = "0x191B180", Length = "0x17A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(IntPtr), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000157")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x191BE80", Offset = "0x191B080", Length = "0xF2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(IntPtr), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000158")]
	public override bool Equals(AnimationCurve other) { }

	[Address(RVA = "0x191C150", Offset = "0x191B350", Length = "0x61")]
	[CalledBy(Type = "LTDescr", Member = "tweenOnCurve", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "RLD.SceneGizmoCamPrjSwitchLabel", Member = "OnGUI", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanAudio", Member = "createAudioWave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve), typeof(AnimationCurve), "LeanAudioOptions"}, ReturnType = typeof(int))]
	[CalledBy(Type = "LeanAudio", Member = "generateAudioFromCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve), typeof(int)}, ReturnType = "UnityEngine.AudioClip")]
	[CalledBy(Type = "LeanTween", Member = "tweenOnCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"LTDescr", typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "LeanTween", Member = "tweenOnCurveVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"LTDescr", typeof(float)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Spline", Member = "Cache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Spline", Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Spline", Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000149")]
	public float Evaluate(float time) { }

	[Address(RVA = "0x191C100", Offset = "0x191B300", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600015B")]
	private static float Evaluate_Injected(IntPtr _unity_self, float time) { }

	[Address(RVA = "0x191C1C0", Offset = "0x191B3C0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000148")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x191C660", Offset = "0x191B860", Length = "0xAA")]
	[CalledBy(Type = "LeanAudio", Member = "createAudioWave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve), typeof(AnimationCurve), "LeanAudioOptions"}, ReturnType = typeof(int))]
	[CalledBy(Type = "LeanAudio", Member = "generateAudioFromCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve), typeof(int)}, ReturnType = "UnityEngine.AudioClip")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Spline", Member = "Cache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600014F")]
	public Keyframe get_Item(int index) { }

	[Address(RVA = "0x191C760", Offset = "0x191B960", Length = "0xED")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Spline", Member = "Cache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18191AE40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("AnimationCurveBindings::GetKeysArray", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x600014A")]
	public Keyframe[] get_keys() { }

	[Address(RVA = "0x191C710", Offset = "0x191B910", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600015C")]
	private static void get_keys_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x191C890", Offset = "0x191BA90", Length = "0x51")]
	[CalledBy(Type = "LeanAudio", Member = "createAudioWave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve), typeof(AnimationCurve), "LeanAudioOptions"}, ReturnType = typeof(int))]
	[CalledBy(Type = "LeanAudio", Member = "generateAudioFromCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationCurve), typeof(int)}, ReturnType = "UnityEngine.AudioClip")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Spline", Member = "Cache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Spline", Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("GetKeyCount", IsThreadSafe = True)]
	[Token(Token = "0x6000150")]
	public int get_length() { }

	[Address(RVA = "0x191C850", Offset = "0x191BA50", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000160")]
	private static int get_length_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x191C280", Offset = "0x191B480", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("AnimationCurveBindings::GetHashCode", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x6000152")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x191C240", Offset = "0x191B440", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000162")]
	private static int GetHashCode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x191C330", Offset = "0x191B530", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("AnimationCurveBindings::GetKey", HasExplicitThis = True, IsThreadSafe = True)]
	[NativeThrows]
	[Token(Token = "0x6000151")]
	private Keyframe GetKey(int index) { }

	[Address(RVA = "0x191C2E0", Offset = "0x191B4E0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000161")]
	private static void GetKey_Injected(IntPtr _unity_self, int index, out Keyframe ret) { }

	[Address(RVA = "0x191C400", Offset = "0x191B600", Length = "0xBC")]
	[CalledBy(Type = typeof(AnimationCurve), Member = "EaseInOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(AnimationCurve))]
	[CalledBy(Type = typeof(AnimationCurve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Keyframe[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnimationCurve), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("AnimationCurveBindings::Internal_Create", IsThreadSafe = True)]
	[Token(Token = "0x6000146")]
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	[Address(RVA = "0x191C3C0", Offset = "0x191B5C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000159")]
	private static IntPtr Internal_Create_Injected(ref ManagedSpanWrapper keys) { }

	[Address(RVA = "0x191C4C0", Offset = "0x191B6C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("AnimationCurveBindings::Internal_Destroy", IsThreadSafe = True)]
	[Token(Token = "0x6000145")]
	private static void Internal_Destroy(IntPtr ptr) { }

	[Address(RVA = "0x191C550", Offset = "0x191B750", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("AnimationCurveBindings::Internal_Equals", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x6000147")]
	private bool Internal_Equals(IntPtr other) { }

	[Address(RVA = "0x191C500", Offset = "0x191B700", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600015A")]
	private static bool Internal_Equals_Injected(IntPtr _unity_self, IntPtr other) { }

	[Address(RVA = "0x191C940", Offset = "0x191BB40", Length = "0xF9")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Spline", Member = "Cache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("AnimationCurveBindings::SetKeysWithSpan", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x600014B")]
	public void set_keys(Keyframe[] value) { }

	[Address(RVA = "0x191C8F0", Offset = "0x191BAF0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600015D")]
	private static void set_keys_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

}

