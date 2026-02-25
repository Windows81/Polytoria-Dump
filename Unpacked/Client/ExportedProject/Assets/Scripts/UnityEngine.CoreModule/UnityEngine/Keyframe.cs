namespace UnityEngine;

[RequiredByNativeCode]
[Token(Token = "0x200006C")]
public struct Keyframe
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D3")]
	private float m_Time; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000D4")]
	private float m_Value; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000D5")]
	private float m_InTangent; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000D6")]
	private float m_OutTangent; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D7")]
	private int m_WeightedMode; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000D8")]
	private float m_InWeight; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000D9")]
	private float m_OutWeight; //Field offset: 0x18

	[Token(Token = "0x1700002E")]
	public float time
	{
		[Address(RVA = "0x2BC190", Offset = "0x2BB390", Length = "0x7")]
		[CallerCount(Count = 55)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000143")]
		 get { } //Length: 7
		[Address(RVA = "0x18732B0", Offset = "0x18724B0", Length = "0x5")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000144")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x192CD80", Offset = "0x192BF80", Length = "0x17")]
	[CalledBy(Type = "LeanAudio", Member = "printOutAudioClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AudioClip", typeof(AnimationCurve&), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Token(Token = "0x6000140")]
	public Keyframe(float time, float value) { }

	[Address(RVA = "0x192CD10", Offset = "0x192BF10", Length = "0x23")]
	[CalledBy(Type = "GLTFast.AnimationUtils", Member = "AddRotationCurves", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AnimationClip", typeof(string), "Unity.Collections.NativeArray`1<Single>", "Unity.Collections.NativeArray`1<Quaternion>", "GLTFast.Schema.InterpolationType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.AnimationUtils", Member = "AddVec3Curves", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AnimationClip", typeof(string), typeof(string), "Unity.Collections.NativeArray`1<Single>", "Unity.Collections.NativeArray`1<float3>", "GLTFast.Schema.InterpolationType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.AnimationUtils", Member = "AddScalarCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AnimationClip", typeof(string), typeof(string), typeof(int), typeof(int), "Unity.Collections.NativeArray`1<Single>", "Unity.Collections.NativeArray`1<Single>", "GLTFast.Schema.InterpolationType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ColorGrading", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 32)]
	[Token(Token = "0x6000141")]
	public Keyframe(float time, float value, float inTangent, float outTangent) { }

	[Address(RVA = "0x192CD40", Offset = "0x192BF40", Length = "0x37")]
	[CalledBy(Type = "GLTFast.AnimationUtils", Member = "AddRotationCurves", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AnimationClip", typeof(string), "Unity.Collections.NativeArray`1<Single>", "Unity.Collections.NativeArray`1<Quaternion>", "GLTFast.Schema.InterpolationType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.AnimationUtils", Member = "AddVec3Curves", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AnimationClip", typeof(string), typeof(string), "Unity.Collections.NativeArray`1<Single>", "Unity.Collections.NativeArray`1<float3>", "GLTFast.Schema.InterpolationType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.AnimationUtils", Member = "AddScalarCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AnimationClip", typeof(string), typeof(string), typeof(int), typeof(int), "Unity.Collections.NativeArray`1<Single>", "Unity.Collections.NativeArray`1<Single>", "GLTFast.Schema.InterpolationType"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Token(Token = "0x6000142")]
	public Keyframe(float time, float value, float inTangent, float outTangent, float inWeight, float outWeight) { }

	[Address(RVA = "0x2BC190", Offset = "0x2BB390", Length = "0x7")]
	[CallerCount(Count = 55)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000143")]
	public float get_time() { }

	[Address(RVA = "0x18732B0", Offset = "0x18724B0", Length = "0x5")]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000144")]
	public void set_time(float value) { }

}

